using CookbookXF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookbookXF.DataAccess
{
    internal interface IRecipeRepository
    {
        //void AddRecipe(Recipe recipe);

        //void DeleteRecipe(string id);

        IEnumerable<Recipe> GetAllRecipes();

        IEnumerable<string> GetRecipeTypes();

        IEnumerable<Recipe> GetRecipeByType(string type);
    }
}
