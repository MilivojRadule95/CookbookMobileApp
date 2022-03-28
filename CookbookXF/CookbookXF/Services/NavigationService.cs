using CookbookXF.Models;
using CookbookXF.View;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CookbookXF.Services
{
    internal class NavigationService : INavigationService
    {
        public void GoBack()
        {
            throw new NotImplementedException();
        }

        public void NavigateToNewRecipeList()
        {
            throw new NotImplementedException();
        }

        public void NavigateToRecipeList(string type)
        {
            var viewModel = App.Locator.RecipeListViewModel;
            viewModel.LoadRecipe(type);
            Application.Current.MainPage.Navigation.PushModalAsync(new RecipeListView { BindingContext = viewModel });
        }
    }
}
