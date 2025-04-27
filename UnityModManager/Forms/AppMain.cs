using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnityModManager.Controls;
using UnityModManager.Objects;
using UnityModManager.Objects.Lib;

namespace UnityModManager.Forms
{
    public partial class AppMain : Form
    {
        private Point windowLocation;
        private GameSelectItem selectedGame;
        private BepInExInstaller? ucBepInExInstaller;
        private BepInExFirstLaunchWarning? ucBepInExFirstLaunchWarning;
        private GameNotSupported? ucGameNotSupported;
        private GameMainView? ucGameMainView;
        private WebView? ucWebView;

        public AppMain(GameSelectItem selectedGame)
        {
            this.selectedGame = selectedGame;

            InitializeComponent();
            InitializeFormLayout();
        }

        private void pnDragBar_MouseDown(object sender, MouseEventArgs e)
        {
            this.windowLocation = e.Location;
        }

        private void pnDragBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Refers to the Form location (or whatever you trigger the event on)
                this.Location = new Point(
                    (this.Location.X - windowLocation.X) + e.X,
                    (this.Location.Y - windowLocation.Y) + e.Y
                );

                this.Update();
            }
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            pnDragBar_MouseDown(sender, e);
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            pnDragBar_MouseMove(sender, e);
        }

        private void InitializeFormLayout()
        {
            this.Text = $"Unity Mod Manager - {selectedGame.Name} - {selectedGame.SteamFolderPath}";
            lblTitle.Text = this.Text;

            if (BepInExManagement.CheckGameForIL2CPP(selectedGame.SteamFolderPath) == true)
            {
                showGameNotSupportedWarning("Game contains an il2cpp_data folder. UMM is not compatible with Unity games built with IL2CPP.");
                return;
            }

            if (!BepInExManagement.IsBepInExInstalled(selectedGame.SteamFolderPath))
            {
                showBepInExInstaller();
                return;
            }

            if (!BepInExManagement.IsBepInExInitialized(selectedGame.SteamFolderPath))
            {
                showBepInExFirstLaunchWarning();
                return;
            }

            showGameMainView();
        }

        private void showGameMainView()
        {
            if (ucGameMainView != null)
            {
                ucGameMainView.Dispose();
            }
            ucGameMainView = new GameMainView(selectedGame);
            ucGameMainView.WebRequested += (s, e) =>
            {
                ucGameMainView.Dispose();
                showWebView();
            };
            ucGameMainView.Dock = DockStyle.Fill;
            pnlMainUcHost.Controls.Add(ucGameMainView);
            this.UpdateZOrder();
            this.lblStatus.Text = "Showing GameMainView - Ready";
        }

        private void showBepInExInstaller()
        {
            ucBepInExInstaller = new BepInExInstaller();
            ucBepInExInstaller.Dock = DockStyle.Fill;
            ucBepInExInstaller.InstallCompleted += ucBepInExInstaller_InstallCompleted;
            ucBepInExInstaller.BringToFront();
            pnlMainUcHost.Controls.Add(ucBepInExInstaller);
            this.UpdateZOrder();
            lblStatus.Text = "Showing BepInExInstaller - Waiting For Install";
        }

        private void showBepInExFirstLaunchWarning()
        {
            ucBepInExFirstLaunchWarning = new BepInExFirstLaunchWarning();
            ucBepInExFirstLaunchWarning.Dock = DockStyle.Fill;
            ucBepInExFirstLaunchWarning.BringToFront();
            pnlMainUcHost.Controls.Add(ucBepInExFirstLaunchWarning);
            this.UpdateZOrder();
            lblStatus.Text = "Showing BepInExFirstLaunchWarning - User Must Launch Game";
        }

        private void ucBepInExInstaller_InstallCompleted(object sender, EventArgs e)
        {
            pnlMainUcHost.Controls.Remove((BepInExInstaller)sender);
            InitializeFormLayout();
            lblStatus.Text = "BepInExInstaller - Install Done";
        }

        private void showGameNotSupportedWarning(string reason)
        {
            ucGameNotSupported = new GameNotSupported(reason);
            ucGameNotSupported.Dock = DockStyle.Fill;
            ucGameNotSupported.BringToFront();
            pnlMainUcHost.Controls.Add(ucGameNotSupported);
            this.UpdateZOrder();
            lblStatus.Text = "Showing GameNotSupportedWarning - Detail In UC";
        }

        private void showWebView()
        {
            if (ucWebView != null)
            {
                ucWebView.Dispose();
            }
            ucWebView = new WebView();
            ucWebView.BackRequested += UcWebView_BackRequested;
            ucWebView.Dock = DockStyle.Fill;
            ucWebView.BringToFront();
            pnlMainUcHost.Controls.Add(ucWebView);
            this.UpdateZOrder();
            lblStatus.Text = "Showing WebView";
        }

        private void UcWebView_BackRequested(object? sender, EventArgs e)
        {
            ucWebView.Dispose();
            showGameMainView();
        }

        private void AppMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
