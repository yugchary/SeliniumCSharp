using LinqToExcel;
//using NUnit.Framework;
using System;
using System.Linq;
namespace Test123
{

    public class UnitTest1
    {
        //[Test]
        public void LinqMethod1(string WorksheetName)
        {
            string filePath = "G:\\data.xlsx";

            string sheetName = "Sheet1";
            var excelFile = new ExcelQueryFactory(filePath);
            var artistAlbums = from a in excelFile.Worksheet(sheetName) select a;
            var columnNames = excelFile.GetColumnNames("Sheet1");

            foreach (var column in columnNames)
            {
                //Console.WriteLine(column);
                if (column.Equals("Name"))
                {

                    foreach (var a in artistAlbums)
                    {
                        var name = a["Name"].ToString();
                        if (name.Equals("senthil"))
                        {
                            string artistInfo = "Artist Name: {0}; Album: {1}";

                            Console.WriteLine(string.Format(artistInfo, a["Name"], a["Age"]));
                            //Console.WriteLine(a["Name"] + "   " + a["Age"]);
                            //Console.WriteLine(a["Age"]);
                        }
                    }
                }
            }

        }
    }
}


