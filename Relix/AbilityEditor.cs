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
    public partial class AbilityEditor : Form
    {
        public Ability abilityToEdit;
        public AbilityEditor(Ability abilityToEdit)
        {
            InitializeComponent();
            this.abilityToEdit = abilityToEdit;
        }

        private void lblVGCompletion_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveJob_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void tbAbilityName_TextChanged(object sender, EventArgs e)
        {
            abilityToEdit.name = tbAbilityName.Text;
        }
    }
}
