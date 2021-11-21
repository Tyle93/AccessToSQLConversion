using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AccessToSQLConversion
{
    public static class LineParser{
        static private Hashtable columnNamesbyIndex;
        static private Hashtable columnIndexByName;
        static private string accessDBPath;
        static private List<string> rowData;
        public static void init(string filePath){
            clear();
            if (File.Exists(filePath)){
                accessDBPath = filePath;
                getRows();
                parseRows();
            }
            throw new ArgumentException("File Path not found.");
        }
        public static void getRows(){
            rowData = new List<string>(); 
            foreach (string line in File.ReadLines(accessDBPath)){
                rowData.Add(line.Trim());
            }
            getColumns(rowData[0]);
            rowData.RemoveAt(0);
        }
        private static void getColumns(string columnHeaderRow) {
            List<string> columns = new List<string>();
            columnIndexByName = new Hashtable();
            columnNamesbyIndex = new Hashtable();   
            columns = columnHeaderRow.Split(',').ToList();
            for (int i = 0; i < columns.Count; i++) {
                columnNamesbyIndex[i] = columns[i].Trim();
                columnIndexByName[columnNamesbyIndex[i]] = i;
            }
        }
        private static void parseRows() {
            foreach(string row in rowData) {
                List<string> splitRow = row.Split(',').ToList();
                for(int i = 0; i < splitRow.Count; i++) {
                    Console.WriteLine(i + " " + splitRow[i]);
                }
                break;
            }
        }
        private static void clear() {
            accessDBPath = "";
            columnIndexByName = null;
            columnNamesbyIndex = null;  
            rowData = null;
        }
    }
}
