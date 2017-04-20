using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
//using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test123
{
    class XLReader
    {
        //string fname = "Consulta_Mail_150122.xls";
       static HSSFWorkbook workbook;
        static IRow row1;
        static ICell cell;
        static HSSFRow row;
        static ISheet sheet;
        
        static void EnterWorkbookPath(string filePath)
        {
            using (var fs = File.OpenRead(filePath))
            {
                workbook = new HSSFWorkbook(fs);
            }
        }

        // [Test]      
        public static void ReadfromExcel()
        {
            string filePath = "G:\\data.xls";
            Console.WriteLine(filePath);
            EnterWorkbookPath(filePath);
             sheet = workbook.GetSheetAt(0);
            Console.WriteLine(sheet.SheetName);
            ICell cell;
            
           // Console.WriteLine(sheet.GetRow(5).GetCell(5));
            int number= sheet.LastRowNum + 1;
            IRow row1;
            row1= sheet.GetRow(5);
            //string row2=;
            //Console.WriteLine("row 4"+row.GetCell(5));
            Console.WriteLine("row 5"+ row1.GetCell(5));
        

             cell = sheet.GetRow(4).GetCell(1);
            Console.WriteLine("cellvalue "+cell);
            
            for(int i=1;i<=row1.LastCellNum;i++)
            {
                Console.WriteLine(row1.GetCell(i));
            }
            Console.WriteLine(getRowCount("KK"));
            Console.WriteLine("reading from sheets" + readsheets("KK", "senthil", 2));
            Console.WriteLine("reading from sheets" + readsheets("KK", "senthil", 3));
        }

        public static int getRowCount(String sheetName)
        {
            int index = workbook.GetSheetIndex(sheetName);
            if (index == -1)
                return 0;
            else
            {
                sheet = workbook.GetSheetAt(index);
                Console.WriteLine("sheet 1"+sheet);
                int number = sheet.LastRowNum + 1;
                return number;
            }
        }


        public static string readsheets(String sheetName, String colName, int rowNum)
        {
            // returns the data from a cell
        
            try
            {
                if (rowNum <= 0)
                    return "";

                int index = workbook.GetSheetIndex(sheetName);
                Console.WriteLine("index value is"+index);
                int col_Num = -1;
                if (index == -1)
                    return "";

                sheet = workbook.GetSheetAt(index);
                // row = sheet.GetRow(0);
                Console.WriteLine("sheetname is"+sheet);
                row1 =sheet.GetRow(0);
                Console.WriteLine(" row value is"+ row1);
                Console.WriteLine("row count"+ row1.LastCellNum);
                for (int i = 0; i < row1.LastCellNum; i++)
                {
                    //System.out.println(row.getCell(i).getStringCellValue().trim());
                    if (row1.GetCell(i).RichStringCellValue.Equals(colName.Trim()))
                        col_Num = i;
                }
                if (col_Num == -1)
                    return "";

                sheet = workbook.GetSheetAt(index);
                row1 = sheet.GetRow(rowNum - 1);
                if (row1 == null)
                    return "";
                cell = row1.GetCell(col_Num);

                if (cell == null)
                    return "";
                //System.out.println(cell.getCellType());
                if (cell.CellType == CellType.String)
                    return cell.StringCellValue;
                else if (cell.CellType == CellType.Numeric || cell.CellType == CellType.Formula)
                {

                    String cellText = cell.NumericCellValue.ToString();
                 /*   if (HSSFDateUtil.IsCellDateFormatted(cell))
                    {
                        // format in form of M/D/YY
                        double d = cell.NumericCellValue;
                        Calendar cal = CultureInfo.InvariantCulture.Calendar;
                        cal.SetTime(HSSFDateUtil.getJavaDate(d));
                        cellText =
                         (String.valueOf(cal.get(Calendar.YEAR))).substring(2);
                        cellText = cal.get(Calendar.DAY_OF_MONTH) + "/" +
                                   cal.get(Calendar.MONTH) + 1 + "/" +
                                   cellText;

                        //System.out.println(cellText);

                    }*/



                    return cellText;
                }
                else if (cell.CellType == CellType.Blank)
                    return "";
                else
                    return cell.BooleanCellValue.ToString();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.StackTrace);
                return "row " + rowNum + " or column " + colName + " does not exist in xls";
            }
        }
    }


    }

