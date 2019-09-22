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
using EuropeanStudiesQuiz.Properties;


namespace EuropeanStudiesQuiz
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            // Enable CenterToScreen so that the game screen will be easy and clear to see.
            CenterToScreen();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            // Play the music when the screen loads.
            PlayMusic();
        }

        // Set up Timer.
        private void timer_Tick(object sender, EventArgs e)
        {
            // Call progress method.
            progress();
        }
        
        // Set progress method.
        public void progress()
        {
            // Ensure that the progress bar will increment by one.
            proBarSplashScreen.Increment(1);
            // The lblLoading label will display the current progress of the progress bar.
            lblLoading.Text = "Loading  " + proBarSplashScreen.Value.ToString() + "%";
            // If the progress bar has incremented fully...
            if (proBarSplashScreen.Value == 100)
            {
                // Stop the timer.
                timer.Stop();
                // Create an instance of the Login Screen.
                LoginScreen next = new LoginScreen();
                // Show the Login Screen.
                next.Show(); 
                // Hide this screen.
                Hide(); 
            }
        }

        private void PlayMusic()
        {
            // Create a new instance of the SoundPlayer class and retrieve the sound file from the resources folder.
            SoundPlayer splashScreenMusic = new SoundPlayer(Resources.SplashScreenSound);
            // Play the music.
            splashScreenMusic.Play();   
        }

        



        
        

    }
}

