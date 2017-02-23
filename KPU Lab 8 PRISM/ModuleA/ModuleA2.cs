using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;

namespace ModuleA
{
    public class ModuleA2 : IModule
    {
        private readonly IUnityContainer container;
        private readonly IRegionManager regionManager;

        public ModuleA2(IUnityContainer container, IRegionManager regionManager)
        {
            this.container = container;
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            var view = new UserControl1();
            regionManager.AddToRegion("MainRegion3", view);
        }
    }
}
