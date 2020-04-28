using Prism.Modularity;
using Prism.Regions;


namespace RestaurantModule
{
    public class RestaurantModule : IModule
    {
        private IRegionManager _regionManager;

        public RestaurantModule(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            //_regionManager.RegisterViewWithRegion("Left", typeof(Views.Home));
            //_regionManager.RegisterViewWithRegion("Right", typeof(Views.AdminLogin));
            //_regionManager.RegisterViewWithRegion("Right", typeof(Views.AdminManage));
            //_regionManager.RegisterViewWithRegion("Right", typeof(Views.CustomerInfo));
            //_regionManager.RegisterViewWithRegion("RightRegion", typeof(Views.CustomerOrder));
            //_regionManager.RegisterViewWithRegion("Right", typeof(Views.CustomerBill));
        }

    }
}
