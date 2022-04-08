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

        private string _type;

        public RecipeListViewModel(IRecipeRepository recipeRepository, INavigationService navigation)
        {
            _recipeRepository = recipeRepository;
            _navigationService = navigation;

            OpenRecipeDetails = new Command<string>(OnSelectOpenRecipeDetails);
            GoBack = new Command(OnSelectedGoBack);
            
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

            foreach (var rec in recipes)
            {
                recipesListViewModel.Add(new RecipeItemViewModel(rec));
            }

            RecipeSource = new ObservableCollection<RecipeItemViewModel>(recipesListViewModel);
            Type = type;
        }

        private void OnSelectOpenRecipeDetails(string type)
        {
            _navigationService.NavigateToRecipeDetailsView(SelectedRecipe.Recipe);
        }

        private void OnSelectedGoBack()
        {
            _navigationService.GoBack();
        }

        public ICommand OpenRecipeDetails { get; }
        public ICommand GoBack { get; }
    }
}
