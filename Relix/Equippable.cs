using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    [Serializable]
    public class Equippable
    {
        // Equipment details
        public string name = "MissingName";
        public enum EquipmentType
        {
            Job,SideProject,VideoGames,Learning,Support,None
        }
        public EquipmentType type = EquipmentType.Job;
        
        // Equipment modifiers
        public float income = 0;
        public int fitness = 0;
        public int vgCompletion = 0;
        public int socialLife = 0;
        public int knowledge = 0;
        public int saving = 0;
        public int stress = 0;
        public int time = 0;
        public int dreams = 0;

        // Ability boost and ability addition information
        public Ability abilityBoost;
        public int abilityLearnRate = 0;
        public List<Ability> abilities = new List<Ability>();

        public Equippable(string name)
        {
            this.name = name;
        }
    }
}
