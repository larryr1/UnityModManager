﻿namespace UnityModManager.Controls
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
            lblSharingCode = new Label();
            tbShareCode = new TextBox();
            lblImportStatus = new Label();
            SuspendLayout();
            // 
            // lbGameName
            // 
            lbGameName.AutoSize = true;
            lbGameName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGameName.ForeColor = Color.Snow;
            lbGameName.Location = new Point(19, 19);
            lbGameName.Name = "lbGameName";
            lbGameName.Size = new Size(209, 32);
            lbGameName.TabIndex = 1;
            lbGameName.Text = "Web and Sharing";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(676, 22);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(102, 37);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back to Game";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(33, 238);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(286, 41);
            btnImport.TabIndex = 3;
            btnImport.Text = "Import Profile";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // lbProfiles
            // 
            lbProfiles.BackColor = Color.FromArgb(35, 35, 35);
            lbProfiles.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbProfiles.ForeColor = Color.Snow;
            lbProfiles.FormattingEnabled = true;
            lbProfiles.ItemHeight = 21;
            lbProfiles.Location = new Point(380, 107);
            lbProfiles.Name = "lbProfiles";
            lbProfiles.Size = new Size(398, 172);
            lbProfiles.TabIndex = 4;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(380, 292);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(397, 40);
            btnExport.TabIndex = 5;
            btnExport.Text = "Export Profile";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(58, 134);
            label1.Name = "label1";
            label1.Size = new Size(261, 54);
            label1.TabIndex = 6;
            label1.Text = "Import a profile via a sharing code, or export a profile you select.";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(732, 89);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 7;
            label2.Text = "Profiles";
            // 
            // lblExportStatus
            // 
            lblExportStatus.AutoSize = true;
            lblExportStatus.ForeColor = Color.Snow;
            lblExportStatus.Location = new Point(380, 335);
            lblExportStatus.Margin = new Padding(2, 0, 2, 0);
            lblExportStatus.Name = "lblExportStatus";
            lblExportStatus.Size = new Size(89, 15);
            lblExportStatus.TabIndex = 8;
            lblExportStatus.Text = "Ready to Export";
            // 
            // lblSharingCode
            // 
            lblSharingCode.AutoSize = true;
            lblSharingCode.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSharingCode.ForeColor = Color.Cyan;
            lblSharingCode.Location = new Point(625, 335);
            lblSharingCode.Margin = new Padding(2, 0, 2, 0);
            lblSharingCode.Name = "lblSharingCode";
            lblSharingCode.Size = new Size(152, 15);
            lblSharingCode.TabIndex = 9;
            lblSharingCode.Text = "Click to Copy Sharing Code";
            lblSharingCode.Visible = false;
            lblSharingCode.Click += lblSharingCode_Click;
            // 
            // tbShareCode
            // 
            tbShareCode.Location = new Point(33, 213);
            tbShareCode.Name = "tbShareCode";
            tbShareCode.PlaceholderText = "Share Code";
            tbShareCode.Size = new Size(286, 23);
            tbShareCode.TabIndex = 10;
            tbShareCode.TextAlign = HorizontalAlignment.Center;
            // 
            // lblImportStatus
            // 
            lblImportStatus.AutoSize = true;
            lblImportStatus.ForeColor = Color.Snow;
            lblImportStatus.Location = new Point(33, 282);
            lblImportStatus.Margin = new Padding(2, 0, 2, 0);
            lblImportStatus.Name = "lblImportStatus";
            lblImportStatus.Size = new Size(92, 15);
            lblImportStatus.TabIndex = 11;
            lblImportStatus.Text = "Ready to Import";
            // 
            // WebView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            Controls.Add(lblImportStatus);
            Controls.Add(tbShareCode);
            Controls.Add(lblSharingCode);
            Controls.Add(lblExportStatus);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExport);
            Controls.Add(lbProfiles);
            Controls.Add(btnImport);
            Controls.Add(btnBack);
            Controls.Add(lbGameName);
            Name = "WebView";
            Size = new Size(800, 378);
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
        private Label lblSharingCode;
        private TextBox tbShareCode;
        private Label lblImportStatus;
    }
}
