using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModule.Interfaces
{
    interface ICustomerInfo
    {
        string customerFirstName { get; set; }
        string customerLastName { get; set; }
        string customerLocation { get; set; }
        string customerWithNumber { get; set; }
    }
}
