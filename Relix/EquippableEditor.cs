using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class EquippableEditor : Form
    {
        public Equippable editEquippable;
        public EquippableEditor(Equippable editEquippable)
        {
            InitializeComponent();
            this.editEquippable = editEquippable;

            // Populate all our fields with the data stored in the equippable
            tbJobName.Text = editEquippable.name;
            spIncome.Value = (decimal)editEquippable.income;
            spFitness.Value = editEquippable.fitness;
            spVGCompletion.Value = editEquippable.vgCompletion;
            spSocialLife.Value = editEquippable.socialLife;
            spKnowledge.Value = editEquippable.knowledge;
            spSaving.Value = editEquippable.saving;
            spTime.Value = editEquippable.time;
            spDreams.Value = editEquippable.dreams;
            spStress.Value = editEquippable.stress;
            lbAbilityList.Items.Clear();

            // Populate the ability list with pre-existing abilities
            foreach (Ability ability in editEquippable.abilities)
            {
                lbAbilityList.Items.Add(ability.name);
            }

            // Populate our ability adding combo box
            foreach(Ability ability in MainWindow.availableEquipment.abilities)
            {
                cbAbilityAdd.Items.Add(ability.name);
            }
        }

        private void btnSaveJob_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void tbJobName_TextChanged(object sender, EventArgs e)
        {
            editEquippable.name = tbJobName.Text;
        }

        private void spIncome_ValueChanged(object sender, EventArgs e)
        {
            editEquippable.income = (float)spIncome.Value;
        }

        private void spFitness_ValueChanged(object sender, EventArgs e)
        {
            editEquippable.fitness = (int)spFitness.Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void lblVGCompletion_Click(object sender, EventArgs e)
        {

        }

        private void spVGCompletion_ValueChanged(object sender, EventArgs e)
        {
            editEquippable.vgCompletion = (int)spVGCompletion.Value;
        }

        private void spSocialLife_ValueChanged(object sender, EventArgs e)
        {
            editEquippable.socialLife = (int)spSocialLife.Value;
        }

        private void spKnowledge_ValueChanged(object sender, EventArgs e)
        {
            editEquippable.knowledge = (int)spKnowledge.Value;
        }

        private void spSaving_ValueChanged(object sender, EventArgs e)
        {
            editEquippable.saving = (int)spSaving.Value;
        }

        private void spTime_ValueChanged(object sender, EventArgs e)
        {
            editEquippable.time = (int)spTime.Value;
        }

        private void spDreams_ValueChanged(object sender, EventArgs e)
        {
            editEquippable.dreams = (int)spDreams.Value;
        }

        private void spStress_ValueChanged(object sender, EventArgs e)
        {
            editEquippable.stress = (int)spStress.Value;
        }

        private void cbAbilityAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Ability ability in MainWindow.availableEquipment.abilities)
            {
                if (ability.name == cbAbilityAdd.Text)
                    editEquippable.abilities.Add(ability);
            }
            lbAbilityList.Items.Add(cbAbilityAdd.Text);
        }

        private void rbJob_CheckedChanged(object sender, EventArgs e)
        {
            editEquippable.type = Equippable.EquipmentType.Job;
        }

        private void rbVG_CheckedChanged(object sender, EventArgs e)
        {
            editEquippable.type = Equippable.EquipmentType.VideoGames;
        }

        private void rbLearning_CheckedChanged(object sender, EventArgs e)
        {
            editEquippable.type = Equippable.EquipmentType.Learning;
        }

        private void rbProject_CheckedChanged(object sender, EventArgs e)
        {
            editEquippable.type = Equippable.EquipmentType.SideProject;
        }

        private void rbSupport_CheckedChanged(object sender, EventArgs e)
        {
            editEquippable.type = Equippable.EquipmentType.Support;
        }
    }
}
