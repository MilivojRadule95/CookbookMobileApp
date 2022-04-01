using CookbookXF.DataAccess;
using CookbookXF.Models;
using CookbookXF.Services;
using System.Collections.ObjectModel;

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

        public void LoadDetails(Recipe recipe)
        {
            DetailsSource = new ObservableCollection<DetailsInfoViewModel>() { new DetailsInfoViewModel(recipe)};
        }

        
    }
}
