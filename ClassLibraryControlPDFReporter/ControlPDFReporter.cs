using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.util;

namespace ClassLibraryControlPDFReporter
{
    public partial class ControlPDFReporter : Component
    {
        public ControlPDFReporter()
        {
            InitializeComponent();
        }

        public ControlPDFReporter(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        /// <param name="phase">Заголовок.</param>
        /// <param name="cap">Формат шапки.</param>
        /// <param name="properti">Порядок свойств данных.</param>
        /// <param name="list">Список данных.</param>
        /// <param name="path">Строка вида @"D:\path\to\report.pdf".</param>
        public void CreatePDFReport<T>(string phase, string cap, string properti, List<T> list, string path)
        {
            //из ресрусов получаем шрифт для кирилицы
            if (!File.Exists("TIMCYR.TTF"))
            {
                File.WriteAllBytes("TIMCYR.TTF", Properties.Resources.TIMCYR);
            }
            string[] caps = cap.Split(' ');
            string[] properties = properti.Split(' ');
            if (caps.Length != properties.Length) {
                throw new Exception($"Количество свойств данных и названий колонок шапки не равны!");
            }
            //открываем файл для работы
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            //создаем документ, задаем границы, связываем документ и поток
            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            doc.SetMargins(0.5f, 0.5f, 0.5f, 0.5f);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            BaseFont baseFont = BaseFont.CreateFont("TIMCYR.TTF", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            //вставляем заголовок
            var phraseTitle = new Phrase(phase,
            new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD));
            iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph(phraseTitle)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 12
            };
            doc.Add(paragraph);
            //вставляем таблицу, задаем количество столбцов, и ширину колонок
            PdfPTable table = new PdfPTable(caps.Length)
            {
                TotalWidth = 800F
            };
            //вставляем шапку
            PdfPCell cell = new PdfPCell();
            var fontForCellBold = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.BOLD);
            foreach (var elem in caps) {
                table.AddCell(new PdfPCell(new Phrase(elem, fontForCellBold))
                {
                    HorizontalAlignment = Element.ALIGN_CENTER
                });
            }
            //заполняем таблицу
            var fontForCells = new iTextSharp.text.Font(baseFont, 10);
            for (int i = 0; i < list.Count; i++)
            {
                foreach (var elem in properties) {
                    cell = new PdfPCell(new Phrase(list[i].GetType().GetProperty(elem).GetValue(list[i]).ToString(), fontForCells));
                    table.AddCell(cell);
                }
            }
            //вставляем таблицу
            doc.Add(table);
            doc.Close();
        }
    }
}
