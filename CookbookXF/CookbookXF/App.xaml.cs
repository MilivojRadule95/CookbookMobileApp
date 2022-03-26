using CookbookXF.Services;
using CookbookXF.View;
using System;
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
            
            MainPage = new NavigationPage(new MealsView());
            MainPage = new NavigationPage(new RecipeListView { BindingContext = Locator.RecipeListViewModel });
            
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
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
