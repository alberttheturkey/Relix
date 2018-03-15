namespace WindowsFormsApplication4
{
    partial class AbilityEditor
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
            this.spProjects = new System.Windows.Forms.NumericUpDown();
            this.spSupport = new System.Windows.Forms.NumericUpDown();
            this.lblMultiplayer = new System.Windows.Forms.Label();
            this.lblApplying = new System.Windows.Forms.Label();
            this.lblTVShows = new System.Windows.Forms.Label();
            this.lblMovies = new System.Windows.Forms.Label();
            this.lbBooks = new System.Windows.Forms.Label();
            this.spExperience = new System.Windows.Forms.NumericUpDown();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblAbilityName = new System.Windows.Forms.Label();
            this.tbAbilityName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveJob = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblAbilityDescription = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.cbBooks = new System.Windows.Forms.CheckBox();
            this.cbMovies = new System.Windows.Forms.CheckBox();
            this.cbTVShows = new System.Windows.Forms.CheckBox();
            this.cbApplying = new System.Windows.Forms.CheckBox();
            this.cbMultiplayer = new System.Windows.Forms.CheckBox();
            this.cbSingleplayer = new System.Windows.Forms.CheckBox();
            this.cbParties = new System.Windows.Forms.CheckBox();
            this.cbGym = new System.Windows.Forms.CheckBox();
            this.lblSinglePlayer = new System.Windows.Forms.Label();
            this.lblParties = new System.Windows.Forms.Label();
            this.lblGym = new System.Windows.Forms.Label();
            this.lblESupport = new System.Windows.Forms.Label();
            this.lblEProjects = new System.Windows.Forms.Label();
            this.lblLate = new System.Windows.Forms.Label();
            this.cbLate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.spProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSupport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spExperience)).BeginInit();
            this.SuspendLayout();
            // 
            // spProjects
            // 
            this.spProjects.Location = new System.Drawing.Point(120, 439);
            this.spProjects.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.spProjects.Name = "spProjects";
            this.spProjects.Size = new System.Drawing.Size(120, 26);
            this.spProjects.TabIndex = 22;
            this.spProjects.ValueChanged += new System.EventHandler(this.spProjects_ValueChanged);
            // 
            // spSupport
            // 
            this.spSupport.Location = new System.Drawing.Point(120, 407);
            this.spSupport.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.spSupport.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.spSupport.Name = "spSupport";
            this.spSupport.Size = new System.Drawing.Size(120, 26);
            this.spSupport.TabIndex = 23;
            this.spSupport.ValueChanged += new System.EventHandler(this.spSupport_ValueChanged);
            // 
            // lblMultiplayer
            // 
            this.lblMultiplayer.AutoSize = true;
            this.lblMultiplayer.Location = new System.Drawing.Point(45, 243);
            this.lblMultiplayer.Name = "lblMultiplayer";
            this.lblMultiplayer.Size = new System.Drawing.Size(222, 20);
            this.lblMultiplayer.TabIndex = 20;
            this.lblMultiplayer.Text = "Able to play Multiplayer games";
            // 
            // lblApplying
            // 
            this.lblApplying.AutoSize = true;
            this.lblApplying.Location = new System.Drawing.Point(45, 212);
            this.lblApplying.Name = "lblApplying";
            this.lblApplying.Size = new System.Drawing.Size(156, 20);
            this.lblApplying.TabIndex = 18;
            this.lblApplying.Text = "Able to apply for jobs";
            // 
            // lblTVShows
            // 
            this.lblTVShows.AutoSize = true;
            this.lblTVShows.Location = new System.Drawing.Point(45, 181);
            this.lblTVShows.Name = "lblTVShows";
            this.lblTVShows.Size = new System.Drawing.Size(181, 20);
            this.lblTVShows.TabIndex = 16;
            this.lblTVShows.Text = "Able to watch TV Shows";
            // 
            // lblMovies
            // 
            this.lblMovies.AutoSize = true;
            this.lblMovies.Location = new System.Drawing.Point(45, 150);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Size = new System.Drawing.Size(162, 20);
            this.lblMovies.TabIndex = 17;
            this.lblMovies.Text = "Able to Watch Movies";
            // 
            // lbBooks
            // 
            this.lbBooks.AutoSize = true;
            this.lbBooks.Location = new System.Drawing.Point(45, 119);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(151, 20);
            this.lbBooks.TabIndex = 15;
            this.lbBooks.Text = "Able to Read Books";
            this.lbBooks.Click += new System.EventHandler(this.lblVGCompletion_Click);
            // 
            // spExperience
            // 
            this.spExperience.Location = new System.Drawing.Point(121, 79);
            this.spExperience.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.spExperience.Name = "spExperience";
            this.spExperience.Size = new System.Drawing.Size(120, 26);
            this.spExperience.TabIndex = 27;
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(13, 81);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(88, 20);
            this.lblExperience.TabIndex = 14;
            this.lblExperience.Text = "Experience";
            // 
            // lblAbilityName
            // 
            this.lblAbilityName.AutoSize = true;
            this.lblAbilityName.Location = new System.Drawing.Point(13, 18);
            this.lblAbilityName.Name = "lblAbilityName";
            this.lblAbilityName.Size = new System.Drawing.Size(51, 20);
            this.lblAbilityName.TabIndex = 9;
            this.lblAbilityName.Text = "Name";
            // 
            // tbAbilityName
            // 
            this.tbAbilityName.Location = new System.Drawing.Point(121, 15);
            this.tbAbilityName.Name = "tbAbilityName";
            this.tbAbilityName.Size = new System.Drawing.Size(467, 26);
            this.tbAbilityName.TabIndex = 8;
            this.tbAbilityName.TextChanged += new System.EventHandler(this.tbAbilityName_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(440, 427);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 43);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSaveJob
            // 
            this.btnSaveJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveJob.Location = new System.Drawing.Point(289, 427);
            this.btnSaveJob.Name = "btnSaveJob";
            this.btnSaveJob.Size = new System.Drawing.Size(145, 43);
            this.btnSaveJob.TabIndex = 6;
            this.btnSaveJob.Text = "Save";
            this.btnSaveJob.UseVisualStyleBackColor = true;
            this.btnSaveJob.Click += new System.EventHandler(this.btnSaveJob_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(121, 49);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(467, 26);
            this.tbDescription.TabIndex = 8;
            // 
            // lblAbilityDescription
            // 
            this.lblAbilityDescription.AutoSize = true;
            this.lblAbilityDescription.Location = new System.Drawing.Point(13, 52);
            this.lblAbilityDescription.Name = "lblAbilityDescription";
            this.lblAbilityDescription.Size = new System.Drawing.Size(89, 20);
            this.lblAbilityDescription.TabIndex = 9;
            this.lblAbilityDescription.Text = "Description";
            // 
            // cbBooks
            // 
            this.cbBooks.AutoSize = true;
            this.cbBooks.Location = new System.Drawing.Point(18, 119);
            this.cbBooks.Name = "cbBooks";
            this.cbBooks.Size = new System.Drawing.Size(22, 21);
            this.cbBooks.TabIndex = 32;
            this.cbBooks.UseVisualStyleBackColor = true;
            // 
            // cbMovies
            // 
            this.cbMovies.AutoSize = true;
            this.cbMovies.Location = new System.Drawing.Point(18, 150);
            this.cbMovies.Name = "cbMovies";
            this.cbMovies.Size = new System.Drawing.Size(22, 21);
            this.cbMovies.TabIndex = 32;
            this.cbMovies.UseVisualStyleBackColor = true;
            // 
            // cbTVShows
            // 
            this.cbTVShows.AutoSize = true;
            this.cbTVShows.Location = new System.Drawing.Point(18, 181);
            this.cbTVShows.Name = "cbTVShows";
            this.cbTVShows.Size = new System.Drawing.Size(22, 21);
            this.cbTVShows.TabIndex = 32;
            this.cbTVShows.UseVisualStyleBackColor = true;
            // 
            // cbApplying
            // 
            this.cbApplying.AutoSize = true;
            this.cbApplying.Location = new System.Drawing.Point(18, 212);
            this.cbApplying.Name = "cbApplying";
            this.cbApplying.Size = new System.Drawing.Size(22, 21);
            this.cbApplying.TabIndex = 32;
            this.cbApplying.UseVisualStyleBackColor = true;
            // 
            // cbMultiplayer
            // 
            this.cbMultiplayer.AutoSize = true;
            this.cbMultiplayer.Location = new System.Drawing.Point(18, 243);
            this.cbMultiplayer.Name = "cbMultiplayer";
            this.cbMultiplayer.Size = new System.Drawing.Size(22, 21);
            this.cbMultiplayer.TabIndex = 32;
            this.cbMultiplayer.UseVisualStyleBackColor = true;
            // 
            // cbSingleplayer
            // 
            this.cbSingleplayer.AutoSize = true;
            this.cbSingleplayer.Location = new System.Drawing.Point(18, 274);
            this.cbSingleplayer.Name = "cbSingleplayer";
            this.cbSingleplayer.Size = new System.Drawing.Size(22, 21);
            this.cbSingleplayer.TabIndex = 32;
            this.cbSingleplayer.UseVisualStyleBackColor = true;
            // 
            // cbParties
            // 
            this.cbParties.AutoSize = true;
            this.cbParties.Location = new System.Drawing.Point(18, 305);
            this.cbParties.Name = "cbParties";
            this.cbParties.Size = new System.Drawing.Size(22, 21);
            this.cbParties.TabIndex = 32;
            this.cbParties.UseVisualStyleBackColor = true;
            // 
            // cbGym
            // 
            this.cbGym.AutoSize = true;
            this.cbGym.Location = new System.Drawing.Point(18, 336);
            this.cbGym.Name = "cbGym";
            this.cbGym.Size = new System.Drawing.Size(22, 21);
            this.cbGym.TabIndex = 32;
            this.cbGym.UseVisualStyleBackColor = true;
            // 
            // lblSinglePlayer
            // 
            this.lblSinglePlayer.AutoSize = true;
            this.lblSinglePlayer.Location = new System.Drawing.Point(46, 274);
            this.lblSinglePlayer.Name = "lblSinglePlayer";
            this.lblSinglePlayer.Size = new System.Drawing.Size(233, 20);
            this.lblSinglePlayer.TabIndex = 15;
            this.lblSinglePlayer.Text = "Able to play Singleplayer games";
            // 
            // lblParties
            // 
            this.lblParties.AutoSize = true;
            this.lblParties.Location = new System.Drawing.Point(46, 305);
            this.lblParties.Name = "lblParties";
            this.lblParties.Size = new System.Drawing.Size(162, 20);
            this.lblParties.TabIndex = 17;
            this.lblParties.Text = "Able to attend Parties";
            // 
            // lblGym
            // 
            this.lblGym.AutoSize = true;
            this.lblGym.Location = new System.Drawing.Point(46, 336);
            this.lblGym.Name = "lblGym";
            this.lblGym.Size = new System.Drawing.Size(173, 20);
            this.lblGym.TabIndex = 16;
            this.lblGym.Text = "Able to attend the Gym";
            // 
            // lblESupport
            // 
            this.lblESupport.AutoSize = true;
            this.lblESupport.Location = new System.Drawing.Point(13, 407);
            this.lblESupport.Name = "lblESupport";
            this.lblESupport.Size = new System.Drawing.Size(107, 20);
            this.lblESupport.TabIndex = 18;
            this.lblESupport.Text = "Extra Support";
            // 
            // lblEProjects
            // 
            this.lblEProjects.AutoSize = true;
            this.lblEProjects.Location = new System.Drawing.Point(13, 439);
            this.lblEProjects.Name = "lblEProjects";
            this.lblEProjects.Size = new System.Drawing.Size(107, 20);
            this.lblEProjects.TabIndex = 20;
            this.lblEProjects.Text = "Extra Projects";
            // 
            // lblLate
            // 
            this.lblLate.AutoSize = true;
            this.lblLate.Location = new System.Drawing.Point(46, 367);
            this.lblLate.Name = "lblLate";
            this.lblLate.Size = new System.Drawing.Size(144, 20);
            this.lblLate.TabIndex = 16;
            this.lblLate.Text = "Able to stay up late";
            // 
            // cbLate
            // 
            this.cbLate.AutoSize = true;
            this.cbLate.Location = new System.Drawing.Point(18, 367);
            this.cbLate.Name = "cbLate";
            this.cbLate.Size = new System.Drawing.Size(22, 21);
            this.cbLate.TabIndex = 32;
            this.cbLate.UseVisualStyleBackColor = true;
            // 
            // AbilityEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 482);
            this.Controls.Add(this.cbLate);
            this.Controls.Add(this.cbGym);
            this.Controls.Add(this.cbParties);
            this.Controls.Add(this.cbSingleplayer);
            this.Controls.Add(this.cbMultiplayer);
            this.Controls.Add(this.cbApplying);
            this.Controls.Add(this.cbTVShows);
            this.Controls.Add(this.cbMovies);
            this.Controls.Add(this.cbBooks);
            this.Controls.Add(this.spProjects);
            this.Controls.Add(this.spSupport);
            this.Controls.Add(this.lblEProjects);
            this.Controls.Add(this.lblESupport);
            this.Controls.Add(this.lblLate);
            this.Controls.Add(this.lblMultiplayer);
            this.Controls.Add(this.lblGym);
            this.Controls.Add(this.lblApplying);
            this.Controls.Add(this.lblParties);
            this.Controls.Add(this.lblTVShows);
            this.Controls.Add(this.lblSinglePlayer);
            this.Controls.Add(this.lblMovies);
            this.Controls.Add(this.lbBooks);
            this.Controls.Add(this.spExperience);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblAbilityDescription);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblAbilityName);
            this.Controls.Add(this.tbAbilityName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveJob);
            this.Name = "AbilityEditor";
            this.Text = "AbilityEditor";
            ((System.ComponentModel.ISupportInitialize)(this.spProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSupport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spExperience)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown spProjects;
        private System.Windows.Forms.NumericUpDown spSupport;
        private System.Windows.Forms.Label lblMultiplayer;
        private System.Windows.Forms.Label lblApplying;
        private System.Windows.Forms.Label lblTVShows;
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.Label lbBooks;
        private System.Windows.Forms.NumericUpDown spExperience;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblAbilityName;
        private System.Windows.Forms.TextBox tbAbilityName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveJob;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblAbilityDescription;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.CheckBox cbBooks;
        private System.Windows.Forms.CheckBox cbMovies;
        private System.Windows.Forms.CheckBox cbTVShows;
        private System.Windows.Forms.CheckBox cbApplying;
        private System.Windows.Forms.CheckBox cbMultiplayer;
        private System.Windows.Forms.CheckBox cbSingleplayer;
        private System.Windows.Forms.CheckBox cbParties;
        private System.Windows.Forms.CheckBox cbGym;
        private System.Windows.Forms.Label lblSinglePlayer;
        private System.Windows.Forms.Label lblParties;
        private System.Windows.Forms.Label lblGym;
        private System.Windows.Forms.Label lblESupport;
        private System.Windows.Forms.Label lblEProjects;
        private System.Windows.Forms.Label lblLate;
        private System.Windows.Forms.CheckBox cbLate;
    }
}