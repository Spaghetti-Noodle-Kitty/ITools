
namespace ITools
{
    partial class Encryption
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.txbIN = new System.Windows.Forms.TextBox();
            this.txbOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Encrypt + Base64";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button2.Location = new System.Drawing.Point(212, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(420, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Password";
            // 
            // txbPass
            // 
            this.txbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.txbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txbPass.Location = new System.Drawing.Point(479, 18);
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(309, 13);
            this.txbPass.TabIndex = 12;
            // 
            // txbIN
            // 
            this.txbIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.txbIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txbIN.Location = new System.Drawing.Point(13, 80);
            this.txbIN.Multiline = true;
            this.txbIN.Name = "txbIN";
            this.txbIN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbIN.Size = new System.Drawing.Size(382, 358);
            this.txbIN.TabIndex = 14;
            // 
            // txbOut
            // 
            this.txbOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.txbOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txbOut.Location = new System.Drawing.Point(406, 80);
            this.txbOut.Multiline = true;
            this.txbOut.Name = "txbOut";
            this.txbOut.ReadOnly = true;
            this.txbOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbOut.Size = new System.Drawing.Size(382, 358);
            this.txbOut.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label3.Location = new System.Drawing.Point(403, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Output";
            // 
            // Encryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbOut);
            this.Controls.Add(this.txbIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Encryption";
            this.Text = "Encryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.TextBox txbIN;
        private System.Windows.Forms.TextBox txbOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}