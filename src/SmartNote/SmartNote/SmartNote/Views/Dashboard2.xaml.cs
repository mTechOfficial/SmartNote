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

            listView.ItemsSource = new string[]
            {
                "Calculus One",
                "Calculus Two",
                "English 151",
                "Engineering 230"
            };
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
        }
    }
}
