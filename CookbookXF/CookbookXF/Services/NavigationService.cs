using CookbookXF.Models;
using CookbookXF.View;
using CookbookXF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace CookbookXF.Services
{
    internal class NavigationService : INavigationService
    {
        public void NavigateToMealsView(string type)
        {
            var viewModel = App.Locator.MealsViewModel;
            viewModel.LoadAllCategoriesOfMeal();
            Application.Current.MainPage.Navigation.PushModalAsync(new MealsView { BindingContext = viewModel });
        }

        public void GoBack()
        {
            Application.Current.MainPage.Navigation.PopModalAsync();
        }

        public void NavigateToRecipeListView(string type)
        {
            var viewModel = App.Locator.RecipeListViewModel;
            viewModel.LoadRecipe(type);
            Application.Current.MainPage.Navigation.PushModalAsync(new RecipeListView { BindingContext = viewModel });
        }

        public void NavigateToRecipeDetailsView(Recipe recipe)
        {
            var viewModel = App.Locator.RecipeDetailsViewModel;
            viewModel.LoadDetails(recipe);
            Application.Current.MainPage.Navigation.PushModalAsync(new RecipeDetailsView { BindingContext = viewModel });
        }

        public void NavigateToSettingsView()
        {
            throw new NotImplementedException();
        }
    }
}
