using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            init();
        }

        private void init()
        {
            //Positioning
            setPosition(logo, 0.1546666666666667f, 0.1214392803598201f);
            setPosition(username, 0.1786666666666667f, 0.3463268365817091f);
            setPosition(password, 0.1786666666666667f, 0.5007496251874063f);
            setPosition(loginBtn, 0.0693333333333333f, 0.7406296851574213f);
            setPosition(registerBtn, 0.0693333333333333f, 0.8275862068965517f);
            setPosition(copyright, 0.6266666666666667f, 0.9730134932533733f);

            

            //Height
            //setSize(loginBtn, 49, 324);
            //setSize(registerBtn, 49, 324);
            //setSize(username, 43, 243);
            //setSize(password, 43, 243);
            loginBtn.WidthRequest = calculateMargin(0.864f, Classes.Globals.ScreenWidth);
            //loginBtn.HeightRequest = calculateMargin(0.0734632683658171f, Classes.Globals.ScreenHeight);
            registerBtn.WidthRequest = calculateMargin(0.864f, Classes.Globals.ScreenWidth);
            username.WidthRequest = calculateMargin(0.648f, Classes.Globals.ScreenWidth);
            password.WidthRequest = calculateMargin(0.648f, Classes.Globals.ScreenWidth);
            //registerBtn.HeightRequest = calculateMargin(0.0734632683658171f, Classes.Globals.ScreenHeight);

        }
        private void setPosition(View controller, float x, float y)
        {
            controller.Margin = new Thickness(calculateMargin(x, Classes.Globals.ScreenWidth),
                calculateMargin(y, Classes.Globals.ScreenHeight), 0, 0);
        }
        private void setSize(View controller, float height, float width)
        {
            controller.HeightRequest = (height / 667) * Classes.Globals.ScreenHeight;
            controller.WidthRequest = (width / 375) * Classes.Globals.ScreenWidth;
            //controller.Margin = new Thickness(calculateMargin(x, Classes.Globals.ScreenWidth),
            //    calculateMargin(y, Classes.Globals.ScreenHeight), 0, 0);
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            Classes.Globals.CurrentPage = Classes.Globals.Dashboard;
            //Classes.Globals.CurrentUser = new Models.User();
        }

        private float calculateMargin(float percent, float full)
        {
            return (percent * full);
        }

        private void field_Focused(object sender, FocusEventArgs e)
        {
            Entry ent = (Entry)sender;
            ent.WidthRequest = calculateMargin(0.864f, Classes.Globals.ScreenWidth);
            setPosition(ent, 0.0693333333333333f, (float)ent.Y/Classes.Globals.ScreenHeight);
        }

        private void field_Unfocused(object sender, FocusEventArgs e)
        {
            Entry ent = (Entry)sender;
            ent.WidthRequest = calculateMargin(0.648f, Classes.Globals.ScreenWidth);
            setPosition(ent, 0.1786666666666667f, (float)ent.Y/Classes.Globals.ScreenHeight);
        }
    }
}
