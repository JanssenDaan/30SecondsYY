﻿using System;
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
        public int ScoreTeamOne { get; set; }
        public int ScoreTeamTwo { get; set; }
        public int ScoreTeamThree { get; set; }
        public int ScoreTeamFour { get; set; }
        public string CurrentPlayer { get; set; }
    }
}
