using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30SecondsYY
{
    public partial class Form1 : Form
    {
        //Usercontrols
        public UCTeam UCTeam = new UCTeam();
        public UCPlayer UCPlayer = new UCPlayer();

        public Random rand = new Random();
        public int teamCount { get; set; }
        public int playerCount { get; set; }
        //Property to easily get and set information out of mainform in usercontrol
        public static Form1 instance { get; set; }
        public List<UCPlayer> UCPlayers = new List<UCPlayer>();
        public List<Player> Players = new List<Player>();
        public List<UCTeam> UCTeams = new List<UCTeam>();
        public List<Team> Teams = new List<Team>();
        public Game Game = new Game();
        public List<string> WordsList = new List<string>();
        public int Countdown = 30;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void btnAddTeamsDjan_Click(object sender, EventArgs e)
        {
            UCTeam = new UCTeam();
            UCTeam.Team.Teamname = "Team: " + teamCount;
            UCTeam.Team.TeamId = teamCount;
            UCTeam.tbxTeamName.Text = "Team: " + teamCount;
            pnlTeams.Controls.Add(UCTeam);
            teamCount++;
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            UCPlayer = new UCPlayer();
            UCPlayer.Player.PlayerName = "Player: " + playerCount;
            UCPlayer.tbxPlayerName.Text = "Player: " + playerCount;
            UCPlayer.BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            pnlPlayers.Controls.Add(UCPlayer);
            playerCount++;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tclControl.SelectedTab = tbpGameView;
            lbxTeams.Items.Clear();
            lbxTeams.DisplayMember = "Team.Teamname";
            UCTeams = pnlTeams.Controls.OfType<UCTeam>().ToList(); ;
            foreach (UCTeam LoopPlayer in UCTeams)
            {
                lbxTeams.Items.Add(LoopPlayer.Team);
            }
        }

        private void lbxTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            Players.Clear();
            lbxPlayersInTeams.Items.Clear();
            if (sender is ListBox listBox)
            {

                UCPlayers = pnlPlayers.Controls.OfType<UCPlayer>().ToList(); ;
                foreach (UCPlayer p in UCPlayers)
                {
                    if (p.Player.TeamName == listBox.Text)
                    {
                        lbxPlayersInTeams.Items.Add(p.Player);
                    }
                }
                lbxPlayersInTeams.DisplayMember = "Player.PlayerName";
            }
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); ;
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader Reader = new StreamReader(Dialog.FileName))
                {
                    string line;
                    while ((line = Reader.ReadLine()) != null)
                    {
                        WordsList.Add(line);
                    }
                }
                tclControl.SelectedTab = tbpPlay;
                tmrGameTimer.Start();
                Countdown = 30;
                

                foreach (UCPlayer pl in pnlPlayers.Controls.OfType<UCPlayer>().ToList())
                {
                    Game.Players.Add(pl.Player);
                }
                ChangeLabels();
                NextPlayer();
            }
        }

        private void tmrGameTimer_Tick(object sender, EventArgs e)
        {
            if (Countdown == 0)
            {
                tmrGameTimer.Stop();
                Countdown = 30;
            }
            lblCountdown.Text = "Countdown = " + Countdown.ToString();
            Countdown--;
        }

        public string GetWord()
        {
            return WordsList[rand.Next(1, WordsList.Count)];
        }
        public void ChangeLabels()
        {
            lblWordOne.Text = GetWord();
            lblWordTwo.Text = GetWord();
            lblWordThree.Text = GetWord();
            lblWordFour.Text = GetWord();
            lblWordFive.Text = GetWord();
        }

        public void NextPlayer()
        {
            if (Game.CurrentPID == Game.Players.Count -1)
            {
                Game.CurrentPID = 0;
            }
            lblCurrentPlayer.Text = Game.Players[Game.CurrentPID].PlayerName;
            Game.CurrentPID++;
        }

        private void btnNextInPlay_Click(object sender, EventArgs e)
        {
            ChangeLabels();
            NextPlayer();
            Countdown = 30;
            tmrGameTimer.Start();
        }
    }
}
