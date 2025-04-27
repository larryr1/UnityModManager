using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityModManager.Objects.Lib
{
    public class Profile
    {
        public required string DisplayName;
        public required string FolderPath;
        public required string Version;
        public required bool Active;
        public required string Id;
        private List<string> mods;

        public Profile(String profileDir)
        {
            this.FolderPath = profileDir;
            Debug.WriteLine("Loading profile: " + FolderPath);

            // Load profiles
            loadProfileMods();
            Debug.WriteLine("Loaded profile: " + FolderPath);
            Debug.WriteLine("Profile is active: " + Active);
            Debug.WriteLine("Profile mods: " + string.Join(", ", mods));
            
        }

        private void loadProfileMods()
        {
            // Get all DLL files in the profile folder
            mods = new List<string>();
            string[] files = System.IO.Directory.GetFiles(FolderPath, "*.dll");
            foreach (string file in files)
            {
                mods.Add(file);
            }

            // Get all folders in the profile folder
            string[] dirs = System.IO.Directory.GetDirectories(FolderPath);
            foreach (string dir in dirs)
            {
                // Get all DLL files in the folder
                files = System.IO.Directory.GetFiles(dir, "*.dll");
                foreach (string file in files)
                {
                    mods.Add(file);
                }
            }
        }

        public override string ToString()
        {
            return $"{DisplayName} v{Version}{(Active ? " - Active" : null)}";
        }
    }
}
