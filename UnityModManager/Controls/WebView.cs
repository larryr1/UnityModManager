using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnityModManager.Objects.Lib;

namespace UnityModManager.Controls
{
    public partial class WebView : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when the back button is pressed.")]
        public event EventHandler BackRequested;

        public WebView()
        {
            InitializeComponent();
            UpdateProfileList();
        }

        private void UpdateProfileList()
        {
            Profile[] profiles = Program.ProfileManager.GetProfiles();
            lbProfiles.SelectedItem = null;
            lbProfiles.Items.Clear();
            lbProfiles.Items.AddRange(profiles);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
