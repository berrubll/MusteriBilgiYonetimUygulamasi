namespace MusteriBilgiYonetimUygulamasi
{
    partial class LoginScreen
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            textBox2 = new System.Windows.Forms.TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Poppins", 25.800001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            label1.Location = new System.Drawing.Point(92, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(321, 71);
            label1.TabIndex = 0;
            label1.Text = "Hoşgeldiniz";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            label2.Location = new System.Drawing.Point(92, 99);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(321, 71);
            label2.TabIndex = 1;
            label2.Text = "Lütfen Giriş Yapınız\r\n";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            textBox1.Location = new System.Drawing.Point(63, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(375, 37);
            textBox1.TabIndex = 2;
            textBox1.PlaceholderText = "Kullanıcı Adı";
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(595, 654);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)5)), ((int)((byte)117)), ((int)((byte)230)));
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(63, 259);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(375, 45);
            button1.TabIndex = 4;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
            textBox2.Location = new System.Drawing.Point(63, 216);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(375, 37);
            textBox2.TabIndex = 3;
            textBox2.PlaceholderText = "Şifre";
            textBox2.UseSystemPasswordChar = true;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(499, 359);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Text = "Müşteri Bilgi Yönetim Sistemi - Giriş";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}
