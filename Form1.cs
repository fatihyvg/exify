using System;
using System.Windows.Forms;
using exify.Exif;
namespace exify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void browsebutton_Click(object sender,System.EventArgs e)
        {
            DialogResult  dialogok = this.browseopen.ShowDialog();

            if(dialogok == DialogResult.OK)
            {
                 ExifRead exf = new ExifRead(this.browseopen.OpenFile());
                 Form2 frm = new Form2();
                 frm.ExifShows(
                 Convert.ToString(exf.Model),
                 Convert.ToString(exf.LensModel),
                 Convert.ToString(exf.FNumber),
                 Convert.ToString(exf.Iso),
                 Convert.ToString(exf.MeteringMode),
                 Convert.ToString(exf.ShutterSpeed),
                 Convert.ToString(exf.FocalLength),
                 Convert.ToString(exf.ExposureProgram),
                 Convert.ToString(exf.ExposureMode),
                 Convert.ToString(exf.ExposureTime),
                 Convert.ToString(exf.Make));
                 frm.Show();
            }
        }

    }
}
