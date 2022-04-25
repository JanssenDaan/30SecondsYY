using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30SecondsYY
{
    public class Game
    {
        public List<Player> Players = new List<Player>();
        public List<Team> Teams = new List<Team>();
        public string CurrentPlayer { get; set; }
        public int CurrentPID;
    }
}
