using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Školní_Aplikace
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            List<Uzel> List_Pointeru_Bodu = new List<Uzel>();
            Uzel Graph_Bod_1 = new Uzel();
            List_Pointeru_Bodu.Add(Graph_Bod_1);
            System.Console.Write("AAAA");

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
