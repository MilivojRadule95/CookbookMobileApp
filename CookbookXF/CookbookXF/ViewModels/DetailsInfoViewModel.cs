using CookbookXF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CookbookXF.ViewModels
{
    internal class DetailsInfoViewModel : BaseViewModel
    {
        public DetailsInfoViewModel(Recipe recipe)
        {
            Recipe = recipe;

            Title = recipe.Name;
            Steps = recipe.Steps;
            Ingredient = recipe.Ingredients;
            LongDescription = recipe.LongDescription;
            BackgroundImage = ImageSource.FromResource($"{Constants.ResourcePrefix} {recipe.BackgroundImage}");

        }
        
        private List<Step> _steps;
        private List<Ingredient> _ingredient;
        private string _longDescription;
        private string _title;
        private ImageSource _backgroundImage;
        public Recipe Recipe { get; }

        public List<Step> Steps
        {
            get { return _steps; }
            set 
            {
                _steps = value;
                OnPropertyChanged(nameof(Steps));
            }
        }

        public List<Ingredient> Ingredient
        {
            get { return _ingredient; }
            set 
            {
                _ingredient = value;
                OnPropertyChanged(nameof(Ingredient));
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
       
        public string Title
        {
            get { return _title; }
            set 
            { 
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public ImageSource BackgroundImage
        {
            get { return _backgroundImage; }
            set
            {
                _backgroundImage = value; OnPropertyChanged(nameof(BackgroundImage)); 
            }
        }

    }
}
