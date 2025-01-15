using System.ComponentModel;

namespace MusteriBilgiYonetimUygulamasi;

partial class NewCustomer
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
        label2 = new System.Windows.Forms.Label();
        nameTxt = new System.Windows.Forms.TextBox();
        surnameTxt = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        mailTxt = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        phoneTxt = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        adressTxt = new System.Windows.Forms.TextBox();
        label6 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Poppins Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
        label1.Location = new System.Drawing.Point(73, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(261, 65);
        label1.TabIndex = 0;
        label1.Text = "Yeni Müşteri";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(22, 90);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(93, 30);
        label2.TabIndex = 1;
        label2.Text = "İsim:";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // nameTxt
        // 
        nameTxt.Location = new System.Drawing.Point(121, 93);
        nameTxt.Name = "nameTxt";
        nameTxt.Size = new System.Drawing.Size(258, 27);
        nameTxt.TabIndex = 2;
        // 
        // surnameTxt
        // 
        surnameTxt.Location = new System.Drawing.Point(121, 126);
        surnameTxt.Name = "surnameTxt";
        surnameTxt.Size = new System.Drawing.Size(258, 27);
        surnameTxt.TabIndex = 4;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(22, 123);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(93, 30);
        label3.TabIndex = 3;
        label3.Text = "Soyisim:";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // mailTxt
        // 
        mailTxt.Location = new System.Drawing.Point(121, 159);
        mailTxt.Name = "mailTxt";
        mailTxt.Size = new System.Drawing.Size(258, 27);
        mailTxt.TabIndex = 6;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(22, 156);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(93, 30);
        label4.TabIndex = 5;
        label4.Text = "E-Mail:";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // phoneTxt
        // 
        phoneTxt.Location = new System.Drawing.Point(121, 192);
        phoneTxt.Name = "phoneTxt";
        phoneTxt.Size = new System.Drawing.Size(258, 27);
        phoneTxt.TabIndex = 8;
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(22, 189);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(93, 30);
        label5.TabIndex = 7;
        label5.Text = "Telefon:";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // adressTxt
        // 
        adressTxt.Location = new System.Drawing.Point(121, 225);
        adressTxt.Multiline = true;
        adressTxt.Name = "adressTxt";
        adressTxt.Size = new System.Drawing.Size(258, 81);
        adressTxt.TabIndex = 10;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(22, 222);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(93, 84);
        label6.TabIndex = 9;
        label6.Text = "Adres:";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)5)), ((int)((byte)117)), ((int)((byte)230)));
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        button1.ForeColor = System.Drawing.Color.White;
        button1.Location = new System.Drawing.Point(22, 323);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(357, 42);
        button1.TabIndex = 11;
        button1.Text = "Müşteri Ekle";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click_1;
        // 
        // NewCustomer
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(410, 388);
        Controls.Add(button1);
        Controls.Add(adressTxt);
        Controls.Add(label6);
        Controls.Add(phoneTxt);
        Controls.Add(label5);
        Controls.Add(mailTxt);
        Controls.Add(label4);
        Controls.Add(surnameTxt);
        Controls.Add(label3);
        Controls.Add(nameTxt);
        Controls.Add(label2);
        Controls.Add(label1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        Text = "Yeni Müşteri Kayıt Ekranı";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.TextBox nameTxt;
    private System.Windows.Forms.TextBox surnameTxt;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox mailTxt;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox phoneTxt;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox adressTxt;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}