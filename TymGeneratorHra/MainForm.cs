namespace TymGeneratorHra
{
    public partial class MainForm : Form
    {
        List<Player> players = new List<Player>();
        List<Team> teams = new List<Team>();

        public MainForm()
        {
            InitializeComponent();
        }

        // ? Pøidání hráèe
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Zadej jméno!");
                return;
            }

            Player p = new Player
            {
                Name = txtName.Text,
                Skill = (int)numSkill.Value
            };

            players.Add(p);
            listPlayers.Items.Add(p);

            txtName.Clear();
        }

        // ? Smazání hráèe
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listPlayers.SelectedItem == null) return;

            Player p = (Player)listPlayers.SelectedItem;
            players.Remove(p);
            listPlayers.Items.Remove(p);
        }

        // ?? Reset
        private void btnClear_Click(object sender, EventArgs e)
        {
            players.Clear();
            teams.Clear();
            listPlayers.Items.Clear();
        }

        // ?? Generování týmù
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int teamCount = (int)numTeams.Value;

            if (players.Count < teamCount)
            {
                MessageBox.Show("Málo hráèù!");
                return;
            }

            // vytvoøení týmù
            teams = new List<Team>();
            for (int i = 0; i < teamCount; i++)
                teams.Add(new Team());

            // seøazení hráèù podle skillu
            var sorted = players.OrderByDescending(p => p.Skill).ToList();

            // rozdìlení do nejslabšího týmu
            foreach (var player in sorted)
            {
                var weakestTeam = teams.OrderBy(t => t.TotalSkill).First();
                weakestTeam.Players.Add(player);
            }

            // otevøení druhého formuláøe
            TeamResultForm form = new TeamResultForm(teams);
            form.ShowDialog();
        }
    }
}