using CookbookXF.DataAccess;
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

        public void LoadRecipe()
        {
            var recipeListViewModel = new List<RecipeItemViewModel>();
            var recipe = _recipeRepository.GetAllRecipes();

            foreach (var recipe in recipes)
            {
                recipeViewModel.Add(new RecipeItemViewModel(recipe));
            }

           RecipeSource = new ObservableCollection<RecipeItemViewModel>(recipeViewModel);
        }

        private void OnSelectedRecipeChangedCommand()
        {
            if (SelectedRecipe != null)
            {
                _navigationService.NavigateToRecipeEditor(SelectedRecipe.Recipe);
            }

            SelectedRecipe = null;
        }

        public RecipeListViewModel()
        {
            Property = "Cile Mile";
            ChangePropertyValueCommand = new Command(OnChangePropertyValueCommand);
        }

        private void OnChangePropertyValueCommand(object obj)
        {
            Property = "ergergrthrtger";
            OnPropertyChanged((Property));

        }

        public string Property { get; set; }

        public ICommand ChangePropertyValueCommand { get; set; }
    }
}
