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
        private Dictionary<string, string> _typeImageMap = new Dictionary<string, string>
        {
            { "Lunch", "lunch.png" },
            { "Breakfast", "breakfast.png" },
            { "Dinner", "dinner.png" },
            { "Snack", "snack.png" }
            
        };
        private readonly IRecipeRepository _recipeRepository;
        private readonly INavigationService _navigationService;

        private ObservableCollection<MealsCategoryViewModel> _recipeSource;
        private MealsCategoryViewModel _category;

        public MealsViewModel(IRecipeRepository recipeRepository, INavigationService navigation)
        {
            _recipeRepository = recipeRepository;
            _navigationService = navigation;

            OpenListOfDishes = new Command<string>(OnSelectOpenListOfDishes);
            LoadAllCategoriesOfMeal();
            
        }


        public void LoadAllCategoriesOfMeal()
        {
           
            List<MealsCategoryViewModel> mealsViewModel = new List<MealsCategoryViewModel>();
            IEnumerable<string> meals = _recipeRepository.GetRecipeTypes();

            foreach (var meal in meals)
            {
               
                if (_typeImageMap.ContainsKey(meal))
                {
                mealsViewModel.Add(new MealsCategoryViewModel(meal, _typeImageMap[meal]));

                }
                else
                {
                    mealsViewModel.Add(new MealsCategoryViewModel(meal, "DefaultImage.png"));
                }
            } 
            
           

            RecipeSource = new ObservableCollection<MealsCategoryViewModel>(mealsViewModel);

        }

        public ObservableCollection<MealsCategoryViewModel> RecipeSource
        {
            get { return _recipeSource; }
            set
            {
                _recipeSource = value;
                OnPropertyChanged(nameof(RecipeSource));
            }
        }

        public MealsCategoryViewModel Category
        {
            get { return _category; }
            set 
            {
                _category = value; 
                OnPropertyChanged(nameof(Category)); 
            }
        }

        private void OnSelectOpenListOfDishes(string type)
        {
            _navigationService.NavigateToRecipeListView(Category.Type);
        }
        public ICommand OpenListOfDishes { get; }

    }
}
