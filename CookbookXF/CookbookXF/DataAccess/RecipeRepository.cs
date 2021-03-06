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
        private List<Recipe> _recipes = new List<Recipe>();
        private const string RecipeName = "recipe.json";

        public RecipeRepository()
        {
            LoadRecipes();
        }

        public void LoadRecipes()
        {
            var resourceNames = typeof(RecipeRepository).Assembly.GetManifestResourceNames();
            var stream = typeof(RecipeRepository).Assembly.GetManifestResourceStream($"{Constants.ResourcePrefix}{RecipeName}" );

            using (var reader = new StreamReader(stream))
            {
                var recipes = JsonConvert.DeserializeObject<RecipeList>(reader.ReadToEnd());
                _recipes = recipes.Recipe;
            }
             

            //var path = Path.Combine(FileSystem.AppDataDirectory, RecipeName);
            //if (!File.Exists(path))
            //{
            //    return;
            //}

            //var data = File.ReadAllText(path);
            //_recipes = JsonConvert.DeserializeObject<List<Recipe>>(data);
        }

        //public void AddRecipe(Recipe recipe)
        //{
        //    _recipe.Add(recipe);
        //    Save();
        //}

        //public void DeleteRecipe(string id)
        //{
        //    _recipe = _recipe.Where(n => n.Id != id).ToList();
        //    Save();
        //}

        private void Save()
        {
            File.WriteAllText(Path.Combine(FileSystem.AppDataDirectory, RecipeName), JsonConvert.SerializeObject(_recipes));
        }

        public IEnumerable<Recipe> GetAllRecipes()
        {
            return _recipes.ToList();
        }

        /// <summary>
        /// Dobijanje svih vrsta recepata:
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetRecipeTypes()
        {
            return _recipes.Select(recipe => {return recipe.Type; }).Distinct();
              
            //List<string> types = new List<string>();

            //foreach (var item in _recipe)
            //{
                
            //    if (!types.Contains(item.Type))
            //    {
            //        types.Add(item.Type);
            //    }
            //}
            //return types;
        }

        /// <summary>
        /// Dobijanje liste recepata koji pripadaju jednom tipu jela:
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public IEnumerable<Recipe> GetRecipeByType(string type)
        {
            if (!GetRecipeTypes().Contains(type))
            {
                return new List<Recipe>();
            }
            return _recipes.Where(recipe => recipe.Type == type).ToList();
        }

        
    }
}
