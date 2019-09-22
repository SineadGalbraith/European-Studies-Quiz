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
    public partial class TrueOrFalseScreen : Form
    {
        // Declare the variable _questPosition and set it to 0.
        int _questPosition = 0;
        // Declare the variable _b and set it to 0;
        int _b = 0;

        // Create an array containing the True or False statements and call the array questions.
        string[] questions = new string[] {"Europe Day is celebrated on 9th May?", 
            "Every six months, a different member state becomes president of \nthe Council of the European Union?", 
            "19 member states of the EU use the Euro?"};

        // Create an array containing the two possible answers to the statements and call the array answers.
        string[] answers = new string[] {"True", "False"};

        // Create an array containting the correct answer for each statement and call the array quizAns.
        string[] quizAns = new string[] { "True", "True", "True"};

        public TrueOrFalseScreen()
        {
            InitializeComponent();
            // Center the form to the middle of the Screen.
            CenterToScreen();
            // Call the HideAvatars() method.
            HideAvatars();
        }

        private void TrueOrFalseScreen_Load(object sender, EventArgs e)
        {
            // Display the Avatar image that was selected in the Login Screen from the Player Class.
            picBoxAvatar.Image = LoginScreen.Player.avatarImage;
            // Display the Username of the user that was entered in the LoginScreen from the Player Class.
            lblDisplayUsername.Text = LoginScreen.Player._name;
            // Dislay the User's Score from the previous screen.
            lblDisplayScore.Text = ("Score: " + LoginScreen.Player._score.ToString());
            // Display the Time from the previous screen.
            lblDisplayTime.Text = ("Time: " + LoginScreen.Player._time);

            // Display the first Question in the questions array.
            lblQuestion.Text = questions[0];

            // Display the first answer in the answers array.
            radioBtnTrue.Text = answers[0];
            // Display the second answer in the answers array.
            radioBtnFalse.Text = answers[1];

            // Set the _b variable to 3.
            _b = 3;
        }

        private void HideAvatars()
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Display the current, incrementing time.
            lblDisplayTime.Text = ("Time: " + LoginScreen.Player._time);
        }

        private void GoToNextQuestion()
        {
            // If there are still _questPosition has not reached the end of the array length...
            if (_questPosition < questions.Length - 1)
            {
                // Set both radio buttons so that they are not checked.
                radioBtnTrue.Checked = false;
                radioBtnFalse.Checked = false;
                
                // Increase the _questPosition.
                _questPosition++;

                // Display the next question in the questions array.
                lblQuestion.Text = questions[_questPosition];

                // Set the radioBtnTrue to display True.
                radioBtnTrue.Text = answers[0];
                // Set the radioBtnFalse to display False.
                radioBtnFalse.Text = answers[1];
            }
            // Otherwise...
            else
            {
                // Call the GoToEndScreen() method.
                GoToEndScreen();
            }
        }

        private void GoToEndScreen()
        {
            // Create an instance of the End Screen.
            EndScreen endScreen = new EndScreen();
            // Display the End Screen.
            endScreen.Show();
            // Hide this screen.
            Hide();
        }

        private void RightAnswer()
        {
            // Show a message box displaying a correct message.
            MessageBox.Show("Correct!");
            // Increase the score in the Player Class.
            LoginScreen.Player.IncreaseScore();
            // Call the score from the Player Class.
            LoginScreen.Player.GetScore();
            // Display the score from the Player Class.
            lblDisplayScore.Text = ("Score: " + LoginScreen.Player.GetScore());
            // Call the NextQuestion() method.
            GoToNextQuestion();
        }

        private void WrongAnswer()
        {
            // Show a message box diaplaying an incorrect message.
            MessageBox.Show("Incorrect.");
            // Call the NextQuestion() method.
            GoToNextQuestion();
        }

        private void radioBtnTrue_Click(object sender, EventArgs e)
        {
            // If the text in the radio button is equal to the text of the current correct answer...
            if (radioBtnTrue.Text == quizAns[_questPosition])
            {
                // Call the RightAnswer() method.
                RightAnswer();
            }
            // Otherwise...
            else
            {
                // Call the WrongAnswer() method.
                WrongAnswer();
            }
        }

        private void radioBtnFalse_Click(object sender, EventArgs e)
        {
            // If the text in the radio button is equal to the text of the current corrent answer...
            if (radioBtnFalse.Text == quizAns[_questPosition])
            {
                // Call the RightAnswer() method.
                RightAnswer();
            }
            // Otherwise...
            else
            {
                // Call the WrongAnswer() method.
                WrongAnswer();
            }
        }

        
    }
}
