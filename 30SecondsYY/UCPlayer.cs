using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30SecondsYY
{
    public partial class UCPlayer : UserControl
    {
        public Player Player = new Player();
        public List<UCTeam> TeamList = new List<UCTeam>();
        public UCPlayer()
        {
            InitializeComponent();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            cdlColor.ShowDialog();
            this.BackColor = cdlColor.Color;
            Player.color = cdlColor.Color;
        }

        private void tbxPlayerName_TextChanged(object sender, EventArgs e)
        {
            Player.PlayerName = tbxPlayerName.Text;
        }

        private void cbxSelectTeam_Click(object sender, EventArgs e)
        {
            cbxSelectTeam.Items.Clear();
            TeamList.Clear();
            TeamList = Form1.instance.pnlTeams.Controls.OfType<UCTeam>().ToList(); ;
            foreach (UCTeam TeamControl in TeamList)
            {
                cbxSelectTeam.Items.Add(TeamControl.Team.Teamname);
            }
        }

        private void cbxSelectTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player.TeamName = cbxSelectTeam.Text;
        }

        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            Form1.instance.pnlPlayers.Controls.Remove(this);
        }
    }
}
