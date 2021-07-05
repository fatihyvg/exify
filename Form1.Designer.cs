using System.Drawing;
using System.Windows.Forms;
namespace exify
{
    partial class Form1
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

            this.mainpanel = new Panel();
            this.browsebutton = new Button();
            this.imagetext = new TextBox();
            this.browseopen = new OpenFileDialog();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();

            this.mainpanel.Controls.Add(browsebutton);
            this.mainpanel.Controls.Add(imagetext);
            this.mainpanel.Location = new Point(-4,-3);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new Size(589,87);

            this.browsebutton.Font = new Font("Calibri",11.25F,FontStyle.Regular,GraphicsUnit.Point);
            this.browsebutton.Location = new Point(466,30);
            this.browsebutton.Name = "browsebutton";
            this.browsebutton.Size = new Size(88,24);
            this.browsebutton.Text = "Browse";
            this.browsebutton.TextAlign = ContentAlignment.TopCenter;
            this.browsebutton.Click += new System.EventHandler(this.browsebutton_Click);

            this.imagetext.BorderStyle = BorderStyle.FixedSingle;
            this.imagetext.Location = new Point(32,31);
            this.imagetext.Name = "browsetext";
            this.imagetext.Size = new Size(428,23);

            this.browseopen.Title = "open";
            this.browseopen.DefaultExt = "ımage";
            this.browseopen.FileName = "ımage";
            this.browseopen.InitialDirectory = @"C:\\";
            this.browseopen.Filter = "Image files (*.jpg, *.jpeg, *.JPEG) | *.jpg; *.jpeg; *.JPEG";
            this.browseopen.CheckFileExists = true;
            this.browseopen.CheckPathExists = true;
            this.browseopen.RestoreDirectory = true;

            this.AutoScaleDimensions = new SizeF(7F,15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(584,81);
            this.Controls.Add(mainpanel);
            this.Name = "ExifForm";
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Exify";
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.ResumeLayout(false);
        }
        private Panel mainpanel;
        private Button browsebutton;
        private TextBox imagetext;

        private OpenFileDialog browseopen;

        #endregion
    }
}

