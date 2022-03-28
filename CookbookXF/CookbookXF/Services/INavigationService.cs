using CookbookXF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookbookXF.Services
{
    internal interface INavigationService
    {
        void NavigateToRecipeList(string type);

        void NavigateToNewRecipeList();

        void GoBack();

    }
}
