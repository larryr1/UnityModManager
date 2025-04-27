using System.ComponentModel;
using System.Diagnostics;
using System.IO.Compression;

namespace UnityModManager.Controls
{
    public partial class BepInExInstaller : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when BepInEx is installed")]
        public event EventHandler InstallCompleted;

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when BepInEx is installed")]
        public event EventHandler DownloadCompleted;

        public BepInExInstaller()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
        }

        private async Task<String> downloadBepInEx()
        {
            using (var client = new HttpClient())
            {
                string tempPath = Path.GetTempFileName();
                var httpResult = await client.GetAsync("https://github.com/BepInEx/BepInEx/releases/download/v5.4.23.2/BepInEx_win_x64_5.4.23.2.zip");
                using var resultStream = await httpResult.Content.ReadAsStreamAsync();
                using var fileStream = File.Create(tempPath + ".zip");
                resultStream.CopyTo(fileStream);
                return tempPath;
            }
        }

        private bool extractBepInEx(string targetFolder, string zipPath)
        {
            using (var archive = ZipFile.OpenRead(zipPath))
            {
                archive.ExtractToDirectory(targetFolder, true);
            }

            return true;
        }

        private void btnInstallBepInEx_Click(object sender, EventArgs e)
        {
            btnInstallBepInEx.Enabled = false;
            btnInstallBepInEx.Visible = false;
            lblOpProgress.Text = "Downloading an official BepInEx release...";
            lblOpProgress.Visible = true;
            pbProcessProgress.Visible = true;
            pbProcessProgress.Style = ProgressBarStyle.Marquee;

            Task.Run(downloadBepInEx).ContinueWith(t =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    Debug.WriteLine("Downloaded BepInEx to " + t.Result);
                    DownloadCompleted?.Invoke(this, EventArgs.Empty);
                    lblOpProgress.Text = "Extracting BepInEx to game folder...";
                });

                Task.Run(() =>
                {
                    if (Program.SelectedGame == null) throw new ArgumentNullException("SelectedGame was null on the static Program class.");
                    extractBepInEx(Program.SelectedGame.SteamFolderPath, t.Result + ".zip");
                    File.Delete(t.Result + ".zip");
                }).ContinueWith(t =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        Debug.WriteLine("Extracted BepInEx to game folder.");
                        lblOpProgress.Text = "BepInEx installed!";
                        pbProcessProgress.Style = ProgressBarStyle.Continuous;
                        pbProcessProgress.Value = 100;
                        btnContinue.Visible = true;
                        btnContinue.Enabled = true;
                    });
                });
            });
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            InstallCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
