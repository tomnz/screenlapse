using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Screenlapse
{
    public partial class MainForm : Form
    {
        int numScreenshots = 0;
        double intervalSecs = 0;
        string folderSave = "";
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                StopRunning();
            }
            else
            {
                StartRunning();
            }
        }

        private void StartRunning()
        {
            // Check settings
            if (string.IsNullOrWhiteSpace(txtInterval.Text))
            {
                MessageBox.Show("You must enter an interval");
                return;
            }

            intervalSecs = 0;
            if (!double.TryParse(txtInterval.Text, out intervalSecs))
            {
                MessageBox.Show("Invalid interval entered. Must be a number greater than zero");
                return;
            }
            else if (intervalSecs <= 0)
            {
                MessageBox.Show("Invalid interval entered. Must be a number greater than zero");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFolder.Text))
            {
                MessageBox.Show("You must enter a target folder for screenshots");
                return;
            }

            numScreenshots = 0;
            if (optNumScreenshots.Checked)
            {
                if (!int.TryParse(txtNumScreenshots.Text, out numScreenshots))
                {
                    MessageBox.Show("Invalid number of screenshots entered. Must be a number greater than zero");
                    return;
                }
                else if (numScreenshots <= 0)
                {
                    MessageBox.Show("Invalid number of screenshots entered. Must be a number greater than zero");
                    return;
                }
            }


            // Check folder exists
            if (!Directory.Exists(txtFolder.Text))
            {
                if (MessageBox.Show("Folder does not exist, would you like to create it?", "Screenlapse", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        Directory.CreateDirectory(txtFolder.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot create folder. Try a different directory");
                        return;
                    }
                }
            }

            folderSave = txtFolder.Text;

            // Start timer
            timer.Interval = (int)(intervalSecs * 1000.0);
            timer.Start();

            // Change button
            btnStartStop.Text = "Stop";
        }

        private void StopRunning()
        {
            btnStartStop.Text = "Start";
            timer.Stop();
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            folder.ShowDialog();
            txtFolder.Text = folder.SelectedPath;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Image img = ScreenshotCapture.CaptureDesktopImage();
            img.Save(Path.Combine(new string[] {folderSave, DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".png"}));
        }
    }
}
