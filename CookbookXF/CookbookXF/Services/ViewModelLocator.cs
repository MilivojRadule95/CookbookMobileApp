using CookbookXF.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CookbookXF.Services
{
    internal class ViewModelLocator
    {
        private readonly IServiceProvider _serviceProvider;

        public ViewModelLocator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public RecipeListViewModel RecipeListViewModel => _serviceProvider.GetService<RecipeListViewModel>();
        public MealsViewModel MealsViewModel => _serviceProvider.GetService<MealsViewModel>();
        public RecipeDetailsViewModel RecipeDetailsViewModel => _serviceProvider.GetService<RecipeDetailsViewModel>();
        public SettingsViewModel SettingsViewModel => _serviceProvider.GetService<SettingsViewModel>();

    }
}
