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
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.Location = new System.Drawing.Point(1269, 581);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(50, 31);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1215, 581);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(1161, 581);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(50, 31);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(83, 40);
            this.lblDebug.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(54, 13);
            this.lblDebug.TabIndex = 1;
            this.lblDebug.Text = "Debugger";
            // 
            // lbJobList
            // 
            this.lbJobList.FormattingEnabled = true;
            this.lbJobList.Location = new System.Drawing.Point(42, 94);
            this.lbJobList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbJobList.Name = "lbJobList";
            this.lbJobList.Size = new System.Drawing.Size(103, 56);
            this.lbJobList.TabIndex = 2;
            this.lbJobList.SelectedIndexChanged += new System.EventHandler(this.lbJobList_SelectedIndexChanged);
            this.lbJobList.DoubleClick += new System.EventHandler(this.lbJobList_DoubleClick);
            // 
            // btnAddJob
            // 
            this.btnAddJob.Location = new System.Drawing.Point(42, 153);
            this.btnAddJob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddJob.Name = "btnAddJob";
            this.btnAddJob.Size = new System.Drawing.Size(101, 22);
            this.btnAddJob.TabIndex = 3;
            this.btnAddJob.Text = "Add Job";
            this.btnAddJob.UseVisualStyleBackColor = true;
            this.btnAddJob.Click += new System.EventHandler(this.btnAddJob_Click);
            // 
            // lbAbility
            // 
            this.lbAbility.FormattingEnabled = true;
            this.lbAbility.Location = new System.Drawing.Point(159, 94);
            this.lbAbility.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbAbility.Name = "lbAbility";
            this.lbAbility.Size = new System.Drawing.Size(103, 56);
            this.lbAbility.TabIndex = 2;
            this.lbAbility.SelectedIndexChanged += new System.EventHandler(this.lbJobList_SelectedIndexChanged);
            this.lbAbility.DoubleClick += new System.EventHandler(this.lbJobList_DoubleClick);
            // 
            // btnAddAbility
            // 
            this.btnAddAbility.Location = new System.Drawing.Point(159, 153);
            this.btnAddAbility.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddAbility.Name = "btnAddAbility";
            this.btnAddAbility.Size = new System.Drawing.Size(101, 22);
            this.btnAddAbility.TabIndex = 3;
            this.btnAddAbility.Text = "Add Ability";
            this.btnAddAbility.UseVisualStyleBackColor = true;
            this.btnAddAbility.Click += new System.EventHandler(this.btnAddAbility_Click);
            // 
            // cbJob
            // 
            this.cbJob.FormattingEnabled = true;
            this.cbJob.Location = new System.Drawing.Point(451, 109);
            this.cbJob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(82, 21);
            this.cbJob.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(599, 249);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(82, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // cbLearn
            // 
            this.cbLearn.FormattingEnabled = true;
            this.cbLearn.Location = new System.Drawing.Point(451, 183);
            this.cbLearn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbLearn.Name = "cbLearn";
            this.cbLearn.Size = new System.Drawing.Size(82, 21);
            this.cbLearn.TabIndex = 6;
            // 
            // cbVG
            // 
            this.cbVG.FormattingEnabled = true;
            this.cbVG.Location = new System.Drawing.Point(451, 144);
            this.cbVG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbVG.Name = "cbVG";
            this.cbVG.Size = new System.Drawing.Size(82, 21);
            this.cbVG.TabIndex = 7;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(2, 2);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(82, 21);
            this.comboBox5.TabIndex = 8;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(599, 108);
            this.comboBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(82, 21);
            this.comboBox6.TabIndex = 9;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(599, 144);
            this.comboBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(82, 21);
            this.comboBox7.TabIndex = 10;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(599, 183);
            this.comboBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(82, 21);
            this.comboBox8.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.comboBox5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(495, 341);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(207, 233);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 311);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 331);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 372);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 393);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 414);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "label2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 435);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "label2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(156, 456);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "label2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(156, 476);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "label2";
            // 
            // lblStress
            // 
            this.lblStress.AutoSize = true;
            this.lblStress.Location = new System.Drawing.Point(58, 476);
            this.lblStress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStress.Name = "lblStress";
            this.lblStress.Size = new System.Drawing.Size(36, 13);
            this.lblStress.TabIndex = 15;
            this.lblStress.Text = "Stress";
            // 
            // lblDreams
            // 
            this.lblDreams.AutoSize = true;
            this.lblDreams.Location = new System.Drawing.Point(58, 456);
            this.lblDreams.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDreams.Name = "lblDreams";
            this.lblDreams.Size = new System.Drawing.Size(43, 13);
            this.lblDreams.TabIndex = 16;
            this.lblDreams.Text = "Dreams";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(58, 435);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "Time";
            // 
            // lblSaving
            // 
            this.lblSaving.AutoSize = true;
            this.lblSaving.Location = new System.Drawing.Point(58, 414);
            this.lblSaving.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaving.Name = "lblSaving";
            this.lblSaving.Size = new System.Drawing.Size(40, 13);
            this.lblSaving.TabIndex = 18;
            this.lblSaving.Text = "Saving";
            // 
            // lblKnowledge
            // 
            this.lblKnowledge.AutoSize = true;
            this.lblKnowledge.Location = new System.Drawing.Point(58, 393);
            this.lblKnowledge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKnowledge.Name = "lblKnowledge";
            this.lblKnowledge.Size = new System.Drawing.Size(60, 13);
            this.lblKnowledge.TabIndex = 19;
            this.lblKnowledge.Text = "Knowledge";
            // 
            // lblSocialLife
            // 
            this.lblSocialLife.AutoSize = true;
            this.lblSocialLife.Location = new System.Drawing.Point(58, 372);
            this.lblSocialLife.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSocialLife.Name = "lblSocialLife";
            this.lblSocialLife.Size = new System.Drawing.Size(56, 13);
            this.lblSocialLife.TabIndex = 20;
            this.lblSocialLife.Text = "Social Life";
            // 
            // lblVGCompletion
            // 
            this.lblVGCompletion.AutoSize = true;
            this.lblVGCompletion.Location = new System.Drawing.Point(58, 352);
            this.lblVGCompletion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVGCompletion.Name = "lblVGCompletion";
            this.lblVGCompletion.Size = new System.Drawing.Size(29, 13);
            this.lblVGCompletion.TabIndex = 21;
            this.lblVGCompletion.Text = "VGC";
            // 
            // lblFitness
            // 
            this.lblFitness.AutoSize = true;
            this.lblFitness.Location = new System.Drawing.Point(58, 331);
            this.lblFitness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFitness.Name = "lblFitness";
            this.lblFitness.Size = new System.Drawing.Size(40, 13);
            this.lblFitness.TabIndex = 22;
            this.lblFitness.Text = "Fitness";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(58, 310);
            this.lblIncome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(42, 13);
            this.lblIncome.TabIndex = 23;
            this.lblIncome.Text = "Income";
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.Location = new System.Drawing.Point(58, 290);
            this.lblJobName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(35, 13);
            this.lblJobName.TabIndex = 24;
            this.lblJobName.Text = "Name";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 620);
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
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cbLearn);
            this.Controls.Add(this.cbVG);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.cbJob);
            this.Controls.Add(this.btnAddAbility);
            this.Controls.Add(this.lbAbility);
            this.Controls.Add(this.btnAddJob);
            this.Controls.Add(this.lbJobList);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnQuit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
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
    }
}

