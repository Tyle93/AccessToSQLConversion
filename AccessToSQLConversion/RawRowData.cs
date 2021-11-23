using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessToSQLConversion {
    public class RawRowData {
        public List<string> RowData { get; private set; }
        public RawRowData(List<string> row) => RowData = row;
        public RawRowData(string[] row) => RowData = RowData.ToList();
    }
}
