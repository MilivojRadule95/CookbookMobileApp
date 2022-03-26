using CookbookXF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookbookXF.ViewModels
{
    internal class RecipeItemViewModel : BaseViewModel
    {
        public RecipeItemViewModel(Recipe recipe)
        {
            Recipe = recipe;
        }

        public Recipe Recipe { get; }
    }
}
