using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Diagnostics;

namespace ColorfulApp
{
    public static class WorkWithExcel
    {
        public static void ExportToExcel(this DataTable tbl, string excelFilePath = null)
        {
            try
            {
                if (tbl == null || tbl.Columns.Count == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // load excel, and create a new workbook
                var excelApp = new Excel.Application();
                excelApp.Workbooks.Add();

                // single worksheet
                Excel._Worksheet workSheet = excelApp.ActiveSheet;

                // column headings
                for (var i = 0; i < tbl.Columns.Count; i++)
                {
                    workSheet.Cells[1, i + 1] = tbl.Columns[i].ColumnName;
                }

                // rows
                for (var i = 0; i < tbl.Rows.Count; i++)
                {
                    // to do: format datetime values before printing
                    for (var j = 0; j < tbl.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 2, j + 1] = tbl.Rows[i][j];
                    }
                }
                workSheet.Range[workSheet.Cells[2, 1], workSheet.Cells[7, 1]].Merge();
                workSheet.Range[workSheet.Cells[8, 1], workSheet.Cells[13, 1]].Merge();
                workSheet.Range[workSheet.Cells[14, 1], workSheet.Cells[19, 1]].Merge();
                workSheet.Range[workSheet.Cells[20, 1], workSheet.Cells[25, 1]].Merge();
                workSheet.Range[workSheet.Cells[26, 1], workSheet.Cells[31, 1]].Merge();
                workSheet.Range["A2:A31"].Orientation = Excel.XlOrientation.xlUpward;

                // check file path
                if (!string.IsNullOrEmpty(excelFilePath))
                {
                    try
                    {
                        excelFilePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) +'\\'+ excelFilePath;
                        workSheet.SaveAs(excelFilePath);
                        excelApp.Quit();
                        Debug.WriteLine("Excel file saved!");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                                            + ex.Message);
                    }
                }
                else
                { // no file path is given
                    excelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }

        public static DataTable GenerateTransposedTable(DataTable inputTable)
        {
            DataTable outputTable = new DataTable();

            // Add columns by looping rows

            // Header row's first column is same as in inputTable
            outputTable.Columns.Add(" ");
            outputTable.Columns.Add(inputTable.Columns[0].ColumnName.ToString());

            // Header row's second column onwards, 'inputTable's first column taken
            foreach (DataRow inRow in inputTable.Rows)
            {
                string newColName = inRow[0].ToString();
                outputTable.Columns.Add(newColName);
            }

            // Add rows by looping columns        
            for (int rCount = 1; rCount <= inputTable.Columns.Count - 1; rCount++)
            {
                DataRow newRow = outputTable.NewRow();

                // First column is inputTable's Header row's second column
                //newRow[1] = inputTable.Columns[rCount].ColumnName.ToString();
                newRow[1] = ((rCount - 1) % 6 + 1).ToString();
                switch (rCount)
                {
                    case 1: newRow[0] = "Понедельник"; break;
                    case 7: newRow[0] = "Вторник"; break;
                    case 13: newRow[0] = "Среда"; break;
                    case 19: newRow[0] = "Четверг"; break;
                    case 25: newRow[0] = "Пятница"; break;
                    default: newRow[0] = ""; break;
                }
                for (int cCount = 0; cCount <= inputTable.Rows.Count - 1; cCount++)
                {
                    string colValue = inputTable.Rows[cCount][rCount].ToString();
                    newRow[cCount + 2] = colValue;
                }
                outputTable.Rows.Add(newRow);
            }

            return outputTable;
        }
    }
}
