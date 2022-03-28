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
        private string _shortDescription;
        private string _type;
        private string _longDescription;
        private string _id;
        private List<Step> _steps;
        private string _backgroundImage;
        private string _thumbNailImage;
        private List<Ingredient> _ingredients;

        public List<Ingredient> Ingredients
        {
            get { return _ingredients; }
            set
            {
                _ingredients = value;
                OnPropertyChanged(nameof(Ingredient));
            }
        }
        public string ThumbNailImage
        {
            get { return _thumbNailImage; }
            set
            {
                _thumbNailImage = value;
                OnPropertyChanged(nameof(ThumbNailImage));
            }
        }

        public string BackgroundImage
        {
            get { return _backgroundImage; }
            set
            {
                _backgroundImage = value;
                OnPropertyChanged(nameof(BackgroundImage));
            }
        }

        public List<Step> Steps
        {
            get { return _steps; }
            set 
            {
                _steps = value;
                OnPropertyChanged(nameof(Steps));
            }
        }

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string LongDescription
        {
            get { return _longDescription; }
            set 
            {
                _longDescription = value;
                OnPropertyChanged(nameof(LongDescription));
            }
        }

        public string Type
        {
            get { return _type; }
            set
            { 
                _type = value; 
                OnPropertyChanged(nameof(Type));
            }
        }

        public string Title
        {
            get { return _title; }
            set 
            { 
                _title = value; 
                OnPropertyChanged(nameof(Title));
            }
        }

        
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
