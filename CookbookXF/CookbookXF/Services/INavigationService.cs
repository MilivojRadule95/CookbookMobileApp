using CookbookXF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookbookXF.Services
{
    internal interface INavigationService
    {
        void NavigateToRecipeList(IEnumerable<Recipe> recipes);

        void NavigateToNewRecipeList();

        void GoBack();

    }
}
