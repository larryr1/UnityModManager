using System.Diagnostics;
using UnityModManager.Forms;

namespace UnityModManager.Objects.Lib
{
    internal class ProfileManager
    {
        private string GamePath;

        public ProfileManager(string gamePath)
        {
            GamePath = gamePath;

            Initialize();
        }

        private void Initialize()
        {
            // Create profile directory
            Directory.CreateDirectory(Path.Join(GamePath, "BepInEx", "UMM_Profiles"));
        }

        /*public void LoadProfile(string profileName)
        {
            if (!BepInExManagement.IsBepInExInitialized(GamePath))
            {
                throw new Exception("BepInEx is not initialized");
            }

            // Copy the profile to the UMM_Active_Profile folder
            CopyDir.Copy(Path.Join(GamePath, "BepInEx", "UMM_Profiles", profileName), Path.Join(GamePath, "BepInEx", "Plugins", "UMM_Active_Profiles"));
        }*/

        public void LoadProfile(Profile profile)
        {
            if (!BepInExManagement.IsBepInExInitialized(GamePath))
            {
                throw new Exception("BepInEx is not initialized");
            }

            // Copy the profile to the UMM_Active_Profile folder
            CopyDir.Copy(profile.FolderPath, Path.Join(GamePath, "BepInEx", "Plugins", "UMM_Active_Profiles", profile.Id));
        }

        public void UnloadProfile(Profile profile)
        {
            // Delete the UMM_Active_Profile folder
            Directory.Delete(Path.Join(GamePath, "BepInEx", "Plugins", "UMM_Active_Profiles", profile.Id), true);
        }

        public Profile[] GetProfiles()
        {
            // Get all profiles in the UMM_Profiles folder
            string[] profileDirs = Directory.GetDirectories(Path.Join(GamePath, "BepInEx", "UMM_Profiles"));
            List<Profile> profiles = new List<Profile>();
            foreach (string dir in profileDirs)
            {
                profiles.Add(GetProfileByFolder(dir));
            }

            return profiles.ToArray();
        }

        public Profile[] GetLoadedProfiles()
        {
            // Get all profiles in the UMM_Profiles folder
            string[] profileDirs = Directory.GetDirectories(Path.Join(GamePath, "BepInEx", "plugins", "UMM_Active_Profiles"));
            List<Profile> profiles = new List<Profile>();
            foreach (string dir in profileDirs)
            {
                profiles.Add(GetProfileByFolder(dir));
            }

            return profiles.ToArray();
        }

        public Profile GetProfileByFolder(string path)
        {
            string[] cfgLines = File.ReadAllLines(Path.Join(path, "umm_profile"));
            Profile profile = new Profile(path)
            {
                FolderPath = path,
                DisplayName = cfgLines[0],
                Version = cfgLines[1],
                Active = false,
                Id = cfgLines[2]
            };

            return profile;
        }

        public void OpenProfileBuilder(Profile profile)
        {
            // If no builder, create one
            if (Program.ProfileBuilder == null)
            {
                Program.ProfileBuilder = new ProfileBuilder(profile);
                Program.ProfileBuilder.ShowDialog();
            }

            // otherwise, destroy the current builder and instantiate a new one with the passed profile
            else
            {
                // Attempt to close the current builder
                try
                {
                    Program.ProfileBuilder.Close();
                    Program.ProfileBuilder.Dispose();
                }
                catch (Exception e)
                {
                    Debug.WriteLine("Ex while destroying builder.");
                    Debug.WriteLine(e.Message);

                }

                // Create a new builder
                Program.ProfileBuilder = new ProfileBuilder(profile);
                Program.ProfileBuilder.ShowDialog();
            }
        }

        public ModSelectItem[] GetProfileItems(Profile profile)
        {
            // Get all files in the profile folder
            string[] files = Directory.GetFiles(profile.FolderPath);
            List<ModSelectItem> items = new List<ModSelectItem>();
            foreach (string file in files)
            {
                if (file.EndsWith("umm_profile")) continue;

                items.Add(new ModSelectItem()
                {
                    Name = Path.GetFileName(file),
                    ItemPath = file,
                });
            }

            // Get all folders in the profile folder
            string[] dirs = Directory.GetDirectories(profile.FolderPath);
            foreach (string dir in dirs)
            {
                items.Add(new ModSelectItem()
                {
                    Name = Path.GetFileName(dir),
                    ItemPath = dir,
                });
            }

            return items.ToArray();
        }

        public bool IntakeProfileItem(Profile profile, string profileItem)
        {
            try
            {
                Debug.WriteLine(profile.FolderPath + " - " + profileItem);
                bool isDirectory = (File.Exists(profileItem) == false && Directory.Exists(profileItem) == true);
                if (isDirectory)
                {
                    // Copy the directory to the profile's directory
                    CopyDir.Copy(profileItem, Path.Join(profile.FolderPath, Path.GetFileName(profileItem)));
                }
                else
                {
                    // Copy the file to the profile's directory
                    File.Copy(profileItem, Path.Join(profile.FolderPath, Path.GetFileName(profileItem)), true);
                }

                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error copying file: " + profileItem + e.Message);
                throw;
            }
        }

        public void RemoveProfileItem(Profile profile, ModSelectItem profileItem)
        {
            // Delete the file or directory
            if (File.Exists(profileItem.ItemPath))
            {
                File.Delete(profileItem.ItemPath);
            }
            else if (Directory.Exists(profileItem.ItemPath))
            {
                Directory.Delete(profileItem.ItemPath, true);
            }
        }

        public Profile CreateProfile(string profileName)
        {
            string path = Path.Join(GamePath, "BepInEx", "UMM_Profiles", "UMM_Managed_" + Sanitize(profileName));
            if (Directory.Exists(path)) {
                throw new Exception("Profile already exists.");
            }

            // Create the profile directory
            Directory.CreateDirectory(path);
            // Create the profile file
            string newGuid = Guid.NewGuid().ToString();

            File.WriteAllText(Path.Join(path, "umm_profile"), profileName + Environment.NewLine + "1" + Environment.NewLine + newGuid);

            return new Profile(path)
            {
                DisplayName = profileName,
                FolderPath = path,
                Version = "1",
                Active = false,
                Id = newGuid,
            };
        }

        public static string Sanitize(string input)
        {
            var invalidChars = Path.GetInvalidFileNameChars();
            var sanitized = new string(input.Where(c => !invalidChars.Contains(c)).ToArray());

            // Optional: if filename is empty after sanitization, use a default
            if (string.IsNullOrWhiteSpace(sanitized))
                sanitized = "default";

            return sanitized;
        }
    }
}