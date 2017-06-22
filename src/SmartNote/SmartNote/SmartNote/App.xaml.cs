using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SmartNote
{
    public partial class App : Application
    {
        public static Controllers.DatabaseManager DBManager { get; private set; }

        public App()
        {
            InitializeComponent();
            DBManager = new Controllers.DatabaseManager(new Controllers.RestService());
            MainPage = new SmartNote.MainPage();
            //FOR DEBUG ONLY
            //Classes.Globals.CurrentUser = new Models.User();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            init();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            Classes.Globals.CurrentPage = startUpPage();
        }
        private void init()
        {
            Classes.Globals.MainPage = (ContentPage)MainPage;
            Classes.Globals.Dashboard = new Views.Dashboard();
            Classes.Globals.LoginPage = new Views.Login();
            Classes.Globals.CurrentPage = startUpPage();
        }

        private ContentView startUpPage()
        {
            var result = Classes.Globals.LoginPage;

            if (Classes.Globals.CurrentUser != null)
                result = Classes.Globals.Dashboard;

            return result;
        }
    }
}
