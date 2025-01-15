using System.ComponentModel;

namespace MusteriBilgiYonetimUygulamasi;

partial class NewBillForm
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
        label1 = new Label();
        label2 = new Label();
        nameTxt = new TextBox();
        label3 = new Label();
        phoneTxt = new TextBox();
        mailTxt = new TextBox();
        label4 = new Label();
        adressTxt = new TextBox();
        label5 = new Label();
        button1 = new Button();
        label6 = new Label();
        button2 = new Button();
        label11 = new Label();
        label12 = new Label();
        label13 = new Label();
        billValueTxt = new Label();
        taxValueTxt = new Label();
        totalValueTxt = new Label();
        dataGridViewUrunler = new DataGridView();
        label7 = new Label();
        radioButton1 = new RadioButton();
        radioButton2 = new RadioButton();
        ((ISupportInitialize)dataGridViewUrunler).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new Font("SF Pro Rounded", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(43, 9);
        label1.Name = "label1";
        label1.Size = new Size(1024, 75);
        label1.TabIndex = 0;
        label1.Text = "Fatura Oluşturma";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Location = new Point(43, 104);
        label2.Name = "label2";
        label2.Size = new Size(369, 23);
        label2.TabIndex = 1;
        label2.Text = "İsim Soyisim:";
        // 
        // nameTxt
        // 
        nameTxt.Location = new Point(478, 101);
        nameTxt.Name = "nameTxt";
        nameTxt.ReadOnly = true;
        nameTxt.Size = new Size(589, 28);
        nameTxt.TabIndex = 2;
        // 
        // label3
        // 
        label3.Location = new Point(43, 140);
        label3.Name = "label3";
        label3.Size = new Size(408, 23);
        label3.TabIndex = 3;
        label3.Text = "Telefon Numarası:";
        // 
        // phoneTxt
        // 
        phoneTxt.Location = new Point(478, 137);
        phoneTxt.Name = "phoneTxt";
        phoneTxt.ReadOnly = true;
        phoneTxt.Size = new Size(589, 28);
        phoneTxt.TabIndex = 4;
        // 
        // mailTxt
        // 
        mailTxt.Location = new Point(478, 171);
        mailTxt.Name = "mailTxt";
        mailTxt.ReadOnly = true;
        mailTxt.Size = new Size(589, 28);
        mailTxt.TabIndex = 6;
        // 
        // label4
        // 
        label4.Location = new Point(45, 174);
        label4.Name = "label4";
        label4.Size = new Size(408, 23);
        label4.TabIndex = 5;
        label4.Text = "Eposta:";
        // 
        // adressTxt
        // 
        adressTxt.Location = new Point(478, 205);
        adressTxt.Multiline = true;
        adressTxt.Name = "adressTxt";
        adressTxt.ReadOnly = true;
        adressTxt.Size = new Size(589, 56);
        adressTxt.TabIndex = 8;
        // 
        // label5
        // 
        label5.Location = new Point(43, 208);
        label5.Name = "label5";
        label5.Size = new Size(408, 23);
        label5.TabIndex = 7;
        label5.Text = "Adres:";
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(5, 117, 230);
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatStyle = FlatStyle.Flat;
        button1.ForeColor = Color.White;
        button1.Location = new Point(734, 284);
        button1.Name = "button1";
        button1.Size = new Size(338, 43);
        button1.TabIndex = 9;
        button1.Text = "Ürün Ekle";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // label6
        // 
        label6.Font = new Font("SF Pro Rounded", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label6.Location = new Point(45, 292);
        label6.Name = "label6";
        label6.Size = new Size(408, 23);
        label6.TabIndex = 10;
        label6.Text = "Fatura İçeriği";
        // 
        // button2
        // 
        button2.BackColor = Color.FromArgb(5, 117, 230);
        button2.FlatAppearance.BorderSize = 0;
        button2.FlatStyle = FlatStyle.Flat;
        button2.ForeColor = Color.White;
        button2.Location = new Point(478, 657);
        button2.Name = "button2";
        button2.Size = new Size(598, 64);
        button2.TabIndex = 12;
        button2.Text = "Faturayı Kaydet";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // label11
        // 
        label11.Location = new Point(497, 579);
        label11.Name = "label11";
        label11.Size = new Size(280, 23);
        label11.TabIndex = 17;
        label11.Text = "Fatura Tutarı:";
        label11.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label12
        // 
        label12.Location = new Point(497, 602);
        label12.Name = "label12";
        label12.Size = new Size(280, 23);
        label12.TabIndex = 18;
        label12.Text = "Vergi Tutarı:";
        label12.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label13
        // 
        label13.Location = new Point(497, 625);
        label13.Name = "label13";
        label13.Size = new Size(280, 23);
        label13.TabIndex = 19;
        label13.Text = "Toplam Tutar:";
        label13.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // billValueTxt
        // 
        billValueTxt.Location = new Point(860, 579);
        billValueTxt.Name = "billValueTxt";
        billValueTxt.Size = new Size(213, 23);
        billValueTxt.TabIndex = 20;
        billValueTxt.Text = "100TL";
        billValueTxt.TextAlign = ContentAlignment.MiddleRight;
        // 
        // taxValueTxt
        // 
        taxValueTxt.Location = new Point(860, 602);
        taxValueTxt.Name = "taxValueTxt";
        taxValueTxt.Size = new Size(213, 23);
        taxValueTxt.TabIndex = 21;
        taxValueTxt.Text = "20TL";
        taxValueTxt.TextAlign = ContentAlignment.MiddleRight;
        // 
        // totalValueTxt
        // 
        totalValueTxt.Location = new Point(859, 625);
        totalValueTxt.Name = "totalValueTxt";
        totalValueTxt.Size = new Size(213, 23);
        totalValueTxt.TabIndex = 22;
        totalValueTxt.Text = "120TL";
        totalValueTxt.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dataGridViewUrunler
        // 
        dataGridViewUrunler.BackgroundColor = Color.White;
        dataGridViewUrunler.ColumnHeadersHeight = 29;
        dataGridViewUrunler.Location = new Point(45, 333);
        dataGridViewUrunler.Name = "dataGridViewUrunler";
        dataGridViewUrunler.RowHeadersWidth = 51;
        dataGridViewUrunler.Size = new Size(1028, 237);
        dataGridViewUrunler.TabIndex = 23;
        // 
        // label7
        // 
        label7.Font = new Font("SF Pro Rounded", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label7.Location = new Point(45, 657);
        label7.Name = "label7";
        label7.Size = new Size(408, 23);
        label7.TabIndex = 24;
        label7.Text = "Ödeme Yöntemi";
        // 
        // radioButton1
        // 
        radioButton1.AutoSize = true;
        radioButton1.Location = new Point(45, 697);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new Size(67, 24);
        radioButton1.TabIndex = 25;
        radioButton1.TabStop = true;
        radioButton1.Text = "Nakit";
        radioButton1.UseVisualStyleBackColor = true;
        radioButton1.CheckedChanged += radioButton1_CheckedChanged;
        // 
        // radioButton2
        // 
        radioButton2.AutoSize = true;
        radioButton2.Location = new Point(171, 697);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new Size(101, 24);
        radioButton2.TabIndex = 26;
        radioButton2.TabStop = true;
        radioButton2.Text = "Kredi Kartı";
        radioButton2.UseVisualStyleBackColor = true;
        radioButton2.CheckedChanged += radioButton2_CheckedChanged;
        // 
        // NewBillForm
        // 
        AutoScaleDimensions = new SizeF(9F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1104, 733);
        Controls.Add(radioButton2);
        Controls.Add(radioButton1);
        Controls.Add(label7);
        Controls.Add(dataGridViewUrunler);
        Controls.Add(totalValueTxt);
        Controls.Add(taxValueTxt);
        Controls.Add(billValueTxt);
        Controls.Add(label13);
        Controls.Add(label12);
        Controls.Add(label11);
        Controls.Add(button2);
        Controls.Add(label6);
        Controls.Add(button1);
        Controls.Add(adressTxt);
        Controls.Add(label5);
        Controls.Add(mailTxt);
        Controls.Add(label4);
        Controls.Add(phoneTxt);
        Controls.Add(label3);
        Controls.Add(nameTxt);
        Controls.Add(label2);
        Controls.Add(label1);
        Font = new Font("SF Pro Rounded", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "NewBillForm";
        Text = "NewBillForm";
        ((ISupportInitialize)dataGridViewUrunler).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.DataGridView dataGridViewUrunler;

    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label billValueTxt;
    private System.Windows.Forms.Label taxValueTxt;
    private System.Windows.Forms.Label totalValueTxt;

    private System.Windows.Forms.Label label11;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.TextBox nameTxt;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox phoneTxt;
    private System.Windows.Forms.TextBox mailTxt;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox adressTxt;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion

    private Label label7;
    private RadioButton radioButton1;
    private RadioButton radioButton2;
}