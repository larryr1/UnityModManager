using System.Data;
using System.Diagnostics;
using System.IO;
using UnityModManager.Objects;
using UnityModManager.Objects.Lib;

namespace UnityModManager.Controls
{
    public partial class ProfileBuilderMainView : UserControl
    {
        private Profile profile;
        private FileSystemWatcher watcher;

        public ProfileBuilderMainView(Profile profile)
        {
            this.profile = profile;
            InitializeComponent();

            LayoutInit();
            WatcherSetup();
        }

        public void HandleClose()
        {
            if (watcher != null)
            {
                watcher.EnableRaisingEvents = false;
                watcher.Dispose();
            }
        }

        private void LayoutInit()
        {
            if (profile == null)
            {
                lblTitle.Text = "New Profile - v1";
            }
            else
            {
                lblTitle.Text = profile.DisplayName + " - v" + profile.Version;
            }

            UpdateItemList();

        }

        private void WatcherSetup()
        {
            this.watcher = new FileSystemWatcher();
            watcher.Path = profile.FolderPath;
            watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "*.*";
            watcher.Changed += WatcherChanged;
            watcher.Created += WatcherChanged;
            watcher.Deleted += WatcherChanged;
            watcher.EnableRaisingEvents = true;
        }

        private void WatcherChanged(object source, FileSystemEventArgs e)
        {
            Debug.WriteLine("File changed: " + e.FullPath);

            this.Invoke((MethodInvoker)delegate
            {
                UpdateItemList();
            });
        }

        private void UpdateItemList()
        {
            Debug.WriteLine("Updating item list");
            ModSelectItem[] currentItems = Program.ProfileManager.GetProfileItems(profile);
            lbCurrentMods.Items.Clear();
            foreach (ModSelectItem item in currentItems)
            {
                lbCurrentMods.Items.Add(item);
            }
        }

        private void lbCurrentMods_DragDrop(object sender, DragEventArgs e)
        {
            Debug.WriteLine("DragDrop event triggered");
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    if (File.Exists(file) || Directory.Exists(file))
                    {
                        string message = "Skipping " + Path.GetFileName(file) + Path.GetDirectoryName(file) + " because it already exists in the profile folder. Skipping this item.";
                        MessageBox.Show(message, "Duplicate Item");
                    }
                    Program.ProfileManager.IntakeProfileItem(profile, file);
                }
            }
        }

        private void lbCurrentMods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbCurrentMods_DragEnter(object sender, DragEventArgs e)
        {
            Debug.WriteLine("DragEnter event triggered");
            e.Effect = DragDropEffects.Copy;
        }

        private void lbCurrentMods_DragLeave(object sender, EventArgs e)
        {
            Debug.WriteLine("DragLeave event triggered");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Program.ProfileBuilder.Close();
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            string filePath = null;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Mod Files (*.dll)|*.dll";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }

            if (filePath != null)
            {
                // Check if the file already exists in the profile folder
                string destinationPath = Path.Combine(profile.FolderPath, Path.GetFileName(filePath));
                if (File.Exists(destinationPath))
                {
                    MessageBox.Show("This file already exists in the profile folder. Skipping this item.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Program.ProfileManager.IntakeProfileItem(profile, filePath);
            }
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            string folderPath = null;

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    folderPath = folderBrowserDialog.SelectedPath;
                }
            }

            if (folderPath != null)
            {
                // Check if the file already exists in the profile folder
                string destinationPath = Path.Combine(profile.FolderPath, Path.GetFileName(folderPath));
                if (File.Exists(destinationPath) || Directory.Exists(destinationPath))
                {
                    MessageBox.Show("This folder already exists in the profile folder. Skipping this item.", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Program.ProfileManager.IntakeProfileItem(profile, folderPath);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lbCurrentMods.SelectedItem != null)
            {
                ModSelectItem selectedItem = (ModSelectItem)lbCurrentMods.SelectedItem;
                Debug.WriteLine("Removing item: " + selectedItem.Name);
                if (selectedItem != null)
                {
                    Program.ProfileManager.RemoveProfileItem(profile, selectedItem);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInspectProfile_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", profile.FolderPath);
        }
    }
}
