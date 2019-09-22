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
    public partial class MultipleChoiceScreen : Form
    {
        // Declare variable _questionPosition and make it 0.
        int _questionPosition = 0;

        // Declare variable _a and make it 0.
        int _a = 0;

        // Create an array called q and populate it with the Multiple Choice Questions.
        string[] q = new string[] {"How many countries are in the European Union?", "Where is the head of the European Parliment?", 
                "How many stars are on the European Flag?", "What country is not in the EU?"};

        // Create an array calles answers and populate it with all of the possible answers for the Mutliple Choice Questions.
        string[] answers = new string[] {"26", "27", "28", "29", "Madrid", "London", "Paris", "Brussels", "9", "12", "15", "18",
                "Ireland", "France", "Serbia", "Portugal"};

        // Create an array called quizAnswers and populate it with the correct answer for each question.
        string[] quizAnswers = new string[] { "28", "Brussels", "12", "Serbia" };

        public MultipleChoiceScreen()
        {
            InitializeComponent();
            // Center the form to the middle of the screen.
            CenterToScreen();
            // Call the HideAvatars() method.
            HideAvatars();
        }

        private void MultipleChoiceScreen_Load(object sender, EventArgs e)
        {
            // Display the Avatar image that was selected in the Login Screen from the Player Class.
            picBoxAvatar.Image = LoginScreen.Player.avatarImage;
            // Display the Username of the user that was entered in the LoginScreen from the Player Class.
            lblDisplayUsername.Text = LoginScreen.Player._name;
            // Dislay the User's Score from the previous screen.
            lblDisplayScore.Text = ("Score: " + LoginScreen.Player._score.ToString());
            // Display the Time from the previous screen.
            lblDisplayTime.Text = ("Time: " + LoginScreen.Player._time);
  
            // Display the first Question in the q array.
            lblQuestion.Text = q[0];

            // Display the first answer in the answers array.
            btnAnswer1.Text = answers[0];
            // Display the second answer in the answers array.
            btnAnswer2.Text = answers[1];
            // Display the third answer in the answers array.
            btnAnswer3.Text = answers[2];
            // Display the fourth answer in the answers array.
            btnAnswer4.Text = answers[3];

            // Set the variable _a to 4.
            _a = 4;
        }

        private void HideAvatars()
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Display the current, incrementing time.
            lblDisplayTime.Text = ("Time: " + LoginScreen.Player._time);
        }

        private void btnanswer_Click(object sender, EventArgs e)
        {
            // When a button is pressed the respective answer will be sent...
            Button selectedButton = sender as Button;
            // The CheckAnswer() method will be called and the answer selected will be checked.
            CheckAnswer(selectedButton.Text);
        }

        private void CheckAnswer(string buttonText)
        {
            // If the button selected contains the answer that matches the correct answer in the quizAnswers array...
            if (buttonText == quizAnswers[_questionPosition])
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
        
        private void GoToNextQuestion()
        {
            // If there are still _questionPosition has not reached the end of the array length...
            if(_questionPosition < q.Length - 1)
            {
                // Increase the _questionPosition.
                _questionPosition++;

                // Display the next question in the q array.
                lblQuestion.Text = q[_questionPosition];

                // Display the appropiate first answer to the next question from the answers array.
                btnAnswer1.Text = answers[_a];
                // Increase _a.
                _a++;
                // Display the appropiate second answer to the next question from the answers array.
                btnAnswer2.Text = answers[_a];
                // Increase _a.
                _a++;
                // Display the appropiate third answer to the next question from the answers array.
                btnAnswer3.Text = answers[_a];
                // Increase _a.
                _a++;
                // Display the appropiate fourth answer to the next question from the answers array.
                btnAnswer4.Text = answers[_a];
                // Increase _a.
                _a++;
            }
            // Otherwise...
            else
            {
                // Call the GoToDragDropText() method.
                GoToDragDropText();
            }
        }
        
        private void GoToDragDropText()
        {
            // Create an instance of the DragDropText Screen.
            DragDropText dragDropText = new DragDropText();
            // Display the DragDropText Screen.
            dragDropText.Show();
            // Hide this Screen.
            this.Hide();
        }

        
    }       
}
 



