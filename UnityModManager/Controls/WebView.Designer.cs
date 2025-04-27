namespace UnityModManager.Controls
{
    partial class WebView
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
            btnBack = new Button();
            btnImport = new Button();
            lbProfiles = new ListBox();
            btnExport = new Button();
            label1 = new Label();
            label2 = new Label();
            lblExportStatus = new Label();
            SuspendLayout();
            // 
            // lbGameName
            // 
            lbGameName.AutoSize = true;
            lbGameName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGameName.ForeColor = Color.Snow;
            lbGameName.Location = new Point(27, 32);
            lbGameName.Margin = new Padding(4, 0, 4, 0);
            lbGameName.Name = "lbGameName";
            lbGameName.Size = new Size(308, 48);
            lbGameName.TabIndex = 1;
            lbGameName.Text = "Web and Sharing";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(966, 37);
            btnBack.Margin = new Padding(4, 5, 4, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(146, 62);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back to Game";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(120, 318);
            btnImport.Margin = new Padding(4, 5, 4, 5);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(299, 68);
            btnImport.TabIndex = 3;
            btnImport.Text = "Import Profile";
            btnImport.UseVisualStyleBackColor = true;
            // 
            // lbProfiles
            // 
            lbProfiles.BackColor = Color.FromArgb(35, 35, 35);
            lbProfiles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbProfiles.ForeColor = Color.Snow;
            lbProfiles.FormattingEnabled = true;
            lbProfiles.ItemHeight = 32;
            lbProfiles.Location = new Point(543, 178);
            lbProfiles.Margin = new Padding(4, 5, 4, 5);
            lbProfiles.Name = "lbProfiles";
            lbProfiles.Size = new Size(567, 292);
            lbProfiles.TabIndex = 4;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(543, 487);
            btnExport.Margin = new Padding(4, 5, 4, 5);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(567, 67);
            btnExport.TabIndex = 5;
            btnExport.Text = "Export Profile";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(83, 223);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(373, 90);
            label1.TabIndex = 6;
            label1.Text = "Import a profile via a link, or export a profile you select.";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(1046, 148);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 7;
            label2.Text = "Profiles";
            // 
            // lblExportStatus
            // 
            lblExportStatus.AutoSize = true;
            lblExportStatus.ForeColor = Color.Snow;
            lblExportStatus.Location = new Point(543, 559);
            lblExportStatus.Name = "lblExportStatus";
            lblExportStatus.Size = new Size(138, 25);
            lblExportStatus.TabIndex = 8;
            lblExportStatus.Text = "Ready to Export";
            // 
            // WebView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            Controls.Add(lblExportStatus);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExport);
            Controls.Add(lbProfiles);
            Controls.Add(btnImport);
            Controls.Add(btnBack);
            Controls.Add(lbGameName);
            Margin = new Padding(4, 5, 4, 5);
            Name = "WebView";
            Size = new Size(1143, 630);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbGameName;
        private Button btnBack;
        private Button btnImport;
        private ListBox lbProfiles;
        private Button btnExport;
        private Label label1;
        private Label label2;
        private Label lblExportStatus;
    }
}
