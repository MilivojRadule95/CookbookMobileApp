using CookbookXF.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Essentials;

namespace CookbookXF.DataAccess
{
    internal class RecipeRepository : IRecipeRepository
    {
        private List<Recipe> _recipe = new List<Recipe>();
        private const string RecipeName = "notes.txt";

        public void LoadRecipes()
        {
            var path = Path.Combine(FileSystem.AppDataDirectory, RecipeName);
            if (!File.Exists(path))
            {
                return;
            }

            var data = File.ReadAllText(path);
            _recipe = JsonConvert.DeserializeObject<List<Recipe>>(data);

            JsonConvert.DeserializeObject<RecipeList>("recipe.jsonContent");
        }

        public void AddRecipe(Recipe recipe)
        {
            _recipe.Add(recipe);
            Save();
        }

        public void DeleteRecipe(string id)
        {
            _recipe = _recipe.Where(n => n.Id != id).ToList();
            Save();
        }

        private void Save()
        {
            File.WriteAllText(Path.Combine(FileSystem.AppDataDirectory, RecipeName), JsonConvert.SerializeObject(_recipe));
        }

        public IEnumerable<Recipe> GetAllRecipes()
        {
            return _recipe.ToList();
        }
    }
}
