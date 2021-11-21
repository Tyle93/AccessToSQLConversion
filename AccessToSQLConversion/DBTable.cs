using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AccessToSQLConversion {
    public class DBTable {
        public string name { get; set; }
        public Hashtable columns = new Hashtable();
        public DBTable() { }
        public DBTable(string tableName) {
            name = tableName;
        }
        public DBTable(string tableName, Hashtable columns) {
            name = tableName;
            this.columns = columns;
        }
    }
}
