using Prism.Events;
using Prism.Regions;
using Prism.Mvvm;
using RestaurantModule.Events;
using System;

namespace RestaurantModule.ViewModels
{
    public class CustomerBillViewModel : BindableBase
    {
        public string MyProperty { get; } = "Customer Bill is loading";

        private IEventAggregator _ea;
        private IRegionManager _rm;

        public CustomerBillViewModel(IEventAggregator ea, IRegionManager rm)
        {
            _ea = ea;
            _rm = rm;
            _ea.GetEvent<Test>().Subscribe(TestDef);
        }

        private void TestDef(string obj)
        {
            Testvalue = obj;
        }

        private string _testvalue;
        public string Testvalue
        {
            get { return _testvalue; }
            set { SetProperty(ref _testvalue, value); }
        }




    }
}
