using System;
using System.ComponentModel.Composition;
using ClassLibraryPluginsInterface;
using MarketServiceDAL.BindingModels;
using MarketServiceDAL.ViewModel;
using MarketModel;
using System.Windows.Forms;
using ClassLibraryControlReport;

namespace Plugins
{
    [Export(typeof(IPlugin))]
    public class PluginStatus : IPlugin
    {
        public string PluginName { get { return "PluginStatus"; } }

        public CustomerBindingModel PluginWork(CustomerViewModel customer)
        {
            CustomerBindingModel newCustomer = new CustomerBindingModel {
                Id = customer.Id,
                CustomerFIO = customer.CustomerFIO,
                State = (CustomerStatus)Enum.Parse(typeof(CustomerStatus), customer.State, true),
                Sum = customer.Sum
            };
            var form = new FormStatus(customer);
            if (form.ShowDialog() == DialogResult.OK)
            {
                newCustomer.State = (CustomerStatus)Enum.Parse(typeof(CustomerStatus), form.GetState, true);
                form.Close();
            }
            return newCustomer;
        }
    }
}
