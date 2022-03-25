using CookbookXF.Models;
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
    public partial class MealsView : ContentPage
    {
        public MealsView()
        {
            InitializeComponent();
        }

        private async void Breakfast_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecipeListView());
        }

        private void Snack_Clicked(object sender, EventArgs e)
        {

        }

        private void Lunch_Clicked(object sender, EventArgs e)
        {

        }

        private void Dinner_Clicked(object sender, EventArgs e)
        {

        }
    }
}