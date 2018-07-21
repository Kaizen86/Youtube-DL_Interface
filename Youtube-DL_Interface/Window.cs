using System;
using System.IO;
using System.Windows.Forms;

namespace Youtube_DL_Interface
{
    public partial class Window : Form
    {
        public string[] audioformats = { "best", "aac", "flac", "mp3", "m4a", "opus", "vorbis", "wav" };
        public Window()
        {
            InitializeComponent();

            try
            {
                //Read the config file and load the settings.
                var folder = Properties.Settings.Default.folderPath;
                if (!(folder == "")) //If there is something in the folder path. Otherwise the current directory is used.
                { folderInput.Text = folder; }
                else { folderInput.Text = Directory.GetCurrentDirectory(); }

                targetExecutable.Text = Properties.Settings.Default.nameOfYoutubeDL;

                var quality = Convert.ToInt32(Properties.Settings.Default.defaultAudioQuality);
                if ((!(quality > 9)) && (!(quality < 0))) { audioquality.Value = Convert.ToInt32(Properties.Settings.Default.defaultAudioQuality); }
                else
                {
                    audioquality.Value = 5;
                    MessageBox.Show("Invalid audio quality specification. Using 5.");
                }

                audioformat.Text = Properties.Settings.Default.defaultAudioFormat;
                //Since defaultAudioFormat could be set to something other than the options provided, add a check for this.
                if (!Array.Exists<string>(audioformats, element => element == audioformat.Text))
                {
                    string audlist = "";
                    foreach (var i in audioformats) { audlist = audlist + "\n" + i; }
                    MessageBox.Show("Error: Default audio format is not a valid audio format. Must be one of\n" + audlist);
                    audioformat.Text = "mp3";
                }
                keepOriginal.Checked = Properties.Settings.Default.keepOriginal;
            }
            catch (Exception err)
            {
                MessageBox.Show("Error reading from config file: " + err.Message);
                Environment.Exit(0);
            }
            //Populate the audioformat list
            audioformat.Items.Clear();
            foreach (var i in audioformats) { audioformat.Items.Add(i); }
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
            try { Directory.SetCurrentDirectory(urlinput.Text); }
            catch (Exception) { }
        }

        private void openSaveFolder_Click(object sender, EventArgs e)
        {
            executeShellCommand("explorer", folderInput.Text);
        }

        private void optionUpdated(object sender, EventArgs e)
        {
            //triggered whenever an option is updated.
            Properties.Settings.Default.folderPath = folderInput.Text;
            Properties.Settings.Default.nameOfYoutubeDL = targetExecutable.Text;
            Properties.Settings.Default.defaultAudioQuality = Convert.ToInt16(audioquality.Value);
            Properties.Settings.Default.defaultAudioFormat = audioformat.Text;
            Properties.Settings.Default.keepOriginal = keepOriginal.Checked;
            Properties.Settings.Default.keepCmdOpen = cmdremainstate.Checked;
            Properties.Settings.Default.Save();
        }

        private void browseForFolderButton_Click(object sender, EventArgs e)
        {
            browseForFolder.ShowDialog();
            folderInput.Text = browseForFolder.SelectedPath;
        }
    }
}
