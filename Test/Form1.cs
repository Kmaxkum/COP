using ClassLibraryControlPDFReporter;
using ClassLibraryControlWordDiagram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public enum TestEnum
        {
            Значение1,

            Значение2,

            Значение3,

            Значение4,

            Значение5
        }
        
        [Serializable]
        public class Person {
            public string firstName { get; set; }
            public string secondName { get; set; }
        }

        List<Person> person;

        public Form1()
        {
            InitializeComponent();
            componentRestore1.Path = "save";
            controlTextBoxTemplate1.Mail = "111@mail.ru";
            List<string> countries = new List<string>() { "Бразилия", "Аргентина", "Чили", "Уругвай", "Колумбия" };
            controlListBoxOutput1.Pattern = "Имя {firstName} *** Фамилия {secondName}";
            person = new List<Person>() {
                new Person { firstName = "Иван", secondName = "Баланар"},
                new Person { firstName = "Ярик", secondName = "Брюмастер"},
                new Person { firstName = "ASDASdqwe", secondName = "ASD"}
            };
            controlListBoxOutput1.LoadListBox(person);
            controlComboBox1.LoadEnumeration(typeof(TestEnum));
            controlComboBox1.SelectedIndex = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = controlComboBox1.SelectedText + " " +  controlComboBox1.SelectedIndex;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = controlTextBoxTemplate1.Mail;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            componentRestore1.Save(person);
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            person.Clear();
            try
            {
                person = componentRestore1.Restore<Person>();
            }
            catch (Exception exp) {
                MessageBox.Show($"Ошибка: {exp.Message}");
                return;
            }
            Console.WriteLine(person[0].firstName);
        }

        private void buttonDiagram_Click(object sender, EventArgs e)
        {
            
            controlWordDiagram1.CreateDiagram<TestData>(ControlWordDiagram.Diagrams.PieChart, TestData.GetTestDataFirst(), "Человеки", "firstName", "value", @"D:\diagram.docx");
        }

        class TestData
        {
            public string firstName { get; set; }
            public string value { get; set; }

            public static List<TestData> GetTestDataFirst()
            {
                List<TestData> testDataFirst = new List<TestData>();

                testDataFirst.Add(new TestData() { firstName = "Иван", value = "1" });
                testDataFirst.Add(new TestData() { firstName = "Ярик", value = "1" });
                testDataFirst.Add(new TestData() { firstName = "Иван", value = "1" });
                testDataFirst.Add(new TestData() { firstName = "Сань", value = "8" });
                testDataFirst.Add(new TestData() { firstName = "Да", value = "5" });

                return testDataFirst;
            }
        }

        private void buttonPDF_Click(object sender, EventArgs e)
        {
            controlPDFReporter1.CreatePDFReport("Человеки", "Имя Фамилия", "firstName secondName", person, @"D:\report.pdf");
        }
    }
}
