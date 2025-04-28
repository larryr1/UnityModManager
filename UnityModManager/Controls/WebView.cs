using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnityModManager.Objects;
using UnityModManager.Objects.Lib;

namespace UnityModManager.Controls
{
    public partial class WebView : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when the back button is pressed.")]
        public event EventHandler BackRequested;

        private string sharingCode = null;

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

        private void InvokeTextChange(string text)
        {
            this.Invoke((MethodInvoker)delegate
            {
                lblExportStatus.Text = text;
            });
        }

        private void InvokeSharingCodeChange(string text)
        {
            this.Invoke((MethodInvoker)delegate
            {
                this.sharingCode = text;
                lblSharingCode.Visible = true;
            });
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
                FileUploadResult uploadResult = null;

                try
                {
                    archivePath = Program.ProfileManager.CompressProfile(selectedProfile);
                }
                catch (Exception e)
                {
                    InvokeTextChange("Failed to zip profile.");
                    MessageBox.Show("Failed to zip profile: " + e.Message);
                    throw;
                }

                try
                {
                    uploadResult = await FileBinOperations.UploadFileToBinAsync(archivePath);
                }
                catch (Exception e)
                {
                    InvokeTextChange("Failed to upload profile.");
                    MessageBox.Show("Failed to upload profile: " + e.Message);
                    throw;
                }

                try
                {
                    await FileBinOperations.LockBinAsync(uploadResult.BinId);
                }
                catch (Exception e)
                {
                    InvokeTextChange("Failed to lock bin.");
                    MessageBox.Show("Failed to lock bin: " + e.Message);
                    throw;
                }

                InvokeTextChange("Profile exported successfully.");
                InvokeSharingCodeChange(uploadResult.GetSharingCode());
            });
        }

        private void lblSharingCode_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(sharingCode);
            MessageBox.Show("Sharing code copied to clipboard.\n" + sharingCode);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            btnImport.Enabled = false;
            btnImport.BackColor = Color.Gray;
            tbShareCode.Enabled = false;
            lblImportStatus.Text = "Retrieving profile...";

            Task.Run(async () =>
            {
                FileUploadResult uploadResult = new FileUploadResult(tbShareCode.Text);
                string path = await FileBinOperations.DownloadBinContentAsync(uploadResult);

                MessageBox.Show("Profile downloaded to:\n" + path);
            }).ContinueWith(t =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    btnImport.Enabled = true;
                    btnImport.BackColor = Color.White;
                    tbShareCode.Enabled = true;
                    tbShareCode.Text = string.Empty;
                    lblImportStatus.Text = "Ready to Import";
                });
            });
        }
    }
}
