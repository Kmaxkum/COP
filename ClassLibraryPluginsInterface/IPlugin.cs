using MarketServiceDAL.BindingModels;
using MarketServiceDAL.ViewModel;

namespace ClassLibraryPluginsInterface
{
    public interface IPlugin
    {
        string PluginName { get; }

        CustomerBindingModel PluginWork(CustomerViewModel customer);
    }
}
