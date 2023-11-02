namespace WinFormsCalc;

partial class BasicCalcForm
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        richTextBox1 = new RichTextBox();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        button5 = new Button();
        button6 = new Button();
        button7 = new Button();
        button8 = new Button();
        button9 = new Button();
        button10 = new Button();
        button11 = new Button();
        button12 = new Button();
        button13 = new Button();
        button14 = new Button();
        button15 = new Button();
        button16 = new Button();
        button17 = new Button();
        button18 = new Button();
        button20 = new Button();
        tableLayoutPanel1 = new TableLayoutPanel();
        panel1 = new Panel();
        tableLayoutPanel1.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // richTextBox1
        // 
        richTextBox1.DetectUrls = false;
        richTextBox1.Dock = DockStyle.Top;
        richTextBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
        richTextBox1.Location = new Point(0, 0);
        richTextBox1.Multiline = false;
        richTextBox1.Name = "richTextBox1";
        richTextBox1.ReadOnly = true;
        richTextBox1.RightToLeft = RightToLeft.Yes;
        richTextBox1.Size = new Size(438, 95);
        richTextBox1.TabIndex = 1;
        richTextBox1.Text = "888,888";
        // 
        // button1
        // 
        button1.Dock = DockStyle.Fill;
        button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        button1.Location = new Point(10, 130);
        button1.Margin = new Padding(10);
        button1.Name = "button1";
        button1.Size = new Size(89, 84);
        button1.TabIndex = 2;
        button1.Text = "AC";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Dock = DockStyle.Fill;
        button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        button2.Location = new Point(119, 130);
        button2.Margin = new Padding(10);
        button2.Name = "button2";
        button2.Size = new Size(89, 84);
        button2.TabIndex = 3;
        button2.Text = "+/-";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Dock = DockStyle.Fill;
        button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        button3.Location = new Point(228, 130);
        button3.Margin = new Padding(10);
        button3.Name = "button3";
        button3.Size = new Size(89, 84);
        button3.TabIndex = 4;
        button3.Text = "%";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Dock = DockStyle.Fill;
        button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        button4.Location = new Point(337, 130);
        button4.Margin = new Padding(10);
        button4.Name = "button4";
        button4.Size = new Size(91, 84);
        button4.TabIndex = 5;
        button4.Text = "/";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button5
        // 
        button5.Dock = DockStyle.Fill;
        button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        button5.Location = new Point(337, 234);
        button5.Margin = new Padding(10);
        button5.Name = "button5";
        button5.Size = new Size(91, 84);
        button5.TabIndex = 9;
        button5.Text = "*";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // button6
        // 
        button6.Dock = DockStyle.Fill;
        button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        button6.Location = new Point(228, 234);
        button6.Margin = new Padding(10);
        button6.Name = "button6";
        button6.Size = new Size(89, 84);
        button6.TabIndex = 8;
        button6.Text = "9";
        button6.UseVisualStyleBackColor = true;
        button6.Click += button6_Click;
        // 
        // button7
        // 
        button7.Dock = DockStyle.Fill;
        button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        button7.Location = new Point(119, 234);
        button7.Margin = new Padding(10);
        button7.Name = "button7";
        button7.Size = new Size(89, 84);
        button7.TabIndex = 7;
        button7.Text = "8";
        button7.UseVisualStyleBackColor = true;
        button7.Click += button7_Click;
        // 
        // button8
        // 
        button8.Dock = DockStyle.Fill;
        button8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        button8.Location = new Point(10, 234);
        button8.Margin = new Padding(10);
        button8.Name = "button8";
        button8.Size = new Size(89, 84);
        button8.TabIndex = 6;
        button8.Text = "7";
        button8.UseVisualStyleBackColor = true;
        button8.Click += button8_Click;
        // 
        // button9
        // 
        button9.Dock = DockStyle.Fill;
        button9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        button9.Location = new Point(337, 338);
        button9.Margin = new Padding(10);
        button9.Name = "button9";
        button9.Size = new Size(91, 84);
        button9.TabIndex = 13;
        button9.Text = "-";
        button9.UseVisualStyleBackColor = true;
        button9.Click += button9_Click;
        // 
        // button10
        // 
        button10.Dock = DockStyle.Fill;
        button10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        button10.Location = new Point(228, 338);
        button10.Margin = new Padding(10);
        button10.Name = "button10";
        button10.Size = new Size(89, 84);
        button10.TabIndex = 12;
        button10.Text = "6";
        button10.UseVisualStyleBackColor = true;
        button10.Click += button10_Click;
        // 
        // button11
        // 
        button11.Dock = DockStyle.Fill;
        button11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        button11.Location = new Point(119, 338);
        button11.Margin = new Padding(10);
        button11.Name = "button11";
        button11.Size = new Size(89, 84);
        button11.TabIndex = 11;
        button11.Text = "5";
        button11.UseVisualStyleBackColor = true;
        button11.Click += button11_Click;
        // 
        // button12
        // 
        button12.Dock = DockStyle.Fill;
        button12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        button12.Location = new Point(10, 338);
        button12.Margin = new Padding(10);
        button12.Name = "button12";
        button12.Size = new Size(89, 84);
        button12.TabIndex = 10;
        button12.Text = "4";
        button12.UseVisualStyleBackColor = true;
        button12.Click += button12_Click;
        // 
        // button13
        // 
        button13.Dock = DockStyle.Fill;
        button13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        button13.Location = new Point(337, 442);
        button13.Margin = new Padding(10);
        button13.Name = "button13";
        button13.Size = new Size(91, 84);
        button13.TabIndex = 17;
        button13.Text = "+";
        button13.UseVisualStyleBackColor = true;
        button13.Click += button13_Click;
        // 
        // button14
        // 
        button14.Dock = DockStyle.Fill;
        button14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        button14.Location = new Point(228, 442);
        button14.Margin = new Padding(10);
        button14.Name = "button14";
        button14.Size = new Size(89, 84);
        button14.TabIndex = 16;
        button14.Text = "3";
        button14.UseVisualStyleBackColor = true;
        button14.Click += button14_Click;
        // 
        // button15
        // 
        button15.Dock = DockStyle.Fill;
        button15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        button15.Location = new Point(119, 442);
        button15.Margin = new Padding(10);
        button15.Name = "button15";
        button15.Size = new Size(89, 84);
        button15.TabIndex = 15;
        button15.Text = "2";
        button15.UseVisualStyleBackColor = true;
        button15.Click += button15_Click;
        // 
        // button16
        // 
        button16.Dock = DockStyle.Fill;
        button16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        button16.Location = new Point(10, 442);
        button16.Margin = new Padding(10);
        button16.Name = "button16";
        button16.Size = new Size(89, 84);
        button16.TabIndex = 14;
        button16.Text = "1";
        button16.UseVisualStyleBackColor = true;
        button16.Click += button16_Click;
        // 
        // button17
        // 
        button17.Dock = DockStyle.Fill;
        button17.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        button17.Location = new Point(337, 546);
        button17.Margin = new Padding(10);
        button17.Name = "button17";
        button17.Size = new Size(91, 85);
        button17.TabIndex = 21;
        button17.Text = "=";
        button17.UseVisualStyleBackColor = true;
        button17.Click += button17_Click;
        // 
        // button18
        // 
        button18.Dock = DockStyle.Fill;
        button18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        button18.Location = new Point(228, 546);
        button18.Margin = new Padding(10);
        button18.Name = "button18";
        button18.Size = new Size(89, 85);
        button18.TabIndex = 20;
        button18.Text = ".";
        button18.UseVisualStyleBackColor = true;
        button18.Click += button18_Click;
        // 
        // button20
        // 
        tableLayoutPanel1.SetColumnSpan(button20, 2);
        button20.Dock = DockStyle.Fill;
        button20.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
        button20.Location = new Point(10, 546);
        button20.Margin = new Padding(10);
        button20.Name = "button20";
        button20.Size = new Size(198, 85);
        button20.TabIndex = 18;
        button20.Text = "0";
        button20.UseVisualStyleBackColor = true;
        button20.Click += button20_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 4;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.Controls.Add(button1, 0, 0);
        tableLayoutPanel1.Controls.Add(button14, 2, 3);
        tableLayoutPanel1.Controls.Add(button18, 2, 4);
        tableLayoutPanel1.Controls.Add(button15, 1, 3);
        tableLayoutPanel1.Controls.Add(button17, 3, 4);
        tableLayoutPanel1.Controls.Add(button2, 1, 0);
        tableLayoutPanel1.Controls.Add(button3, 2, 0);
        tableLayoutPanel1.Controls.Add(button13, 3, 3);
        tableLayoutPanel1.Controls.Add(button20, 0, 4);
        tableLayoutPanel1.Controls.Add(button4, 3, 0);
        tableLayoutPanel1.Controls.Add(button8, 0, 1);
        tableLayoutPanel1.Controls.Add(button9, 3, 2);
        tableLayoutPanel1.Controls.Add(button7, 1, 1);
        tableLayoutPanel1.Controls.Add(button10, 2, 2);
        tableLayoutPanel1.Controls.Add(button6, 2, 1);
        tableLayoutPanel1.Controls.Add(button11, 1, 2);
        tableLayoutPanel1.Controls.Add(button16, 0, 3);
        tableLayoutPanel1.Controls.Add(button5, 3, 1);
        tableLayoutPanel1.Controls.Add(button12, 0, 2);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.Padding = new Padding(0, 120, 0, 0);
        tableLayoutPanel1.RowCount = 5;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.Size = new Size(438, 641);
        tableLayoutPanel1.TabIndex = 22;
        // 
        // panel1
        // 
        panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        panel1.Controls.Add(richTextBox1);
        panel1.Controls.Add(tableLayoutPanel1);
        panel1.Location = new Point(19, 19);
        panel1.Margin = new Padding(10);
        panel1.Name = "panel1";
        panel1.Size = new Size(438, 641);
        panel1.TabIndex = 23;
        // 
        // BasicCalcForm
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(476, 679);
        Controls.Add(panel1);
        MinimumSize = new Size(450, 750);
        Name = "BasicCalcForm";
        Text = "Calc";
        tableLayoutPanel1.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private RichTextBox richTextBox1;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button8;
    private Button button9;
    private Button button10;
    private Button button11;
    private Button button12;
    private Button button13;
    private Button button14;
    private Button button15;
    private Button button16;
    private Button button17;
    private Button button18;
    private Button button20;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel panel1;
}
