using CookbookXF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookbookXF.ViewModels
{
    internal class RecipeItemViewModel : BaseViewModel
    {
        public RecipeItemViewModel(Recipe recipe)
        {
            Recipe = recipe;

            Title = recipe.Name;
            ShortDescription = recipe.ShortDescription;
        }

        public Recipe Recipe { get; }

        private string _title;

        public string Title
        {
            get { return _title; }
            set 
            { 
                _title = value; 
                OnPropertyChanged(nameof(Title));
            }
        }

        private string _shortDescription;

        public string ShortDescription
        {
            get { return _shortDescription; }
            set 
            { 
                _shortDescription = value; 
                OnPropertyChanged(nameof(ShortDescription));
            }
        }



    }
}
