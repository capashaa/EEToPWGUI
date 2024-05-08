




namespace EEtoPWGUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            txtbAuthTokenOrEmail = new TextBox();
            lblWorldId = new Label();
            txtbWorldId = new TextBox();
            label1 = new Label();
            txtbFileName = new TextBox();
            label2 = new Label();
            button1 = new Button();
            btnImport = new Button();
            SuspendLayout();
            // 
            // txtbAuthTokenOrEmail
            // 
            txtbAuthTokenOrEmail.Location = new Point(12, 29);
            txtbAuthTokenOrEmail.Name = "txtbAuthTokenOrEmail";
            txtbAuthTokenOrEmail.Size = new Size(130, 23);
            txtbAuthTokenOrEmail.TabIndex = 2;
            txtbAuthTokenOrEmail.UseSystemPasswordChar = true;
            // 
            // lblWorldId
            // 
            lblWorldId.AutoSize = true;
            lblWorldId.Location = new Point(12, 64);
            lblWorldId.Name = "lblWorldId";
            lblWorldId.Size = new Size(50, 15);
            lblWorldId.TabIndex = 4;
            lblWorldId.Text = "WorldID";
            // 
            // txtbWorldId
            // 
            txtbWorldId.Location = new Point(12, 82);
            txtbWorldId.Name = "txtbWorldId";
            txtbWorldId.Size = new Size(130, 23);
            txtbWorldId.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 6;
            label1.Text = "EELVL FileName";
            // 
            // txtbFileName
            // 
            txtbFileName.Location = new Point(157, 29);
            txtbFileName.Name = "txtbFileName";
            txtbFileName.Size = new Size(130, 23);
            txtbFileName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 5);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 8;
            label2.Text = "AuthToken";
            // 
            // button1
            // 
            button1.Location = new Point(121, 134);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Upload";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(157, 60);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(75, 23);
            btnImport.TabIndex = 11;
            btnImport.Text = "Import...";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 168);
            Controls.Add(btnImport);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtbFileName);
            Controls.Add(label1);
            Controls.Add(txtbWorldId);
            Controls.Add(lblWorldId);
            Controls.Add(txtbAuthTokenOrEmail);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtbAuthTokenOrEmail;
        private Label lblWorldId;
        private TextBox txtbWorldId;
        private Label label1;
        private TextBox txtbFileName;
        private Label label2;
        private Button button1;
        private Button btnImport;
    }
}
