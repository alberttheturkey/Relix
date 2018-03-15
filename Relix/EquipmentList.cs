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
        public List<Equippable> equippables = new List<Equippable>();
        public List<Ability> abilities = new List<Ability>();
    }
}
