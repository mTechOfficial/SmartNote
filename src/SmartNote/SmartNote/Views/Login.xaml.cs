using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartNote.Views
{
	public partial class Login : ContentView
	{
		public Login ()
		{
			InitializeComponent ();
            
		}

        private void Login_Clicked(object sender, EventArgs e)
        {
            Classes.Globals.CurrentPage = Classes.Globals.Dashboard;
            Classes.Globals.CurrentUser = new Models.User();
        }
    }
}
