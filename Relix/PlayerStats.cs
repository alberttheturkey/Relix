using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    [Serializable]
    public class PlayerStats
    {
        public String playerName = "Name!";

        public float income = 0;
        public int fitness = 0;
        public int vgCompletion = 0;
        public int socialLife = 0;
        public int knowledge = 0;
        public int saving = 0;
        public int stress = 0;
        public int time = 0;
        public int dreams = 0;

        public Equippable job = new Equippable("NoJob");
        public Equippable videoGame = new Equippable("noVG");
        public Equippable learning = new Equippable("noLearn");

        public List<Equippable> sideProjects;
        public int sideProjectCount = 2;

        public List<Equippable> supports = new List<Equippable>();
        private int supportCount = 2;

        private List<Ability> abilities;

        public int SupportCount {
            get
            {
                int result = supportCount;

                foreach (Ability a in abilities)
                    result += a.sideProjectModifier;

                return supportCount; }
            set { supportCount = value; }
        }

        public List<Ability> Abilities
        {
            get
            {
                List<Ability> result = new List<Ability>();

                result.AddRange(job.abilities);
                result.AddRange(videoGame.abilities);
                result.AddRange(learning.abilities);
                result.AddRange(job.abilities);

                foreach (Equippable e in sideProjects)
                    if (sideProjects.IndexOf(e) < sideProjectCount)
                        result.AddRange(e.abilities);

                foreach (Equippable e in supports)
                    if (supports.IndexOf(e) < supportCount)
                        result.AddRange(e.abilities);

                return result;
            }
        }

        public PlayerStats()
        {
        }



    }
}
