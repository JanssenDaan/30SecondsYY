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
    public partial class UCTeam : UserControl
    {
        public Team Team = new Team();

        public UCTeam()
        {
            InitializeComponent();
        }

        private void btnRemoveTeam_Click(object sender, EventArgs e)
        {
            Form1.instance.pnlTeams.Controls.Remove(this);
        }

        private void tbxTeamName_TextChanged(object sender, EventArgs e)
        {
            Team.Teamname = tbxTeamName.Text;
        }
    }
}
