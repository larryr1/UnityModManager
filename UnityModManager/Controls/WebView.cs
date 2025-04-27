using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnityModManager.Objects.Lib;

namespace UnityModManager.Controls
{
    public partial class WebView : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when the back button is pressed.")]
        public event EventHandler BackRequested;

        public WebView()
        {
            InitializeComponent();
            UpdateProfileList();
        }

        private void UpdateProfileList()
        {
            Profile[] profiles = Program.ProfileManager.GetProfiles();
            lbProfiles.SelectedItem = null;
            lbProfiles.Items.Clear();
            lbProfiles.Items.AddRange(profiles);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackRequested?.Invoke(this, EventArgs.Empty);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (lbProfiles.SelectedItem == null)
            {
                MessageBox.Show("Please select a profile to export.");
                return;
            }

            Profile selectedProfile = (Profile)lbProfiles.SelectedItem;

            btnExport.Enabled = false;
            btnExport.BackColor = Color.Gray;

            lblExportStatus.Text = "Zipping profile...";

            string archivePath = null;

            Task.Run(async () =>
            {
                try
                {
                    archivePath = Program.ProfileManager.CompressProfile(selectedProfile);
                    string binId = await FileBinOperations.UploadFileToBinAsync(archivePath);
                    await FileBinOperations.LockBinAsync("123");
                }
                catch (Exception e)
                {
                    lblExportStatus.Text = "Failed to zip profile.";
                    MessageBox.Show("Failed to zip profile: " + e.Message);
                    throw;
                }

                this.Invoke((MethodInvoker)delegate
                {
                    lblExportStatus.Text = "Profile zipped successfully.";
                });

                MessageBox.Show(archivePath, "Profile Exported", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });
        }
    }
}
