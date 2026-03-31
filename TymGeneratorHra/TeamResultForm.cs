using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TymGeneratorHra
{
    public partial class TeamResultForm : Form
    {
        public TeamResultForm(List<Team> teams)
        {
            InitializeComponent();
            ShowTeams(teams);
        }

        private void ShowTeams(List<Team> teams)
        {
            listTeams.Items.Clear();

            for (int i = 0; i < teams.Count; i++)
            {
                listTeams.Items.Add($"--- Tým {i + 1} ---");

                foreach (var p in teams[i].Players)
                    listTeams.Items.Add($"{p.Name} (Skill: {p.Skill})");

                listTeams.Items.Add($"*** CELKOVÝ SKILL: {teams[i].TotalSkill} ***");
                listTeams.Items.Add("");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
