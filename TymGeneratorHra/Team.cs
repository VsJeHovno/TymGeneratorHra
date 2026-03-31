using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TymGeneratorHra
{
    public class Team
    {
        public List<Player> Players { get; set; } = new List<Player>();

        public int TotalSkill => Players.Sum(p => p.Skill);
    }
}
