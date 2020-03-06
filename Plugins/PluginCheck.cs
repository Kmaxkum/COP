using System;
using System.ComponentModel.Composition;
using ClassLibraryPluginsInterface;
using MarketServiceDAL.BindingModels;
using MarketServiceDAL.ViewModel;
using MarketModel;
using System.Windows.Forms;
using System.Collections.Generic;
using ClassLibraryControlReport;

namespace Plugins
{
    [Export(typeof(IPlugin))]
    public class PluginCheck : IPlugin
    {
        public string PluginName { get { return "PluginCheck"; } }

        public CustomerBindingModel PluginWork(CustomerViewModel customer)
        {
            CustomerBindingModel newCustomer = new CustomerBindingModel
            {
                Id = customer.Id,
                CustomerFIO = customer.CustomerFIO,
                State = (CustomerStatus)Enum.Parse(typeof(CustomerStatus), customer.State, true),
                Sum = customer.Sum
            };
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "doc|*.doc|docx|*.docx"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    object[] horizontalHeader = new object[] { "Чек" };
                    object[] verticalHeader = new object[] { "ФИО", "Сумма", "Подпись", "Дата" };
                    List<object[]> elem = new List<object[]>();
                    elem.Add(new object[] { customer.CustomerFIO });
                    elem.Add(new object[] { customer.Sum });
                    elem.Add(new object[] { "" });
                    elem.Add(new object[] { DateTime.Now });
                    ComponentWordReport componentWordReport = new ComponentWordReport();
                    componentWordReport.CreateReport(elem.ToArray(), horizontalHeader, verticalHeader, sfd.FileName);
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return newCustomer;
        }
    }
}
