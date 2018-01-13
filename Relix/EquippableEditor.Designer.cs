namespace WindowsFormsApplication4
{
    partial class EquippableEditor
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
            this.btnSaveJob = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbJobName = new System.Windows.Forms.TextBox();
            this.lblJobName = new System.Windows.Forms.Label();
            this.spIncome = new System.Windows.Forms.NumericUpDown();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblFitness = new System.Windows.Forms.Label();
            this.spFitness = new System.Windows.Forms.NumericUpDown();
            this.lblVGCompletion = new System.Windows.Forms.Label();
            this.spVGCompletion = new System.Windows.Forms.NumericUpDown();
            this.lblSocialLife = new System.Windows.Forms.Label();
            this.spSocialLife = new System.Windows.Forms.NumericUpDown();
            this.lblKnowledge = new System.Windows.Forms.Label();
            this.spKnowledge = new System.Windows.Forms.NumericUpDown();
            this.lblSaving = new System.Windows.Forms.Label();
            this.spSaving = new System.Windows.Forms.NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.spTime = new System.Windows.Forms.NumericUpDown();
            this.lblDreams = new System.Windows.Forms.Label();
            this.spDreams = new System.Windows.Forms.NumericUpDown();
            this.lblStress = new System.Windows.Forms.Label();
            this.spStress = new System.Windows.Forms.NumericUpDown();
            this.cbAbilityBoost = new System.Windows.Forms.ComboBox();
            this.lblAbilityBoost = new System.Windows.Forms.Label();
            this.lblBoostAmount = new System.Windows.Forms.Label();
            this.spBoostAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAbilityAdd = new System.Windows.Forms.Label();
            this.cbAbilityAdd = new System.Windows.Forms.ComboBox();
            this.lbAbilityList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.spIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spFitness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spVGCompletion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSocialLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spKnowledge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSaving)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDreams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spStress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBoostAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveJob
            // 
            this.btnSaveJob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveJob.Location = new System.Drawing.Point(412, 322);
            this.btnSaveJob.Name = "btnSaveJob";
            this.btnSaveJob.Size = new System.Drawing.Size(145, 43);
            this.btnSaveJob.TabIndex = 0;
            this.btnSaveJob.Text = "Save";
            this.btnSaveJob.UseVisualStyleBackColor = true;
            this.btnSaveJob.Click += new System.EventHandler(this.btnSaveJob_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(579, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 43);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbJobName
            // 
            this.tbJobName.Location = new System.Drawing.Point(120, 6);
            this.tbJobName.Name = "tbJobName";
            this.tbJobName.Size = new System.Drawing.Size(467, 26);
            this.tbJobName.TabIndex = 1;
            this.tbJobName.TextChanged += new System.EventHandler(this.tbJobName_TextChanged);
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.Location = new System.Drawing.Point(12, 9);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(51, 20);
            this.lblJobName.TabIndex = 2;
            this.lblJobName.Text = "Name";
            // 
            // spIncome
            // 
            this.spIncome.Location = new System.Drawing.Point(120, 38);
            this.spIncome.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.spIncome.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.spIncome.Name = "spIncome";
            this.spIncome.Size = new System.Drawing.Size(120, 26);
            this.spIncome.TabIndex = 3;
            this.spIncome.ValueChanged += new System.EventHandler(this.spIncome_ValueChanged);
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(12, 40);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(62, 20);
            this.lblIncome.TabIndex = 2;
            this.lblIncome.Text = "Income";
            // 
            // lblFitness
            // 
            this.lblFitness.AutoSize = true;
            this.lblFitness.Location = new System.Drawing.Point(12, 72);
            this.lblFitness.Name = "lblFitness";
            this.lblFitness.Size = new System.Drawing.Size(61, 20);
            this.lblFitness.TabIndex = 2;
            this.lblFitness.Text = "Fitness";
            // 
            // spFitness
            // 
            this.spFitness.Location = new System.Drawing.Point(120, 70);
            this.spFitness.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.spFitness.Name = "spFitness";
            this.spFitness.Size = new System.Drawing.Size(120, 26);
            this.spFitness.TabIndex = 3;
            this.spFitness.ValueChanged += new System.EventHandler(this.spFitness_ValueChanged);
            // 
            // lblVGCompletion
            // 
            this.lblVGCompletion.AutoSize = true;
            this.lblVGCompletion.Location = new System.Drawing.Point(12, 104);
            this.lblVGCompletion.Name = "lblVGCompletion";
            this.lblVGCompletion.Size = new System.Drawing.Size(44, 20);
            this.lblVGCompletion.TabIndex = 2;
            this.lblVGCompletion.Text = "VGC";
            this.lblVGCompletion.Click += new System.EventHandler(this.lblVGCompletion_Click);
            // 
            // spVGCompletion
            // 
            this.spVGCompletion.Location = new System.Drawing.Point(120, 102);
            this.spVGCompletion.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.spVGCompletion.Name = "spVGCompletion";
            this.spVGCompletion.Size = new System.Drawing.Size(120, 26);
            this.spVGCompletion.TabIndex = 3;
            this.spVGCompletion.ValueChanged += new System.EventHandler(this.spVGCompletion_ValueChanged);
            // 
            // lblSocialLife
            // 
            this.lblSocialLife.AutoSize = true;
            this.lblSocialLife.Location = new System.Drawing.Point(12, 136);
            this.lblSocialLife.Name = "lblSocialLife";
            this.lblSocialLife.Size = new System.Drawing.Size(82, 20);
            this.lblSocialLife.TabIndex = 2;
            this.lblSocialLife.Text = "Social Life";
            // 
            // spSocialLife
            // 
            this.spSocialLife.Location = new System.Drawing.Point(120, 134);
            this.spSocialLife.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.spSocialLife.Name = "spSocialLife";
            this.spSocialLife.Size = new System.Drawing.Size(120, 26);
            this.spSocialLife.TabIndex = 3;
            this.spSocialLife.ValueChanged += new System.EventHandler(this.spSocialLife_ValueChanged);
            // 
            // lblKnowledge
            // 
            this.lblKnowledge.AutoSize = true;
            this.lblKnowledge.Location = new System.Drawing.Point(12, 168);
            this.lblKnowledge.Name = "lblKnowledge";
            this.lblKnowledge.Size = new System.Drawing.Size(87, 20);
            this.lblKnowledge.TabIndex = 2;
            this.lblKnowledge.Text = "Knowledge";
            // 
            // spKnowledge
            // 
            this.spKnowledge.Location = new System.Drawing.Point(120, 166);
            this.spKnowledge.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.spKnowledge.Name = "spKnowledge";
            this.spKnowledge.Size = new System.Drawing.Size(120, 26);
            this.spKnowledge.TabIndex = 3;
            this.spKnowledge.ValueChanged += new System.EventHandler(this.spKnowledge_ValueChanged);
            // 
            // lblSaving
            // 
            this.lblSaving.AutoSize = true;
            this.lblSaving.Location = new System.Drawing.Point(12, 200);
            this.lblSaving.Name = "lblSaving";
            this.lblSaving.Size = new System.Drawing.Size(57, 20);
            this.lblSaving.TabIndex = 2;
            this.lblSaving.Text = "Saving";
            // 
            // spSaving
            // 
            this.spSaving.Location = new System.Drawing.Point(120, 198);
            this.spSaving.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.spSaving.Name = "spSaving";
            this.spSaving.Size = new System.Drawing.Size(120, 26);
            this.spSaving.TabIndex = 3;
            this.spSaving.ValueChanged += new System.EventHandler(this.spSaving_ValueChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 232);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 20);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time";
            // 
            // spTime
            // 
            this.spTime.Location = new System.Drawing.Point(120, 230);
            this.spTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.spTime.Name = "spTime";
            this.spTime.Size = new System.Drawing.Size(120, 26);
            this.spTime.TabIndex = 3;
            this.spTime.ValueChanged += new System.EventHandler(this.spTime_ValueChanged);
            // 
            // lblDreams
            // 
            this.lblDreams.AutoSize = true;
            this.lblDreams.Location = new System.Drawing.Point(12, 264);
            this.lblDreams.Name = "lblDreams";
            this.lblDreams.Size = new System.Drawing.Size(65, 20);
            this.lblDreams.TabIndex = 2;
            this.lblDreams.Text = "Dreams";
            // 
            // spDreams
            // 
            this.spDreams.Location = new System.Drawing.Point(120, 262);
            this.spDreams.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.spDreams.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.spDreams.Name = "spDreams";
            this.spDreams.Size = new System.Drawing.Size(120, 26);
            this.spDreams.TabIndex = 3;
            this.spDreams.ValueChanged += new System.EventHandler(this.spDreams_ValueChanged);
            // 
            // lblStress
            // 
            this.lblStress.AutoSize = true;
            this.lblStress.Location = new System.Drawing.Point(12, 296);
            this.lblStress.Name = "lblStress";
            this.lblStress.Size = new System.Drawing.Size(55, 20);
            this.lblStress.TabIndex = 2;
            this.lblStress.Text = "Stress";
            // 
            // spStress
            // 
            this.spStress.Location = new System.Drawing.Point(120, 294);
            this.spStress.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.spStress.Name = "spStress";
            this.spStress.Size = new System.Drawing.Size(120, 26);
            this.spStress.TabIndex = 3;
            this.spStress.ValueChanged += new System.EventHandler(this.spStress_ValueChanged);
            // 
            // cbAbilityBoost
            // 
            this.cbAbilityBoost.FormattingEnabled = true;
            this.cbAbilityBoost.Location = new System.Drawing.Point(404, 41);
            this.cbAbilityBoost.Name = "cbAbilityBoost";
            this.cbAbilityBoost.Size = new System.Drawing.Size(320, 28);
            this.cbAbilityBoost.TabIndex = 4;
            // 
            // lblAbilityBoost
            // 
            this.lblAbilityBoost.AutoSize = true;
            this.lblAbilityBoost.Location = new System.Drawing.Point(266, 44);
            this.lblAbilityBoost.Name = "lblAbilityBoost";
            this.lblAbilityBoost.Size = new System.Drawing.Size(118, 20);
            this.lblAbilityBoost.TabIndex = 2;
            this.lblAbilityBoost.Text = "Ability To Boost";
            // 
            // lblBoostAmount
            // 
            this.lblBoostAmount.AutoSize = true;
            this.lblBoostAmount.Location = new System.Drawing.Point(266, 76);
            this.lblBoostAmount.Name = "lblBoostAmount";
            this.lblBoostAmount.Size = new System.Drawing.Size(111, 20);
            this.lblBoostAmount.TabIndex = 2;
            this.lblBoostAmount.Text = "Boost Amount";
            // 
            // spBoostAmount
            // 
            this.spBoostAmount.Location = new System.Drawing.Point(404, 76);
            this.spBoostAmount.Name = "spBoostAmount";
            this.spBoostAmount.Size = new System.Drawing.Size(120, 26);
            this.spBoostAmount.TabIndex = 3;
            // 
            // lblAbilityAdd
            // 
            this.lblAbilityAdd.AutoSize = true;
            this.lblAbilityAdd.Location = new System.Drawing.Point(266, 108);
            this.lblAbilityAdd.Name = "lblAbilityAdd";
            this.lblAbilityAdd.Size = new System.Drawing.Size(105, 20);
            this.lblAbilityAdd.TabIndex = 2;
            this.lblAbilityAdd.Text = "Add an Ability";
            // 
            // cbAbilityAdd
            // 
            this.cbAbilityAdd.FormattingEnabled = true;
            this.cbAbilityAdd.Location = new System.Drawing.Point(270, 133);
            this.cbAbilityAdd.Name = "cbAbilityAdd";
            this.cbAbilityAdd.Size = new System.Drawing.Size(454, 28);
            this.cbAbilityAdd.TabIndex = 4;
            this.cbAbilityAdd.SelectedIndexChanged += new System.EventHandler(this.cbAbilityAdd_SelectedIndexChanged);
            // 
            // lbAbilityList
            // 
            this.lbAbilityList.FormattingEnabled = true;
            this.lbAbilityList.ItemHeight = 20;
            this.lbAbilityList.Location = new System.Drawing.Point(270, 166);
            this.lbAbilityList.Name = "lbAbilityList";
            this.lbAbilityList.Size = new System.Drawing.Size(454, 144);
            this.lbAbilityList.TabIndex = 5;
            // 
            // EquippableEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 377);
            this.Controls.Add(this.lbAbilityList);
            this.Controls.Add(this.cbAbilityAdd);
            this.Controls.Add(this.cbAbilityBoost);
            this.Controls.Add(this.spStress);
            this.Controls.Add(this.lblStress);
            this.Controls.Add(this.spDreams);
            this.Controls.Add(this.lblDreams);
            this.Controls.Add(this.spTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.spSaving);
            this.Controls.Add(this.lblSaving);
            this.Controls.Add(this.spKnowledge);
            this.Controls.Add(this.lblKnowledge);
            this.Controls.Add(this.spSocialLife);
            this.Controls.Add(this.lblSocialLife);
            this.Controls.Add(this.spVGCompletion);
            this.Controls.Add(this.lblVGCompletion);
            this.Controls.Add(this.spFitness);
            this.Controls.Add(this.lblFitness);
            this.Controls.Add(this.spBoostAmount);
            this.Controls.Add(this.spIncome);
            this.Controls.Add(this.lblAbilityAdd);
            this.Controls.Add(this.lblBoostAmount);
            this.Controls.Add(this.lblAbilityBoost);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.lblJobName);
            this.Controls.Add(this.tbJobName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveJob);
            this.Name = "EquippableEditor";
            this.Text = "JobEditor";
            ((System.ComponentModel.ISupportInitialize)(this.spIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spFitness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spVGCompletion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSocialLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spKnowledge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spSaving)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spDreams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spStress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spBoostAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveJob;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbJobName;
        private System.Windows.Forms.Label lblJobName;
        private System.Windows.Forms.NumericUpDown spIncome;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblFitness;
        private System.Windows.Forms.NumericUpDown spFitness;
        private System.Windows.Forms.Label lblVGCompletion;
        private System.Windows.Forms.NumericUpDown spVGCompletion;
        private System.Windows.Forms.Label lblSocialLife;
        private System.Windows.Forms.NumericUpDown spSocialLife;
        private System.Windows.Forms.Label lblKnowledge;
        private System.Windows.Forms.NumericUpDown spKnowledge;
        private System.Windows.Forms.Label lblSaving;
        private System.Windows.Forms.NumericUpDown spSaving;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.NumericUpDown spTime;
        private System.Windows.Forms.Label lblDreams;
        private System.Windows.Forms.NumericUpDown spDreams;
        private System.Windows.Forms.Label lblStress;
        private System.Windows.Forms.NumericUpDown spStress;
        private System.Windows.Forms.ComboBox cbAbilityBoost;
        private System.Windows.Forms.Label lblAbilityBoost;
        private System.Windows.Forms.Label lblBoostAmount;
        private System.Windows.Forms.NumericUpDown spBoostAmount;
        private System.Windows.Forms.Label lblAbilityAdd;
        private System.Windows.Forms.ComboBox cbAbilityAdd;
        private System.Windows.Forms.ListBox lbAbilityList;
    }
}