using MarketServiceDAL.BindingModels;
using MarketServiceDAL.Interfaces;
using MarketServiceDAL.ViewModel;
using ClassLibraryControlView;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;
using ClassLibraryControlWordDiagram;
using ClassLibraryControlReport;
using ClassLibrarySingleton;
using ClassLibraryPluginsInterface;

namespace MarketView
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ICustomerService service;
        
        public FormMain(ICustomerService service)
        {
            InitializeComponent();
            this.service = service;
            LoadData();
        }

        public void LoadData()
        {
            var customers = service.GetList();

            var nodes = new List<Node>();

            foreach (var customer in customers)
            {
                var node = new Node(customer.State);
                node.AddSubNode(new Node($"ФИО: {customer.CustomerFIO}"));
                node.AddSubNode(new Node($"Сумма: {customer.Sum}"));
                nodes.Add(node);
            }

            customersTreeView.AddNodes(nodes);
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Container.Resolve<FormCustomerList>().Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "doc|*.doc|docx|*.docx"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    object[] horizontalHeader = new object[] { "hh1", "hh2", "hh3" };
                    List<string> verticalHeader = new List<string>();
                    int i = 1;
                    //object[] verticalHeader = new object[] { "vh1", "vh2"};
                    List<object[]> elem = new List<object[]>();
                    foreach (var value in service.GetList()) {
                        elem.Add(new object[] { value.CustomerFIO, value.State, value.Sum == null? "" : value.Sum.ToString() });
                        verticalHeader.Add($"vh{i++}");
                    }
                    componentWordReport1.CreateReport(elem.ToArray(), horizontalHeader, verticalHeader.ToArray(), sfd.FileName);
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDiagram_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "doc|*.doc|docx|*.docx"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Dictionary<int?, int> mp = new Dictionary<int?, int>();
                    foreach (var elem in service.GetList()) {
                        if (elem.Sum == null)
                        {
                            if (mp.ContainsKey(0))
                            {
                                mp[0]++;
                            }
                            else
                            {
                                mp[0] = 1;
                            }
                            continue;
                        }
                        if (mp.ContainsKey(elem.Sum)) {
                            mp[elem.Sum]++;
                        }
                        else {
                            mp[elem.Sum] = 1;
                        }
                    } 

                    controlWordDiagram1.CreateDiagram(ControlWordDiagram.Diagrams.BarChart, SingletonData.getInstance(mp).Data, "Количество покупателей с суммами", "sum", "cnt", sfd.FileName);
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    componentJsonBackup1.OutputPath = sfd.FileName;
                    componentJsonBackup1.Backup(service.GetList().ToArray());
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //class Data
        //{
        //    public int cnt { get; set; }
        //    public int? sum { get; set; }

        //    public static List<Data> GetData(Dictionary<int?, int> mp)
        //    {
        //        List<Data> data = new List<Data>();

        //        foreach (var pair in mp) {
        //            data.Add(new Data() { sum = pair.Key, cnt = pair.Value });
        //        }

        //        return data;
        //    }
        //}
    }
}
