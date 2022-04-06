using System;
using System.Collections.Generic;
using System.Text;

namespace CookbookXF.ViewModels
{
    internal class MealsCategoryViewModel : BaseViewModel
    {
        public MealsCategoryViewModel(string category)
        {
            Type = category;
        }

        public string Recipe { get; set; }
        private string _type;

        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }

    }
}
