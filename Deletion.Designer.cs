
namespace ITools
{
    partial class Deletion
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
            this.txbFileName = new System.Windows.Forms.TextBox();
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbFileName
            // 
            this.txbFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.txbFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txbFileName.Location = new System.Drawing.Point(188, 18);
            this.txbFileName.Name = "txbFileName";
            this.txbFileName.ReadOnly = true;
            this.txbFileName.Size = new System.Drawing.Size(600, 15);
            this.txbFileName.TabIndex = 19;
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btnFileSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnFileSelect.Location = new System.Drawing.Point(12, 15);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(170, 23);
            this.btnFileSelect.TabIndex = 20;
            this.btnFileSelect.Text = "Select File";
            this.btnFileSelect.UseVisualStyleBackColor = false;
            this.btnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.ForeColor = System.Drawing.Color.Red;
            this.Delete.Location = new System.Drawing.Point(12, 64);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(776, 23);
            this.Delete.TabIndex = 21;
            this.Delete.Text = "Delete File Securely";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Warning, this can\'t be undone!";
            // 
            // Deletion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 101);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.btnFileSelect);
            this.Controls.Add(this.txbFileName);
            this.Name = "Deletion";
            this.Text = "Deletion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbFileName;
        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label1;
    }
}