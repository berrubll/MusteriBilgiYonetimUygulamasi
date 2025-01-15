using System.ComponentModel;

namespace MusteriBilgiYonetimUygulamasi;

partial class CustomerDetailsForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        label1 = new System.Windows.Forms.Label();
        nameTxt = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        surnameTxt = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        phoneTxt = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        mailTxt = new System.Windows.Forms.TextBox();
        label6 = new System.Windows.Forms.Label();
        adressTxt = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        label7 = new System.Windows.Forms.Label();
        checkBox1 = new System.Windows.Forms.CheckBox();
        panel1 = new System.Windows.Forms.Panel();
        label8 = new System.Windows.Forms.Label();
        button3 = new System.Windows.Forms.Button();
        faturaListPanel = new System.Windows.Forms.Panel();
        panel2 = new System.Windows.Forms.Panel();
        button4 = new System.Windows.Forms.Button();
        label15 = new System.Windows.Forms.Label();
        label14 = new System.Windows.Forms.Label();
        label13 = new System.Windows.Forms.Label();
        label9 = new System.Windows.Forms.Label();
        label10 = new System.Windows.Forms.Label();
        label11 = new System.Windows.Forms.Label();
        label12 = new System.Windows.Forms.Label();
        faturaListPanel.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
        label1.Location = new System.Drawing.Point(70, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(300, 59);
        label1.TabIndex = 0;
        label1.Text = "Müşteri Detay";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // nameTxt
        // 
        nameTxt.Location = new System.Drawing.Point(162, 89);
        nameTxt.Name = "nameTxt";
        nameTxt.Size = new System.Drawing.Size(270, 27);
        nameTxt.TabIndex = 1;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        label2.Location = new System.Drawing.Point(28, 84);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(128, 41);
        label2.TabIndex = 2;
        label2.Text = "İsim:";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        label3.Location = new System.Drawing.Point(28, 123);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(128, 41);
        label3.TabIndex = 4;
        label3.Text = "Soyisim:";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // surnameTxt
        // 
        surnameTxt.Location = new System.Drawing.Point(162, 128);
        surnameTxt.Name = "surnameTxt";
        surnameTxt.Size = new System.Drawing.Size(270, 27);
        surnameTxt.TabIndex = 3;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        label4.Location = new System.Drawing.Point(28, 162);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(128, 41);
        label4.TabIndex = 6;
        label4.Text = "Telefon:";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // phoneTxt
        // 
        phoneTxt.Location = new System.Drawing.Point(162, 167);
        phoneTxt.Name = "phoneTxt";
        phoneTxt.Size = new System.Drawing.Size(270, 27);
        phoneTxt.TabIndex = 5;
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        label5.Location = new System.Drawing.Point(28, 201);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(128, 41);
        label5.TabIndex = 8;
        label5.Text = "Email:";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // mailTxt
        // 
        mailTxt.Location = new System.Drawing.Point(162, 206);
        mailTxt.Name = "mailTxt";
        mailTxt.Size = new System.Drawing.Size(270, 27);
        mailTxt.TabIndex = 7;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        label6.Location = new System.Drawing.Point(28, 245);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(128, 59);
        label6.TabIndex = 10;
        label6.Text = "Adres:";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // adressTxt
        // 
        adressTxt.Location = new System.Drawing.Point(162, 245);
        adressTxt.Multiline = true;
        adressTxt.Name = "adressTxt";
        adressTxt.Size = new System.Drawing.Size(270, 59);
        adressTxt.TabIndex = 9;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)5)), ((int)((byte)117)), ((int)((byte)230)));
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        button1.ForeColor = System.Drawing.Color.White;
        button1.Location = new System.Drawing.Point(228, 356);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(204, 59);
        button1.TabIndex = 11;
        button1.Text = "Güncelle";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)5)), ((int)((byte)117)), ((int)((byte)230)));
        button2.FlatAppearance.BorderSize = 0;
        button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        button2.ForeColor = System.Drawing.Color.White;
        button2.Location = new System.Drawing.Point(28, 356);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(194, 59);
        button2.TabIndex = 12;
        button2.Text = "Vazgeç";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click_1;
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        label7.Location = new System.Drawing.Point(28, 304);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(128, 49);
        label7.TabIndex = 13;
        label7.Text = "Aktif Mi";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // checkBox1
        // 
        checkBox1.Location = new System.Drawing.Point(162, 307);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new System.Drawing.Size(71, 40);
        checkBox1.TabIndex = 14;
        checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.White;
        panel1.Location = new System.Drawing.Point(451, 5);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(10, 409);
        panel1.TabIndex = 15;
        // 
        // label8
        // 
        label8.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
        label8.Location = new System.Drawing.Point(467, 9);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(386, 59);
        label8.TabIndex = 16;
        label8.Text = "Müşteriye Ait Alışverişler";
        label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // button3
        // 
        button3.BackColor = System.Drawing.Color.FromArgb(((int)((byte)5)), ((int)((byte)117)), ((int)((byte)230)));
        button3.FlatAppearance.BorderSize = 0;
        button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        button3.ForeColor = System.Drawing.Color.White;
        button3.Location = new System.Drawing.Point(858, 9);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(121, 57);
        button3.TabIndex = 17;
        button3.Text = "Yeni Fatura";
        button3.UseVisualStyleBackColor = false;
        button3.Click += button3_Click;
        // 
        // faturaListPanel
        // 
        faturaListPanel.AutoScroll = true;
        faturaListPanel.BackColor = System.Drawing.Color.White;
        faturaListPanel.Controls.Add(panel2);
        faturaListPanel.Location = new System.Drawing.Point(467, 123);
        faturaListPanel.Name = "faturaListPanel";
        faturaListPanel.Size = new System.Drawing.Size(512, 292);
        faturaListPanel.TabIndex = 18;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.DimGray;
        panel2.Controls.Add(button4);
        panel2.Controls.Add(label15);
        panel2.Controls.Add(label14);
        panel2.Controls.Add(label13);
        panel2.Location = new System.Drawing.Point(3, 3);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(506, 51);
        panel2.TabIndex = 0;
        // 
        // button4
        // 
        button4.Location = new System.Drawing.Point(379, 2);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(127, 46);
        button4.TabIndex = 3;
        button4.Text = "Detay Gör";
        button4.UseVisualStyleBackColor = true;
        // 
        // label15
        // 
        label15.Location = new System.Drawing.Point(235, -2);
        label15.Name = "label15";
        label15.Size = new System.Drawing.Size(138, 54);
        label15.TabIndex = 2;
        label15.Text = "Kredi Kartı";
        label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label14
        // 
        label14.Location = new System.Drawing.Point(91, -3);
        label14.Name = "label14";
        label14.Size = new System.Drawing.Size(138, 54);
        label14.TabIndex = 1;
        label14.Text = "120.000TL";
        label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label13
        // 
        label13.Location = new System.Drawing.Point(1, 0);
        label13.Name = "label13";
        label13.Size = new System.Drawing.Size(85, 51);
        label13.TabIndex = 0;
        label13.Text = "313260";
        label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label9
        // 
        label9.Font = new System.Drawing.Font("SF Pro Rounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        label9.Location = new System.Drawing.Point(467, 93);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(88, 27);
        label9.TabIndex = 19;
        label9.Text = "Fatura No";
        label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label10
        // 
        label10.Font = new System.Drawing.Font("SF Pro Rounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        label10.Location = new System.Drawing.Point(561, 93);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(138, 27);
        label10.TabIndex = 20;
        label10.Text = "Toplam Tutar";
        label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label11
        // 
        label11.Font = new System.Drawing.Font("SF Pro Rounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        label11.Location = new System.Drawing.Point(705, 93);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(138, 27);
        label11.TabIndex = 21;
        label11.Text = "Ödeme Yönetimi";
        label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label12
        // 
        label12.Font = new System.Drawing.Font("SF Pro Rounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        label12.Location = new System.Drawing.Point(849, 93);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(121, 27);
        label12.TabIndex = 22;
        label12.Text = "Detay";
        label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // CustomerDetailsForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(991, 427);
        Controls.Add(label12);
        Controls.Add(label11);
        Controls.Add(label10);
        Controls.Add(label9);
        Controls.Add(faturaListPanel);
        Controls.Add(button3);
        Controls.Add(label8);
        Controls.Add(panel1);
        Controls.Add(checkBox1);
        Controls.Add(label7);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label6);
        Controls.Add(adressTxt);
        Controls.Add(label5);
        Controls.Add(mailTxt);
        Controls.Add(label4);
        Controls.Add(phoneTxt);
        Controls.Add(label3);
        Controls.Add(surnameTxt);
        Controls.Add(label2);
        Controls.Add(nameTxt);
        Controls.Add(label1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
        Text = "Müşteri Detay";
        faturaListPanel.ResumeLayout(false);
        panel2.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label13;

    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;

    private System.Windows.Forms.Label label10;

    private System.Windows.Forms.Label label9;

    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Panel faturaListPanel;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.CheckBox checkBox1;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox surnameTxt;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox phoneTxt;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox mailTxt;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox adressTxt;
    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox nameTxt;

    #endregion
}