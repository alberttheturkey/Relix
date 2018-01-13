using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    [Serializable]
    public class EquipmentList
    {
        public List<Equippable> jobs = new List<Equippable>();
        public List<Equippable> sideProjects = new List<Equippable>();
        public List<Equippable> videoGames = new List<Equippable>();
        public List<Equippable> learning = new List<Equippable>();
        public List<Equippable> supports = new List<Equippable>();
        public List<Ability> abilities = new List<Ability>();
    }
}
