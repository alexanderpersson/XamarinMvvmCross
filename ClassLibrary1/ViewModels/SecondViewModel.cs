using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Cirrious.MvvmCross.ViewModels;

namespace ClassLibrary1.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        public ObservableCollection<Person> List { get; set; }

        public string ButtonText { get { return "Click me"; } }

        public ICommand MyCommand
        {
            get { return new MvxCommand(() => List.Add(new Person {Name = DateTime.Now.ToString("F")})); }
        }

        public SecondViewModel()
        {
            List = new ObservableCollection<Person>();
        }
    }

    public class Person
    {
        public string Name { get; set; }
    }
}