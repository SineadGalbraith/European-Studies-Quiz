using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EuropeanStudiesQuiz
{
    public class FileLocationManager
    {
        // Save the usernames into the variable _fileName.
        private const string _fileName = @"EuropeanStudiesQuiz.txt";

        public static string GetFileLocation()
        {
            // Return _fileName.
            return _fileName;
        }

        // Save the times into the variable _fileTime.
        private const string _fileTime = @"EuropeanStudiesQuiz.bin";

        public static string GetFileName()
        {
            // Return _fileTime.
            return _fileTime;
        }

        // Save the username and times into the variable _userAndTime.
        private const string _userAndTime = @"playertime.txt";

        public static string GetFileTime()
        {
            // Return _userAndTime.
            return _userAndTime;
        }

        // Save the sound file for the SplashScreen into the variable _splashScreenMusic.
        private const string _splashScreenMusic = @"SplashScreenSound.wav";

        public static string GetSplashScreenSound()
        {
            // Return _splashScreenMusic.
            return _splashScreenMusic;
        }
    }
}

