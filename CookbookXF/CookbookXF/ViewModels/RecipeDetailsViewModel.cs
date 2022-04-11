using CookbookXF.DataAccess;
using CookbookXF.Models;
using CookbookXF.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace CookbookXF.ViewModels
{
    internal class RecipeDetailsViewModel : BaseViewModel
    {
        private readonly INavigationService _navigationService;
        private ObservableCollection<IngridientsViewModel> _ingridientsSource;
        private ObservableCollection<StepsViewModel> _stepsSource;
        private string _longDescription;
        private string _title;

        public RecipeDetailsViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            GoBack = new Command(OnSelectedGoBack);
            DisplayIngredients = new Command(OnSelectedDisplayIngredients);
            DisplaySteps = new Command(OnSelectedDisplaySteps);
        }

        public ObservableCollection<IngridientsViewModel> IngredientsSource
        {
            get { return _ingridientsSource; }
            set 
            {
                _ingridientsSource = value;
                OnPropertyChanged(nameof(IngredientsSource));
            }
        }

        public ObservableCollection<StepsViewModel> StepsSource
        {
            get { return _stepsSource; }
            set
            {
                _stepsSource = value;
                OnPropertyChanged(nameof(StepsSource));
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

        public string LongDescription
        {
            get { return _longDescription; }
            set 
            { 
                _longDescription = value; 
                OnPropertyChanged(nameof(LongDescription));
            }
        }

        public void LoadDetails(Recipe recipe)
        {
            Title = recipe.Name;
            LongDescription = recipe.LongDescription;

            IngredientsSource = new ObservableCollection<IngridientsViewModel>();

            StepsSource = new ObservableCollection<StepsViewModel>();

            foreach (var ingredient in recipe.Ingredients)
            {
                var ingredientViewModel = new IngridientsViewModel(ingredient);
                
                IngredientsSource.Add(ingredientViewModel);
            }

            foreach (var step in recipe.Steps)
            {
                var stepViewModel = new StepsViewModel(step);

                StepsSource.Add(stepViewModel);
            }
        }

        private void OnSelectedGoBack()
        {
            _navigationService.GoBack();
        }

        private void OnSelectedDisplayIngredients()
        {
            
        }

        private void OnSelectedDisplaySteps()
        {
           
        }

        public ICommand GoBack { get; }
        public ICommand DisplayIngredients { get; }
        public ICommand DisplaySteps { get; }
    }
}
