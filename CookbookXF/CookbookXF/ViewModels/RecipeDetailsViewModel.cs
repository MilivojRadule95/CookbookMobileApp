using CookbookXF.DataAccess;
using CookbookXF.Models;
using CookbookXF.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CookbookXF.ViewModels
{
    internal class RecipeDetailsViewModel : BaseViewModel
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly INavigationService _navigationService;

        private ObservableCollection<DetailsInfoViewModel> _detailsSource;
        private DetailsInfoViewModel _selectedDetails;
        private string _longDescription;
        private string _title;

        


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
            DetailsSource = new ObservableCollection<DetailsInfoViewModel>() { new DetailsInfoViewModel(recipe) };
            Title = recipe.Name;
            LongDescription = recipe.LongDescription;
            
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

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }


    }
}
