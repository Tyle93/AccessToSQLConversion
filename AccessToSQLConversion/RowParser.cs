using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AccessToSQLConversion
{
    public class ColumnMapping {
        private Dictionary<int, string> columnNamesbyIndex;
        private Dictionary<string, int> columnIndexByName;
        List<List<string>> rows;
        public ColumnMapping(Dictionary<int,string> indexToNames, Dictionary<string,int> namesToIndex) {
            columnIndexByName = namesToIndex;
            columnNamesbyIndex = indexToNames;
            rows = new List<List<string>>();
        }
        public void insertRow(List<string> row) {
            rows.Add(row);
        }
    }
    public static class RowParser{

        public static List<string> getLineData(string filePath){
            if (File.Exists(filePath)){
                return File.ReadAllLines(filePath).ToList();
            } else {
                throw new ArgumentException("File Path not found.");
            }
        }
        public static void getRows(){
            rowData = new List<string>(); 
            foreach (string line in File.ReadLines(accessDBPath)){
                rowData.Add(line.Trim());
            }
            getColumns(rowData[0]);
            rowData.RemoveAt(0);
        }
        public static ColumnMapping getColumnMapping(string columnHeaderRow) {
            List<string> columns = new List<string>();
            Dictionary<string,int> columnIndexByName = new Dictionary<string, int>();
            Dictionary<int,string> columnNamesbyIndex = new Dictionary<int, string>();   
            columns = columnHeaderRow.Split(',').ToList();
            for (int i = 0; i < columns.Count; i++) {
                columnNamesbyIndex[i] = columns[i].Trim();
                columnIndexByName[columnNamesbyIndex[i]] = i;
            }
            return new ColumnMapping(columnNamesbyIndex, columnIndexByName);
        }
        public static void parseRows() {
            foreach(string row in rowData) {
                List<string> splitRow = row.Split(',').ToList();
                for(int i = 0; i < splitRow.Count; i++) {
                    Console.WriteLine(i + " " + splitRow[i]);
                }
                break;
            }
        }

    }
}
