using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartNote.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard2 : TabbedPage
    {
        public Dashboard2()
        {
            InitializeComponent();

            // Set the "Home" page as startup page. Throws exception if more than 1 "Home" page is found
            this.CurrentPage = Children.Where(p => p.Title == "Home").SingleOrDefault();

            classList.ItemsSource = new string[]
            {
                "Calculus One",
                "Calculus Two",
                "English 151",
                "Engineering 230"
            };
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Classes.Globals.CurrentPage = Classes.Globals.LoginPage;
        }
    }
}
