using System;
using System.ComponentModel.Composition;
using ClassLibraryPluginsInterface;
using MarketServiceDAL.BindingModels;
using MarketServiceDAL.ViewModel;
using MarketModel;
using System.Windows.Forms;

namespace Plugins
{
    [Export(typeof(IPlugin))]
    public class PluginSum : IPlugin
    {
        public string PluginName { get { return "PluginSum"; } }

        public CustomerBindingModel PluginWork(CustomerViewModel customer)
        {
            CustomerBindingModel newCustomer = new CustomerBindingModel
            {
                Id = customer.Id,
                CustomerFIO = customer.CustomerFIO,
                State = (CustomerStatus)Enum.Parse(typeof(CustomerStatus), customer.State, true),
                Sum = customer.Sum
            };
            var form = new FormSum(customer);
            if (form.ShowDialog() == DialogResult.OK)
            {
                newCustomer.Sum = form.GetSum;
                form.Close();
            }
            return newCustomer;
        }
    }
}
