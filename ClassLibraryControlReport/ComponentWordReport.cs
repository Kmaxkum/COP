using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace ClassLibraryControlReport
{
    public partial class ComponentWordReport : Component
    {
        public void CreateReport(object[][] elements, object[] horizontalHeader, object[] verticalHeader, string fileName)
        {
            if (elements.GetLength(0) != verticalHeader.Length || elements[0].GetLength(0) != horizontalHeader.Length)
            {
               throw new BadDimensions();
            }

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            var rowCount = elements.GetLength(0) + 1;
            var colCount = elements[0].GetLength(0) + 1;


            var winword = new Microsoft.Office.Interop.Word.Application();

            try
            {
                object missing = System.Reflection.Missing.Value;

                var document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                var paragraph = document.Paragraphs.Add(missing);
                
                var paragraphTable = document.Paragraphs.Add(Type.Missing);
                var rangeTable = paragraphTable.Range;
                var table = document.Tables.Add(rangeTable, rowCount, colCount, ref
                    missing, ref missing);
                var font = table.Range.Font;
                font.Name = "Times New Roman";
                font.Size = 16;

                for (int i = 2; i < colCount + 1; i++)
                {
                    table.Cell(1, i).Range.Text = horizontalHeader[i - 2].ToString();

                }
                for (int i = 2; i < rowCount+ 1; i++)
                {
                    table.Cell(i, 1).Range.Text = verticalHeader[i - 2].ToString();
                }

                font.Size = 14;
                font.Bold = 0;

                for (int i = 2; i < rowCount+1; i++)
                {
                    for (int j = 2; j < colCount+1; j++)
                    {
                        table.Cell(i, j).Range.Text = elements[i - 2][j - 2].ToString();
                    }
                }

                table.Borders.InsideLineStyle = WdLineStyle.wdLineStyleInset;
                table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;

                object fileFormat = WdSaveFormat.wdFormatXMLDocument;
                document.SaveAs(fileName, ref fileFormat, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing,
                    ref missing);
                document.Close(ref missing, ref missing, ref missing);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }


        }


        public ComponentWordReport()
        {
            InitializeComponent();
        }

        public ComponentWordReport(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
