using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TymGeneratorHra
{
    public class Player
    {
        public string Name { get; set; }
        public int Skill { get; set; }

        public override string ToString()
        {
            return $"{Name} (Skill: {Skill})";
        }
    }
}
