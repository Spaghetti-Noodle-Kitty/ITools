
namespace ITools
{
    partial class Hashing
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbHash = new System.Windows.Forms.TextBox();
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.txbFileName = new System.Windows.Forms.TextBox();
            this.btnSaveOut = new System.Windows.Forms.Button();
            this.btnCompareSHA256 = new System.Windows.Forms.Button();
            this.btnCompareMD5 = new System.Windows.Forms.Button();
            this.btnSHA256hash = new System.Windows.Forms.Button();
            this.btnMD5hash = new System.Windows.Forms.Button();
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(188, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Hash";
            // 
            // txbHash
            // 
            this.txbHash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.txbHash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txbHash.Location = new System.Drawing.Point(188, 56);
            this.txbHash.Name = "txbHash";
            this.txbHash.Size = new System.Drawing.Size(600, 15);
            this.txbHash.TabIndex = 20;
            // 
            // txbOutput
            // 
            this.txbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.txbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbOutput.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txbOutput.Location = new System.Drawing.Point(188, 82);
            this.txbOutput.Multiline = true;
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.ReadOnly = true;
            this.txbOutput.Size = new System.Drawing.Size(600, 356);
            this.txbOutput.TabIndex = 19;
            // 
            // txbFileName
            // 
            this.txbFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.txbFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txbFileName.Location = new System.Drawing.Point(188, 15);
            this.txbFileName.Name = "txbFileName";
            this.txbFileName.ReadOnly = true;
            this.txbFileName.Size = new System.Drawing.Size(600, 15);
            this.txbFileName.TabIndex = 18;
            // 
            // btnSaveOut
            // 
            this.btnSaveOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnSaveOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnSaveOut.Location = new System.Drawing.Point(13, 241);
            this.btnSaveOut.Name = "btnSaveOut";
            this.btnSaveOut.Size = new System.Drawing.Size(170, 23);
            this.btnSaveOut.TabIndex = 17;
            this.btnSaveOut.Text = "Save Output";
            this.btnSaveOut.UseVisualStyleBackColor = false;
            this.btnSaveOut.Click += new System.EventHandler(this.btnSaveOut_Click);
            // 
            // btnCompareSHA256
            // 
            this.btnCompareSHA256.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnCompareSHA256.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompareSHA256.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCompareSHA256.Location = new System.Drawing.Point(13, 140);
            this.btnCompareSHA256.Name = "btnCompareSHA256";
            this.btnCompareSHA256.Size = new System.Drawing.Size(170, 23);
            this.btnCompareSHA256.TabIndex = 16;
            this.btnCompareSHA256.Text = "Compare SHA256";
            this.btnCompareSHA256.UseVisualStyleBackColor = false;
            this.btnCompareSHA256.Click += new System.EventHandler(this.btnCompareSHA256_Click);
            // 
            // btnCompareMD5
            // 
            this.btnCompareMD5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnCompareMD5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompareMD5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCompareMD5.Location = new System.Drawing.Point(13, 111);
            this.btnCompareMD5.Name = "btnCompareMD5";
            this.btnCompareMD5.Size = new System.Drawing.Size(170, 23);
            this.btnCompareMD5.TabIndex = 15;
            this.btnCompareMD5.Text = "Compare MD5";
            this.btnCompareMD5.UseVisualStyleBackColor = false;
            this.btnCompareMD5.Click += new System.EventHandler(this.btnCompareMD5_Click);
            // 
            // btnSHA256hash
            // 
            this.btnSHA256hash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnSHA256hash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHA256hash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnSHA256hash.Location = new System.Drawing.Point(13, 82);
            this.btnSHA256hash.Name = "btnSHA256hash";
            this.btnSHA256hash.Size = new System.Drawing.Size(170, 23);
            this.btnSHA256hash.TabIndex = 13;
            this.btnSHA256hash.Text = "Calculate SHA256";
            this.btnSHA256hash.UseVisualStyleBackColor = false;
            this.btnSHA256hash.Click += new System.EventHandler(this.btnSHA256hash_Click);
            // 
            // btnMD5hash
            // 
            this.btnMD5hash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnMD5hash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMD5hash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnMD5hash.Location = new System.Drawing.Point(12, 53);
            this.btnMD5hash.Name = "btnMD5hash";
            this.btnMD5hash.Size = new System.Drawing.Size(170, 23);
            this.btnMD5hash.TabIndex = 12;
            this.btnMD5hash.Text = "Claculate MD5";
            this.btnMD5hash.UseVisualStyleBackColor = false;
            this.btnMD5hash.Click += new System.EventHandler(this.btnMD5hash_Click);
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnFileSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnFileSelect.Location = new System.Drawing.Point(12, 12);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(170, 23);
            this.btnFileSelect.TabIndex = 11;
            this.btnFileSelect.Text = "Select File";
            this.btnFileSelect.UseVisualStyleBackColor = false;
            this.btnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click);
            // 
            // Hashing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbHash);
            this.Controls.Add(this.txbOutput);
            this.Controls.Add(this.txbFileName);
            this.Controls.Add(this.btnSaveOut);
            this.Controls.Add(this.btnCompareSHA256);
            this.Controls.Add(this.btnCompareMD5);
            this.Controls.Add(this.btnSHA256hash);
            this.Controls.Add(this.btnMD5hash);
            this.Controls.Add(this.btnFileSelect);
            this.Name = "Hashing";
            this.Text = "Hashing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hashing_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbHash;
        private System.Windows.Forms.TextBox txbOutput;
        private System.Windows.Forms.TextBox txbFileName;
        private System.Windows.Forms.Button btnSaveOut;
        private System.Windows.Forms.Button btnCompareSHA256;
        private System.Windows.Forms.Button btnCompareMD5;
        private System.Windows.Forms.Button btnSHA256hash;
        private System.Windows.Forms.Button btnMD5hash;
        private System.Windows.Forms.Button btnFileSelect;
    }
}