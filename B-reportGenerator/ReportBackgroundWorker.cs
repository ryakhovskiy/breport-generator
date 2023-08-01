using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_reportGenerator
{
    internal class ReportBackgroundWorker
    {
        private BackgroundWorker bw;
        private CsvCiDataLoader dataLoader;
        private string outputFile;
        private string date;

        internal ReportBackgroundWorker(BackgroundWorker bw, 
            string windowsCiFile, string sqlCiFile, string publicDbCiFile,
            string outputFile, string date, CsvInputFormatConfig config)
        {
            this.bw = bw;
            this.dataLoader = new CsvCiDataLoader(bw, windowsCiFile, sqlCiFile, publicDbCiFile, config);
            this.outputFile = outputFile;
            this.date = date;
        }

        public void run()
        {
            bw.ReportProgress(0, "Loading CMDB CSV data...");
            CmdbCsvData data = dataLoader.run();

            bw.ReportProgress(0, "Generating Report");
            ReportGenerator generator = new ReportGenerator(outputFile, data, date);
            generator.generateReport();
        }
    }
}
