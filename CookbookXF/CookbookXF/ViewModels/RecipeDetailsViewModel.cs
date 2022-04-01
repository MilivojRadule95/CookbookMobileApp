using CookbookXF.DataAccess;
using CookbookXF.Models;
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
        private DetailsInfoViewModel _selectedDetails;

        public RecipeDetailsViewModel(IRecipeRepository recipeRepository, INavigationService navigationService)
        {
            _recipeRepository = recipeRepository;
            _navigationService = navigationService;
        }
        public ObservableCollection<DetailsInfoViewModel> DetailsSource
        {
            get { return _detailsSource; }
            set 
            {
                _detailsSource = value;
                OnPropertyChanged(nameof(DetailsSource));
            }
        }

        public DetailsInfoViewModel SelectedDetails
        {
            get
            {
                return _selectedDetails;
            }
            set
            {
                _selectedDetails = value;
                OnPropertyChanged(nameof(SelectedDetails));
            }
        }

        public void LoadDetails(string type)
        {
            List<DetailsInfoViewModel> recipeDetailsViewModel = new List<DetailsInfoViewModel>();
            IEnumerable<Recipe> recipes = _recipeRepository.GetRecipeByType(type);

            foreach (var recipe in recipes)
            {
                recipeDetailsViewModel.Add(new DetailsInfoViewModel(recipe));
            }

            DetailsSource = new ObservableCollection<DetailsInfoViewModel>(recipeDetailsViewModel);
        }

        
    }
}
