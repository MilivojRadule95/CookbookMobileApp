using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookbookXF.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeDetailsView : ContentPage
    {
        public RecipeDetailsView()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Ingredients.IsVisible = true;
            Steps.IsVisible = false;
           
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Steps.IsVisible = true ;
            Ingredients.IsVisible = false ;
        }
    }
}