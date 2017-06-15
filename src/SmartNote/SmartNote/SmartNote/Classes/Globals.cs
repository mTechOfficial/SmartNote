/*
						 Globals.cs
						  Zhi Qiu
						 04/10/2017
 Class object holding globally shared data.
 Revised by: Muhand Jumah
 Revised on: 4/14/2017
*/

using SmartNote.Models;
using Xamarin.Forms;

namespace SmartNote.Classes
{
    public class Globals
    {
        // static fields
        private static ContentView loginPage;
        private static ContentView registerPage;
        private static ContentView dashboard;
        private static ContentView publicClasses;
        private static ContentView privateClasses;
        private static ContentView groupStudy;
        private static ContentView settings;
        private static ContentView currentPage;
        private static ContentView profilePage;
        private static ContentPage mainPage;
        private static User currentUser;
        private static int screenWidth;
        private static int screenHeight;
        /// <summary>
        /// Why is the height 667 and width 375? why is it fixed?
        /// </summary>
        private static int designWidth = 375;
        private static int designHeight = 667;
        //private static readonly HTTPClient

        // public static properties
        public static ContentView Dashboard
        {
            get { return dashboard; }
            set { dashboard = value; }
        }
        public static ContentView PublicClasses
        {
            get { return publicClasses; }
            set { publicClasses = value; }
        }
        public static ContentView PrivateClasses
        {
            get { return privateClasses; }
            set { privateClasses = value; }
        }
        public static ContentView GroupStudy
        {
            get { return groupStudy; }
            set { groupStudy = value; }
        }
        public static ContentView Settings
        {
            get { return settings; }
            set { settings = value; }
        }
        public static ContentView CurrentPage
        {
            get { return currentPage; }
            set
            {
                currentPage = value;
                mainPage.Content = currentPage;
            }
        }
        public static ContentView ProfilePage
        {
            get { return profilePage; }
            set { profilePage = value; }
        }
        public static User CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        public static ContentView LoginPage
        {
            get { return loginPage; }
            set { loginPage = value; }
        }

        public static ContentView RegisterPage
        {
            get { return registerPage; }
            set { registerPage = value; }
        }

        public static ContentPage MainPage
        {
            get { return mainPage; }
            set { mainPage = value; }
        }
        public static int ScreenWidth
        {
            get { return screenWidth; }
            set { screenWidth = value; }
        }
        public static int ScreenHeight
        {
            get { return screenHeight; }
            set { screenHeight = value; }
        }

        public static int DesignWidth
        {
            get { return designWidth; }
        }
        public static int DesignHeight
        {
            get { return designHeight; }
        }

        public static void setPosition(View controller, float x, float y)
        {
            controller.Margin = new Thickness(calcWidthMargin(x),
                calcHeightMargin(y), 0, 0);
        }

        public static float calcWidthMargin(float x)
        {
            return (x / (float)designWidth * screenWidth);
        }

        public static float calcHeightMargin(float y)
        {
            return (y / (float)designHeight * screenHeight);
        }
    }
}
