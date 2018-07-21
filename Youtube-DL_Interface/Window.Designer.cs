namespace Youtube_DL_Interface
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.start_download = new System.Windows.Forms.Button();
            this.audioformat = new System.Windows.Forms.ComboBox();
            this.audioquality = new System.Windows.Forms.NumericUpDown();
            this.targetExecutable = new System.Windows.Forms.TextBox();
            this.urlinput = new System.Windows.Forms.TextBox();
            this.cmdremainstate = new System.Windows.Forms.CheckBox();
            this.updatebutton = new System.Windows.Forms.Button();
            this.audioFormatlabel = new System.Windows.Forms.Label();
            this.audioQualitylabel1 = new System.Windows.Forms.Label();
            this.programNameLabel = new System.Windows.Forms.Label();
            this.audioQualitylabel2 = new System.Windows.Forms.Label();
            this.URLinputlabel = new System.Windows.Forms.Label();
            this.keepOriginal = new System.Windows.Forms.CheckBox();
            this.folderInput = new System.Windows.Forms.TextBox();
            this.folderinputlabel = new System.Windows.Forms.Label();
            this.TabHolder = new System.Windows.Forms.TabControl();
            this.Tab_simpleOptions = new System.Windows.Forms.TabPage();
            this.Tab_advancedOptions = new System.Windows.Forms.TabPage();
            this.checkboxGroup = new System.Windows.Forms.GroupBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.hoverInformationLabel = new System.Windows.Forms.Label();
            this.simpleOptions_Help = new System.Windows.Forms.TextBox();
            this.openSaveFolder = new System.Windows.Forms.Button();
            this.browseForFolderButton = new System.Windows.Forms.Button();
            this.browseForFolder = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.audioquality)).BeginInit();
            this.TabHolder.SuspendLayout();
            this.Tab_simpleOptions.SuspendLayout();
            this.Tab_advancedOptions.SuspendLayout();
            this.checkboxGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_download
            // 
            this.start_download.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_download.Location = new System.Drawing.Point(148, 345);
            this.start_download.Name = "start_download";
            this.start_download.Size = new System.Drawing.Size(310, 59);
            this.start_download.TabIndex = 0;
            this.start_download.Text = "Download";
            this.ToolTip.SetToolTip(this.start_download, "Begins the download process.");
            this.start_download.UseVisualStyleBackColor = true;
            this.start_download.Click += new System.EventHandler(this.start_download_Click);
            // 
            // audioformat
            // 
            this.audioformat.FormattingEnabled = true;
            this.audioformat.Location = new System.Drawing.Point(144, 205);
            this.audioformat.Name = "audioformat";
            this.audioformat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.audioformat.Size = new System.Drawing.Size(78, 28);
            this.audioformat.TabIndex = 1;
            this.audioformat.Text = "mp3";
            this.ToolTip.SetToolTip(this.audioformat, "Select format of downloaded file");
            this.audioformat.SelectedValueChanged += new System.EventHandler(this.optionUpdated);
            // 
            // audioquality
            // 
            this.audioquality.Location = new System.Drawing.Point(144, 154);
            this.audioquality.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.audioquality.Name = "audioquality";
            this.audioquality.Size = new System.Drawing.Size(78, 26);
            this.audioquality.TabIndex = 2;
            this.ToolTip.SetToolTip(this.audioquality, "Determines the quality of the dowloaded audio. Lower numbers increase the quality" +
        ", while higher numbers decrease it. Higher quality audio will result in larger f" +
        "iles.");
            this.audioquality.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.audioquality.ValueChanged += new System.EventHandler(this.optionUpdated);
            // 
            // targetExecutable
            // 
            this.targetExecutable.Location = new System.Drawing.Point(144, 254);
            this.targetExecutable.Name = "targetExecutable";
            this.targetExecutable.Size = new System.Drawing.Size(428, 26);
            this.targetExecutable.TabIndex = 4;
            this.targetExecutable.Text = "youtube-dl";
            this.ToolTip.SetToolTip(this.targetExecutable, "Sets the name of the youtube-dl executable in case it is located elsewhere on the" +
        " system");
            this.targetExecutable.TextChanged += new System.EventHandler(this.optionUpdated);
            // 
            // urlinput
            // 
            this.urlinput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlinput.Location = new System.Drawing.Point(6, 6);
            this.urlinput.Name = "urlinput";
            this.urlinput.Size = new System.Drawing.Size(526, 26);
            this.urlinput.TabIndex = 5;
            this.ToolTip.SetToolTip(this.urlinput, "This is where the video URL is entered");
            this.urlinput.TextChanged += new System.EventHandler(this.urlinput_TextChanged);
            // 
            // cmdremainstate
            // 
            this.cmdremainstate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdremainstate.AutoSize = true;
            this.cmdremainstate.Location = new System.Drawing.Point(21, 55);
            this.cmdremainstate.Name = "cmdremainstate";
            this.cmdremainstate.Size = new System.Drawing.Size(249, 24);
            this.cmdremainstate.TabIndex = 6;
            this.cmdremainstate.Text = "Keep Command Window open";
            this.ToolTip.SetToolTip(this.cmdremainstate, "Keeps the command window open afterwards. Useful if the download crashes and you " +
        "need to read the error message produced.");
            this.cmdremainstate.UseVisualStyleBackColor = true;
            this.cmdremainstate.Click += new System.EventHandler(this.optionUpdated);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(374, 68);
            this.updatebutton.MinimumSize = new System.Drawing.Size(111, 55);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(198, 55);
            this.updatebutton.TabIndex = 7;
            this.updatebutton.Text = "Update Core Files";
            this.ToolTip.SetToolTip(this.updatebutton, "Updates the youtube-dl executable. Try this if the download isn\'t working.");
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // audioFormatlabel
            // 
            this.audioFormatlabel.AutoSize = true;
            this.audioFormatlabel.Location = new System.Drawing.Point(25, 205);
            this.audioFormatlabel.Name = "audioFormatlabel";
            this.audioFormatlabel.Size = new System.Drawing.Size(100, 20);
            this.audioFormatlabel.TabIndex = 8;
            this.audioFormatlabel.Text = "Audio format";
            // 
            // audioQualitylabel1
            // 
            this.audioQualitylabel1.AutoSize = true;
            this.audioQualitylabel1.Location = new System.Drawing.Point(25, 154);
            this.audioQualitylabel1.Name = "audioQualitylabel1";
            this.audioQualitylabel1.Size = new System.Drawing.Size(99, 20);
            this.audioQualitylabel1.TabIndex = 9;
            this.audioQualitylabel1.Text = "Audio quality";
            // 
            // programNameLabel
            // 
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Location = new System.Drawing.Point(25, 260);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(113, 20);
            this.programNameLabel.TabIndex = 10;
            this.programNameLabel.Text = "Program name";
            // 
            // audioQualitylabel2
            // 
            this.audioQualitylabel2.AutoSize = true;
            this.audioQualitylabel2.Location = new System.Drawing.Point(248, 156);
            this.audioQualitylabel2.Name = "audioQualitylabel2";
            this.audioQualitylabel2.Size = new System.Drawing.Size(132, 20);
            this.audioQualitylabel2.TabIndex = 11;
            this.audioQualitylabel2.Text = "(0=best, 9=worst)";
            // 
            // URLinputlabel
            // 
            this.URLinputlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.URLinputlabel.AutoSize = true;
            this.URLinputlabel.Location = new System.Drawing.Point(550, 9);
            this.URLinputlabel.Name = "URLinputlabel";
            this.URLinputlabel.Size = new System.Drawing.Size(42, 20);
            this.URLinputlabel.TabIndex = 12;
            this.URLinputlabel.Text = "URL";
            // 
            // keepOriginal
            // 
            this.keepOriginal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.keepOriginal.AutoSize = true;
            this.keepOriginal.Location = new System.Drawing.Point(21, 17);
            this.keepOriginal.Name = "keepOriginal";
            this.keepOriginal.Size = new System.Drawing.Size(163, 24);
            this.keepOriginal.TabIndex = 13;
            this.keepOriginal.Text = "Keep original Files";
            this.ToolTip.SetToolTip(this.keepOriginal, "Determines whether or not the original video files are deleted once the operation" +
        " is completed");
            this.keepOriginal.UseVisualStyleBackColor = true;
            this.keepOriginal.Click += new System.EventHandler(this.optionUpdated);
            // 
            // folderInput
            // 
            this.folderInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderInput.Location = new System.Drawing.Point(6, 38);
            this.folderInput.Name = "folderInput";
            this.folderInput.Size = new System.Drawing.Size(526, 26);
            this.folderInput.TabIndex = 14;
            this.ToolTip.SetToolTip(this.folderInput, "This is the path of the folder that the downloaded files will be located.");
            this.folderInput.TextChanged += new System.EventHandler(this.optionUpdated);
            // 
            // folderinputlabel
            // 
            this.folderinputlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.folderinputlabel.AutoSize = true;
            this.folderinputlabel.Location = new System.Drawing.Point(538, 41);
            this.folderinputlabel.Name = "folderinputlabel";
            this.folderinputlabel.Size = new System.Drawing.Size(54, 20);
            this.folderinputlabel.TabIndex = 15;
            this.folderinputlabel.Text = "Folder";
            // 
            // TabHolder
            // 
            this.TabHolder.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TabHolder.Controls.Add(this.Tab_simpleOptions);
            this.TabHolder.Controls.Add(this.Tab_advancedOptions);
            this.TabHolder.Location = new System.Drawing.Point(0, 0);
            this.TabHolder.Margin = new System.Windows.Forms.Padding(0);
            this.TabHolder.Name = "TabHolder";
            this.TabHolder.SelectedIndex = 0;
            this.TabHolder.Size = new System.Drawing.Size(606, 336);
            this.TabHolder.TabIndex = 16;
            // 
            // Tab_simpleOptions
            // 
            this.Tab_simpleOptions.BackColor = System.Drawing.SystemColors.Control;
            this.Tab_simpleOptions.Controls.Add(this.browseForFolderButton);
            this.Tab_simpleOptions.Controls.Add(this.openSaveFolder);
            this.Tab_simpleOptions.Controls.Add(this.simpleOptions_Help);
            this.Tab_simpleOptions.Controls.Add(this.urlinput);
            this.Tab_simpleOptions.Controls.Add(this.folderInput);
            this.Tab_simpleOptions.Controls.Add(this.URLinputlabel);
            this.Tab_simpleOptions.Controls.Add(this.folderinputlabel);
            this.Tab_simpleOptions.Location = new System.Drawing.Point(4, 32);
            this.Tab_simpleOptions.Name = "Tab_simpleOptions";
            this.Tab_simpleOptions.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_simpleOptions.Size = new System.Drawing.Size(598, 300);
            this.Tab_simpleOptions.TabIndex = 0;
            this.Tab_simpleOptions.Text = "Simple Options";
            // 
            // Tab_advancedOptions
            // 
            this.Tab_advancedOptions.BackColor = System.Drawing.SystemColors.Control;
            this.Tab_advancedOptions.Controls.Add(this.hoverInformationLabel);
            this.Tab_advancedOptions.Controls.Add(this.checkboxGroup);
            this.Tab_advancedOptions.Controls.Add(this.updatebutton);
            this.Tab_advancedOptions.Controls.Add(this.programNameLabel);
            this.Tab_advancedOptions.Controls.Add(this.targetExecutable);
            this.Tab_advancedOptions.Controls.Add(this.audioquality);
            this.Tab_advancedOptions.Controls.Add(this.audioQualitylabel2);
            this.Tab_advancedOptions.Controls.Add(this.audioformat);
            this.Tab_advancedOptions.Controls.Add(this.audioQualitylabel1);
            this.Tab_advancedOptions.Controls.Add(this.audioFormatlabel);
            this.Tab_advancedOptions.Location = new System.Drawing.Point(4, 32);
            this.Tab_advancedOptions.Name = "Tab_advancedOptions";
            this.Tab_advancedOptions.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_advancedOptions.Size = new System.Drawing.Size(598, 300);
            this.Tab_advancedOptions.TabIndex = 1;
            this.Tab_advancedOptions.Text = "Advanced Options";
            // 
            // checkboxGroup
            // 
            this.checkboxGroup.Controls.Add(this.keepOriginal);
            this.checkboxGroup.Controls.Add(this.cmdremainstate);
            this.checkboxGroup.Location = new System.Drawing.Point(8, 44);
            this.checkboxGroup.Name = "checkboxGroup";
            this.checkboxGroup.Size = new System.Drawing.Size(289, 93);
            this.checkboxGroup.TabIndex = 14;
            this.checkboxGroup.TabStop = false;
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 0;
            this.ToolTip.InitialDelay = 500;
            this.ToolTip.ReshowDelay = 100;
            // 
            // hoverInformationLabel
            // 
            this.hoverInformationLabel.AutoSize = true;
            this.hoverInformationLabel.Location = new System.Drawing.Point(25, 20);
            this.hoverInformationLabel.Name = "hoverInformationLabel";
            this.hoverInformationLabel.Size = new System.Drawing.Size(473, 20);
            this.hoverInformationLabel.TabIndex = 15;
            this.hoverInformationLabel.Text = "Hover your mouse over an option to see more information about it!";
            this.ToolTip.SetToolTip(this.hoverInformationLabel, "Yes, like that. But somewhere else.");
            // 
            // simpleOptions_Help
            // 
            this.simpleOptions_Help.Location = new System.Drawing.Point(6, 178);
            this.simpleOptions_Help.Multiline = true;
            this.simpleOptions_Help.Name = "simpleOptions_Help";
            this.simpleOptions_Help.ReadOnly = true;
            this.simpleOptions_Help.Size = new System.Drawing.Size(588, 126);
            this.simpleOptions_Help.TabIndex = 16;
            this.simpleOptions_Help.Text = resources.GetString("simpleOptions_Help.Text");
            this.simpleOptions_Help.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openSaveFolder
            // 
            this.openSaveFolder.Location = new System.Drawing.Point(192, 121);
            this.openSaveFolder.Name = "openSaveFolder";
            this.openSaveFolder.Size = new System.Drawing.Size(216, 36);
            this.openSaveFolder.TabIndex = 17;
            this.openSaveFolder.Text = "Open save folder";
            this.ToolTip.SetToolTip(this.openSaveFolder, "Opens the folder the downloaded file was saved into");
            this.openSaveFolder.UseVisualStyleBackColor = true;
            this.openSaveFolder.Click += new System.EventHandler(this.openSaveFolder_Click);
            // 
            // browseForFolderButton
            // 
            this.browseForFolderButton.Location = new System.Drawing.Point(192, 75);
            this.browseForFolderButton.Name = "browseForFolderButton";
            this.browseForFolderButton.Size = new System.Drawing.Size(216, 36);
            this.browseForFolderButton.TabIndex = 18;
            this.browseForFolderButton.Text = "Select save folder";
            this.ToolTip.SetToolTip(this.browseForFolderButton, "Opens the folder the downloaded file was saved into");
            this.browseForFolderButton.UseVisualStyleBackColor = true;
            this.browseForFolderButton.Click += new System.EventHandler(this.browseForFolderButton_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 414);
            this.Controls.Add(this.TabHolder);
            this.Controls.Add(this.start_download);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(630, 470);
            this.MinimumSize = new System.Drawing.Size(630, 470);
            this.Name = "Window";
            this.Text = "Audio Grabber";
            ((System.ComponentModel.ISupportInitialize)(this.audioquality)).EndInit();
            this.TabHolder.ResumeLayout(false);
            this.Tab_simpleOptions.ResumeLayout(false);
            this.Tab_simpleOptions.PerformLayout();
            this.Tab_advancedOptions.ResumeLayout(false);
            this.Tab_advancedOptions.PerformLayout();
            this.checkboxGroup.ResumeLayout(false);
            this.checkboxGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_download;
        private System.Windows.Forms.ComboBox audioformat;
        private System.Windows.Forms.NumericUpDown audioquality;
        private System.Windows.Forms.TextBox targetExecutable;
        private System.Windows.Forms.TextBox urlinput;
        private System.Windows.Forms.CheckBox cmdremainstate;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Label audioFormatlabel;
        private System.Windows.Forms.Label audioQualitylabel1;
        private System.Windows.Forms.Label programNameLabel;
        private System.Windows.Forms.Label audioQualitylabel2;
        private System.Windows.Forms.Label URLinputlabel;
        private System.Windows.Forms.CheckBox keepOriginal;
        private System.Windows.Forms.TextBox folderInput;
        private System.Windows.Forms.Label folderinputlabel;
        private System.Windows.Forms.TabControl TabHolder;
        private System.Windows.Forms.TabPage Tab_simpleOptions;
        private System.Windows.Forms.TabPage Tab_advancedOptions;
        private System.Windows.Forms.GroupBox checkboxGroup;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Label hoverInformationLabel;
        private System.Windows.Forms.Button openSaveFolder;
        private System.Windows.Forms.TextBox simpleOptions_Help;
        private System.Windows.Forms.Button browseForFolderButton;
        private System.Windows.Forms.FolderBrowserDialog browseForFolder;
    }
}

