using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using CourseSurface.RightRectangleMethodLogic.Model;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Drawing.Chart;

namespace CourseSurface
{
    public class ExcelWriter
    {
        public void WriteThreadsDataToExcel(List<IntegrationResultInfo> threadsData)
        {
            var fileInfo = new FileInfo("threadsData.xlsx");

            using (var excelPackage = new ExcelPackage(fileInfo))
            {
                var worksheet = excelPackage.Workbook.Worksheets.FirstOrDefault(x => x.Name == "ThreadsData");

                if (worksheet == null)
                {
                    worksheet = excelPackage.Workbook.Worksheets.Add("ThreadsData");
                }

                worksheet.Cells[1, 1].LoadFromCollection(threadsData, true);

                var lineChart = worksheet.Drawings.FirstOrDefault(x => x.Name == "lineChart") as ExcelBarChart;

                if (lineChart == null)
                {
                    lineChart = worksheet.Drawings.AddChart("lineChart", eChartType.ColumnClustered) as ExcelBarChart;
                }

                lineChart.YAxis.Font.Size = 9;
                lineChart.XAxis.Font.Size = 9;
                lineChart.YAxis.Border.Fill.Style = eFillStyle.NoFill;
                lineChart.XAxis.Border.Fill.Style = eFillStyle.NoFill;

                lineChart.Legend.Position = eLegendPosition.Bottom;

                var rangeLabel = worksheet.Cells["A2:A" + (threadsData.Count + 1)];
                var range1 = worksheet.Cells["B2:B" + (threadsData.Count + 1)];

                lineChart.Series.Add(range1, rangeLabel).Header = "Time";

                lineChart.SetSize(600, 300);

                lineChart.SetPosition(5, 0, 3, 0);

                excelPackage.Save();
            }
        }
    }
}