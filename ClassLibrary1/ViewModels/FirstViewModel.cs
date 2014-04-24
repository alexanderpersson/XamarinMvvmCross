using System;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace ClassLibrary1.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}

        public string ButtonText { get { return "Click me"; } }

        public ICommand MyCommand
        {
            get
            {
                return new MvxCommand(() => ShowViewModel<SecondViewModel>(), () => true);
            }
        }
    }
}
