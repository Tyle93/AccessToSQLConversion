using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AccessToSQLConversion {
    public static class DBSchema {
        private static Dictionary<string, DBTable> tables;
        public static void init() {
            tables = new Dictionary<string, DBTable>();
        }
        public static void insertTable(DBTable table) {
            tables[table.name] = table;
        }

    }
}
