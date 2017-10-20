using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube_DL_Interface
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();

            //Populate the audioformat list
            audioformat.Items.Clear();
            audioformat.Items.Add("best");
            audioformat.Items.Add("aac");
            audioformat.Items.Add("flac");
            audioformat.Items.Add("mp3");
            audioformat.Items.Add("m4a");
            audioformat.Items.Add("opus");
            audioformat.Items.Add("vorbis");
            audioformat.Items.Add("wav");

            //disable audioformat and audioquality on startup, so by default you download video.
            audioformat.Enabled = false;
            audioquality.Enabled = false;
        }
        private void onlyaudio_CheckedChanged(object sender, EventArgs e)
        {
            //Enables/disables audio extraction options
            if (onlyaudio.Checked)
            {
                audioformat.Enabled = true;
                audioquality.Enabled = true;
            }
            else
            {
                audioquality.Enabled = false;
                audioformat.Enabled = false;
            }
        }
        //strings needed by start_download_Click()
        public static string audioparam;
        public static string cmdvanish;

        private void start_download_Click(object sender, EventArgs e)
        {
            //Get the executable name. This is kinda important.
            string targetprgname = targetExecutable.Text;
            //Get the URL provided to us
            string URL = urlinput.Text;

            //build the command by adding parameters
            if (onlyaudio.Checked) { audioparam = ("-x --audio-format " + audioformat.Text + " --audio-quality " + audioquality.Value); }
            if (cmdremainstate.Checked) { cmdvanish = "/K"; } //If they want the window to remain open afterwards, use /K.
            else { cmdvanish = "/C"; } //Otherwise /C.

            //This is the generated command from the data.
            string arguments = (" " + cmdvanish + " \"" + targetprgname + " " + audioparam + " " + URL + " && echo Completed download! && pause\"");
            //Now to execute it
            executeShellCommand("cmd.exe", arguments);
        }
        public void executeShellCommand(string command, string arguments)
        {
            //MessageBox.Show(command + arguments); //Debugging purposes
            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = command;
            p.StartInfo.Arguments = arguments;
            p.Start();
        }

    }
}
