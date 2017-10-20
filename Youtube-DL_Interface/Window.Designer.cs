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
            this.start_download = new System.Windows.Forms.Button();
            this.audioformat = new System.Windows.Forms.ComboBox();
            this.audioquality = new System.Windows.Forms.NumericUpDown();
            this.onlyaudio = new System.Windows.Forms.CheckBox();
            this.targetExecutable = new System.Windows.Forms.TextBox();
            this.urlinput = new System.Windows.Forms.TextBox();
            this.cmdremainstate = new System.Windows.Forms.CheckBox();
            this.updatedownloader = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.audioquality)).BeginInit();
            this.SuspendLayout();
            // 
            // start_download
            // 
            this.start_download.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start_download.Location = new System.Drawing.Point(12, 323);
            this.start_download.Name = "start_download";
            this.start_download.Size = new System.Drawing.Size(426, 71);
            this.start_download.TabIndex = 0;
            this.start_download.Text = "START";
            this.start_download.UseVisualStyleBackColor = true;
            this.start_download.Click += new System.EventHandler(this.start_download_Click);
            // 
            // audioformat
            // 
            this.audioformat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.audioformat.FormattingEnabled = true;
            this.audioformat.Location = new System.Drawing.Point(308, 64);
            this.audioformat.Name = "audioformat";
            this.audioformat.Size = new System.Drawing.Size(121, 28);
            this.audioformat.TabIndex = 1;
            this.audioformat.Text = "mp3";
            // 
            // audioquality
            // 
            this.audioquality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.audioquality.Location = new System.Drawing.Point(192, 65);
            this.audioquality.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.audioquality.Name = "audioquality";
            this.audioquality.Size = new System.Drawing.Size(108, 26);
            this.audioquality.TabIndex = 2;
            this.audioquality.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // onlyaudio
            // 
            this.onlyaudio.AutoSize = true;
            this.onlyaudio.Location = new System.Drawing.Point(12, 66);
            this.onlyaudio.Name = "onlyaudio";
            this.onlyaudio.Size = new System.Drawing.Size(181, 24);
            this.onlyaudio.TabIndex = 3;
            this.onlyaudio.Text = "Only download audio";
            this.onlyaudio.UseVisualStyleBackColor = true;
            this.onlyaudio.CheckedChanged += new System.EventHandler(this.onlyaudio_CheckedChanged);
            // 
            // targetExecutable
            // 
            this.targetExecutable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.targetExecutable.Location = new System.Drawing.Point(12, 291);
            this.targetExecutable.Name = "targetExecutable";
            this.targetExecutable.Size = new System.Drawing.Size(100, 26);
            this.targetExecutable.TabIndex = 4;
            this.targetExecutable.Text = "youtube-dl";
            // 
            // urlinput
            // 
            this.urlinput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlinput.Location = new System.Drawing.Point(12, 12);
            this.urlinput.Name = "urlinput";
            this.urlinput.Size = new System.Drawing.Size(417, 26);
            this.urlinput.TabIndex = 5;
            // 
            // cmdremainstate
            // 
            this.cmdremainstate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdremainstate.AutoSize = true;
            this.cmdremainstate.Location = new System.Drawing.Point(129, 293);
            this.cmdremainstate.Name = "cmdremainstate";
            this.cmdremainstate.Size = new System.Drawing.Size(249, 24);
            this.cmdremainstate.TabIndex = 6;
            this.cmdremainstate.Text = "Keep Command Window open";
            this.cmdremainstate.UseVisualStyleBackColor = true;
            // 
            // updatedownloader
            // 
            this.updatedownloader.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.updatedownloader.Location = new System.Drawing.Point(334, 174);
            this.updatedownloader.Name = "updatedownloader";
            this.updatedownloader.Size = new System.Drawing.Size(104, 60);
            this.updatedownloader.TabIndex = 7;
            this.updatedownloader.Text = "Update YoutubeDL";
            this.updatedownloader.UseVisualStyleBackColor = true;
            this.updatedownloader.Click += new System.EventHandler(this.updatedownloader_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 397);
            this.Controls.Add(this.updatedownloader);
            this.Controls.Add(this.cmdremainstate);
            this.Controls.Add(this.urlinput);
            this.Controls.Add(this.audioquality);
            this.Controls.Add(this.audioformat);
            this.Controls.Add(this.start_download);
            this.Controls.Add(this.onlyaudio);
            this.Controls.Add(this.targetExecutable);
            this.MinimumSize = new System.Drawing.Size(392, 407);
            this.Name = "Window";
            this.Text = "Youtube-DL Interface";
            ((System.ComponentModel.ISupportInitialize)(this.audioquality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_download;
        private System.Windows.Forms.ComboBox audioformat;
        private System.Windows.Forms.NumericUpDown audioquality;
        private System.Windows.Forms.CheckBox onlyaudio;
        private System.Windows.Forms.TextBox targetExecutable;
        private System.Windows.Forms.TextBox urlinput;
        private System.Windows.Forms.CheckBox cmdremainstate;
        private System.Windows.Forms.Button updatedownloader;
    }
}

