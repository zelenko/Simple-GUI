using System;
using System.Windows.Forms;
public class Form1: System.Windows.Forms.Form
{
  private System.Windows.Forms.Button button1;
  private System.Windows.Forms.Button button2;
  private System.Windows.Forms.Button button3;
  private System.Windows.Forms.TextBox textBox1;
  public Form1() // constructor
  {
    InitializeComponent();
  }
  
  private void button1_Click(object sender, EventArgs e)
  {
    this.textBox1.Text = "Hello there!";
  }
  
  private void button2_Click(object sender, EventArgs e)
  {
    this.textBox1.Text = "";
  }
  
  private void button3_Click(object sender, EventArgs e)
  {
    this.textBox1.Text = "Results";
  }
  
  static void Main()
  {
    Application.Run(new Form1()); // Run our form
  }
  private void InitializeComponent() // helper method to keep constructor clean
  {
    this.SuspendLayout(); // for better performance
    // button1
    this.button1 = new System.Windows.Forms.Button();
    this.button1.Location = new System.Drawing.Point(28, 26);
    this.button1.Name = "button1";
    this.button1.Size = new System.Drawing.Size(75, 23);
    this.button1.TabIndex = 0;
    this.button1.Text = "button-1";
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new System.EventHandler(this.button1_Click);
	
	// button2
    this.button2 = new System.Windows.Forms.Button();
    this.button2.Location = new System.Drawing.Point(120, 26);
    this.button2.Name = "button2";
    this.button2.Size = new System.Drawing.Size(75, 23);
    this.button2.TabIndex = 2;
    this.button2.Text = "Clear";
    this.button2.UseVisualStyleBackColor = true;
    this.button2.Click += new System.EventHandler(this.button2_Click);
	
	// button3
    this.button3 = new System.Windows.Forms.Button();
    this.button3.Location = new System.Drawing.Point(28, 106);
    this.button3.Name = "button3";
    this.button3.Size = new System.Drawing.Size(75, 23);
    this.button3.TabIndex = 4;
    this.button3.Text = "Clear";
    this.button3.UseVisualStyleBackColor = true;
    this.button3.Click += new System.EventHandler(this.button3_Click);
    // textBox1
    this.textBox1 = new System.Windows.Forms.TextBox();
    this.textBox1.Location = new System.Drawing.Point(28, 55);
    this.textBox1.Name = "textBox1";
    this.textBox1.Size = new System.Drawing.Size(100, 20);
    this.textBox1.TabIndex = 3;
    // Form1
    this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(284, 664); // width, height
    this.Name = "Form1";
    this.Text = "Product Updater 1.1";
    this.Controls.Add(this.button1);
	this.Controls.Add(this.button2);
	this.Controls.Add(this.button3);
    this.Controls.Add(this.textBox1);
    this.ResumeLayout(false);
  }
} // class Form1