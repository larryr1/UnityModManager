using System.Runtime.CompilerServices;
using UnityModManager.Forms;
using UnityModManager.Objects;
using UnityModManager.Objects.Lib;

namespace UnityModManager
{
    internal static class Program
    {
        private static readonly AppLauncher launcher = new AppLauncher();
        internal static AppMain? main;
        internal static GameSelectItem? SelectedGame { get; private set; }
        internal static ProfileManager? ProfileManager { get; private set; }
        internal static ProfileBuilder? ProfileBuilder { get; set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(launcher);
        }

        internal static void EntryFromLauncher(GameSelectItem gsi)
        {
            SelectedGame = gsi;
            ProfileManager = new ProfileManager(gsi.SteamFolderPath);
            if (main == null) main = new AppMain(gsi);
            launcher.Hide();
            main.ShowDialog();
        }
    }
}