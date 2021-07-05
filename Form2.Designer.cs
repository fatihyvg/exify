using System.Drawing;
using System.Windows.Forms;
namespace exify
{
    partial class Form2
    {
        private System.ComponentModel.IContainer container = null;
        protected override void Dispose(bool disposing)
        {
            if(disposing && (container != null))
            {
                container.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {

            this.exifrespanel = new Panel();
            this.lab1 = new Label();
            this.lab2 = new Label();
            this.lab3 = new Label();
            this.lab4 = new Label();
            this.lab5 = new Label();
            this.lab6 = new Label();
            this.lab7 = new Label();
            this.lab8 = new Label();
            this.lab9 = new Label();
            this.lab10 = new Label();
            this.lab11 = new Label();
            this.exifrespanel.SuspendLayout();
            this.SuspendLayout();

            this.exifrespanel.Controls.Add(lab1);
            this.exifrespanel.Controls.Add(lab2);
            this.exifrespanel.Controls.Add(lab3);
            this.exifrespanel.Controls.Add(lab4);
            this.exifrespanel.Controls.Add(lab5);
            this.exifrespanel.Controls.Add(lab6);
            this.exifrespanel.Controls.Add(lab7);
            this.exifrespanel.Controls.Add(lab8);
            this.exifrespanel.Controls.Add(lab9);
            this.exifrespanel.Controls.Add(lab10);
            this.exifrespanel.Controls.Add(lab11);
            this.exifrespanel.Location = new System.Drawing.Point(0, 0);
            this.exifrespanel.Name = "exifrespanel";
            this.exifrespanel.Size = new System.Drawing.Size(396, 610);
            this.exifrespanel.TabIndex = 0;

            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab1.Location = new System.Drawing.Point(13, 50);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(46, 20);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "brand";

            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(69,80);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(38, 15);
            this.lab2.TabIndex = 1;
            this.lab2.Text = "lab2";

            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(69, 100);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(38, 15);
            this.lab3.TabIndex = 2;
            this.lab3.Text = "lab3";

            this.lab4.AutoSize = true;
            this.lab4.Location = new System.Drawing.Point(69, 120);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(38, 15);
            this.lab4.TabIndex = 3;
            this.lab4.Text = "lab4";

            this.lab5.AutoSize = true;
            this.lab5.Location = new System.Drawing.Point(69, 140);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(38, 15);
            this.lab5.TabIndex = 4;
            this.lab5.Text = "lab5";

            this.lab6.AutoSize = true;
            this.lab6.Location = new System.Drawing.Point(69, 160);
            this.lab6.Name = "lab6";
            this.lab6.Size = new System.Drawing.Size(38, 15);
            this.lab6.TabIndex = 5;
            this.lab6.Text = "lab6";

            this.lab7.AutoSize = true;
            this.lab7.Location = new System.Drawing.Point(69, 180);
            this.lab7.Name = "lab7";
            this.lab7.Size = new System.Drawing.Size(38, 15);
            this.lab7.TabIndex = 6;
            this.lab7.Text = "lab7";

            this.lab8.AutoSize = true;
            this.lab8.Location = new System.Drawing.Point(69, 200);
            this.lab8.Name = "lab8";
            this.lab8.Size = new System.Drawing.Size(38, 15);
            this.lab8.TabIndex = 7;
            this.lab8.Text = "lab8";

            this.lab9.AutoSize = true;
            this.lab9.Location = new System.Drawing.Point(69, 220);
            this.lab9.Name = "lab9";
            this.lab9.Size = new System.Drawing.Size(38, 15);
            this.lab9.TabIndex = 8;
            this.lab9.Text = "lab9";

            this.lab10.AutoSize = true;
            this.lab10.Location = new System.Drawing.Point(69, 240);
            this.lab10.Name = "lab10";
            this.lab10.Size = new System.Drawing.Size(38, 15);
            this.lab10.TabIndex = 9;
            this.lab10.Text = "lab10";

            this.lab11.AutoSize = true;
            this.lab11.Location = new System.Drawing.Point(69, 260);
            this.lab11.Name = "lab11";
            this.lab11.Size = new System.Drawing.Size(38, 15);
            this.lab11.TabIndex = 10;
            this.lab11.Text = "lab11";

            
            
            
            this.AutoScaleDimensions = new SizeF(7F,15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(350,499);
            this.Controls.Add(exifrespanel);
            this.Name = "ExifResultForm";
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Exif Result";
            this.exifrespanel.ResumeLayout(false);
            this.exifrespanel.PerformLayout();
            this.ResumeLayout(false);
        }
        private Panel exifrespanel;
        private Label lab1;
        private Label lab2;
        private Label lab3;
        private Label lab4;
        private Label lab5;
        private Label lab6;
        private Label lab7;
        private Label lab8;
        private Label lab9;
        private Label lab10;
         private Label lab11;
    }
}