using CookbookXF.Models;
using Xamarin.Forms;

namespace CookbookXF.ViewModels
{
    internal class RecipeItemViewModel : BaseViewModel
    {
        public RecipeItemViewModel(Recipe recipe)
        {
            Recipe = recipe;

            Title = recipe.Name;
            ShortDescription = recipe.ShortDescription;
            ThumbNailImage = ImageSource.FromResource($"{Constants.ResourcePrefix}{recipe.ThumbnailImage}");
        }

        public Recipe Recipe { get; }

        private string _title;
        private string _shortDescription;
        private ImageSource _thumbNailImage;
       
        public ImageSource ThumbNailImage
        {
            get { return _thumbNailImage; }
            set
            {
                _thumbNailImage = value;
                OnPropertyChanged(nameof(ThumbNailImage));
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

        public string ShortDescription
        {
            get { return _shortDescription; }
            set 
            { 
                _shortDescription = value; 
                OnPropertyChanged(nameof(ShortDescription));
            }
        }



    }
}
