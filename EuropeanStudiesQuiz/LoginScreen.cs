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
using EuropeanStudiesQuiz.Properties;

namespace EuropeanStudiesQuiz
{
    public partial class LoginScreen : Form
    {
        // Create a variable called filePath and store the usernames from the text file into it.
        string filePath = FileLocationManager.GetFileLocation();
        // Create a new string array called users.
        string[] users;

        // Create a static instance of the Player Class.
        public static Player Player = new Player();
        
        public LoginScreen()
        {
            InitializeComponent();
            // Enable CenterToScreen so that the game screen will be easy and clear to see.
            CenterToScreen();
            // Allow a drop in picBoxAvatar.
            picBoxAvatar.AllowDrop = true;
            // Ensure the Admin button is invisible.
            btnAdmin.Visible = false;

            // Create a variable called bestTime and store the information returned from the method BestTime() into it.
            double bestTime = BestTime();

            // Create an if statement.
            if (bestTime == 0)
            {
                // If there are no recorded times in the table, do not show the BestTime label.
                lblBestTime.Visible = false;
            }
            // Otherwise...
            else
            {
                // Show the BestTime label.
                lblBestTime.Visible = true;
                // Display a message showing the best time.
                lblBestTime.Text = "The Best Time is: " + BestTime() + " seconds.";
            }

            // Create an if statement.
            if (File.Exists(filePath))
            {
                // If the filePath file exists, read this information into the users array.
                users = File.ReadLines(filePath).ToArray();
            }
            // Otherwise...
            else
            {
                // Create a new instance of the FileStream class called aFile, where a new file will be created.
                FileStream aFile = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                // Create a new instance of the StreamWriter class and called it sw. Pass the newly create aFile.
                StreamWriter sw = new StreamWriter(aFile);
                // Close sw.
                sw.Close();
                // Close aFile.
                aFile.Close();
            }


        }
        
        private void LoginScreen_Load(object sender, EventArgs e)
        {
            // Allow a drop in picBoxAvatar.
            picBoxAvatar.AllowDrop = true;
        }

        private double BestTime()
        {
            // Create a new variable called lowestTime and set it to 0.
            double lowestTime = 0;
            // Create an if statment.
            if (File.Exists(FileLocationManager.GetFileName()))
            {
                // If the file from the variable filePath exists, make a new list and call it timeArray.
                List<double> timeArray = new List<double>();
                // Make an instance of the BinaryReader class, open the File class, go to method GetFileName() in File Location Manager, open the FileMode.
                using (BinaryReader b = new BinaryReader(File.Open(FileLocationManager.GetFileName(), FileMode.Open)))
                {
                    // Create a new variable called pos and set it to 0;
                    double pos = 0;
                    
                    // Create a new variable called length and using the instance of the BinaryReader class, open the BaseStream and get the .Length property. 
                    // Cast this so it is a double.
                    double length = (double)b.BaseStream.Length;
                    // While pos is less than length...
                    while (pos < length)
                    {
                        // Create a new variable called v and using the instance of the BinaryReader class, open the method ReadDouble().
                        double v = b.ReadDouble();
                        // Add the time to the array.
                        timeArray.Add(v);

                        // 
                        pos += sizeof(double);
                    }
                }

                // Save the minimum time in the timeArray array under the variable lowestTime.
                lowestTime = timeArray.Min();
            }
            // Return the variable lowestTime.
            return lowestTime;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Admin Screen and call it adminScreen.
            AdminScreen adminScreen = new AdminScreen();
            // Show the Admin Screen.
            adminScreen.Show();
            // Hide this screen.
            this.Hide();
        }
        
       private void btnLogin_Click(object sender, EventArgs e)
        {
            // Create a new instance of the DragDropPicture class and call it dragDropPicture.
            DragDropPicture dragDropPicture = new DragDropPicture();

            // Create a variable called userValid and make it false.
            bool userValid = false;

            // Create a for loop.
            for (int i = 0; i < users.Length; i++)
            {
                // Create an if statement.
                if (txtEnterUsername.Text == users[i])
                {
                    // If the text in the text box matched a name in the array. change the userValid variable to true.
                    userValid = true;
                }
            }

            // If userValid is true...
            if (userValid)
            {
                // Create an if statement...
                if (lblDragAvatar.Text != "Please drag the avatar you wish to use into this box.")
                {
                    // If the text in the DragAvatar label is not equal to "Please drag the avatar you wish to use into this box"
                    if (lblDragAvatar.Text == "                           You are the Leprechaun!                ")
                    {
                        // Make the text in the DragAvatar label "                           You are the Leprechaun!                " and 
                        // change the avatarImage in the Player class to the LeprechaunAvatar.
                        Player.avatarImage = Resources.LeprechaunAvatar;
                    }
                    // Otherwise...
                    else if (lblDragAvatar.Text == "                                 You are Jean-Luc!                ")
                    {
                        // Make the text in the DragAvatar label "                                 You are Jean-Luc!                " and 
                        // change the avatarImage in the Player class to the FrenchPersonAvatar.
                        Player.avatarImage = Resources.FrenchPersonAvatar;
                    }
                    else if (lblDragAvatar.Text == "                                    You are Lucia!                  ")
                    {
                        // Make the text in the DragAvatar label "                                    You are Lucia!                  " and 
                        // change the avatarImage in the Player class to the SpanishDancerAvatar.
                        Player.avatarImage = Resources.SpanishDancerAvatar;
                    }

                    // Create an if statement.
                    if (txtEnterUsername.Text != "" && txtEnterUsername.Text != "admin")
                    {
                        // If there is no text in the textbox or the text is not "admin", save the text in txtEnterUsername to the variable _name in the Player Class.
                        Player._name = txtEnterUsername.Text;
                    }

                    // Show the Drag and Drop Picture Screen.
                    dragDropPicture.Show();
                    // Hide this screen.
                    Hide();
                }
                else
                {
                    // If an avatar has not been selected, display the message below. 
                    MessageBox.Show("Please select an avatar", "Avatar not selected");
                }
            }
            else
            {
                // If userValid is false, display the message below.
                MessageBox.Show("User is not a valid user", "Invalid User");
            }
        }

        private void picBoxLeprechaun_MouseDown(object sender, MouseEventArgs e)
        {
            // Allow the Leprechaun image to be dragged.
            picBoxLeprechaun.DoDragDrop(picBoxLeprechaun.Image, DragDropEffects.Copy);
            // Change the text in lblDragAvatar to the text below.
            lblDragAvatar.Text = ("                           You are the Leprechaun!                ");
        }

        private void picBoxJeanLuc_MouseDown(object sender, MouseEventArgs e)
        {
            // Allow the Jean-Luc image to be dragged.
            picBoxJeanLuc.DoDragDrop(picBoxJeanLuc.Image, DragDropEffects.Copy);
            // Change the text in lblDragAvatar to the text below.
            lblDragAvatar.Text = ("                                 You are Jean-Luc!                ");
        }

        private void picBoxLucia_MouseDown(object sender, MouseEventArgs e)
        {
            // Allow the Sophia image to be dragged.
            picBoxLucia.DoDragDrop(picBoxLucia.Image, DragDropEffects.Copy);
            // Change the text in lblDragAvatar to the text below.
            lblDragAvatar.Text = ("                                    You are Lucia!                  ");
        }

        private void picBoxAvatar_DragEnter(object sender, DragEventArgs e)
        {
            // Allow picBoxAvatar to be dragged into.
            e.Effect = DragDropEffects.Copy;
        }

        private void picBoxAvatar_DragDrop(object sender, DragEventArgs e)
        {
            // Copy the image dragged into the textbox and make it the image in the textbox.
            picBoxAvatar.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void txtEnterUsername_TextChanged(object sender, EventArgs e)
        {
            // Create an if statement.
            if (txtEnterUsername.Text.ToLower() == "admin")
            {
                // If the text in the textbox is "admin", make the Admin button true.
                btnAdmin.Visible = true;
            }
            // Otherwise...
            else
            {
                // Keep the admin button false.
                btnAdmin.Visible = false;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Help Screen.
            HelpScreen helpScreen = new HelpScreen();
            // Show the Help Screen.
            helpScreen.Show();
            // Hide this screen.
            Hide();
        }

        

        

        
    }
}
