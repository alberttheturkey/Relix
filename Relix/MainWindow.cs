using System;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class MainWindow : Form
    {
        PlayerStats player = new PlayerStats();
        public static EquipmentList availableEquipment = new EquipmentList();

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
            Equippable toAdd = new Equippable("job" + availableEquipment.jobs.Count);
            toAdd.type = Equippable.EquipmentType.Job;

            EquippableEditor equippableEditor = new EquippableEditor(toAdd);
            equippableEditor.ShowDialog();

            if(equippableEditor.DialogResult == DialogResult.OK)
            {
                availableEquipment.jobs.Add(equippableEditor.editEquippable);
                updateLists();
            }
        }

        private void updateLists()
        {
            lbJobList.Items.Clear();
            cbJob.Items.Clear();
            cbLearn.Items.Clear();
            cbVG.Items.Clear();
            foreach(Equippable job in availableEquipment.jobs)
            {
                lbJobList.Items.Add(job.name);
                if(job.type == Equippable.EquipmentType.Job)
                    cbJob.Items.Add(job.name);
                if (job.type == Equippable.EquipmentType.Learning)
                    cbLearn.Items.Add(job.name);
                if (job.type == Equippable.EquipmentType.VideoGames)
                    cbVG.Items.Add(job.name);
            }
            lbAbility.Items.Clear();
            foreach (Ability ability in availableEquipment.abilities)
            {
                lbAbility.Items.Add(ability.name);
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
                EquippableEditor equippableEditor = new EquippableEditor(availableEquipment.jobs[lbJobList.SelectedIndex]);
                equippableEditor.ShowDialog();

                if (equippableEditor.DialogResult == DialogResult.OK)
                {
                    availableEquipment.jobs[lbJobList.SelectedIndex] = equippableEditor.editEquippable;
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
    }
}
