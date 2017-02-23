using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism;
using Microsoft.Practices.Prism.Regions;


namespace TestModule
{
    public class TestModule : IModule
    {
        private readonly IRegionManager regionManager;
        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.TestView));
        }

        public TestModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }
    }
}
