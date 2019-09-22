using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuropeanStudiesQuiz
{
    public partial class HelpScreen : Form
    {
        public HelpScreen()
        {
            InitializeComponent();
            // Center the form to the middle of the screen.
            CenterToScreen();
        }

        private void btnHelpBack_Click(object sender, EventArgs e)
        {
            // Create a new instance of the LoginScreen class.
            LoginScreen loginScreen = new LoginScreen();
            // Show the Login Screen.
            loginScreen.Show();
            // Hide this screen.
            Hide();
        }
    }
}
