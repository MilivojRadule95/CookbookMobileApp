using CookbookXF.DataAccess;
using CookbookXF.Helpers;
using CookbookXF.Services;
using CookbookXF.View;
using CookbookXF.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookbookXF
{
    public partial class App : Application
    {
        private static IServiceProvider _serviceProvider;
        private static ViewModelLocator _viewLocator;

        public App()
        {
            InitializeComponent();
            SetupServices();
            TheTheme.SetTheme();

            MainPage = new NavigationPage(new MealsView { BindingContext = Locator.MealsViewModel });
            
           
            
        }

        internal static ViewModelLocator Locator
        {
            get
            {
                if (_viewLocator is null)
                {
                    _viewLocator = new ViewModelLocator(_serviceProvider);
                }

                return _viewLocator;
            }
        }

        protected override void OnStart()
        {
            OnResume();
        }

        protected override void OnSleep()
        {
            TheTheme.SetTheme();
            RequestedThemeChanged -= App_RequestedThemeChanged;
        }

        protected override void OnResume()
        {
            TheTheme.SetTheme();
            RequestedThemeChanged += App_RequestedThemeChanged;
        }

        private void App_RequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                TheTheme.SetTheme();
            });
        }

        private void SetupServices()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<MealsViewModel>();
            serviceCollection.AddTransient<RecipeListViewModel>();
            serviceCollection.AddTransient<RecipeDetailsViewModel>();
            serviceCollection.AddSingleton<IRecipeRepository, RecipeRepository>();
            serviceCollection.AddSingleton<INavigationService, NavigationService>();
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
