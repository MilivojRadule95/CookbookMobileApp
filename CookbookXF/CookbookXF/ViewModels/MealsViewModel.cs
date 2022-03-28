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
    internal class MealsViewModel : BaseViewModel
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly INavigationService _navigationService;

        private ObservableCollection<RecipeItemViewModel> _recipeSource;
        private RecipeItemViewModel _selectedRecipe;
        public MealsViewModel(IRecipeRepository recipeRepository, INavigationService navigation)
        {
            _recipeRepository = recipeRepository;
            _navigationService = navigation;

            OpenListOfDishes = new Command(OnSelectOpenListOfDishes);
            LoadAllCategoriesOfMeal();
            LoadRecipe("Lunch");
            


        }

        public void LoadAllCategoriesOfMeal()
        {
            List<RecipeItemViewModel> mealsViewModel = new List<RecipeItemViewModel>();
            IEnumerable<Recipe> meals = _recipeRepository.GetRecipeByType("");

            foreach (var meal in meals)
            {
                mealsViewModel.Add(new MealsViewModel());
            }

            RecipeSource = new ObservableCollection<RecipeItemViewModel>(mealsViewModel);
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

        public ObservableCollection<RecipeItemViewModel> RecipeSource
        {
            get { return _recipeSource; }
            set
            {
                _recipeSource = value;
                OnPropertyChanged(nameof(RecipeSource));
            }
        }

        private void OnSelectOpenListOfDishes()
        {
            _navigationService.NavigateToRecipeList("Lunch");
        }
        public ICommand OpenListOfDishes { get; }

    }
}
