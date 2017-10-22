using System;
using System.IO;
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

            folderInput.Text = Directory.GetCurrentDirectory();
        }
        //strings needed by start_download_Click() and updatebutton_Click()
        public static string audioparam;
        public static string cmdvanish;
        public static string keeporiginal;
        public static string folder;

        private void start_download_Click(object sender, EventArgs e)
        {
            //first, go into target directory.
            folder = folderInput.Text;
            if (Directory.Exists(folder))
            {
                Directory.SetCurrentDirectory(folder);

                //Get the executable name. This is kinda important.
                string targetprgname = targetExecutable.Text;
                //Get the URL provided to us
                string URL = urlinput.Text;

                //build the command by adding parameters
                audioparam = ("-x --audio-format " + audioformat.Text + " --audio-quality " + audioquality.Value); //get audio settings
                if (cmdremainstate.Checked) { cmdvanish = "/K"; } //If they want the window to remain open afterwards, use /K.
                else { cmdvanish = "/C"; } //Otherwise /C.
                if (keepOriginal.Checked) { keeporiginal = " -k "; } //keeps original video file
                else { keeporiginal = " "; } //doesn't. this is default.

                //This is the generated command from the data.
                string arguments = (" " + cmdvanish + " \"echo Saving into %cd% && " + targetprgname + keeporiginal + " -o %(title)s.%(ext)s " + audioparam + " " + URL + " && echo Completed download! && pause\"");

                //Now to execute it
                executeShellCommand("cmd.exe", arguments);
            }
            else
            {
                MessageBox.Show("The specified folder does not exist.");
            }
        }

        public void executeShellCommand(string command, string arguments)
        {
            //MessageBox.Show(command + arguments); //Debugging purposes
            var p = new System.Diagnostics.Process();
            p.StartInfo.FileName = command;
            p.StartInfo.Arguments = arguments;
            p.Start();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            //get executable name
            string targetprgname = targetExecutable.Text;

            if (cmdremainstate.Checked) { cmdvanish = "/K"; } //If they want the window to remain open afterwards, use /K.
            else { cmdvanish = "/C"; } //Otherwise /C.

            //create arguments
            string arguments = (" " + cmdvanish + " \"" + targetprgname + " -U && echo Completed upgrade! && pause\"");
            executeShellCommand("cmd.exe", arguments);
        }

        private void urlinput_TextChanged(object sender, EventArgs e)
        {
            //Since the user will likely by typing in the folder path, there will be errors preventing us from changing directories.
            try{Directory.SetCurrentDirectory(urlinput.Text);}
            catch (Exception){}
        }
    }
}
