using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_reportGenerator
{
    internal class CsvCiDataLoader
    {
        private readonly string windowsCiFile;
        private readonly string sqlCiFile;
        private readonly string publicDbCiFile;

        private readonly ConcurrentDictionary<string, WinServer> winServerData = 
            new ConcurrentDictionary<string, WinServer>();

        private readonly ConcurrentDictionary<string, List<SqlInstance>> sqlInstanceData =
            new ConcurrentDictionary<string, List<SqlInstance>>();

        private readonly ConcurrentDictionary<string, PublicCloudDb> publicCloudDbData =
            new ConcurrentDictionary<string, PublicCloudDb>();

        private BackgroundWorker backgroundWorker;

        public CsvCiDataLoader(BackgroundWorker bw, 
            string windowsCiFile, string sqlCiFile, string publicDbCiFile)
        {
            this.backgroundWorker = bw;
            this.windowsCiFile = windowsCiFile;
            this.sqlCiFile = sqlCiFile;
            this.publicDbCiFile = publicDbCiFile;
        }

        public CmdbCsvData run()
        {
            this.backgroundWorker.ReportProgress(0, "Loading data from csv files...");
            var tasks = new[]
            {
                Task.Factory.StartNew(() => loadWinServerData()),
                Task.Factory.StartNew(() => loadSqlInstanceData()),
                Task.Factory.StartNew(() => loadPublicCloudDbData())
            };
            Task.WaitAll(tasks);
            this.backgroundWorker.ReportProgress(0, "Data loaded");
            CmdbCsvData data = new CmdbCsvData();
            winServerData.ToList().ForEach(kv => data.WinServerData.Add(kv.Key, kv.Value));
            sqlInstanceData.ToList().ForEach(kv => data.SqlInstanceData.Add(kv.Key, kv.Value));
            publicCloudDbData.ToList().ForEach(kv => data.PublicCloudDbData.Add(kv.Key, kv.Value));
            return data;
        }

        private void loadWinServerData()
        {

            List<string[]> lines = CsvReader.readCsv(windowsCiFile);
            if (lines.Count == 0) return;

            Dictionary<string, int> headerData = parseHeaderData(lines[0]);
            int i = 1;
            try
            {
                for (i = 1; i < lines.Count; i++)
                {
                    string[] line = lines[i];
                    if (null == line) continue;
                    if (headerData.ContainsKey("install_status"))
                    {
                        string status = line[headerData["install_status"]];
                        if (!status.Equals("Installed")) continue;
                    }

                    WinServer srv = new WinServer();
                    srv.Name = line[headerData["name"]];
                    srv.ServiceName = line[headerData["u_service_name"]];
                    srv.ServiceInstance = line[headerData["u_service_instance"]];
                    int result;
                    int.TryParse(line[headerData["cpu_count"]], out result);
                    srv.CpuCount = result;
                    int.TryParse(line[headerData["cpu_core_count"]], out result);
                    srv.CpuCoreCount = result;
                    winServerData.TryAdd(srv.Name, srv);
                }
            }
            catch (Exception e)
            {
                throw new Exception(
                   String.Format("Error processing Windows Servers file, {0}, line #{1}: {2}", windowsCiFile, i, e.Message), e);
            }
        }

        private void loadSqlInstanceData()
        {
            List<string[]> lines = CsvReader.readCsv(sqlCiFile);
            if (lines.Count == 0) return;

            Dictionary<string, int> headerData = parseHeaderData(lines[0]);
            int i = 1;
            try
            {
                for (i = 1; i < lines.Count; i++)
                {
                    string[] line = lines[i];
                    if (null == line) continue;
                    SqlInstance sql = new SqlInstance();
                    sql.Name = line[headerData["name"]];
                    sql.ServiceName = line[headerData["u_service_name"]];
                    sql.RecoveryServerName = line[headerData["u_recovery_server_name"]];
                    sql.Edition = line[headerData["edition"]];
                    sql.Version = line[headerData["version"]];
                    sql.InstanceName = line[headerData["instance_name"]];
                    sql.ServerName = line[headerData["u_servername"]];
                    string[] names = sql.Name.Split('@');
                    if (names.Length != 2) continue;
                    sql.ParsedWinServerName = names[1];
                    sql.ParsedInstanceName = names[0];

                    sqlInstanceData.AddOrUpdate(sql.ParsedWinServerName, new List<SqlInstance>() { sql },
                        (key, oldValue) => { oldValue.Add(sql); return oldValue; } );
                }
            }
            catch (Exception e)
            {
                throw new Exception(
                   String.Format("Error processing SQL Instances file, {0}, line #{1}: {2}", sqlCiFile, i, e.Message), e);
            }
        }

        private void loadPublicCloudDbData()
        {
            List<string[]> lines = CsvReader.readCsv(publicDbCiFile);
            if (lines.Count == 0) return;
            
            Dictionary<string, int> headerData = parseHeaderData(lines[0]);
            int i = 1;
            try
            {
                for (i = 1; i < lines.Count; i++)
                {
                    string[] line = lines[i];
                    if (null == line) continue;
                    if (headerData.ContainsKey("install_status"))
                    {
                        string status = line[headerData["install_status"]];
                        if (!status.Equals("Installed")) continue;
                    }
                    PublicCloudDb pdb = new PublicCloudDb();
                    pdb.Name = line[headerData["name"]];
                    pdb.ServiceName = line[headerData["u_service_name"]];
                    pdb.ServiceInstance = line[headerData["u_service_instance"]];
                    this.publicCloudDbData.TryAdd(pdb.Name, pdb);
                }
            } catch (Exception e)
            {
                throw new Exception(
                    String.Format("Error processing Public Cloud DBs, {0}, line #{1}: {2}", publicDbCiFile, i, e.Message), e);
            }

            backgroundWorker.ReportProgress(0, "Public Cloud SQL Instances Data Loaded");
        }

        private Dictionary<string, int> parseHeaderData(string[] line)
        {
            Dictionary<string, int> headerData = new Dictionary<string, int>(line.Length);
            for (int i = 0; i < line.Length; i++) headerData[line[i]] = i;
            return headerData;
        }
    }

    class WinServer
    {
        public string Name { get; set; }
        public string ServiceName { get; set; }

        public int CpuCount { get; set; }
        public int CpuCoreCount { get; set; }

        public string ServiceInstance { get; set; }
    }

    class SqlInstance
    {
        public string Name { get; set; }
        public string InstanceName { get; set; }
        public string ServerName { get; set; }
        public string RecoveryServerName { get; set; }
        public string Version { get; set; }
        public string Edition { get; set; }
        public string ServiceName { get; set; }

        public string ParsedInstanceName { get; set; }

        public string ParsedWinServerName { get; set; }

        public override string ToString()
        {
            return InstanceName;
        }
    }

    class PublicCloudDb
    {
        public string Name { get; set; }
        public string ServiceName { get; set; }
        public string ServiceInstance { get; set; }

    }

    class CsvReader
    {
        private static readonly string DELIMITER = ",";

        public static List<string[]> readCsv(string file)
        {
            List<string[]> data = new List<string[]>();
            try
            {
                using (TextFieldParser parser = new TextFieldParser(file))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(DELIMITER);
                    while (!parser.EndOfData) data.Add(parser.ReadFields());
                }
            } catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace, "Error loading data from CSV: " + file, 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return data;
        }
    }
}
