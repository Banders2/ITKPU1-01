using System;
using System.Linq;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;

namespace KPU_Lab_8_PRISM
{
    class Bootstrapper : UnityBootstrapper
    {
        private ModuleCatalog Catalog;
        protected override DependencyObject CreateShell()
        {
            return new Shell();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            App.Current.MainWindow = (Window)this.Shell;
            App.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(TestModule.TestModule));
            moduleCatalog.AddModule(typeof(TestModule.TestModule2));
            moduleCatalog.AddModule(typeof(TestModule.TestModule3));


            //var assemblyName = "Prism101.Modules.Core";
            //var filePath = "ModuleCatalog.xaml";
            //var uriPath = string.Format("/{0};component/{1}", assemblyName, filePath);

            //var uri = new Uri(uriPath, UriKind.Relative);
            //var moduleCatalog2 = Microsoft.Practices.Prism.Modularity.ModuleCatalog.CreateFromXaml(uri);
            //moduleCatalog.AddModule(moduleCatalog2.Modules.First()); 
        }
        //protected override IModuleCatalog CreateModuleCatalog()
        //{
        //    //    ModuleCatalog.
        //    //    return ModuleCatalog.CreateFromXaml(new Uri("/MyProject;component/ModulesCatalog.xaml",
        //    //UriKind.Relative));
        //    return Microsoft.Practices.Prism.Modularity.ModuleCatalog.CreateFromXaml(new Uri("Modules.xaml", UriKind.Relative));
        //}


    }
}
