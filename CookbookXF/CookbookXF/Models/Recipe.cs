using System;
using System.Collections.Generic;
using System.Text;

namespace CookbookXF.Models
{
    internal class Recipe
    {
        public string Meal { get; }

        public string RecipeName { get; }

        public string Description { get; }

        public Guid RecipeId { get; }

        public Recipe(string recipeName, string description, Guid recipeId)
        {
            RecipeName = recipeName;
            Description = description;

            if (string.IsNullOrEmpty(recipeName))
            {
                throw new InvalidOperationException("Recipe title can't be empty!");
            }

            if (string.IsNullOrEmpty(description))
            {
                throw new InvalidOperationException(nameof(description));
            }
        }
    }
}
