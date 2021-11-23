using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessToSQLConversion {
    public class DBSchema {
        private  Dictionary<string, DBTable> tables;
        DBSchema(DBTable table) {
            tables = new Dictionary<string, DBTable>();
            tables[table.name] = table;
        }
        DBSchema(List<DBTable> tables) {
            this.tables = new Dictionary<string, DBTable>();
            foreach (DBTable t in tables) {
                this.tables[t.name] = t;
            }
        }
        public void insertTable(DBTable table?) {
            if (!tables.ContainsKey(table.name)) {
                tables[table.name] = table;
            }else {
                throw new ArgumentException("Table already exitst in this schema.");
            }
        }
        public void insertTable(List<DBTable> tables) {
            foreach(DBTable t in tables) {
                if (this.tables.ContainsKey(t.name)) {
                    throw new ArgumentException("Table already exitst in this schema.");
                } else {
                    this.tables[t.name] = t;
                }
            }
        }

    }
}
