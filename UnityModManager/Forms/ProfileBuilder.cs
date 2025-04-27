using System.Diagnostics;
using UnityModManager.Controls;
using UnityModManager.Objects.Lib;

namespace UnityModManager.Forms
{
    public partial class ProfileBuilder : Form
    {
        private Point windowLocation;
        private Profile profile;
        private ProfileBuilderMainView mainViewUc;

        public ProfileBuilder(Profile profile)
        {
            this.profile = profile;
            InitializeComponent();

            mainViewUc = new ProfileBuilderMainView(profile);
            pnlMainUcHost.Controls.Add(mainViewUc);

            if (profile == null)
            {
                this.Text = "UMM Profile Builder - New Profile";
                this.lblTitle.Text = this.Text;
            }
            else
            {
                this.Text = "UMM Profile Builder - " + profile.DisplayName;
                this.lblTitle.Text = this.Text;
            }
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

        private void ProfileBuilder_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainViewUc.HandleClose();
        }
    }
}
