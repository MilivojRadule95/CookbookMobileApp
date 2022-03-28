using CookbookXF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookbookXF.Services
{
    internal interface INavigationService
    {
        void NavigateToMealsView(string type);
        void NavigateToRecipeList(string type);
        void GoBack();

    }
}
