using RestaurantModule.Interfaces;

namespace RestaurantModule.Models
{
    public class CustomerInfo : ICustomerInfo
    {
        public string customerFirstName { get; set; }
        public string customerLastName { get; set; }
        public string customerLocation { get; set; }
        public string customerWithNumber { get; set; }
    }
}
