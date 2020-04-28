using Prism.Commands;
using Prism.Mvvm;
using RestaurantModule.Models;
using System.Collections.ObjectModel;
using Prism.Events;
using RestaurantModule.Events;

namespace RestaurantModule.ViewModels
{
    public class AdminManageViewModel : BindableBase
    {
        public string MyProperty { get; } = "Admin Manage";
        public DelegateCommand SaveChanges { get; private set; }

        IEventAggregator _ea; 

        private string _message;    
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
            //RaisePropertyChanged("Message"); <-- not required SetProperty does the job.
        }
        
        public AdminManageViewModel(IEventAggregator ea)
        {
            DefaultMenu();
            SaveChanges = new DelegateCommand(ChangesSaved, canExecuteMethod);
            Message = "No Changes";
            _ea = ea;
            
        }

        private void ChangesSaved()
        {
            Message = "Changes made have been saved.";
            //code to save the changes in some Collections. To be shared for later.
            _ea.GetEvent<MenuEvent>().Publish(MyItems);
        }

        private bool canExecuteMethod()
        {
            return true;
        }

        private ObservableCollection<MenuItems> myItems;
		public ObservableCollection<MenuItems> MyItems
		{
			get { return myItems; }
			//set { myItems = value; }
			set { SetProperty(ref myItems, value); }
		}

        private void DefaultMenu()
        {
            myItems = new ObservableCollection<MenuItems>()
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
