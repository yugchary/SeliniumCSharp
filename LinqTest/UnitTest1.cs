using System;
using System.Linq;
namespace Test123
{

    public class UnitTest1
    {
        
        public void LinqMethod1()
        {
            string filePath = "G:\\data.xls";

            string sheetName = "Sheet1";
            var excelFile = new ExcelQueryFactory(filePath);
            var artistAlbums = from a in excelFile.Worksheet(sheetName) select a;

            foreach (var a in artistAlbums)
            {
                string artistInfo = "Artist Name: {0}; Album: {1}";
                Console.WriteLine(string.Format(artistInfo, a["Name"], a["Title"]));
            }
        }

    }
    }
}
