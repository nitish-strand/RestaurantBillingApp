using Prism.Commands;
using Prism.Mvvm;
using RestaurantModule.Models;
using System.Windows;

namespace RestaurantModule.ViewModels
{
    public class CustomerInfoViewModel : BindableBase
    {
        public string MyProperty { get; } = "Customer Info";

		private string _customerFirstName;
		public string CustomerFirstName
		{
			get { return _customerFirstName; }
			set { _customerFirstName = value; }
		}

		private string _customerLastName;
		public string CustomerLastName
		{
			get { return _customerLastName; }
			set { _customerLastName = value; }
		}

		private string _customerLocation;
		public string CustomerLocation
		{
			get { return _customerLocation; }
			set { _customerLocation = value; }
		}

		private string _customerWithNumber;
		public string CustomerWithNumber
		{
			get { return _customerWithNumber; }
			set { _customerWithNumber = value; }
		}

		private string _message;
		public string Message
		{
			get { return _message; }
			set { SetProperty(ref _message, value); }
		}

		private Visibility _checkVisbility;
		public Visibility CheckVisibility
		{
			get { return _checkVisbility; }
			set { SetProperty(ref _checkVisbility, value); }
		}

		public DelegateCommand SubmitInfo { get; private set; }
		public CustomerInfoViewModel()
		{
			SubmitInfo = new DelegateCommand(SubmitCustomerInfo);
			Message = "";
			CheckVisibility = Visibility.Collapsed;
		}

		private CustomerInfo custObj;
		private CustomerInfo newCustObj;
		private void SubmitCustomerInfo()
		{
			custObj = new CustomerInfo();
			custObj.customerFirstName = CustomerFirstName;
			custObj.customerLastName = CustomerLastName;
			custObj.customerLocation = CustomerLocation;
			custObj.customerWithNumber = CustomerWithNumber;

			newCustObj = custObj;
			Message = "Your information is saved please go ahead and order.";
			CheckVisibility = Visibility.Visible;
		}
	}
}
