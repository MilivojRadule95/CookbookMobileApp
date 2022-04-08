using CookbookXF.DataAccess;
using CookbookXF.Models;
using CookbookXF.Services;
using System.Collections.ObjectModel;

namespace CookbookXF.ViewModels
{
    internal class RecipeDetailsViewModel : BaseViewModel
    {
        
        private readonly INavigationService _navigationService;

        private ObservableCollection<DetailsInfoViewModel> _detailsSource;
        private ObservableCollection<IngridientsViewModel> _ingridientsSource;
        private ObservableCollection<StepsViewModel> _stepsSource;

        private DetailsInfoViewModel _selectedDetails;
        private string _longDescription;
        private string _title;

        

        private string _title;
        private string _longDescription;

        public RecipeDetailsViewModel(INavigationService navigationService)
        {
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

        public void LoadDetails(Recipe recipe)
        {
            DetailsSource = new ObservableCollection<DetailsInfoViewModel>() { new DetailsInfoViewModel(recipe)};
            
            Title = recipe.Name;
            LongDescription = recipe.LongDescription;

            IngredientsSource = new ObservableCollection<IngridientsViewModel>() { new IngridientsViewModel() };

            StepsSource = new ObservableCollection<StepsViewModel>() { new StepsViewModel() };

            foreach (var ingredient in recipe.Ingredients)
            {
                var ingredientViewModel = new IngridientsViewModel();
                ingredientViewModel.LoadIngredient(ingredient);
                ingredient.Add(IngridientsViewModel);

                    
            }

        }


    }
}
