namespace UnityModManager.Objects.Lib
{
    internal class DriveManagement
    {
        // Potential directories where Steam games could be installed on a drive
        static List<string> potentialDirectories = new List<string>
        {
            Path.Combine("Program Files (x86)", "Steam", "steamapps", "common"),
            Path.Combine("SteamLibrary", "steamapps", "common")
        };

        public static GameSelectItem[] FindSteamGames()
        {
            string[] drives = Environment.GetLogicalDrives();

            List<GameSelectItem> games = new List<GameSelectItem>();

            foreach (string drive in drives)
            {
                foreach (string potentialDirectory in potentialDirectories)
                {
                    string steamPath = Path.Combine(drive, potentialDirectory);
                    if (!Directory.Exists(steamPath)) continue;

                    foreach (string gamePath in Directory.GetDirectories(steamPath))
                    {
                        games.Add(new GameSelectItem
                        {
                            Name = Path.GetFileName(gamePath),
                            SteamFolderPath = gamePath
                        });
                    }
                }
            }

            return games.ToArray();
        }
        
        private static string[] FindGamesInDirectory(string directory)
        {
            if (!Directory.Exists(directory)) return new string[0];
            return Directory.GetDirectories(directory);
        }
    }
}
