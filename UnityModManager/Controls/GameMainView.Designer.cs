namespace UnityModManager.Controls
{
    partial class GameMainView
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
            lbGameName = new Label();
            lbProfiles = new ListBox();
            label1 = new Label();
            btnLoadProfile = new Button();
            btnUnloadProfile = new Button();
            label2 = new Label();
            label3 = new Label();
            lbLoadedProfiles = new ListBox();
            btnBuilder = new Button();
            btnWeb = new Button();
            btnNewProfile = new Button();
            SuspendLayout();
            // 
            // lbGameName
            // 
            lbGameName.AutoSize = true;
            lbGameName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGameName.ForeColor = Color.Snow;
            lbGameName.Location = new Point(19, 19);
            lbGameName.Name = "lbGameName";
            lbGameName.Size = new Size(146, 32);
            lbGameName.TabIndex = 0;
            lbGameName.Text = "GameName";
            // 
            // lbProfiles
            // 
            lbProfiles.BackColor = Color.FromArgb(35, 35, 35);
            lbProfiles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbProfiles.ForeColor = Color.Snow;
            lbProfiles.FormattingEnabled = true;
            lbProfiles.ItemHeight = 21;
            lbProfiles.Location = new Point(299, 32);
            lbProfiles.Name = "lbProfiles";
            lbProfiles.Size = new Size(479, 298);
            lbProfiles.TabIndex = 1;
            lbProfiles.SelectedIndexChanged += lbProfiles_SelectedIndexChanged;
            lbProfiles.DoubleClick += btnLoadProfile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(732, 14);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Profiles";
            // 
            // btnLoadProfile
            // 
            btnLoadProfile.BackColor = Color.Gray;
            btnLoadProfile.Enabled = false;
            btnLoadProfile.Location = new Point(686, 336);
            btnLoadProfile.Name = "btnLoadProfile";
            btnLoadProfile.Size = new Size(92, 42);
            btnLoadProfile.TabIndex = 3;
            btnLoadProfile.Text = "Load";
            btnLoadProfile.UseVisualStyleBackColor = false;
            btnLoadProfile.Click += btnLoadProfile_Click;
            // 
            // btnUnloadProfile
            // 
            btnUnloadProfile.BackColor = Color.Gray;
            btnUnloadProfile.Enabled = false;
            btnUnloadProfile.Location = new Point(588, 336);
            btnUnloadProfile.Name = "btnUnloadProfile";
            btnUnloadProfile.Size = new Size(92, 42);
            btnUnloadProfile.TabIndex = 4;
            btnUnloadProfile.Text = " Unload";
            btnUnloadProfile.UseVisualStyleBackColor = false;
            btnUnloadProfile.Click += btnUnloadProfile_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(204, 54);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 5;
            label2.Text = "Current Loaded";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(19, 350);
            label3.Name = "label3";
            label3.Size = new Size(220, 15);
            label3.TabIndex = 7;
            label3.Text = "UMM does not save config with profiles.";
            // 
            // lbLoadedProfiles
            // 
            lbLoadedProfiles.BackColor = Color.FromArgb(35, 35, 35);
            lbLoadedProfiles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLoadedProfiles.ForeColor = Color.Snow;
            lbLoadedProfiles.FormattingEnabled = true;
            lbLoadedProfiles.ItemHeight = 21;
            lbLoadedProfiles.Location = new Point(23, 74);
            lbLoadedProfiles.Name = "lbLoadedProfiles";
            lbLoadedProfiles.Size = new Size(270, 256);
            lbLoadedProfiles.TabIndex = 9;
            lbLoadedProfiles.SelectedIndexChanged += lbLoadedProfiles_SelectedIndexChanged;
            lbLoadedProfiles.DoubleClick += btnUnloadProfile_Click;
            // 
            // btnBuilder
            // 
            btnBuilder.BackColor = Color.Snow;
            btnBuilder.Location = new Point(490, 336);
            btnBuilder.Name = "btnBuilder";
            btnBuilder.Size = new Size(92, 42);
            btnBuilder.TabIndex = 10;
            btnBuilder.Text = "Builder";
            btnBuilder.UseVisualStyleBackColor = false;
            btnBuilder.Click += btnBuilder_Click;
            // 
            // btnWeb
            // 
            btnWeb.BackColor = Color.Snow;
            btnWeb.Location = new Point(392, 336);
            btnWeb.Name = "btnWeb";
            btnWeb.Size = new Size(92, 42);
            btnWeb.TabIndex = 11;
            btnWeb.Text = "Web...";
            btnWeb.UseVisualStyleBackColor = false;
            btnWeb.Click += btnWeb_Click;
            // 
            // btnNewProfile
            // 
            btnNewProfile.BackColor = Color.Snow;
            btnNewProfile.Location = new Point(294, 336);
            btnNewProfile.Name = "btnNewProfile";
            btnNewProfile.Size = new Size(92, 42);
            btnNewProfile.TabIndex = 12;
            btnNewProfile.Text = "New Profile";
            btnNewProfile.UseVisualStyleBackColor = false;
            btnNewProfile.Click += btnNewProfile_Click;
            // 
            // GameMainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            Controls.Add(btnNewProfile);
            Controls.Add(btnWeb);
            Controls.Add(btnBuilder);
            Controls.Add(lbLoadedProfiles);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnUnloadProfile);
            Controls.Add(btnLoadProfile);
            Controls.Add(label1);
            Controls.Add(lbProfiles);
            Controls.Add(lbGameName);
            Name = "GameMainView";
            Size = new Size(800, 378);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbGameName;
        private ListBox lbProfiles;
        private Label label1;
        private Button btnLoadProfile;
        private Button btnUnloadProfile;
        private Label label2;
        private Label label3;
        private ListBox lbLoadedProfiles;
        private Button btnBuilder;
        private Button btnWeb;
        private Button btnNewProfile;
    }
}
