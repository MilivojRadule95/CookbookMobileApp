﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CookbookXF.Droid
{
    [Activity(Label = "SplashScreen", MainLauncher=true, Theme="@style/MyTheme.Splash", NoHistory =true)]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }

        protected override async void OnResume()
        {
            base.OnResume();
            await SimulateStartup();
        } 
        private async Task SimulateStartup()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
      
    }
}
