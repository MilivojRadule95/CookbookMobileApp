
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CookbookXF.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        
        public MainViewModel()
        {
            Property = "Cile Mile";
            ChangePropertyValueCommand = new Command(OnChangePropertyValueCommand); 
        }

        private void OnChangePropertyValueCommand(object obj)
        {
            Property = "ergergrthrtger";
            OnePropertyChanged((Property)); 
            
        }

        public string Property { get; set; }

        public ICommand ChangePropertyValueCommand { get; set; }
    }
}
