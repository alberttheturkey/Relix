using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    [Serializable]
    public class Ability
    {
        // Ability details
        public string name = "MissingName";
        public string description = "MissingDesc";
        public long experience = 0;

        // Ability modifiers
        public bool books = false;
        public bool movies = false;
        public bool tvShows = false;
        public bool applying = false;
        public bool multiplayer = false;
        public bool singleplayer = false;
        public bool parties = false;
        public bool gym = false;
        public bool late = false;
        public int sideProjectModifier = 0;
        public int supportsModifier = 0;        

        public Ability(string name, string desc)
        {
            this.name = name;
            this.description = desc;
        }

    }
}
