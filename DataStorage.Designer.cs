
namespace ITools
{
    partial class DataStorage
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
            this.components = new System.ComponentModel.Container();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txbContents = new System.Windows.Forms.TextBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnChoose.FlatAppearance.BorderSize = 0;
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnChoose.Location = new System.Drawing.Point(450, 13);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(91, 21);
            this.btnChoose.TabIndex = 10;
            this.btnChoose.Text = "Choose File";
            this.toolTip1.SetToolTip(this.btnChoose, "Reads in the contents of the chosen File.\r\nNeeded for Decryption to work.");
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnEncrypt.FlatAppearance.BorderSize = 0;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnEncrypt.Location = new System.Drawing.Point(351, 13);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(92, 21);
            this.btnEncrypt.TabIndex = 9;
            this.btnEncrypt.Text = "Save";
            this.toolTip1.SetToolTip(this.btnEncrypt, "Saves whatever you wrote into the Textfield below.\r\nWill encrypt your text with t" +
        "he specified password.");
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnDecrypt.FlatAppearance.BorderSize = 0;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDecrypt.Location = new System.Drawing.Point(242, 13);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(102, 21);
            this.btnDecrypt.TabIndex = 8;
            this.btnDecrypt.Text = "Decrypt";
            this.toolTip1.SetToolTip(this.btnDecrypt, "Decrypts the File contents of the open file\r\nwith the password given.\r\nTo open a " +
        "File use the \"Choose File\" button.");
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txbContents
            // 
            this.txbContents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.txbContents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbContents.Location = new System.Drawing.Point(13, 40);
            this.txbContents.Multiline = true;
            this.txbContents.Name = "txbContents";
            this.txbContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbContents.Size = new System.Drawing.Size(775, 398);
            this.txbContents.TabIndex = 7;
            // 
            // txbPass
            // 
            this.txbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.txbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txbPass.Location = new System.Drawing.Point(71, 17);
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(165, 13);
            this.txbPass.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txbPass, "Specify your password for the file here.\r\nIf you want to decrypt, enter password " +
        "and press decrypt.\r\nIf you want to encrypt, enter password and press save.");
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Help";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password";
            // 
            // DataStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txbContents);
            this.Controls.Add(this.txbPass);
            this.Name = "DataStorage";
            this.Text = "DataStorage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnChoose;
        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button btnEncrypt;
        public System.Windows.Forms.Button btnDecrypt;
        public System.Windows.Forms.TextBox txbContents;
        public System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Label label1;
    }
}