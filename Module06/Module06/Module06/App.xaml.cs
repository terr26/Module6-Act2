﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module06
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.ShowEmployeePage());
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
