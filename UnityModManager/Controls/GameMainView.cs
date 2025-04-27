using System.ComponentModel;
using System.Diagnostics;
using UnityModManager.Objects;
using UnityModManager.Objects.Lib;

namespace UnityModManager.Controls
{
    public partial class GameMainView : UserControl
    {
        private GameSelectItem game;
        public GameMainView(GameSelectItem game)
        {
            this.game = game;
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            InitializeLayout();
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when the Web button is clicked.")]
        public event EventHandler WebRequested;

        private void InitializeLayout()
        {
            lbGameName.Text = game.Name;
            lbProfiles.Items.Clear();
            lbLoadedProfiles.Items.Clear();
            UpdateProfileLists();

            //new Profile(Path.Join(game.SteamFolderPath, "BepInEx", "UMM_Profiles", "UMM_Managed_My First Profile")).LoadProfiles();
        }

        private void UpdateProfileLists()
        {
            Profile[] loaded = Program.ProfileManager.GetLoadedProfiles();
            Profile[] all = Program.ProfileManager.GetProfiles();

            lbLoadedProfiles.SelectedItem = null;
            lbLoadedProfiles.Items.Clear();
            foreach (Profile profile in Program.ProfileManager.GetLoadedProfiles())
            {
                lbLoadedProfiles.Items.Add(profile);
            }


            lbProfiles.SelectedItem = null;
            lbProfiles.Items.Clear();
            lbProfiles.Items.AddRange(all.Except(loaded, new ProfileIdComparer()).ToArray());
        }

        private void btnLoadProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbProfiles.SelectedItem == null)
                {
                    MessageBox.Show("Please select a profile to load");
                    return;
                }

                Program.ProfileManager.LoadProfile(((Profile)lbProfiles.SelectedItem));
                UpdateProfileLists();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void lbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonStates(true);
        }

        private void lbLoadedProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonStates(false);
        }

        private void UpdateButtonStates(bool isStaticProfile)
        {
            if (isStaticProfile == null)
            {
                lbLoadedProfiles.SelectedItem = null;
                lbProfiles.SelectedItem = null;

                btnLoadProfile.Enabled = false;
                btnLoadProfile.BackColor = Color.Gray;

                btnUnloadProfile.Enabled = false;
                btnUnloadProfile.BackColor = Color.Gray;

                btnWeb.Enabled = false;
                btnWeb.BackColor = Color.Gray;
            }
            else if (isStaticProfile)
            {
                lbLoadedProfiles.SelectedItem = null;

                btnLoadProfile.Enabled = true;
                btnLoadProfile.BackColor = Color.White;

                btnUnloadProfile.Enabled = false;
                btnUnloadProfile.BackColor = Color.Gray;

                btnWeb.Enabled = true;
                btnWeb.BackColor = Color.White;
            }
            else
            {
                lbProfiles.SelectedItem = null;

                btnLoadProfile.Enabled = false;
                btnLoadProfile.BackColor = Color.Gray;

                btnUnloadProfile.Enabled = true;
                btnUnloadProfile.BackColor = Color.White;

                btnWeb.Enabled = false;
                btnWeb.BackColor = Color.Gray;
            }
        }

        private void btnUnloadProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbLoadedProfiles.SelectedItem == null)
                {
                    MessageBox.Show("Please select a profile to unload");
                    return;
                }

                Program.ProfileManager.UnloadProfile(((Profile)lbLoadedProfiles.SelectedItem));
                UpdateProfileLists();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBuilder_Click(object sender, EventArgs e)
        {
            if (lbProfiles.SelectedItem == null)
            {
                MessageBox.Show("Please select a profile to load first.");
                return;
            }

            Program.main.Hide();
            Program.ProfileManager.OpenProfileBuilder((Profile)lbProfiles.SelectedItem);
            Program.main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNewProfile_Click(object sender, EventArgs e)
        {
            string res = Microsoft.VisualBasic.Interaction.InputBox("Enter a name for the profile.", "New Profile");
            if (string.IsNullOrEmpty(res))
            {
                return;
            }
            try
            {
                Profile newProfile = Program.ProfileManager.CreateProfile(res);
                UpdateProfileLists();
                Program.ProfileManager.OpenProfileBuilder(newProfile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating profile: " + ex.Message);
            }
        }

        private void btnWeb_Click(object sender, EventArgs e)
        {
            WebRequested?.Invoke(this, EventArgs.Empty);
        }
    }

    public class ProfileIdComparer : IEqualityComparer<Profile>
    {
        public bool Equals(Profile x, Profile y)
        {
            if (x is null || y is null) return false;
            return x.Id == y.Id;
        }

        public int GetHashCode(Profile obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
