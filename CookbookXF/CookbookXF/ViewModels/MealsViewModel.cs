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
        
        public MealsViewModel(IRecipeRepository recipeRepository, INavigationService navigation)
        {
            _recipeRepository = recipeRepository;
            _navigationService = navigation;

            OpenListOfDishes = new Command<string>(OnSelectOpenListOfDishes);
            //LoadAllCategoriesOfMeal("");
            
            


        }

        //public void LoadAllCategoriesOfMeal(string type)
        //{
        //    List<RecipeItemViewModel> mealsViewModel = new List<RecipeItemViewModel>();
        //    IEnumerable<Recipe> meals = _recipeRepository.GetRecipeByType(type);

        //    foreach (var meal in meals)
        //    {
        //        mealsViewModel.Add(new RecipeItemViewModel(meal)); 
        //    }

        //    RecipeSource = new ObservableCollection<RecipeItemViewModel>(mealsViewModel);

        //}

        public ObservableCollection<RecipeItemViewModel> RecipeSource
        {
            get { return _recipeSource; }
            set
            {
                _recipeSource = value;
                OnPropertyChanged(nameof(RecipeSource));
            }
        }

        private void OnSelectOpenListOfDishes(string type)
        {
            _navigationService.NavigateToRecipeListView(type);
        }
        public ICommand OpenListOfDishes { get; }

    }
}
