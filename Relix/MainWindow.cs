using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class MainWindow : Form
    {
        PlayerStats player = new PlayerStats();
        public static EquipmentList availableEquipment = new EquipmentList();
        ComboBox[] cbList;

        int supportListSize = 2;
        int abilityListSpacing = 20;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "List Files (*.lif)|*.lif|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    availableEquipment = Persistence.loadEquipmentList(openFileDialog.FileName);
                    updateLists();
                    MessageBox.Show("Load Successful");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Sorry, couldn't load that file.");
                    lblDebug.Text = ex.Message;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "List Files (*.lif)|*.lif|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Persistence.saveEquipmentList(availableEquipment, saveFileDialog.FileName);
                    MessageBox.Show("Save Successful");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sorry, couldn't load that file.");
                    lblDebug.Text = ex.Message;
                }
            }
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            Equippable toAdd = new Equippable("job" + availableEquipment.equippables.Count);
            toAdd.type = Equippable.EquipmentType.Job;

            EquippableEditor equippableEditor = new EquippableEditor(toAdd);
            equippableEditor.ShowDialog();

            if(equippableEditor.DialogResult == DialogResult.OK)
            {
                availableEquipment.equippables.Add(equippableEditor.editEquippable);
                updateLists();
            }
        }

        private void updateLists()
        {
            // Clear our lists before we update them
            // TODO: Make these retain if they have items selected
            lbJobList.Items.Clear();
            cbJob.Items.Clear();
            cbLearn.Items.Clear();
            cbVG.Items.Clear();

            // These select boxes can be duplicated, so we create them here first
            // then we duplicate them later
            ComboBox cbProject = new ComboBox();

            // Add our different equippables to their respective combo boxes
            // This is where the equippables list is getting populated
            foreach(Equippable eqp in availableEquipment.equippables)
            {
                lbJobList.Items.Add(eqp.name);
                if(eqp.type == Equippable.EquipmentType.Job)
                    cbJob.Items.Add(eqp.name);
                if (eqp.type == Equippable.EquipmentType.Learning)
                    cbLearn.Items.Add(eqp.name);
                if (eqp.type == Equippable.EquipmentType.VideoGames)
                    cbVG.Items.Add(eqp.name);
                if (eqp.type == Equippable.EquipmentType.SideProject)
                    cbProject.Items.Add(eqp.name);
            }

            //  Adding all the abilities to the ability list box
            lbAbility.Items.Clear();
            foreach (Ability ability in availableEquipment.abilities)
            {
                lbAbility.Items.Add(ability.name);
            }
            flpSupport.Controls.Clear();
                cbList = new ComboBox[player.SupportCount];
            for (int i = 0; i < player.SupportCount; i++)
            {
                ComboBox cbSupport = new ComboBox();

                // This is too clunky for my liking. Maybe I should extract to seperate lists...
                foreach (Equippable eqp in availableEquipment.equippables)
                {
                    if (eqp.type == Equippable.EquipmentType.Support)
                        cbSupport.Items.Add(eqp.name);
                }

                cbList[i] = cbSupport;
                List<Ability> stuff = player.Abilities;
                cbList[i].Name = "cbSupport" + i;
                cbList[i].Tag = i;
                flpSupport.Controls.Add(cbList[i]);
            }

        }

        private void lbJobList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbJobList_DoubleClick(object sender, EventArgs e)
        {
            // Open up our dialog for editing equippables using the index from the job list
            if (lbJobList.SelectedIndex > -1)
            {
                EquippableEditor equippableEditor = new EquippableEditor(availableEquipment.equippables[lbJobList.SelectedIndex]);
                equippableEditor.ShowDialog();

                if (equippableEditor.DialogResult == DialogResult.OK)
                {
                    availableEquipment.equippables[lbJobList.SelectedIndex] = equippableEditor.editEquippable;
                    updateLists();
                }
            }
        }

        private void btnAddAbility_Click(object sender, EventArgs e)
        {
            Ability toAdd = new Ability("ability" + availableEquipment.abilities.Count, "");            

            AbilityEditor abilityEditor = new AbilityEditor(toAdd);
            abilityEditor.ShowDialog();

            if (abilityEditor.DialogResult == DialogResult.OK)
            {
                availableEquipment.abilities.Add(abilityEditor.abilityToEdit);
                updateLists();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
                try
                {
                    player = Persistence.loadPlayerStats("PlayerEquipment.eqp");
                    updatePlayer();
                }
                catch (Exception ex)
                {
                player = new PlayerStats();
                    MessageBox.Show("Sorry, couldn't load that file.");
                    player = new PlayerStats();
                    
                    lblDebug.Text = ex.Message;
                }
        }

        public void updatePlayer()
        {

        }

        private void cbJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Equippable job in availableEquipment.equippables)
                if (job.type == Equippable.EquipmentType.Job)
                    if (job.name == cbJob.GetItemText(cbJob.SelectedItem))
                        player.job = job;
        }
    }
}
