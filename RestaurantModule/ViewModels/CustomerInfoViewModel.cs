using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using RestaurantModule.Events;
using RestaurantModule.Models;
using RestaurantModule.Views;
using System;
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
		public DelegateCommand TakeOrder { get; private set; }
		public IEventAggregator _eventAggregator;
		public IRegionManager _regionManager ;
		public CustomerInfoViewModel(IEventAggregator eventAggregator, IRegionManager regionManager)
		{
			SubmitInfo = new DelegateCommand(SubmitCustomerInfo);
			TakeOrder = new DelegateCommand(TakeOrderDef);
			Message = "";
			CheckVisibility = Visibility.Collapsed;
			_eventAggregator = eventAggregator;
			_regionManager = regionManager;
		}

		private void TakeOrderDef()
		{
			RemoveAllRegions("RightRegion");
			_regionManager.RegisterViewWithRegion("RightRegion", typeof(CustomerOrder));
		}

		private CustomerInfoModel custObj;
		
		private void SubmitCustomerInfo()
		{
			custObj = new CustomerInfoModel();
			custObj.customerFirstName = CustomerFirstName;
			custObj.customerLastName = CustomerLastName;
			custObj.customerLocation = CustomerLocation;
			custObj.customerWithNumber = CustomerWithNumber;
			
			Message = "Your information is saved please go ahead and order.";
			CheckVisibility = Visibility.Visible;

			_eventAggregator.GetEvent<CustomerInfoEvent>().Publish(custObj);
		}

		private void RemoveAllRegions(string regionName)
		{
			foreach (var view in _regionManager.Regions[regionName].Views)
			{
				_regionManager.Regions[regionName].Remove(view);
			}
		}
	}
}
