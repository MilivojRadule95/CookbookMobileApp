using CookbookXF.DataAccess;
using CookbookXF.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookbookXF.ViewModels
{
    internal class RecipeListViewModel : BaseViewModel
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly INavigationService _navigationService;
        public void LoadRecipeList()
        {
            var recipeListViewModel = new List<RecipeItemViewModel>();

           
        }
    }
}
