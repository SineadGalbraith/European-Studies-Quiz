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
using System.Media;

namespace EuropeanStudiesQuiz
{
    public partial class EndScreen : Form
    {
        public EndScreen()
        {
            InitializeComponent();
            // Center the form to the middle of the screen.
            CenterToScreen();
            // Call the HideAvatars() method.
            HideAvatars();
            // Call the Result() method.
            Result();
        }

        // Save the Username that was entered in the LoginScreen to the variable user.
        string user = LoginScreen.Player._name;
        // Save the most recent score that was achieved in the last screen to the variable scoreTotal.
        int scoreTotal = LoginScreen.Player._score;
        // Save the most recent time that was achieved in the last screen to the variable finalTime.
        double finalTime = LoginScreen.Player._time;
        
        private void Result()
        {
            // If the user has scored 20...
            if(scoreTotal == 20)
            {
                // Display a message congratulating them.
                lblMessage.Text = string.Format("Excellent! You got full marks, {0}!", user);
                // Call the SaveTime() method.
                SaveTime();
                // Call the ScoreTableData() method and pass the user and finalTime parameters to it.
                ScoreTableData(user, finalTime);
                // Call the ShowResults() method.
                ShowResults();
            }
            // Otherwise...
            else
            {
                // Display a message commiserating the user.
                lblMessage.Text = string.Format("Hard Luck! You didn't get full marks, {0}!", user);
                // Call the ShowResults() method.
                ShowResults();
            }
        }
        
        private void EndScreen_Load(object sender, EventArgs e)
        {
            // Display the Avatar image that was selected in the Login Screen from the Player Class.
            picBoxAvatar.Image = LoginScreen.Player.avatarImage;
            // Display the Username of the user that was entered in the LoginScreen from the Player Class.
            lblDisplayUsername.Text = LoginScreen.Player._name;
            // Display the Score as 0 to start.
            lblDisplayScore.Text = ("Score: " + LoginScreen.Player._score.ToString());
            // Display the Time Clock as 0 to start.
            lblDisplayTime.Text = ("Time: " + LoginScreen.Player._time);
        }
        
        private void HideAvatars()
        {
            
        }

        private void SaveTime()
        {
            // Save the information from this file as the variable fileName.
            string fileName = FileLocationManager.GetFileName();

            // If fileName exists...
            if(File.Exists(fileName))
            {
                // Create a new instance of the FileStream class and call it fs. Add to the existing file.
                FileStream fs = new FileStream(fileName, FileMode.Append);
                // Create a new instance of the BinaryWriter class and call it w. Pass fs into this class.
                BinaryWriter w = new BinaryWriter(fs);
                // Write the finalTime to w.
                w.Write(finalTime);
                // Close w.
                w.Close();
                // Close fs.
                fs.Close();
            }
            // Otherwise...
            else
            {
                // Create a new instance of the FileStream class and called it fs. Crate a new file.
                FileStream fs = new FileStream(fileName, FileMode.Create);
                // Create a new instance of the BinaryWriter class and call it w. Pass fs into this class.
                BinaryWriter w = new BinaryWriter(fs);
                // Close w.
                w.Close();
                // Close fs.
                fs.Close();
            }
        }

        private void ScoreTableData(string Player, double time)
        {
            // Save the Player and time under the variable userAndTime.
            string userAndTime = Player + "-" + time;

            // Save the information from this file as the variable filePath.
            string filePath = FileLocationManager.GetFileTime();

            // If filePath does not exist...
            if (!File.Exists(filePath))
            {
                // Create a new instance of the FileStream class and call it aFile. Create a new file.
                FileStream aFile = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                // Create a new instance of the StreamWriter class and call it sw. Pass aFile into this class.
                StreamWriter sw = new StreamWriter(aFile);
                // Write the userAndTime to sw.
                sw.WriteLine(userAndTime);
                // Close sw.
                sw.Close();
                // Close aFile.
                aFile.Close();
            }
            // Otherwise...
            else
            {
                // Create a new instance of the FileStream class and call it aFile. Add to the existing file.
                FileStream aFile = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                // Create a new instance of the StreamWriter class and call it sw. Pass aFile into this class.
                StreamWriter sw = new StreamWriter(aFile);
                // Write the userAndTime to sw.
                sw.WriteLine(userAndTime);
                // Close sw.
                sw.Close();
                // Close aFile.
                aFile.Close();
            }
        }

        private void ShowResults()
        {
            // Create a new List call it column and populate it with the information below.
            List<string> column = new List<string>() { "Name", "Time (sec)" };
            // Create a new List and call it Row. 
            List<string[]> Row = new List<string[]>();

            // Create a new two-dimensional string array and call it timeArray.
            string[,] timeArray;
            // Create a new string array and call it users. 
            string[] users = new string[0];

            // If this file exists...
            if (File.Exists(FileLocationManager.GetFileTime()))
            {
               // Pass the information from this file into users.
               users = File.ReadLines(FileLocationManager.GetFileTime()).ToArray();
            }

            // Add the information from the users array.
            timeArray = new string[users.Length, 2];

            // Create a for loop.
            for (int i = 0; i < users.Length; i++)
            {
                // For every piece of information from the users array, split the name and time using a '-'.
                string[] userNameAndTime = users[i].Split('-');

                // Assign the appropiate information to the appropiate place in the table.
                timeArray[i, 0] = userNameAndTime[0];
                timeArray[i, 1] = userNameAndTime[1];
            }

            // Create another for loop.
            for (int i = 0; i < users.Length; i++)
            {
                // Add a new row. Create a new array and display the information that was split above.
                Row.Add(new string[] { timeArray[i, 0], timeArray[i, 1].ToString() });
            }

            // Create a new instance of the DataTable class and call it table.
            DataTable table = new DataTable();

            // Create a foreach statement.
            foreach (string text in column)
            {
                // Add the text into the column.
                table.Columns.Add(text);
            }

            // Create another foreach statement.
            foreach (string[] cell in Row)
            {
                // Add the cell into the row.
                table.Rows.Add(cell);
            }

            // Show the dataScoreTable.
            dataScoreTable.DataSource = table.AsDataView();
            dataScoreTable.Sort(dataScoreTable.Columns["Time (sec)"], ListSortDirection.Ascending);
        }

        private void dataScoreTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            // Set the score to 0.
            LoginScreen.Player._score = 0;
            // Create a new instance of the LoginScreen class and call it loginScreen.
            LoginScreen loginScreen = new LoginScreen();
            // Show the LoginScreen.
            loginScreen.Show();
            // Hide this screen.
            Hide();
        }

        

    }
}
