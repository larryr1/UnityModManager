namespace UnityModManager.Controls
{
    partial class BepInExFirstLaunchWarning
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
            label1 = new Label();
            btnClose = new Button();
            lnkAlreadyLaunched = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(71, 108);
            label1.Name = "label1";
            label1.Size = new Size(658, 32);
            label1.TabIndex = 2;
            label1.Text = "Please launch the game at least once, then restart UMM.";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(326, 164);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(148, 31);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close UMM";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lnkAlreadyLaunched
            // 
            lnkAlreadyLaunched.LinkColor = Color.FromArgb(0, 192, 192);
            lnkAlreadyLaunched.Location = new Point(326, 209);
            lnkAlreadyLaunched.Name = "lnkAlreadyLaunched";
            lnkAlreadyLaunched.Size = new Size(148, 20);
            lnkAlreadyLaunched.TabIndex = 4;
            lnkAlreadyLaunched.TabStop = true;
            lnkAlreadyLaunched.Text = "I already launched it!";
            lnkAlreadyLaunched.TextAlign = ContentAlignment.MiddleCenter;
            lnkAlreadyLaunched.LinkClicked += lnkAlreadyLaunched_LinkClicked;
            // 
            // BepInExFirstLaunchWarning
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            Controls.Add(lnkAlreadyLaunched);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Name = "BepInExFirstLaunchWarning";
            Size = new Size(800, 378);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnClose;
        private LinkLabel lnkAlreadyLaunched;
    }
}
