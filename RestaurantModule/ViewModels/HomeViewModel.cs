using System;
using Prism.Commands;
using Prism.Mvvm;
using System.Windows;
using Prism.Regions;

namespace RestaurantModule.ViewModels
{
    public class HomeViewModel : BindableBase
    {
        public DelegateCommand<Window> ExitCommand { get; private set; }

        private IRegionManager _regionManager;
        public HomeViewModel(IRegionManager regionManager)
        {
            ExitCommand = new DelegateCommand<Window>(Execute, CanExecute);
            _regionManager = regionManager;
            
            //unity container region manager

        }

        private void Execute(Window arg)
        {
            arg.Close();
        }

        private bool CanExecute(Window arg)
        {
            return true;
        }

        private bool p_ButtonAIsChecked;
        public bool ButtonAIsChecked
        {
            get { return p_ButtonAIsChecked; }
            set
            {
                RemoveAllRegions("RightRegion");
                //MessageBox.Show(string.Format("Button A is checked: {0}", value));
                _regionManager.RegisterViewWithRegion("RightRegion", typeof(Views.AdminLogin));
                SetProperty(ref p_ButtonAIsChecked, value);
            }
        }

        private bool p_ButtonBIsChecked;
        public bool ButtonBIsChecked
        {
            get { return p_ButtonBIsChecked; }
            set
            {
                RemoveAllRegions("RightRegion");
                //MessageBox.Show(string.Format("Button B is checked: {0}", value));
                _regionManager.RegisterViewWithRegion("RightRegion", typeof(Views.CustomerInfo));
                SetProperty(ref p_ButtonBIsChecked, value);
            }
        }

        private void RemoveAllRegions(string regionName)
        {
            foreach (var view in _regionManager.Regions[regionName].Views)
            {
                _regionManager.Regions[regionName].Remove(view);
            }
        }
    }
}