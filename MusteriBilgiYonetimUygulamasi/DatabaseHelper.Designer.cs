using System.ComponentModel;

namespace MusteriBilgiYonetimUygulamasi;

partial class DatabaseHelper
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
        panel1 = new System.Windows.Forms.Panel();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        sqlServerIpTxt = new System.Windows.Forms.TextBox();
        button1 = new System.Windows.Forms.Button();
        sqlServerUsernameTxt = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        sqlServerPassTxt = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.White;
        panel1.Controls.Add(sqlServerPassTxt);
        panel1.Controls.Add(label5);
        panel1.Controls.Add(sqlServerUsernameTxt);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(button1);
        panel1.Controls.Add(sqlServerIpTxt);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label1);
        panel1.Location = new System.Drawing.Point(12, 12);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(520, 327);
        panel1.TabIndex = 0;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("SF Pro Rounded", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)162));
        label1.Location = new System.Drawing.Point(0, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(520, 68);
        label1.TabIndex = 0;
        label1.Text = "Veritabanı Ayarları";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("SF Pro Rounded", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(0, 58);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(520, 68);
        label2.TabIndex = 1;
        label2.Text = ("Uygulamanın Çalışabilmesi İçin Veritabanı Ayarlarınızın Doğru Olduğundan Emin Olu" + "nuz");
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("SF Pro Rounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        label3.Location = new System.Drawing.Point(79, 152);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(138, 27);
        label3.TabIndex = 2;
        label3.Text = "Sunucu Adresi:";
        // 
        // sqlServerIpTxt
        // 
        sqlServerIpTxt.Location = new System.Drawing.Point(223, 152);
        sqlServerIpTxt.Name = "sqlServerIpTxt";
        sqlServerIpTxt.Size = new System.Drawing.Size(234, 27);
        sqlServerIpTxt.TabIndex = 3;
        sqlServerIpTxt.Text = "localhost";
        // 
        // button1
        // 
        button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
        button1.Font = new System.Drawing.Font("SF Pro Rounded", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        button1.Location = new System.Drawing.Point(144, 251);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(231, 61);
        button1.TabIndex = 4;
        button1.Text = "Bağlan";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // sqlServerUsernameTxt
        // 
        sqlServerUsernameTxt.Location = new System.Drawing.Point(223, 185);
        sqlServerUsernameTxt.Name = "sqlServerUsernameTxt";
        sqlServerUsernameTxt.Size = new System.Drawing.Size(234, 27);
        sqlServerUsernameTxt.TabIndex = 6;
        sqlServerUsernameTxt.Text = "root";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("SF Pro Rounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        label4.Location = new System.Drawing.Point(79, 185);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(138, 27);
        label4.TabIndex = 5;
        label4.Text = "Kullanıcı Adı:";
        // 
        // sqlServerPassTxt
        // 
        sqlServerPassTxt.Location = new System.Drawing.Point(223, 218);
        sqlServerPassTxt.Name = "sqlServerPassTxt";
        sqlServerPassTxt.Size = new System.Drawing.Size(234, 27);
        sqlServerPassTxt.TabIndex = 8;
        sqlServerPassTxt.UseSystemPasswordChar = true;
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("SF Pro Rounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        label5.Location = new System.Drawing.Point(79, 218);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(138, 27);
        label5.TabIndex = 7;
        label5.Text = "Şifre:";
        // 
        // DatabaseHelper
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(544, 350);
        Controls.Add(panel1);
        Text = "Veritabanı Bağlantısı";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.TextBox sqlServerUsernameTxt;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox sqlServerPassTxt;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox sqlServerIpTxt;
    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Panel panel1;

    #endregion
}