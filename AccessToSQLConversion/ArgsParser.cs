using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AccessToSQLConversion {
    static public class ArgsParser {
        private static Dictionary<string,Action<string>> flags;
        private static string conn;
        private static string path;
        private static void init() {
            clear();
            flags = new Dictionary<string, Action<string>>(); 
            flags["-p"] = new Action<string>((str) => { path = str; });
            flags["-c"] = new Action<string>((str) => { conn = str; });
        }
        public static Config parseArgs(string[] args) {
            init();
            Action<string> action = null;
\            foreach(string s in args) {
                if (isFlag(s)){
                    action = (Action<string>)flags[s];
                }else if(action != null){
                    action(s);
                    action = null;
                } else {
                    Console.WriteLine($"The arg \"{s}\" is either not a matching flag or is a paramanter without without a flag.");
                }
            }
            return new Config(path,conn);
        }
        private static bool isFlag(string arg) {
            return flags.ContainsKey(arg);
        }
        private static void clear() {
            flags = null;
            path = null;
            conn = null;
        }
    }
}
