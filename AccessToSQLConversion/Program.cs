using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AccessToSQLConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Config conf = ArgsParser.init(args);
            LineParser.init(conf.path);
        }
    }
}
