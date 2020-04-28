using Prism.Mvvm;
using Prism.Regions;
using RestaurantModule.Views;

namespace GS_Restaurant_Prism.ViewModels
{
    public class ShellViewModel : BindableBase
    {
        public string Title { get; } = "Gene Spring: Restaurant";

        private IRegionManager leftRegionManager;

        //public IRegionManager 

        public ShellViewModel(IRegionManager regionManager)
        {
            leftRegionManager = regionManager.RegisterViewWithRegion("LeftRegion", typeof(RestaurantModule.Views.Home));
        }
    }
}
