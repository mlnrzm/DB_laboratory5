using BusinessLogicsHardwareStore.BusinessLogic;
using HardwareStoreContracts.BindingModels;
using HardwareStoreContracts.BusinessLogicContracts;
using HardwareStoreContracts.StorageContracts;
using DatabaseImplement.Implements;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;
using System.Configuration;
using System.Threading;

namespace HardwareStoreView
{
    static class Program
    {
        private static IUnityContainer container = null;
        public static IUnityContainer Container
        {
            get
            {
                if (container == null)
                {
                    container = BuildUnityContainer();
                }
                return container;
            }
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Container.Resolve<FormMain>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();

            currentContainer.RegisterType<ICategoryStorage, CategoryStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ITechnicStorage, TechnicStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IMovementTypeStorage, MovementTypeStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IMovementStorage, MovementStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ICounterpartyStorage, CounterpartyStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IContentStorage, ContentStorage>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<ICategoryLogic, CategoryLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ITechnicLogic, TechnicLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IMovementTypeLogic, MovementTypeLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IMovementLogic, MovementLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ICounterpartyLogic, CounterpartyLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IContentLogic, ContentLogic>(new HierarchicalLifetimeManager());

            return currentContainer;
        }
    }
}
