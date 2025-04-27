namespace UnityModManager.Forms
{
    partial class AppLauncher
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
            lblHeader = new Label();
            lblStatus = new Label();
            btnLaunch = new Button();
            label1 = new Label();
            cbGames = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Snow;
            lblHeader.Location = new Point(12, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(323, 45);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Unity Mod Manager";
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Bottom;
            lblStatus.ForeColor = Color.Snow;
            lblStatus.Location = new Point(0, 302);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(684, 25);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Initializing";
            lblStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnLaunch
            // 
            btnLaunch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnLaunch.Enabled = false;
            btnLaunch.Location = new Point(98, 177);
            btnLaunch.Name = "btnLaunch";
            btnLaunch.Size = new Size(488, 53);
            btnLaunch.TabIndex = 2;
            btnLaunch.Text = "Select Game";
            btnLaunch.UseVisualStyleBackColor = true;
            btnLaunch.Click += btnLaunch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(583, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 3;
            label1.Text = "Exit with Alt+F4";
            // 
            // cbGames
            // 
            cbGames.FormattingEnabled = true;
            cbGames.Location = new Point(60, 129);
            cbGames.Name = "cbGames";
            cbGames.Size = new Size(565, 23);
            cbGames.TabIndex = 5;
            cbGames.SelectedIndexChanged += cbGames_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(300, 111);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 6;
            label2.Text = "Selected Game";
            // 
            // AppLauncher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            ClientSize = new Size(684, 327);
            Controls.Add(label2);
            Controls.Add(cbGames);
            Controls.Add(label1);
            Controls.Add(btnLaunch);
            Controls.Add(lblStatus);
            Controls.Add(lblHeader);
            Cursor = Cursors.AppStarting;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AppLauncher";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UMM Launcher";
            Load += AppLauncher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblStatus;
        private Button btnLaunch;
        private Label label1;
        private ComboBox cbGames;
        private Label label2;
    }
}