using Prism.Events;
using Prism.Mvvm;
using RestaurantModule.Events;
using RestaurantModule.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace RestaurantModule.ViewModels 
{
    public class CustomerOrderViewModel : BindableBase
    {
        public string MyProperty { get; } = "Customer Order";
        public CustomerOrderViewModel(IEventAggregator ea)
        {
            ea.GetEvent<MenuEvent>().Subscribe(CustomerDisplayMenu);
            _displayMenu = new ObservableCollection<MenuItems>();
        }

        
        private ObservableCollection<MenuItems> _displayMenu;
        public ObservableCollection<MenuItems> DisplayMenu
        {
            get { return _displayMenu; }
            set { SetProperty(ref _displayMenu, value); }
        }


        private void CustomerDisplayMenu(ObservableCollection<MenuItems> obj)
        {
            DisplayMenu.Clear();
            foreach(MenuItems item in obj)
            {
                DisplayMenu.Add(item);
            }

        }
    }
}
