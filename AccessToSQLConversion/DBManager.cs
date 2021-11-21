using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Collections;

namespace AccessToSQLConversion {
    public static class DBManager {
        public static Dictionary<string, List<DBTable>> tableEntries;
        public static void init() {

        }
        private static string GetConnectionString(string connectionString) {
            
            return "";
        }
        private static List<DBTable> buildTables(List<string> row) {
            List<DBTable> tables = new List<DBTable>(); 
            return tables;
        }
    }
}
