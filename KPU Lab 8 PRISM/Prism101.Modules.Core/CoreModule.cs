using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace Prism101.Modules.Core
{
    public class CoreModule : IModule
    {
        private readonly IUnityContainer container;
        private readonly IRegionManager regionManager;

        public CoreModule(IUnityContainer container, IRegionManager regionManager)
        {
            this.container = container;
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            var view = new WelcomeView();
            regionManager.AddToRegion("MainContent", view);
        }
    }
}
