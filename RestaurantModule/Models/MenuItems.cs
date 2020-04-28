using RestaurantModule.Interfaces;

namespace RestaurantModule.Models
{
    public class MenuItems : IMenuItems
    {
        private int _itemId;
        public int itemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        private string _typeVegNonV;
        public string typeVegNonV
        {
            get { return _typeVegNonV; }
            set { _typeVegNonV = value; }
        }

        private string _itemName;
        public string itemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }
        
        private int _quantity;
        public int quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        private double _rate;
        public double rate
        {
            get { return _rate; }
            set { _rate = value; }
        }
    }
}
