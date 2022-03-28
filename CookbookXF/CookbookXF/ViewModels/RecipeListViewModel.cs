using CookbookXF.DataAccess;
using CookbookXF.Models;
using CookbookXF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CookbookXF.ViewModels
{
    internal class RecipeListViewModel : BaseViewModel
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly INavigationService _navigationService;

        private ObservableCollection<RecipeItemViewModel> _recipeSource;
        private RecipeItemViewModel _selectedRecipe;

        public RecipeListViewModel(IRecipeRepository recipeRepository, INavigationService navigation)
        {
            _recipeRepository = recipeRepository;
            _navigationService = navigation;

            LoadRecipe("");

        }

        public ObservableCollection<RecipeItemViewModel> RecipeSource
        {
            get { return _recipeSource; }
            set
            {
                _recipeSource = value;
                OnPropertyChanged(nameof(RecipeSource));
            }
        }

        public RecipeItemViewModel SelectedRecipe
        {
            get
            {
                return _selectedRecipe;
            }
            set
            {
                _selectedRecipe = value;
                OnPropertyChanged(nameof(SelectedRecipe));
            }
        }

        public void LoadRecipe(string type)
        {
            List<RecipeItemViewModel> recipesListViewModel = new List<RecipeItemViewModel>();
            IEnumerable<Recipe> recipes = _recipeRepository.GetRecipeByType(type);

            foreach (var recipe in recipes)
            {
                recipesListViewModel.Add(new RecipeItemViewModel(recipe));
            }

            RecipeSource = new ObservableCollection<RecipeItemViewModel>(recipesListViewModel);
        }

        

       
    }
}
