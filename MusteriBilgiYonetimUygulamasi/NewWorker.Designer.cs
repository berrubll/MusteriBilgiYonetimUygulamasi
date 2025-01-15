using System.ComponentModel;

namespace MusteriBilgiYonetimUygulamasi;

partial class NewWorker
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
        button1 = new System.Windows.Forms.Button();
        usernameTxt = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        passTxt = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        managerRdrBtn = new System.Windows.Forms.RadioButton();
        workerRdrBtn = new System.Windows.Forms.RadioButton();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("SF Pro Rounded", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(45, -5);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(444, 98);
        label1.TabIndex = 0;
        label1.Text = "Yeni Çalışan";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(20, 99);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(287, 28);
        label2.TabIndex = 1;
        label2.Text = "İsim Soyisim:";
        // 
        // nameTxt
        // 
        nameTxt.Location = new System.Drawing.Point(179, 96);
        nameTxt.Name = "nameTxt";
        nameTxt.Size = new System.Drawing.Size(309, 28);
        nameTxt.TabIndex = 2;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)5)), ((int)((byte)117)), ((int)((byte)230)));
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button1.ForeColor = System.Drawing.Color.White;
        button1.Location = new System.Drawing.Point(20, 266);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(469, 57);
        button1.TabIndex = 4;
        button1.Text = "Kaydet";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // usernameTxt
        // 
        usernameTxt.Location = new System.Drawing.Point(179, 130);
        usernameTxt.Name = "usernameTxt";
        usernameTxt.Size = new System.Drawing.Size(309, 28);
        usernameTxt.TabIndex = 6;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(20, 133);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(166, 28);
        label3.TabIndex = 5;
        label3.Text = "Kullanıcı Adı:";
        // 
        // passTxt
        // 
        passTxt.Location = new System.Drawing.Point(179, 167);
        passTxt.Name = "passTxt";
        passTxt.Size = new System.Drawing.Size(309, 28);
        passTxt.TabIndex = 8;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(20, 167);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(287, 28);
        label4.TabIndex = 7;
        label4.Text = "Şifre:";
        // 
        // managerRdrBtn
        // 
        managerRdrBtn.Location = new System.Drawing.Point(20, 201);
        managerRdrBtn.Name = "managerRdrBtn";
        managerRdrBtn.Size = new System.Drawing.Size(215, 59);
        managerRdrBtn.TabIndex = 9;
        managerRdrBtn.Text = "Yönetici";
        managerRdrBtn.UseVisualStyleBackColor = true;
        managerRdrBtn.CheckedChanged += managerRdrBtn_CheckedChanged;
        // 
        // workerRdrBtn
        // 
        workerRdrBtn.Location = new System.Drawing.Point(243, 201);
        workerRdrBtn.Name = "workerRdrBtn";
        workerRdrBtn.Size = new System.Drawing.Size(245, 59);
        workerRdrBtn.TabIndex = 10;
        workerRdrBtn.Text = "Çalışan";
        workerRdrBtn.UseVisualStyleBackColor = true;
        workerRdrBtn.CheckedChanged += workerRdrBtn_CheckedChanged;
        // 
        // NewWorker
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(516, 347);
        Controls.Add(workerRdrBtn);
        Controls.Add(managerRdrBtn);
        Controls.Add(passTxt);
        Controls.Add(label4);
        Controls.Add(usernameTxt);
        Controls.Add(label3);
        Controls.Add(button1);
        Controls.Add(nameTxt);
        Controls.Add(label2);
        Controls.Add(label1);
        Font = new System.Drawing.Font("SF Pro Rounded", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        Text = "Yeni Çalışan Kayıt Ekranı";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.RadioButton workerRdrBtn;

    private System.Windows.Forms.RadioButton managerRdrBtn;

    private System.Windows.Forms.TextBox usernameTxt;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox passTxt;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox nameTxt;
    private System.Windows.Forms.Button button1;

    #endregion
}