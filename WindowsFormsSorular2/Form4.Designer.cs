namespace WindowsFormsSorular2
{
    partial class Form4
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCıkar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.btnDiziEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(50, 331);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCıkar
            // 
            this.btnCıkar.Location = new System.Drawing.Point(228, 331);
            this.btnCıkar.Name = "btnCıkar";
            this.btnCıkar.Size = new System.Drawing.Size(75, 23);
            this.btnCıkar.TabIndex = 1;
            this.btnCıkar.Text = "Çıkar";
            this.btnCıkar.UseVisualStyleBackColor = true;
            this.btnCıkar.Click += new System.EventHandler(this.btnCıkar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(50, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 292);
            this.listBox1.TabIndex = 2;
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(380, 13);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(253, 22);
            this.txtEkle.TabIndex = 3;
            // 
            // btnDiziEkle
            // 
            this.btnDiziEkle.Location = new System.Drawing.Point(558, 65);
            this.btnDiziEkle.Name = "btnDiziEkle";
            this.btnDiziEkle.Size = new System.Drawing.Size(75, 23);
            this.btnDiziEkle.TabIndex = 4;
            this.btnDiziEkle.Text = "Dizi Ekle";
            this.btnDiziEkle.UseVisualStyleBackColor = true;
            this.btnDiziEkle.Click += new System.EventHandler(this.btnDiziEkle_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDiziEkle);
            this.Controls.Add(this.txtEkle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCıkar);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCıkar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtEkle;
        private System.Windows.Forms.Button btnDiziEkle;
    }
}