namespace UnityModManager.Controls
{
    partial class ProfileBuilderMainView
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
            lblTitle = new Label();
            lbCurrentMods = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnIncrementVersion = new Button();
            btnRemoveItem = new Button();
            btnAddFile = new Button();
            btnAddFolder = new Button();
            label3 = new Label();
            btnClose = new Button();
            btnInspectProfile = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Snow;
            lblTitle.Location = new Point(17, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(345, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Profile Builder - Loading Profile Name...";
            // 
            // lbCurrentMods
            // 
            lbCurrentMods.AllowDrop = true;
            lbCurrentMods.BackColor = Color.FromArgb(35, 35, 35);
            lbCurrentMods.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCurrentMods.ForeColor = Color.Snow;
            lbCurrentMods.FormattingEnabled = true;
            lbCurrentMods.ItemHeight = 21;
            lbCurrentMods.Location = new Point(17, 78);
            lbCurrentMods.Name = "lbCurrentMods";
            lbCurrentMods.Size = new Size(530, 277);
            lbCurrentMods.TabIndex = 1;
            lbCurrentMods.SelectedIndexChanged += lbCurrentMods_SelectedIndexChanged;
            lbCurrentMods.DragDrop += lbCurrentMods_DragDrop;
            lbCurrentMods.DragEnter += lbCurrentMods_DragEnter;
            lbCurrentMods.DragLeave += lbCurrentMods_DragLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(17, 60);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Mods";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(298, 60);
            label2.Name = "label2";
            label2.Size = new Size(249, 15);
            label2.TabIndex = 4;
            label2.Text = "Drag and drop folder or DLL on the list to add.";
            // 
            // btnIncrementVersion
            // 
            btnIncrementVersion.Location = new Point(571, 223);
            btnIncrementVersion.Name = "btnIncrementVersion";
            btnIncrementVersion.Size = new Size(204, 28);
            btnIncrementVersion.TabIndex = 5;
            btnIncrementVersion.Text = "Increment Profile Version";
            btnIncrementVersion.UseVisualStyleBackColor = true;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.FromArgb(255, 192, 192);
            btnRemoveItem.Location = new Point(571, 146);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(204, 28);
            btnRemoveItem.TabIndex = 6;
            btnRemoveItem.Text = "Remove Selected Item";
            btnRemoveItem.UseVisualStyleBackColor = false;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnAddFile
            // 
            btnAddFile.BackColor = Color.FromArgb(192, 255, 192);
            btnAddFile.Location = new Point(571, 78);
            btnAddFile.Name = "btnAddFile";
            btnAddFile.Size = new Size(204, 28);
            btnAddFile.TabIndex = 7;
            btnAddFile.Text = "Add DLL";
            btnAddFile.UseVisualStyleBackColor = false;
            btnAddFile.Click += btnAddFile_Click;
            // 
            // btnAddFolder
            // 
            btnAddFolder.BackColor = Color.FromArgb(192, 255, 192);
            btnAddFolder.Location = new Point(571, 112);
            btnAddFolder.Name = "btnAddFolder";
            btnAddFolder.Size = new Size(204, 28);
            btnAddFolder.TabIndex = 8;
            btnAddFolder.Text = "Add Folder";
            btnAddFolder.UseVisualStyleBackColor = false;
            btnAddFolder.Click += btnAddFolder_Click;
            // 
            // label3
            // 
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(571, 332);
            label3.Name = "label3";
            label3.Size = new Size(204, 35);
            label3.TabIndex = 9;
            label3.Text = "Changes to profiles are saved and effective immediately.";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(571, 291);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(204, 28);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close Builder";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnInspectProfile
            // 
            btnInspectProfile.Location = new Point(571, 257);
            btnInspectProfile.Name = "btnInspectProfile";
            btnInspectProfile.Size = new Size(204, 28);
            btnInspectProfile.TabIndex = 11;
            btnInspectProfile.Text = "Inspect Directory";
            btnInspectProfile.UseVisualStyleBackColor = true;
            btnInspectProfile.Click += btnInspectProfile_Click;
            // 
            // ProfileBuilderMainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            Controls.Add(btnInspectProfile);
            Controls.Add(btnClose);
            Controls.Add(label3);
            Controls.Add(btnAddFolder);
            Controls.Add(btnAddFile);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnIncrementVersion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbCurrentMods);
            Controls.Add(lblTitle);
            Name = "ProfileBuilderMainView";
            Size = new Size(800, 388);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListBox lbCurrentMods;
        private Label label1;
        private Label label2;
        private Button btnIncrementVersion;
        private Button btnRemoveItem;
        private Button btnAddFile;
        private Button btnAddFolder;
        private Label label3;
        private Button btnClose;
        private Button btnInspectProfile;
    }
}
