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
            ((System.ComponentModel.ISupportInitialize)(this.audioquality)).BeginInit();
            this.SuspendLayout();
            // 
            // start_download
            // 
            this.start_download.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.start_download.Location = new System.Drawing.Point(0, 305);
            this.start_download.Name = "start_download";
            this.start_download.Size = new System.Drawing.Size(292, 71);
            this.start_download.TabIndex = 0;
            this.start_download.Text = "START";
            this.start_download.UseVisualStyleBackColor = true;
            this.start_download.Click += new System.EventHandler(this.start_download_Click);
            // 
            // audioformat
            // 
            this.audioformat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.audioformat.FormattingEnabled = true;
            this.audioformat.Location = new System.Drawing.Point(161, 74);
            this.audioformat.Name = "audioformat";
            this.audioformat.Size = new System.Drawing.Size(121, 28);
            this.audioformat.TabIndex = 1;
            this.audioformat.Text = "mp3";
            // 
            // audioquality
            // 
            this.audioquality.Location = new System.Drawing.Point(12, 76);
            this.audioquality.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.audioquality.Name = "audioquality";
            this.audioquality.Size = new System.Drawing.Size(78, 26);
            this.audioquality.TabIndex = 2;
            this.audioquality.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // targetExecutable
            // 
            this.targetExecutable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.targetExecutable.Location = new System.Drawing.Point(12, 270);
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
            this.urlinput.Size = new System.Drawing.Size(220, 26);
            this.urlinput.TabIndex = 5;
            this.urlinput.TextChanged += new System.EventHandler(this.urlinput_TextChanged);
            // 
            // cmdremainstate
            // 
            this.cmdremainstate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdremainstate.AutoSize = true;
            this.cmdremainstate.Location = new System.Drawing.Point(12, 240);
            this.cmdremainstate.Name = "cmdremainstate";
            this.cmdremainstate.Size = new System.Drawing.Size(249, 24);
            this.cmdremainstate.TabIndex = 6;
            this.cmdremainstate.Text = "Keep Command Window open";
            this.cmdremainstate.UseVisualStyleBackColor = true;
            // 
            // updatebutton
            // 
            this.updatebutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.updatebutton.Location = new System.Drawing.Point(12, 166);
            this.updatebutton.MinimumSize = new System.Drawing.Size(111, 55);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(113, 55);
            this.updatebutton.TabIndex = 7;
            this.updatebutton.Text = "Update Youtube-DL";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // audioFormatlabel
            // 
            this.audioFormatlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.audioFormatlabel.AutoSize = true;
            this.audioFormatlabel.Location = new System.Drawing.Point(180, 105);
            this.audioFormatlabel.Name = "audioFormatlabel";
            this.audioFormatlabel.Size = new System.Drawing.Size(100, 20);
            this.audioFormatlabel.TabIndex = 8;
            this.audioFormatlabel.Text = "Audio format";
            // 
            // audioQualitylabel1
            // 
            this.audioQualitylabel1.AutoSize = true;
            this.audioQualitylabel1.Location = new System.Drawing.Point(8, 105);
            this.audioQualitylabel1.Name = "audioQualitylabel1";
            this.audioQualitylabel1.Size = new System.Drawing.Size(99, 20);
            this.audioQualitylabel1.TabIndex = 9;
            this.audioQualitylabel1.Text = "Audio quality";
            // 
            // programNameLabel
            // 
            this.programNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Location = new System.Drawing.Point(116, 273);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(113, 20);
            this.programNameLabel.TabIndex = 10;
            this.programNameLabel.Text = "Program name";
            // 
            // audioQualitylabel2
            // 
            this.audioQualitylabel2.AutoSize = true;
            this.audioQualitylabel2.Location = new System.Drawing.Point(8, 125);
            this.audioQualitylabel2.Name = "audioQualitylabel2";
            this.audioQualitylabel2.Size = new System.Drawing.Size(132, 20);
            this.audioQualitylabel2.TabIndex = 11;
            this.audioQualitylabel2.Text = "(0=best, 9=worst)";
            // 
            // URLinputlabel
            // 
            this.URLinputlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.URLinputlabel.AutoSize = true;
            this.URLinputlabel.Location = new System.Drawing.Point(238, 15);
            this.URLinputlabel.Name = "URLinputlabel";
            this.URLinputlabel.Size = new System.Drawing.Size(42, 20);
            this.URLinputlabel.TabIndex = 12;
            this.URLinputlabel.Text = "URL";
            // 
            // keepOriginal
            // 
            this.keepOriginal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.keepOriginal.AutoSize = true;
            this.keepOriginal.Location = new System.Drawing.Point(159, 175);
            this.keepOriginal.Name = "keepOriginal";
            this.keepOriginal.Size = new System.Drawing.Size(129, 24);
            this.keepOriginal.TabIndex = 13;
            this.keepOriginal.Text = "Keep Original";
            this.keepOriginal.UseVisualStyleBackColor = true;
            // 
            // folderInput
            // 
            this.folderInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderInput.Location = new System.Drawing.Point(12, 44);
            this.folderInput.Name = "folderInput";
            this.folderInput.Size = new System.Drawing.Size(220, 26);
            this.folderInput.TabIndex = 14;
            // 
            // folderinputlabel
            // 
            this.folderinputlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.folderinputlabel.AutoSize = true;
            this.folderinputlabel.Location = new System.Drawing.Point(239, 45);
            this.folderinputlabel.Name = "folderinputlabel";
            this.folderinputlabel.Size = new System.Drawing.Size(54, 20);
            this.folderinputlabel.TabIndex = 15;
            this.folderinputlabel.Text = "Folder";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 376);
            this.Controls.Add(this.folderInput);
            this.Controls.Add(this.keepOriginal);
            this.Controls.Add(this.URLinputlabel);
            this.Controls.Add(this.audioQualitylabel2);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.cmdremainstate);
            this.Controls.Add(this.urlinput);
            this.Controls.Add(this.audioquality);
            this.Controls.Add(this.audioformat);
            this.Controls.Add(this.start_download);
            this.Controls.Add(this.targetExecutable);
            this.Controls.Add(this.programNameLabel);
            this.Controls.Add(this.audioFormatlabel);
            this.Controls.Add(this.audioQualitylabel1);
            this.Controls.Add(this.folderinputlabel);
            this.MinimumSize = new System.Drawing.Size(290, 397);
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
    }
}

