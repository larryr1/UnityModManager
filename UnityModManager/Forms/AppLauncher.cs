using UnityModManager.Objects;
using UnityModManager.Objects.Lib;

namespace UnityModManager.Forms
{
    public partial class AppLauncher : Form
    {
        public AppLauncher()
        {
            InitializeComponent();
        }
        private void AppLauncher_Load(object sender, EventArgs e)
        {
            PopulateGameList();
        }

        private void PopulateGameList()
        {
            lblStatus.Text = "Searching for compatible games...";

            Task.Run(() =>
            {
                GameSelectItem[] items = DriveManagement.FindSteamGames();

                // Update UI with the found games
                this.Invoke((MethodInvoker)delegate
                {
                    btnLaunch.Text = "Select game below";
                    lblStatus.Text = "Ready to start";
                    foreach (GameSelectItem game in items)
                    {
                        // Assuming you have a ListBox named lstGames to display the games

                        cbGames.Items.Add(game);
                    }
                });
            });
        }

        private void cbGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            object? selectedItem = ((ComboBox)sender).SelectedItem;
            if (selectedItem == null) return;
            btnLaunch.Text = "Launch for " + selectedItem;
            btnLaunch.Enabled = true;
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            GameSelectItem? selectedItem = (GameSelectItem?)cbGames.SelectedItem;
            if (selectedItem == null) return;

            Program.EntryFromLauncher(selectedItem);
        }
    }
}
