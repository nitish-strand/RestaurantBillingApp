using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using RestaurantModule.Events;
using RestaurantModule.Models;
using RestaurantModule.Views;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace RestaurantModule.ViewModels 
{
    public class CustomerOrderViewModel : BindableBase
    {
        public string MyProperty { get; } = "Customer Order";

        private IEventAggregator _ea;
        private IRegionManager _rm;
        public CustomerOrderViewModel(IEventAggregator ea, IRegionManager rm)
        {
            _rm = rm;
            _ea = ea;
            _displayMenu = new ObservableCollection<MenuItems>();
            _ea.GetEvent<MenuEvent>().Subscribe(CustomerDisplayMenu);
            //ea.GetEvent<Test>().Subscribe(TestDef);

            //detour call
            DefaultMenu();
            AddToList = new DelegateCommand(TakeOrder);
            Order = new DelegateCommand(PrintBill);
        }

        //private string testvalue;
        //public string Testvalue
        //{
        //    get { return testvalue; }
        //    set { SetProperty(ref testvalue, value); }
        //}
        //private void TestDef(string obj)
        //{
        //    Testvalue = obj.ToString();
        //}



        private ObservableCollection<MenuItems> _displayMenu;
        public ObservableCollection<MenuItems> DisplayMenu
        {
            get { return _displayMenu; }
            set { SetProperty(ref _displayMenu, value); }
        }


        private void CustomerDisplayMenu(ObservableCollection<MenuItems> obj)
        {
            foreach(MenuItems item in obj)
            {
                DisplayMenu.Add(item);
            }

        }

        //TakeOrder operations
        private int _id;
        public int ID
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private int _quant;
        public int Quant
        {
            get { return _quant; }
            set { SetProperty(ref _quant, value); }
        }

        OrderedMenuItems OrderObj = new OrderedMenuItems();

        private ObservableCollection<OrderedMenuItems> myOrder = new ObservableCollection<OrderedMenuItems>();
        public ObservableCollection<OrderedMenuItems> MyOrder
        {
            get { return myOrder; }
            set { SetProperty(ref myOrder, value); }
        }

        public DelegateCommand AddToList { get; set; }
        public DelegateCommand Order { get; set; }

        private void TakeOrder()
        {
            foreach(MenuItems i in DisplayMenu)
            {
                if(ID == i.itemId)
                {
                    OrderObj.itemId = i.itemId;
                    OrderObj.itemName = i.itemName;
                    OrderObj.typeVegNonV = i.typeVegNonV;
                    OrderObj.quantity = Quant;
                    OrderObj.rate = i.rate;
                    OrderObj.total = i.rate * Quant;

                    ID = Quant = 0;

                    MyOrder.Add(OrderObj);
                }
            }
        }

        private void PrintBill()
        {
            _ea.GetEvent<Test>().Publish("Checking 123");
            //_rm.RegisterViewWithRegion("RightRegion", typeof(CustomerBill));
            _rm.RequestNavigate("RightRegion", new Uri("CustomerBill", UriKind.Relative));

        }



        //A little detour to be deleted later
        private void DefaultMenu()
        {
            _displayMenu = new ObservableCollection<MenuItems>()
            {
                new MenuItems() { itemId = 1, typeVegNonV = "Veg", itemName = "Poha", quantity = 1, rate = 45 },
                new MenuItems() { itemId = 2, typeVegNonV = "Veg", itemName = "Noodles", quantity = 1, rate = 55 },
                new MenuItems() { itemId = 3, typeVegNonV = "NonVeg", itemName = "ChikenCurry", quantity = 1, rate = 150 },
                new MenuItems() { itemId = 4, typeVegNonV = "NonVeg", itemName = "MuttonCurry", quantity = 1, rate = 245 },
                new MenuItems() { itemId = 5, typeVegNonV = "NonVeg", itemName = "MuttonKorma", quantity = 1, rate = 200 },
                new MenuItems() { itemId = 6, typeVegNonV = "MockTail", itemName = "Tea", quantity = 1, rate = 15 },
                new MenuItems() { itemId = 7, typeVegNonV = "MockTail", itemName = "Pena-co-lada", quantity = 1, rate = 50 },
                new MenuItems() { itemId = 8, typeVegNonV = "Cocktail", itemName = "Martini", quantity = 1, rate = 550 },
                new MenuItems() { itemId = 9, typeVegNonV = "Cocktail", itemName = "RumNCoke", quantity = 1, rate = 240 },
                new MenuItems() { itemId = 10, typeVegNonV = "Cocktail", itemName = "JackNCoke", quantity = 1, rate = 590 },
            };

        }
    }
}
