using System;
using System.Reflection;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms.StyleSheets;
using Xamarin.Forms.Xaml;

namespace Lab07
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            MainPage = new NavigationPage(new MainPage());
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
