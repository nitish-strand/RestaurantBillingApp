using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using RestaurantModule.Views;
using System;
using System.Windows;
using System.Windows.Controls;

namespace RestaurantModule.ViewModels
{
    public class AdminLoginViewModel : BindableBase
    {
        public string MyProperty { get; } = "Admin Login";

        public DelegateCommand<object> LoginCommand { get; private set; }

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value); }
        }

        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }


        IRegionManager _regionManager;

        public AdminLoginViewModel(IRegionManager regionManager)
        {
            LoginCommand = new DelegateCommand<object>(CheckCredentials, canExecute);
            _regionManager = regionManager;
        }

        private bool canExecute(object arg)
        {
            return true;
        }

        private void CheckCredentials(object obj)
        {
            var password = obj as PasswordBox;
            
            MessageBox.Show("Hello Admin");

            if(UserName == "nitish" && password.Password.Equals("nitish123"))
            {
                RemoveAllRegions("RightRegion");
                _regionManager.RegisterViewWithRegion("RightRegion", typeof(AdminManage));
                //_regionManager.RequestNavigate("RightRegion", new Uri("CustomerBill", UriKind.Relative));
            }
            else
            {
                Message = "Please enter the right username & password";
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
