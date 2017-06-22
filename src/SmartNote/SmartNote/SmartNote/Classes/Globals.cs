/*
						 Globals.cs
						  Zhi Qiu
						 04/10/2017
 Class object holding globally shared data.
 Revised by: Muhand Jumah
 Revised on: 4/14/2017, 6/17/2017
*/

using SmartNote.Models;
using Xamarin.Forms;

namespace SmartNote.Classes
{
    public class Globals
    {
        // static fields
        private static Page loginPage;
        private static ContentPage registerPage;
        private static ContentPage dashboard;
        private static ContentPage publicClasses;
        private static ContentPage privateClasses;
        private static ContentPage groupStudy;
        private static ContentPage settings;
        private static Page currentPage;
        private static ContentPage profilePage;
        private static Page mainPage;
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
        public static ContentPage Dashboard
        {
            get { return dashboard; }
            set { dashboard = value; }
        }
        public static ContentPage PublicClasses
        {
            get { return publicClasses; }
            set { publicClasses = value; }
        }
        public static ContentPage PrivateClasses
        {
            get { return privateClasses; }
            set { privateClasses = value; }
        }
        public static ContentPage GroupStudy
        {
            get { return groupStudy; }
            set { groupStudy = value; }
        }
        public static ContentPage Settings
        {
            get { return settings; }
            set { settings = value; }
        }
        public static Page CurrentPage
        {
            get { return currentPage; }
            set
            {
                currentPage = value;
                MainPage = currentPage;
            }
        }
        public static ContentPage ProfilePage
        {
            get { return profilePage; }
            set { profilePage = value; }
        }
        public static User CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        public static Page LoginPage
        {
            get { return loginPage; }
            set { loginPage = value; }
        }

        public static ContentPage RegisterPage
        {
            get { return registerPage; }
            set { registerPage = value; }
        }

        public static Page MainPage
        {
            get { return mainPage; }
            set
            {
                mainPage = value;
                Application.Current.MainPage = mainPage;
            }
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

        public static void setPosition(View controller, float x, float y, float width = 0.0f, float height = 0.0f)
        {
            controller.Margin = new Thickness(calcWidthMargin(x),
                calcHeightMargin(y), 0, 0);

            if(width != 0.0f)
                controller.WidthRequest = calcWidthMargin(width);
            if (height != 0.0f)
                controller.HeightRequest = calcHeightMargin(height);
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
