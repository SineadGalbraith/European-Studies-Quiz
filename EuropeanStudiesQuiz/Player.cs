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
    public class Player
    {
        // Create a new Bitmap variable and call it avatarImage.
        public Bitmap avatarImage;
        // Create a new int variable and call it _score.
        public int _score;
        // Create a new double variable and call it _time.
        public double _time;
        // Create a new string variable and call it _name.
        public string _name;
        // Create a new double variable and call it _totalTime.
        public double _totalTime;

        // Make a new, private, instance of the Timer class and call it _timer.
        private Timer _timer = new Timer();

        public Player()
        {
            // Set the score to 0.
            _score = 0;
            // Set the time to 0.
            _time = 0;
        }

        public int GetScore()
        {
            // Return the score.
            return _score;
        }

        public void IncreaseScore()
        {
            // Increment the score by 1.
            _score++;
        }

        public double GetTime()
        {
            // Return the time.
            return _time;
        }

        public void IncreaseTime()
        {
            // Increment the time by 1.
            _time++;
        }

        public void Time()
        {
            // Save the time into the _totalTime varibale.
            _totalTime = _time;
        }

        public double TotalTime()
        {
            // Return the _totalTime.
            return _totalTime;
        }

        public void ResetPlayer()
        {
            // Remove the name.
            _name = "";
            // Reset the score to 0.
            _score = 0;
        }
    }
}
