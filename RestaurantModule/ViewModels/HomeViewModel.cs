using System;
using Prism.Commands;
using Prism.Mvvm;
using System.Windows;

namespace RestaurantModule.ViewModels
{
    public class HomeViewModel : BindableBase
    {
        public DelegateCommand<Window> ExitCommand { get; private set; }
        public HomeViewModel()
        {
            ExitCommand = new DelegateCommand<Window>(Execute, CanExecute);
            //unity container region manager

        }

        private void Execute(Window arg)
        {
            arg.Close();
        }

        private bool CanExecute(Window arg)
        {
            return true;
        }

        private bool p_ButtonAIsChecked;
        public bool ButtonAIsChecked
        {
            get { return p_ButtonAIsChecked; }
            set
            {
                SetProperty(ref p_ButtonAIsChecked, value);
                MessageBox.Show(string.Format("Button A is checked: {0}", value));
                // if true remove all regions from right regions and add admin password view
                //
                // else 
            }
        }

        private bool p_ButtonBIsChecked;
        public bool ButtonBIsChecked
        {
            get { return p_ButtonBIsChecked; }
            set
            {
                SetProperty(ref p_ButtonBIsChecked, value);
                MessageBox.Show(string.Format("Button B is checked: {0}", value));
            }
        }
    }
}