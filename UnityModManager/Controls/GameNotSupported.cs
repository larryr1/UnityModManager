using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnityModManager.Controls
{
    public partial class GameNotSupported : UserControl
    {
        private string reason = string.Empty;

        public GameNotSupported(string reason)
        {
            this.reason = reason;
            InitializeComponent();

            lblErrorReason.Text = reason;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lnk(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkAlreadyLaunched_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = @"Make sure the game is using Unity Mono and not something else like IL2CPP.
UMM does not support games running IL2CPP code.";
            MessageBox.Show(message, "First Launch Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
