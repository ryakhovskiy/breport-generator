using System;
using System.Text.Json;

namespace B_reportGenerator { 

	public class Config
	{
		private static readonly string materialsFile = "config/materials.json";
		private static readonly string aagFile = "config/aag.json";
		private static readonly string teamVmsFile = "config/team_vms.json";
		private static readonly string csvFormatCustomizationsFile = "config/csvInputConfig.json";

		private static readonly Config config = new Config();

		public static Config getConfig()
		{
			return config;
		}

		private Material[] materials = new Material[0];
		private Dictionary<string, string[]> aag = new Dictionary<string, string[]>();
		private HashSet<string> aagPassiveInstances = new HashSet<string>();
		private HashSet<string> teamVms = new HashSet<string>();

		public Material[] GetMaterials() { return materials; }

		private Material opsGoldMaterial;
		private Material opsSilverMaterial;
		private Material licenseEnterpriseMaterial;
		private Material licenseStandardMaterial;

		public Material GetOpsGoldMaterial() { return opsGoldMaterial; }
		public Material GetOpsSilverMaterial() { return opsSilverMaterial; }
		public Material GetLicenseEnterpriseMaterial() { return licenseEnterpriseMaterial; }
		public Material GetLicenseStandardMaterial() { return licenseStandardMaterial; }

		private CsvInputFormatConfig csvInputConfig = new CsvInputFormatConfig();

		public CsvInputFormatConfig GetCsvInputFormatConfig() { return csvInputConfig; }  

		public bool isNodeActive(string name)
        {
			return aag.ContainsKey(name);
        }

		public bool isNodePassive(string name)
		{
			return aagPassiveInstances.Contains(name);
		}

		public bool isTeamVm(string name)
        {
			return teamVms.Contains(name);
        }

		public List<string> GetTeamVms() { return teamVms.ToList(); }

		public Dictionary<string, string[]> GetAag() { return aag; }

		public Config()
		{
			loadConfig();
		}

		private void loadConfig()
		{
			loadMaterials();
			loadAag();
			loadTeamVms();
			loadCsvFormatCustomizations();
		}

		private void loadCsvFormatCustomizations()
        {
			if (!File.Exists(csvFormatCustomizationsFile)) return;
			string jsonString = File.ReadAllText(csvFormatCustomizationsFile);
			this.csvInputConfig = JsonSerializer.Deserialize<CsvInputFormatConfig>(jsonString)!;
		}

		private void loadMaterials()
        {
			if (!File.Exists(materialsFile)) return;
			string jsonString = File.ReadAllText(materialsFile);
			this.materials = JsonSerializer.Deserialize<Material[]>(jsonString)!;
			prepareMaterials();
		}

		private void prepareMaterials()
        {
			foreach (Material m in materials) {
				if (m.Description.Contains("Software Standard")) this.licenseStandardMaterial = m;
				if (m.Description.Contains("Software Enterprise")) this.licenseEnterpriseMaterial = m;
				if (m.Description.Contains("Base Instance Support")) this.opsSilverMaterial = m;
				if (m.Description.Contains("Extended Instance Support")) this.opsGoldMaterial = m;
			}
			if (null == this.licenseStandardMaterial) throw new Exception("Material not found: Software Standard");
			if (null == this.licenseEnterpriseMaterial) throw new Exception("Material not found: Software Enterprise");
			if (null == this.opsSilverMaterial) throw new Exception("Material not found: Base Instance Support");
			if (null == this.opsGoldMaterial) throw new Exception("Material not found: Extended Instance Support");
		}

		private void loadAag()
		{
			if (!File.Exists(aagFile)) return;
			string jsonString = File.ReadAllText(aagFile);
			AAG[] data = JsonSerializer.Deserialize<AAG[]>(jsonString)!;
			foreach (AAG item in data)
			{
				this.aag[item.Active] = item.Passive;
				item.Passive.ToList().ForEach(p => this.aagPassiveInstances.Add(p));
			}
			
		}
		private void loadTeamVms()
		{
			if (!File.Exists(teamVmsFile)) return;
			string jsonString = File.ReadAllText(teamVmsFile);
            string[] data = JsonSerializer.Deserialize<string[]>(jsonString)!;
			foreach (string item in data) this.teamVms.Add(item);
		}

		public void saveConfig()
		{
			string materialsJson = JsonSerializer.Serialize<Material[]>(this.materials);
			string teamVmsJson = JsonSerializer.Serialize<string[]>(this.teamVms.ToArray<string>());
			AAG[] data = new AAG[this.aag.Count];
			int i = 0;
			foreach (string key in this.aag.Keys)
            {
				AAG item = new AAG();
				item.Active = key;
				item.Passive = this.aag[key];
				data[i++] = item;
			}
			string aagJson = JsonSerializer.Serialize<AAG[]>(data);

			string csvInputConfigJson = JsonSerializer.Serialize<CsvInputFormatConfig>(this.csvInputConfig);

			File.WriteAllText(materialsFile, materialsJson);
			File.WriteAllText(teamVmsFile, teamVmsJson);
			File.WriteAllText(aagFile, aagJson);
			File.WriteAllText(csvFormatCustomizationsFile, csvInputConfigJson);

		}

        internal void AddTeamVm(string vm)
        {
			this.teamVms.Add(vm);
        }

        internal void AddAagItem(string active, string passive)
        {
            string[] passiveInstances = passive.Split(";");
			this.aag[active] = passiveInstances;
			passiveInstances.ToList().ForEach(p => this.aagPassiveInstances.Add(p));
        }

        internal void DeleteAagItem(string active)
        {
			string[] passive = this.aag[active];
			passive.ToList().ForEach(p => this.aagPassiveInstances.Remove(p));
			this.aag.Remove(active);
        }
    }

	public class Material
	{
		public string MaterialNumber { get; set; }
		public string Description { get; set; }
	}

	public class AAG
    {
		public string Active { get; set; }
		public string[] Passive { get; set; }
	}

	public class CsvInputFormatConfig
	{
		public WindowsCsvConfig WindowsCsvConfig { get; set; }
		public SqlInstancesCsvConfig SqlInstancesCsvConfig { get; set; }
		public PublicCloudDBsCsvConfig PublicCloudDBsCsvConfig { get; set; }
	}

	public class PublicCloudDBsCsvConfig
	{
		public string InstallStatusColumn { get; set; }
		public string InstallStatusValue { get; set; }
		public string NameColumn { get; set; }
		public string ServiceNameColumn { get; set; }
		public string ServiceInstanceColumn { get; set; }
		public string CreatedOnColumn { get; set; }
		public string CreatedOnDateFormat { get; set; }
	}

	public class SqlInstancesCsvConfig
	{
		public string InstallStatusColumn { get; set; }
		public string InstallStatusValue { get; set; }
		public string NameColumn { get; set; }
		public string ServerNameColumn { get; set; }
		public string ServiceNameColumn { get; set; }
		public string RecoveryServerColumn { get; set; }
		public string EditionColumn { get; set; }
		public string VersionColumn { get; set; }
		public string InstanceNameColumn { get; set; }
		public string CreatedOnColumn { get; set; }
		public string CreatedOnDateFormat { get; set; }
	}

	public class WindowsCsvConfig
	{
		public string InstallStatusColumn { get; set; }
		public string InstallStatusValue { get; set; }
		public string ServiceNameColumn { get; set; }
		public string ServiceInstanceColumn { get; set; }
		public string CPUCountColumn { get; set; }
		public string CPUCoreCountColumn { get; set; }
		public string NameColumn { get; set; }
		public string CreatedOnColumn { get; set; }
		public string CreatedOnDateFormat { get; set; }
	}

}