using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class Round
    {
        public int Turn { get; set; }
        public HomeTeam HomeTeam { get; set; }
        public AwayTeam AwayTeam { get; set; }
    }

    public class HomeTeam
    {
        public string Name { get; set; } = null!;
        public int Goals { get; set; }
        public int HalfTimeGoals { get; set; }
    }

    public class AwayTeam
    {
        public string Name { get; set; } = null!;
        public int Goals { get; set; }
        public int HalfTimeGoals { get; set; }
    }
}
