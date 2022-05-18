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
        List<Uzel> List_Pointeru_Bodu;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Debug.WriteLine("ahoj");
            List_Pointeru_Bodu = new List<Uzel>();
            for (int i = 0; i < 10; i++)
            {
                Uzel Graph_Bod_1 = new Uzel();
                Debug.WriteLine(i);
                List_Pointeru_Bodu.Add(Graph_Bod_1);
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        public void Connections()
        {
            List_Pointeru_Bodu[1].Connection(List_Pointeru_Bodu[2], 3);







        }
    }
}
