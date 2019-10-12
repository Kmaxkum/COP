using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace ClassLibraryControlWordDiagram
{
    public partial class ControlWordDiagram : Component
    {
        public ControlWordDiagram()
        {
            InitializeComponent();
        }

        public ControlWordDiagram(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public enum Diagrams {
            LineChart,
            PieChart,
            BarChart
        }

        /// <typeparam name="T"></typeparam>
        /// <param name="diagram">Тип диаграммы.</param>
        /// <param name="dataLine">Список данных.</param>
        /// <param name="diagramName">Название диаграммы.</param>
        /// <param name="nameFirstProjection">Название свойства оси ординат.</param>
        /// <param name="nameSecondProjection">Название свойства оси абсцисс (обязательно численное значение).</param>
        /// <param name="path">Строка вида @"D:\path\to\diagram.docx".</param>
        public void CreateDiagram<T>(Diagrams diagram, List<T> dataLine, string diagramName, string nameFirstProjection, string nameSecondProjection, string path) {
            DocX document = DocX.Create(path);

            Series series = GetSeries<T>(dataLine, diagramName, nameFirstProjection, nameSecondProjection);

            switch (diagram)
            {
                case Diagrams.LineChart:
                    document.InsertChart(CreateLineChart(series));
                    break;
                case Diagrams.PieChart:
                    document.InsertChart(CreatePieChart(series));
                    break;
                case Diagrams.BarChart:
                    document.InsertChart(CreateBarChart(series));
                    break;
            }

            document.Save();
        }

        private static Chart CreateLineChart(Series series)
        {
            // создаём линейную диаграмму
            LineChart lineChart = new LineChart();
            // добавляем легенду вниз диаграммы
            lineChart.AddLegend(ChartLegendPosition.Bottom, false);

            // создаём набор данных и добавляем на диаграмму
            lineChart.AddSeries(series);

            return lineChart;
        }

        private static Chart CreatePieChart(Series series)
        {
            // создаём круговую диаграмму
            PieChart pieChart = new PieChart();
            // добавляем легенду слева от диаграммы
            pieChart.AddLegend(ChartLegendPosition.Left, false);

            // создаём набор данных и добавляем на диаграмму
            pieChart.AddSeries(series);

            return pieChart;
        }

        private static Chart CreateBarChart(Series series)
        {
            // создаём столбцовую диаграмму
            BarChart barChart = new BarChart();
            // отображаем легенду сверху диаграммы
            barChart.AddLegend(ChartLegendPosition.Top, false);

            // создаём набор данных и добавляем в диаграмму
            barChart.AddSeries(series);

            return barChart;
        }

        public static Series GetSeries<T>(List<T> data, string diagramName, string nameFirstProjection, string nameSecondProjection)
        {
            // создаём набор данных
            Series seriesFirst = new Series(diagramName);
            // заполняем данными
            seriesFirst.Bind(data, nameFirstProjection, nameSecondProjection);
            return seriesFirst;
        }
    }
}
