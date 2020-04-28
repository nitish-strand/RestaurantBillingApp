using Prism.Events;
using RestaurantModule.Models;

namespace RestaurantModule.Events
{
    class CustomerInfoEvent : PubSubEvent<CustomerInfoModel>
    {
    }
}
