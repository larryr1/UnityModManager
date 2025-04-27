namespace UnityModManager.Objects.Lib
{
    internal class BepInExManagement
    {
        public static bool IsBepInExInstalled(string gamePath)
        {
            return System.IO.Directory.Exists(System.IO.Path.Combine(gamePath, "BepInEx", "core"));
        }

        public static bool IsBepInExInitialized(string gamePath)
        {
            // Tell whether BepInEx has initialized by seeing if the config folder exists
            return System.IO.Directory.Exists(System.IO.Path.Combine(gamePath, "BepInEx", "config"));
        }

        public static bool CheckGameForIL2CPP(string gamePath)
        {
            bool isIL2CPP = false;
            // Check if the game is IL2CPP by looking recursively for any subfolder that contains the folder il2cpp_data.
            void checkFolder(string path)
            {
                if (System.IO.Directory.Exists(System.IO.Path.Combine(path, "il2cpp_data")))
                {
                    isIL2CPP = true;
                    return;
                }
                foreach (var dir in System.IO.Directory.GetDirectories(path))
                {
                    checkFolder(dir);
                    if (isIL2CPP) return;
                }
            }

            // Check the game folder and its subfolders
            checkFolder(gamePath);
            return isIL2CPP;
        }
    }
}
