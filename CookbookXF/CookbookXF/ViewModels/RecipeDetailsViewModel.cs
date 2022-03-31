using CookbookXF.DataAccess;
using CookbookXF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CookbookXF.ViewModels
{
    internal class RecipeDetailsViewModel : BaseViewModel
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly INavigationService _navigationService;
        private ObservableCollection<DetailsInfoViewModel> _detailsSource;
        private ObservableCollection<DetailsInfoViewModel> DetailsSource
        {
            get { return _detailsSource; }
            set 
            {
                _detailsSource = value;
                OnPropertyChanged(nameof(DetailsSource));
            }
        }

        public void LoadDetails(string type)
        {

        }
    }
}
