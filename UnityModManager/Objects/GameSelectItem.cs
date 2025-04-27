namespace UnityModManager.Objects
{
    public class GameSelectItem
    {
        public required string Name { get; set; }
        public required string SteamFolderPath { get; set; }

        public override string ToString()
        {
            return $"{Name} ({SteamFolderPath.Substring(0, 2)})";
        }
    }
}
