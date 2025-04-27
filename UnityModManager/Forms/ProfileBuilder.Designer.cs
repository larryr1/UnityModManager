namespace UnityModManager.Forms
{
    partial class ProfileBuilder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            pnlMainUcHost = new Panel();
            lblStatus = new Label();
            pnDragBar = new Panel();
            pnDragBar.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.ForeColor = Color.Snow;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(10, 0, 0, 0);
            lblTitle.Size = new Size(800, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "UMM Profile Builder - Loading...";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblTitle.MouseDown += lblTitle_MouseDown;
            lblTitle.MouseMove += lblTitle_MouseMove;
            // 
            // pnlMainUcHost
            // 
            pnlMainUcHost.BackColor = Color.RosyBrown;
            pnlMainUcHost.Dock = DockStyle.Fill;
            pnlMainUcHost.Location = new Point(0, 37);
            pnlMainUcHost.Name = "pnlMainUcHost";
            pnlMainUcHost.Size = new Size(800, 388);
            pnlMainUcHost.TabIndex = 6;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Bottom;
            lblStatus.ForeColor = Color.Snow;
            lblStatus.Location = new Point(0, 425);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(800, 25);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Initializing";
            lblStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnDragBar
            // 
            pnDragBar.BackColor = Color.Black;
            pnDragBar.Controls.Add(lblTitle);
            pnDragBar.Dock = DockStyle.Top;
            pnDragBar.Location = new Point(0, 0);
            pnDragBar.Margin = new Padding(0);
            pnDragBar.Name = "pnDragBar";
            pnDragBar.Size = new Size(800, 37);
            pnDragBar.TabIndex = 4;
            pnDragBar.MouseDown += pnDragBar_MouseDown;
            pnDragBar.MouseMove += pnDragBar_MouseMove;
            // 
            // ProfileBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMainUcHost);
            Controls.Add(lblStatus);
            Controls.Add(pnDragBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProfileBuilder";
            ShowInTaskbar = false;
            Text = "UMM Profile Builder";
            FormClosing += ProfileBuilder_FormClosing;
            pnDragBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Panel pnlMainUcHost;
        private Label lblStatus;
        private Panel pnDragBar;
    }
}