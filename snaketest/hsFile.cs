using System;
using System.Windows.Forms;
using System.IO;

namespace snaketest
{
    class hsFile
    {
        private string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); // appdata location
        private int highScore;
        private int mainHS;

        public void setHighScore()// we use this to read from the txt file and set the high score in game
        {
            try // Exception Handling
            {
                StreamReader readFile = new StreamReader(appData + @"\SnakeGame\highScore.txt");
                highScore = Convert.ToInt32(readFile.ReadLine());
                readFile.Close();
            }
            catch (FileNotFoundException) // this literally should NEVER happen, but if it does, this will be more useful.
            {
                MessageBox.Show("Error. File was not found. Please re-run this program.");
            }
            catch (Exception ex) // this is very helpful if someone messes with the txt file, we will notify them that they need to reset it.
            {
                MessageBox.Show("Error: " + ex.Message + "\nPlease reset highScore.txt\nLocated in %appdata%\\SnakeGame\\ (leave it empty).");
                highScore = 0;
            }
        }

        public int getHS() // we need dis to get the highscore duhhhhh
        {
            return highScore;
        }

        public void createFile()// create file if neccessary, called on startup
        {
            if (File.Exists(appData + @"\SnakeGame\highScore.txt")) // don't want to create a file that already exists
                return;

            if (!Directory.Exists(appData + @"\SnakeGame\")) //same thing, dont want to create directory that already exists
                Directory.CreateDirectory(appData + @"\SnakeGame\");

            var highScoreTXT = File.Create(appData + @"\SnakeGame\highScore.txt");

            highScoreTXT.Close();
        }

        public void saveFile()// save file when ded
        {
            try // More Exception Handling
            {
                StreamWriter writeFile = new StreamWriter(appData + @"\SnakeGame\highScore.txt");
                writeFile.Write(mainHS); // we need to write the high score to the file
                writeFile.Close(); // close the file
            }
            catch (FileNotFoundException fnf)
            {
                MessageBox.Show(fnf.Message + "\nFor some reason the file was not found, howd you do this?!");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        
        public void Reset() // resets highscore to 0
        {
            try
            {
                StreamWriter resetFile = new StreamWriter(appData + @"\SnakeGame\highScore.txt");
                resetFile.Write("0");
                resetFile.Close();
                MessageBox.Show("The High Score was successfully reset.", "Reset Successful.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found. You messed up.");
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + ". Pls fix");
            }
        }

        public int setHS(int hs)// we need to set this when we die or else highscore will always be set to 0
        {
            return mainHS = hs;
        }
    }
}
