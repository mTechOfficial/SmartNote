using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SmartNote.Views
{
    public partial class Login2 : ContentView
    {
        public Login2()
        {
            InitializeComponent();
            init();
            Controllers.MySQLController.CreateAccount("emailtest", "passwordtest");
        }

        /// <summary>
        /// This method will initialize the position and size for each controller in the xaml file.
        /// </summary>
        private void init()
        {
            //Position
            setPosition(logo, 0.1546666666666667f, 0.1214392803598201f);
            setPosition(loginContainer, 0.0693333333333333f, 0.3189505247376312f);
            setPosition(mtechLoginBtn, 0.0693333333333333f, 0.5007496251874063f);
            setPosition(leftLine, 0.0706666666666667f, 0.6409295352323838f);
            setPosition(rightLine, 0.556f, 0.6409295352323838f);
            setPosition(orLabel, 0.464f, 0.6206896551724138f);
            //setPosition(facebookBtn, 0.0693333333333333f, 0.7136431784107946f);
            setPosition(facebookIcon, 0.0693333333333333f, 0.7136431784107946f);
            setPosition(facebookLoginBtn, 0.224f, 0.7136431784107946f);
            setPosition(gmailIcon, 0.0693333333333333f, 0.7961019490254873f);
            setPosition(gmailLoginBtn, 0.224f, 0.7961019490254873f);
            setPosition(fpassword, 0.0693333333333333f, 0.8875562218890555f);
            setPosition(newHere, 0.5866666666666667f, 0.8875562218890555f);
            setPosition(signup, 0.784f, 0.8875562218890555f);
            setPosition(copyright, 0.6266666666666667f, 0.9730134932533733f);

            //Width
            loginContainer.WidthRequest = calculateMargin(0.864f, Classes.Globals.ScreenWidth);
            username.WidthRequest = calculateMargin(0.864f, Classes.Globals.ScreenWidth);
            password.WidthRequest = calculateMargin(0.864f, Classes.Globals.ScreenWidth);
            mtechLoginBtn.WidthRequest = calculateMargin(0.864f, Classes.Globals.ScreenWidth);
            leftLine.WidthRequest = calculateMargin(0.3786666666666667f, Classes.Globals.ScreenWidth);
            rightLine.WidthRequest = calculateMargin(0.3786666666666667f, Classes.Globals.ScreenWidth);
            //facebookBtn.WidthRequest = calculateMargin(0.864f, Classes.Globals.ScreenWidth);
            facebookIcon.WidthRequest = calculateMargin(0.1546666666666667f, Classes.Globals.ScreenWidth);
            facebookLoginBtn.WidthRequest = calculateMargin(0.7093333333333333f, Classes.Globals.ScreenWidth);
            //facebookIcon.HeightRequest = calculateMargin(0.0869565217391304f, Classes.Globals.ScreenHeight);
            //facebookLoginBtn.HeightRequest = calculateMargin(0.0869565217391304f, Classes.Globals.ScreenHeight);
            gmailIcon.WidthRequest = calculateMargin(0.1546666666666667f, Classes.Globals.ScreenWidth);
            gmailLoginBtn.WidthRequest = calculateMargin(0.7093333333333333f, Classes.Globals.ScreenWidth);
            //gmailIcon.HeightRequest = calculateMargin(0.0869565217391304f, Classes.Globals.ScreenHeight);
            //gmailLoginBtn.HeightRequest = calculateMargin(0.0869565217391304f, Classes.Globals.ScreenHeight);

        }

        /// <summary>
        /// This method sets the position for a controller based on x,y retrieved from Adobe XD
        /// </summary>
        /// <param name="controller">Change the position of this controller</param>
        /// <param name="x">The x position in percentage</param>
        /// <param name="y">The y position in percentage</param>
        private void setPosition(View controller, float x, float y)
        {
            controller.Margin = new Thickness(calculateMargin(x, Classes.Globals.ScreenWidth),
                calculateMargin(y, Classes.Globals.ScreenHeight), 0, 0);
        }

        /// <summary>
        /// Calculate margin of a specific device based on it's percentage and the device width/height
        /// </summary>
        /// <param name="percent"></param>
        /// <param name="full"></param>
        /// <returns></returns>
        private float calculateMargin(float percent, float full)
        {
            return (percent * full);
        }

        private void gmailLoginBtn_Clicked(object sender, EventArgs e)
        {
            //Classes.Globals.CurrentPage = new Views.Login();
        }
    }
}
