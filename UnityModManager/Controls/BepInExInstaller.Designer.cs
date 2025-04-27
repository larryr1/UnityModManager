namespace UnityModManager.Controls
{
    partial class BepInExInstaller
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnInstallBepInEx = new Button();
            label1 = new Label();
            pbProcessProgress = new ProgressBar();
            lblOpProgress = new Label();
            btnContinue = new Button();
            SuspendLayout();
            // 
            // btnInstallBepInEx
            // 
            btnInstallBepInEx.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnInstallBepInEx.Location = new Point(307, 121);
            btnInstallBepInEx.Name = "btnInstallBepInEx";
            btnInstallBepInEx.Size = new Size(172, 43);
            btnInstallBepInEx.TabIndex = 0;
            btnInstallBepInEx.Text = "Download and Install";
            btnInstallBepInEx.UseVisualStyleBackColor = true;
            btnInstallBepInEx.Click += btnInstallBepInEx_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(216, 73);
            label1.Name = "label1";
            label1.Size = new Size(368, 32);
            label1.TabIndex = 1;
            label1.Text = "This installation needs BepInEx";
            // 
            // pbProcessProgress
            // 
            pbProcessProgress.Location = new Point(204, 211);
            pbProcessProgress.Name = "pbProcessProgress";
            pbProcessProgress.RightToLeftLayout = true;
            pbProcessProgress.Size = new Size(392, 19);
            pbProcessProgress.TabIndex = 2;
            // 
            // lblOpProgress
            // 
            lblOpProgress.AutoSize = true;
            lblOpProgress.ForeColor = Color.Snow;
            lblOpProgress.Location = new Point(204, 237);
            lblOpProgress.Name = "lblOpProgress";
            lblOpProgress.Size = new Size(39, 15);
            lblOpProgress.TabIndex = 3;
            lblOpProgress.Text = "Status";
            lblOpProgress.Visible = false;
            // 
            // btnContinue
            // 
            btnContinue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnContinue.Enabled = false;
            btnContinue.Location = new Point(307, 285);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(172, 43);
            btnContinue.TabIndex = 4;
            btnContinue.Text = "Continue to Mod Manager";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Visible = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // BepInExInstaller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(23, 23, 23);
            Controls.Add(btnContinue);
            Controls.Add(lblOpProgress);
            Controls.Add(pbProcessProgress);
            Controls.Add(label1);
            Controls.Add(btnInstallBepInEx);
            Name = "BepInExInstaller";
            Size = new Size(800, 378);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInstallBepInEx;
        private Label label1;
        private ProgressBar pbProcessProgress;
        private Label lblOpProgress;
        private Button btnContinue;
    }
}
