using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;




namespace Školní_Aplikace
{
 
    public partial class App : Application
    {
        List<Uzel> Uzly;
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Debug.WriteLine("ahoj");
            Uzly = new List<Uzel>();
            for (int i = 0; i < 10; i++)
            {
                Debug.WriteLine(i);
                Uzly.Add(new Uzel());
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        public void SetUpConnections()
        {
            Uzly[0].ConnectUzel(Uzly[2], 3);
            Uzly[0].jmeno = "Vstup";







        }
    }
}
