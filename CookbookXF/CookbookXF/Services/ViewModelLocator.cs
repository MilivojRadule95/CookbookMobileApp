using CookbookXF.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookbookXF.Services
{
    internal class ViewModelLocator
    {
        public RecipeListViewModel RecipeListViewModel => _serviceProvider.GetService<RecipeListViewModel>();

        private readonly IServiceProvider _serviceProvider;

        public ViewModelLocator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public MealsViewModel MealsViewModel => _serviceProvider.GetService<MealsViewModel>();
        public RecipeDetailsViewModel RecipeDetailsViewModel => _serviceProvider.GetService<RecipeDetailsViewModel>();



       

    }
}
