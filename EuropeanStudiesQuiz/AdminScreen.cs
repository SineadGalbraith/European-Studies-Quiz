using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EuropeanStudiesQuiz
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
            // Center the form to the middle of the screen.
            CenterToScreen();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // Save the text in txtNewUsername into the variable userId.
            string userId = txtNewUsername.Text;
            
            // Create a foreach statement.
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    // If the textbox is empty...
                    TextBox txtBox = c as TextBox;
                    if(txtBox.Text == string.Empty)
                    {
                        // If the textbox is empty, display a message prompting the userto enter a name.
                        MessageBox.Show("You must enter a username.");
                        return;
                    }
                }
            }
            // Call the GetFileLocation() method from the File Location Manager class and save the returned information 
            // into the variable filePath.
            string filePath = FileLocationManager.GetFileLocation();

            // Create a try catch.
            try
            {
                // See if the file already exists and if it does, write the name to the file.
                FileStream aFile = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                // Create a new instance of the StreamWriter class and cll it sw. Pass aFile into this class.
                StreamWriter sw = new StreamWriter(aFile);
                // Write the userId to sw.
                sw.WriteLine(userId);
                // Close sw.
                sw.Close();
                // Close aFile.
                aFile.Close();
            }
            // If there is an error, catch the error.
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            // Show a message box telling the user that the name has been successfully added.
            MessageBox.Show("User Added Succesfully.");
            
            // Reset txtNewUsername to having no characters.
            txtNewUsername.Text = "";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            // Create an instance of the LoginScreen class.
            LoginScreen loginScreen = new LoginScreen();
            // Show the Login Screen.
            loginScreen.Show();
            // Hide this Screen.
            Hide();
        }
    }
}

