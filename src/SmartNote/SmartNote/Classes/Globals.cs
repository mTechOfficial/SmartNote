/*
						 Globals.cs
						  Zhi Qiu
						 04/10/2017
 Class object holding globally shared data.
*/
using Xamarin.Forms;
using SmartNote.Models;

namespace SmartNote.Classes
{
    class Globals
    {
        // static fields
        private static ContentView dashboard;
        private static ContentView publicClasses;
        private static ContentView privateClasses;
        private static ContentView groupStudy;
        private static ContentView settings;
        private static ContentView currentPage;
        private static ContentView profilePage;
        private static User currentUser;

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
            set { currentPage = value; }
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
    }
}
