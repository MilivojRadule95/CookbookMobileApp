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
            //viewModel.LoadRecipe(type);
            Application.Current.MainPage.Navigation.PushModalAsync(new MealsView { BindingContext = viewModel });
        }

        public void GoBack()
        {
            Application.Current.MainPage.Navigation.PopModalAsync();

            var lastView = Application.Current.MainPage.Navigation.NavigationStack.Last();
            //if (lastView is MealsView mealsView
            //    && mealsView.BindingContext is MealsViewModel mealsViewModel)
            //{
            //    mealsViewModel.LoadRecipe("");
            //}
        }

        public void NavigateToRecipeList(string type)
        {
            var viewModel = App.Locator.RecipeListViewModel;
            viewModel.LoadRecipe(type);
            Application.Current.MainPage.Navigation.PushModalAsync(new RecipeListView { BindingContext = viewModel });
        }

        public void NavigateToRecipeDetails()
        {
            var viewModel = App.Locator.RecipeDetailsViewModel;
            
        }
    }
}
