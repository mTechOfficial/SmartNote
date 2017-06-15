/*
						  SignUpView.xaml.cs
						    Irteza Syed
						    06/15/2017
This is the corresponding C# code for the Sign Up Page.
Last Edited: Irteza Syed, 06/15/2017
*/
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
	public partial class SignUpView : ContentView
	{
		public SignUpView ()
		{
			InitializeComponent ();
            init();
		}

        private void init ()
        {
            // Positions
            Classes.Globals.setPosition(logo, 58, 81);
            Classes.Globals.setPosition(cancel, 15, 11);
            Classes.Globals.setPosition(signUpContainer, 26, 259.2f);
            Classes.Globals.setPosition(registerBtn, 26, 602);
            Classes.Globals.setPosition(toggleAgree, 26, 548);
            Classes.Globals.setPosition(agree, 65, 553);
            Classes.Globals.setPosition(terms, 137, 553);

            //Widths
            signUpContainer.WidthRequest = Classes.Globals.calcWidthMargin(324);
            registerBtn.WidthRequest = Classes.Globals.calcWidthMargin(324);
            username.WidthRequest = Classes.Globals.calcWidthMargin(324);
            password.WidthRequest = Classes.Globals.calcWidthMargin(324);
            confirmPassword.WidthRequest = Classes.Globals.calcWidthMargin(324);
        }

        private void terms_Tapped(object sender, EventArgs e)
        {

        }

        private void toggleAgree_Toggled(object sender, ToggledEventArgs e)
        {
            
        }

        private void cancel_Tapped(object sender, EventArgs e)
        {
            Classes.Globals.CurrentPage = Classes.Globals.LoginPage;
        }

        private void registerBtn_Clicked(object sender, EventArgs e)
        {
            Classes.Globals.CurrentPage = Classes.Globals.LoginPage;
        }
    }
}