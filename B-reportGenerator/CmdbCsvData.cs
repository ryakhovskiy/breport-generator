using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_reportGenerator
{
    internal class CmdbCsvData
    {
        private Dictionary<string, WinServer> winServerData = new Dictionary<string, WinServer>();
        private Dictionary<string, List<SqlInstance>> sqlInstanceData = new Dictionary<string, List<SqlInstance>>();
        private Dictionary<string, PublicCloudDb> publicCloudDbData = new Dictionary<string, PublicCloudDb>();

        internal Dictionary<string, WinServer> WinServerData { get { return winServerData; } }
        internal Dictionary<string, List<SqlInstance>> SqlInstanceData { get { return sqlInstanceData; } }
        internal Dictionary<string, PublicCloudDb> PublicCloudDbData { get { return publicCloudDbData; } }
    }
}
