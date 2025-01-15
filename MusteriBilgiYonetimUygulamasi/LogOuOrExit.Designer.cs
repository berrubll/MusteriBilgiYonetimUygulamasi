using System.ComponentModel;

namespace MusteriBilgiYonetimUygulamasi;

partial class LogOuOrExit
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
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(3, 2);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(429, 72);
        label1.TabIndex = 0;
        label1.Text = "Uygulamayı Kapatmakmı Oturumu Kapatmakmı İstersiniz?";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)5)), ((int)((byte)117)), ((int)((byte)230)));
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        button1.ForeColor = System.Drawing.Color.White;
        button1.Location = new System.Drawing.Point(4, 77);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(212, 60);
        button1.TabIndex = 1;
        button1.Text = "Uygulamayı Kapat";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)5)), ((int)((byte)117)), ((int)((byte)230)));
        button2.FlatAppearance.BorderSize = 0;
        button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button2.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)162));
        button2.ForeColor = System.Drawing.Color.White;
        button2.Location = new System.Drawing.Point(220, 77);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(212, 60);
        button2.TabIndex = 2;
        button2.Text = "Oturumu Kapat";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button2_Click;
        // 
        // LogOuOrExit
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(435, 143);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        Text = "Çıkış Yap";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Label label1;

    #endregion
}