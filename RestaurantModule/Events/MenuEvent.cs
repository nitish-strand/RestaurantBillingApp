using Prism.Events;
using RestaurantModule.Models;
using System.Collections.ObjectModel;

namespace RestaurantModule.Events
{
    public class MenuEvent: PubSubEvent<ObservableCollection<MenuItems>>
    {

    }
}
