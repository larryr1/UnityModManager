namespace UnityModManager.Controls
{
    partial class GameNotSupported
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
            label2 = new Label();
            lblErrorReason = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(233, 51);
            label1.Name = "label1";
            label1.Size = new Size(334, 32);
            label1.TabIndex = 2;
            label1.Text = "This game is not supported.";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(326, 323);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(148, 31);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close UMM";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(216, 128);
            label2.Name = "label2";
            label2.Size = new Size(369, 15);
            label2.TabIndex = 4;
            label2.Text = "UMM does not support modding this game for the following reason:";
            // 
            // lblErrorReason
            // 
            lblErrorReason.BackColor = Color.FromArgb(30, 30, 30);
            lblErrorReason.ForeColor = Color.Snow;
            lblErrorReason.Location = new Point(122, 158);
            lblErrorReason.Name = "lblErrorReason";
            lblErrorReason.Size = new Size(557, 116);
            lblErrorReason.TabIndex = 5;
            lblErrorReason.Text = "Loading reason...";
            // 
            // GameNotSupported
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            Controls.Add(lblErrorReason);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Name = "GameNotSupported";
            Size = new Size(800, 378);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnClose;
        private Label label2;
        private Label lblErrorReason;
    }
}
