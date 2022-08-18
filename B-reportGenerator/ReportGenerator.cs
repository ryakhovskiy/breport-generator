using System;

namespace B_reportGenerator
{
	internal class ReportGenerator
	{
		private Config config = Config.getConfig();
		private CmdbCsvData data;
		private string reportDate;
		private readonly string outputFile;

		internal ReportGenerator(string outputFile, CmdbCsvData data, string reportDate)
		{
			this.outputFile = outputFile;
			this.data = data;
			this.reportDate = reportDate;
		}

		public void generateReport()
        {
			var tasks = new[]
			{
				Task.Factory.StartNew(() => generateOnPremData()),
				Task.Factory.StartNew(() => generatePublicCloudData()),
			};
			Task.WaitAll(tasks);
			List<string> reportLines = new List<string>();
			tasks.ToList().ForEach(t => t.Result.ForEach(r => reportLines.Add(r.ToString())));
			if (File.Exists(outputFile)) File.Delete(outputFile);
			File.WriteAllLines(outputFile, reportLines);
		}

		private List<ReportLine> generateOnPremData()
        {
			List<ReportLine> reportLines = new List<ReportLine>();
			if (null == data) return reportLines;
			if (null == data.WinServerData || null == data.SqlInstanceData) return reportLines;

			foreach (WinServer winServer in data.WinServerData.Values)
            {
				//skip team VMs
				if (config.isTeamVm(winServer.Name)) continue;
				List<SqlInstance> sqlInstances;
				if (!data.SqlInstanceData.TryGetValue(winServer.Name, out sqlInstances))
					continue;
				Material licenseMaterial = config.GetLicenseStandardMaterial();
				
				foreach (SqlInstance instance in sqlInstances)
				{
					ReportLine opsLine = generateOpsReportLine(winServer, instance);
					reportLines.Add(opsLine);
					if (licenseMaterial.MaterialNumber.Equals(config.GetLicenseEnterpriseMaterial().MaterialNumber)) continue;
					if (instance.Edition.ToLower().Contains("enterprise")) licenseMaterial = config.GetLicenseEnterpriseMaterial();
				}
				//skip AAG passive items
				if (config.isNodePassive(winServer.Name)) continue;
				ReportLine licenseLine = generateLicenseReportLine(winServer, licenseMaterial, sqlInstances);
				reportLines.Add(licenseLine);
			}
			return reportLines;
        }

		private ReportLine generateOpsReportLine(WinServer winServer, SqlInstance instance)
        {
			string name = winServer.Name;

			string serviceInstance = name;
			string material;
			string materialDescription;
			if (winServer.ServiceName.ToLower().Contains("hc mssql gold"))
			{
				material = config.GetOpsGoldMaterial().MaterialNumber;
				materialDescription = config.GetOpsGoldMaterial().Description;
			}
			else
			{
				material = config.GetOpsSilverMaterial().MaterialNumber;
				materialDescription = config.GetOpsSilverMaterial().Description;
			}

			int consumption = 1;

			string date = reportDate;
			string primaryTag = winServer.Name;
			string secondaryTag = String.Format("{0} - {1}", material, materialDescription);
			string customerTag = instance.InstanceName;

			return new ReportLine(serviceInstance, material, consumption, date, primaryTag, secondaryTag, customerTag);
		}

		private ReportLine generateLicenseReportLine(WinServer winServer, Material material, List<SqlInstance> sqlInstances)
        {
			//generateSecondLine
			string name = winServer.Name;

			string serviceInstance = name;

			int consumption = winServer.CpuCount * winServer.CpuCoreCount;
			
			string date = reportDate;
			String primaryTag = winServer.Name;
			string secondaryTag = String.Format("{0} - {1}", material.MaterialNumber, material.Description);

			string customerTag = String.Join(",", sqlInstances);

			return new ReportLine(serviceInstance, material.MaterialNumber, consumption, date, primaryTag, secondaryTag, customerTag);
		}
		private List<ReportLine> generatePublicCloudData()
		{
			List<ReportLine> reportLines = new List<ReportLine>();
			if (null == data) return reportLines;
			if (null == data.PublicCloudDbData) return reportLines;

			foreach (PublicCloudDb db in data.PublicCloudDbData.Values)
            {
				string name = db.Name;

				string serviceInstance = name;

				int consumption = 1;

				string date = reportDate;

				string material;
				string materialDescription;
				if (db.ServiceName.ToLower().Contains("hc mssql gold"))
				{
					material = config.GetOpsGoldMaterial().MaterialNumber;
					materialDescription = config.GetOpsGoldMaterial().Description;
				}
				else
				{
					material = config.GetOpsSilverMaterial().MaterialNumber;
					materialDescription = config.GetOpsSilverMaterial().Description;
				}

				string primaryTag = name;
				string secondaryTag = String.Format("{0} - {1}", material, materialDescription);
				string customerTag = string.Empty;

				ReportLine line = new ReportLine(serviceInstance, material, consumption, date, primaryTag, secondaryTag, customerTag);
				reportLines.Add(line);
			}
			return reportLines;
		}
	}

	internal class ReportLine
    {
		string serviceInstance;
		string material;
		int consumption;
		string date;
		string primaryTag;
		string secondaryTag;
		string customerTag;

		internal ReportLine(string serviceInstance, 
			string material, 
			int consumption, 
			string date, 
			string primaryTag, 
			string secondaryTag, 
			string customerTag)
        {
            this.serviceInstance = serviceInstance;
            this.material = material;
            this.consumption = consumption;
            this.date = date;
            this.primaryTag = primaryTag;
            this.secondaryTag = secondaryTag;
            this.customerTag = customerTag;
        }

		public override string ToString()
        {
			return String.Format("{0};{1};{2};{3};{4};{5};{6}", 
				serviceInstance, material, consumption, date, primaryTag, secondaryTag, customerTag);
        }
    }
}