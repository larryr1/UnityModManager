namespace UnityModManager.Forms
{
    partial class AppMain
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
            pnDragBar = new Panel();
            lblTitle = new Label();
            lblStatus = new Label();
            pnlMainUcHost = new Panel();
            pnDragBar.SuspendLayout();
            SuspendLayout();
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
            pnDragBar.TabIndex = 0;
            pnDragBar.MouseDown += pnDragBar_MouseDown;
            pnDragBar.MouseMove += pnDragBar_MouseMove;
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
            lblTitle.Text = "UMM - Loading...";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblTitle.MouseDown += lblTitle_MouseDown;
            lblTitle.MouseMove += lblTitle_MouseMove;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Bottom;
            lblStatus.ForeColor = Color.Snow;
            lblStatus.Location = new Point(0, 425);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(800, 25);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Initializing";
            lblStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlMainUcHost
            // 
            pnlMainUcHost.BackColor = Color.RosyBrown;
            pnlMainUcHost.Dock = DockStyle.Fill;
            pnlMainUcHost.Location = new Point(0, 37);
            pnlMainUcHost.Name = "pnlMainUcHost";
            pnlMainUcHost.Size = new Size(800, 388);
            pnlMainUcHost.TabIndex = 3;
            // 
            // AppMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMainUcHost);
            Controls.Add(lblStatus);
            Controls.Add(pnDragBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AppMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UMM - Loading...";
            FormClosed += AppMain_FormClosed;
            pnDragBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnDragBar;
        private Label lblTitle;
        private Label lblStatus;
        private Panel pnlMainUcHost;
    }
}