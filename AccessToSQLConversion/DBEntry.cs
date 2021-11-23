using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessToSQLConversion {
    public class DBEntry {
        public RawRowData row { get; private set; }

        public DBEntry(RawRowData row) {
            this.row = row;
        }
    }
}
