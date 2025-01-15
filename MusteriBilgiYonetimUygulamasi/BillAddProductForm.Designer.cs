using System.ComponentModel;

namespace MusteriBilgiYonetimUygulamasi;

partial class BillAddProductForm
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
        textBox1 = new TextBox();
        miktarTxt = new TextBox();
        label2 = new Label();
        label3 = new Label();
        valueTxt = new TextBox();
        button1 = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new Point(18, 17);
        label1.Margin = new Padding(21, 0, 21, 0);
        label1.Name = "label1";
        label1.Size = new Size(356, 52);
        label1.TabIndex = 0;
        label1.Text = "Ürün İsmi";
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(18, 79);
        textBox1.Margin = new Padding(21, 10, 21, 10);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(356, 31);
        textBox1.TabIndex = 1;
        // 
        // miktarTxt
        // 
        miktarTxt.Location = new Point(381, 79);
        miktarTxt.Margin = new Padding(21, 10, 21, 10);
        miktarTxt.Name = "miktarTxt";
        miktarTxt.Size = new Size(200, 31);
        miktarTxt.TabIndex = 3;
        // 
        // label2
        // 
        label2.Location = new Point(381, 18);
        label2.Margin = new Padding(21, 0, 21, 0);
        label2.Name = "label2";
        label2.Size = new Size(200, 54);
        label2.TabIndex = 2;
        label2.Text = "Miktar";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.Location = new Point(585, 17);
        label3.Margin = new Padding(21, 0, 21, 0);
        label3.Name = "label3";
        label3.Size = new Size(212, 52);
        label3.TabIndex = 4;
        label3.Text = "Birim Fiyatı";
        label3.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // valueTxt
        // 
        valueTxt.Location = new Point(586, 79);
        valueTxt.Margin = new Padding(21, 10, 21, 10);
        valueTxt.Name = "valueTxt";
        valueTxt.Size = new Size(211, 31);
        valueTxt.TabIndex = 5;
        valueTxt.TextChanged += valueTxt_TextChanged;
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(5, 155, 235);
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatStyle = FlatStyle.Flat;
        button1.ForeColor = Color.White;
        button1.Location = new Point(480, 123);
        button1.Name = "button1";
        button1.Size = new Size(317, 78);
        button1.TabIndex = 8;
        button1.Text = "Ürün Ekle";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // BillAddProductForm
        // 
        AutoScaleDimensions = new SizeF(11F, 24F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(819, 224);
        Controls.Add(button1);
        Controls.Add(valueTxt);
        Controls.Add(label3);
        Controls.Add(miktarTxt);
        Controls.Add(label2);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Font = new Font("SF Pro Rounded", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Margin = new Padding(4);
        Name = "BillAddProductForm";
        Text = "Ürün Ekle";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox miktarTxt;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox valueTxt;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;

    #endregion

    private Button button1;
}