namespace WindowsFormsApplication4
{
    partial class MainWindow
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblDebug = new System.Windows.Forms.Label();
            this.lbJobList = new System.Windows.Forms.ListBox();
            this.btnAddJob = new System.Windows.Forms.Button();
            this.lbAbility = new System.Windows.Forms.ListBox();
            this.btnAddAbility = new System.Windows.Forms.Button();
            this.cbJob = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cbLearn = new System.Windows.Forms.ComboBox();
            this.cbVG = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.flpSupport = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblVGC = new System.Windows.Forms.Label();
            this.lblStress = new System.Windows.Forms.Label();
            this.lblDreams = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSaving = new System.Windows.Forms.Label();
            this.lblKnowledge = new System.Windows.Forms.Label();
            this.lblSocialLife = new System.Windows.Forms.Label();
            this.lblVGCompletion = new System.Windows.Forms.Label();
            this.lblFitness = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblJobName = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblLearn = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblEquip = new System.Windows.Forms.Label();
            this.lblProjects = new System.Windows.Forms.Label();
            this.lblSupport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.Location = new System.Drawing.Point(869, 894);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 48);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(787, 894);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 48);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(707, 894);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 48);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(124, 62);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(80, 20);
            this.lblDebug.TabIndex = 1;
            this.lblDebug.Text = "Debugger";
            // 
            // lbJobList
            // 
            this.lbJobList.FormattingEnabled = true;
            this.lbJobList.ItemHeight = 20;
            this.lbJobList.Location = new System.Drawing.Point(63, 145);
            this.lbJobList.Name = "lbJobList";
            this.lbJobList.Size = new System.Drawing.Size(152, 84);
            this.lbJobList.TabIndex = 2;
            this.lbJobList.SelectedIndexChanged += new System.EventHandler(this.lbJobList_SelectedIndexChanged);
            this.lbJobList.DoubleClick += new System.EventHandler(this.lbJobList_DoubleClick);
            // 
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(63, 235);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(152, 34);
            this.btnAddJob.TabIndex = 3;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // lbAbility
            // 
            this.lbAbility.FormattingEnabled = true;
            this.lbAbility.ItemHeight = 20;
            this.lbAbility.Location = new System.Drawing.Point(238, 145);
            this.lbAbility.Name = "lbAbility";
            this.lbAbility.Size = new System.Drawing.Size(152, 84);
            this.lbAbility.TabIndex = 2;
            this.lbAbility.SelectedIndexChanged += new System.EventHandler(this.lbJobList_SelectedIndexChanged);
            this.lbAbility.DoubleClick += new System.EventHandler(this.lbJobList_DoubleClick);
            // 
            // btnAddAbility
            // 
            this.btnAddAbility.Location = new System.Drawing.Point(238, 235);
            this.btnAddAbility.Name = "btnAddAbility";
            this.btnAddAbility.Size = new System.Drawing.Size(152, 34);
            this.btnAddAbility.TabIndex = 3;
            this.btnAddAbility.Text = "Add Ability";
            this.btnAddAbility.UseVisualStyleBackColor = true;
            this.btnAddAbility.Click += new System.EventHandler(this.btnAddAbility_Click);
            // 
            // cbJob
            // 
            this.cbJob.FormattingEnabled = true;
            this.cbJob.Location = new System.Drawing.Point(547, 130);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(121, 28);
            this.cbJob.TabIndex = 4;
            this.cbJob.SelectedIndexChanged += new System.EventHandler(this.cbJob_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(539, 749);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 5;
            // 
            // cbLearn
            // 
            this.cbLearn.FormattingEnabled = true;
            this.cbLearn.Location = new System.Drawing.Point(547, 244);
            this.cbLearn.Name = "cbLearn";
            this.cbLearn.Size = new System.Drawing.Size(121, 28);
            this.cbLearn.TabIndex = 6;
            // 
            // cbVG
            // 
            this.cbVG.FormattingEnabled = true;
            this.cbVG.Location = new System.Drawing.Point(547, 184);
            this.cbVG.Name = "cbVG";
            this.cbVG.Size = new System.Drawing.Size(121, 28);
            this.cbVG.TabIndex = 7;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(539, 588);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 28);
            this.comboBox7.TabIndex = 10;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(539, 648);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 28);
            this.comboBox8.TabIndex = 11;
            // 
            // flpSupport
            // 
            this.flpSupport.Location = new System.Drawing.Point(742, 525);
            this.flpSupport.Name = "flpSupport";
            this.flpSupport.Size = new System.Drawing.Size(195, 358);
            this.flpSupport.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 755);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 542);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 572);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 605);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 637);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "label2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 669);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "label2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 702);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "label2";
            // 
            // lblVGC
            // 
            this.lblVGC.AutoSize = true;
            this.lblVGC.Location = new System.Drawing.Point(234, 732);
            this.lblVGC.Name = "lblVGC";
            this.lblVGC.Size = new System.Drawing.Size(51, 20);
            this.lblVGC.TabIndex = 14;
            this.lblVGC.Text = "label2";
            // 
            // lblStress
            // 
            this.lblStress.AutoSize = true;
            this.lblStress.Location = new System.Drawing.Point(87, 732);
            this.lblStress.Name = "lblStress";
            this.lblStress.Size = new System.Drawing.Size(55, 20);
            this.lblStress.TabIndex = 15;
            this.lblStress.Text = "Stress";
            // 
            // lblDreams
            // 
            this.lblDreams.AutoSize = true;
            this.lblDreams.Location = new System.Drawing.Point(87, 702);
            this.lblDreams.Name = "lblDreams";
            this.lblDreams.Size = new System.Drawing.Size(65, 20);
            this.lblDreams.TabIndex = 16;
            this.lblDreams.Text = "Dreams";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(87, 669);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 20);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "Time";
            // 
            // lblSaving
            // 
            this.lblSaving.AutoSize = true;
            this.lblSaving.Location = new System.Drawing.Point(87, 637);
            this.lblSaving.Name = "lblSaving";
            this.lblSaving.Size = new System.Drawing.Size(57, 20);
            this.lblSaving.TabIndex = 18;
            this.lblSaving.Text = "Saving";
            // 
            // lblKnowledge
            // 
            this.lblKnowledge.AutoSize = true;
            this.lblKnowledge.Location = new System.Drawing.Point(87, 605);
            this.lblKnowledge.Name = "lblKnowledge";
            this.lblKnowledge.Size = new System.Drawing.Size(87, 20);
            this.lblKnowledge.TabIndex = 19;
            this.lblKnowledge.Text = "Knowledge";
            // 
            // lblSocialLife
            // 
            this.lblSocialLife.AutoSize = true;
            this.lblSocialLife.Location = new System.Drawing.Point(87, 572);
            this.lblSocialLife.Name = "lblSocialLife";
            this.lblSocialLife.Size = new System.Drawing.Size(82, 20);
            this.lblSocialLife.TabIndex = 20;
            this.lblSocialLife.Text = "Social Life";
            // 
            // lblVGCompletion
            // 
            this.lblVGCompletion.AutoSize = true;
            this.lblVGCompletion.Location = new System.Drawing.Point(87, 542);
            this.lblVGCompletion.Name = "lblVGCompletion";
            this.lblVGCompletion.Size = new System.Drawing.Size(44, 20);
            this.lblVGCompletion.TabIndex = 21;
            this.lblVGCompletion.Text = "VGC";
            // 
            // lblFitness
            // 
            this.lblFitness.AutoSize = true;
            this.lblFitness.Location = new System.Drawing.Point(87, 509);
            this.lblFitness.Name = "lblFitness";
            this.lblFitness.Size = new System.Drawing.Size(61, 20);
            this.lblFitness.TabIndex = 22;
            this.lblFitness.Text = "Fitness";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(87, 477);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(62, 20);
            this.lblIncome.TabIndex = 23;
            this.lblIncome.Text = "Income";
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.Location = new System.Drawing.Point(87, 446);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(51, 20);
            this.lblJobName.TabIndex = 24;
            this.lblJobName.Text = "Name";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(451, 137);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(35, 20);
            this.lblJob.TabIndex = 25;
            this.lblJob.Text = "Job";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(442, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "VGC";
            // 
            // lblLearn
            // 
            this.lblLearn.AutoSize = true;
            this.lblLearn.Location = new System.Drawing.Point(436, 244);
            this.lblLearn.Name = "lblLearn";
            this.lblLearn.Size = new System.Drawing.Size(50, 20);
            this.lblLearn.TabIndex = 27;
            this.lblLearn.Text = "Learn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(389, 532);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "label10";
            // 
            // lblEquip
            // 
            this.lblEquip.AutoSize = true;
            this.lblEquip.Location = new System.Drawing.Point(565, 94);
            this.lblEquip.Name = "lblEquip";
            this.lblEquip.Size = new System.Drawing.Size(86, 20);
            this.lblEquip.TabIndex = 29;
            this.lblEquip.Text = "Equipment";
            // 
            // lblProjects
            // 
            this.lblProjects.AutoSize = true;
            this.lblProjects.Location = new System.Drawing.Point(528, 457);
            this.lblProjects.Name = "lblProjects";
            this.lblProjects.Size = new System.Drawing.Size(66, 20);
            this.lblProjects.TabIndex = 30;
            this.lblProjects.Text = "Projects";
            // 
            // lblSupport
            // 
            this.lblSupport.AutoSize = true;
            this.lblSupport.Location = new System.Drawing.Point(741, 457);
            this.lblSupport.Name = "lblSupport";
            this.lblSupport.Size = new System.Drawing.Size(66, 20);
            this.lblSupport.TabIndex = 31;
            this.lblSupport.Text = "Support";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 954);
            this.Controls.Add(this.lblSupport);
            this.Controls.Add(this.lblProjects);
            this.Controls.Add(this.lblEquip);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblLearn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblStress);
            this.Controls.Add(this.lblDreams);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblSaving);
            this.Controls.Add(this.lblKnowledge);
            this.Controls.Add(this.lblSocialLife);
            this.Controls.Add(this.lblVGCompletion);
            this.Controls.Add(this.lblFitness);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.lblJobName);
            this.Controls.Add(this.lblVGC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpSupport);
            this.Controls.Add(this.cbLearn);
            this.Controls.Add(this.cbVG);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cbJob);
            this.Controls.Add(this.btnAddAbility);
            this.Controls.Add(this.lbAbility);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.lbJobList);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnQuit);
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.ListBox lbJobList;
        private System.Windows.Forms.Button btnAddJob;
        private System.Windows.Forms.ListBox lbAbility;
        private System.Windows.Forms.Button btnAddAbility;
        private System.Windows.Forms.ComboBox cbJob;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cbLearn;
        private System.Windows.Forms.ComboBox cbVG;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.FlowLayoutPanel flpSupport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblVGC;
        private System.Windows.Forms.Label lblStress;
        private System.Windows.Forms.Label lblDreams;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSaving;
        private System.Windows.Forms.Label lblKnowledge;
        private System.Windows.Forms.Label lblSocialLife;
        private System.Windows.Forms.Label lblVGCompletion;
        private System.Windows.Forms.Label lblFitness;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblJobName;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblLearn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblEquip;
        private System.Windows.Forms.Label lblProjects;
        private System.Windows.Forms.Label lblSupport;
    }
}

