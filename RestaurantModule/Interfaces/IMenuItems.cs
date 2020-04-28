using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModule.Interfaces
{
    public interface IMenuItems
    {
        int itemId { get; set; }
        string typeVegNonV { get; set; }
        string itemName { get; set; }
        int quantity { get; set; }
        double rate { get; set; }
    }
}
