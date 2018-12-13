using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace snaketest
{


    class UpdateCheck
    {
        private string newUpdate;
        public string currentUpdate = "121218dr9";
        private WebClient webc = new WebClient();
        private bool latest;

        public void CheckUpdate() // Check for update
        {
            /*
             *
             * We download info from raw git, translate it to UTF8 and compare it
             * to currentUpdate. If they're the same, its on the latest build.
             * If they don't match, we tell the user there is a new update available.
             * 
            */

            try // exception handling
            {
                byte[] webData = webc.DownloadData("https://raw.githubusercontent.com/Creeperlover234/Snake-Game/master/release"); // get latest release

                newUpdate = Encoding.UTF8.GetString(webData); // translate that boi

                if (newUpdate == currentUpdate) // compare
                {
                    latest = true;
                }
                else
                {
                    latest = false;
                    DialogResult UpdateYesNo = MessageBox.Show("There is a newer version of this application.\nWould you like to update?", "New Update " + newUpdate, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (UpdateYesNo == DialogResult.Yes)
                    {
                        Process.Start("https://github.com/Creeperlover234/Snake-Game/releases");
                    }
                    else { }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nThis most likely means you do not have an internet connection.");
            }
        }

        public bool isLatest()
        {
            if (latest == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
