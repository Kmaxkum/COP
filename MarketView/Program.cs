using MarketServiceDAL.Interfaces;
using MarketServiceImplementDataBase.Implementations;
using MarketServiceImplementDataBase;
using System;
using System.Windows.Forms;
using System.Data.Entity;
using Unity;
using Unity.Lifetime;

namespace MarketView
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormMain>());
        }
        public static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<DbContext, MarketDbContext>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ICustomerService, CustomerServiceDB>(new HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
