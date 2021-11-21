using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessToSQLConversion {
    public class Config {
        public string path { get; private set; }
        public string connectionString { get; private set; }
        public Config(string path, string conn) { 
            this.path = path;
            connectionString =  conn;
        }
    }
}
