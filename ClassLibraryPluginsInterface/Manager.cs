using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel;
using System.IO;
using MarketServiceDAL.Interfaces;
using MarketServiceDAL.BindingModels;
using MarketServiceDAL.ViewModel;
using MarketModel;

namespace ClassLibraryPluginsInterface
{
    public class Manager
    {
        [ImportMany(typeof(IPlugin))]
        IEnumerable<IPlugin> Plugins { get; set; }

        public readonly Dictionary<string, Func<CustomerViewModel, CustomerBindingModel>> Plg = new Dictionary<string, Func<CustomerViewModel, CustomerBindingModel>>();

        public string[] Headers { get; private set; }

        public Manager() {
            AggregateCatalog catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory));
            catalog.Catalogs.Add(new DirectoryCatalog(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins")));

            CompositionContainer container = new CompositionContainer(catalog);
            try
            {
                container.ComposeParts(this);
            }
            catch (System.Reflection.ReflectionTypeLoadException compositionException)
            {
                Console.WriteLine(compositionException.LoaderExceptions.ToString());
            }
            if (Plugins.Count() != 0) {
                Plugins.ToList().ForEach(p => Plg.Add(p.PluginName, (i) => p.PluginWork(i)));
                Headers = Plg.Keys.ToArray();
            }
        }
    }
}
