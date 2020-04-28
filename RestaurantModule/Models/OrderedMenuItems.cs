using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantModule.Models
{
    public class OrderedMenuItems : MenuItems
    {
		private double _total;
		public double total
		{
			get { return _total; }
			set { _total = value; }
		}

	}
}
