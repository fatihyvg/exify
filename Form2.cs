using System.Windows.Forms;
namespace exify
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void ExifShows(params string[] lists)
        {
            lab1.Text = lists[0].ToString();
            lab2.Text =lists[1].ToString();
            lab3.Text = "f/"+ lists[2].ToString();
            lab4.Text ="Iso "+ lists[3].ToString();
            lab5.Text = lists[4].ToString();
            lab6.Text = lists[5].ToString();
            lab7.Text = lists[6].ToString();
            lab8.Text = lists[7].ToString();
            lab9.Text = lists[8].ToString();
            lab10.Text = lists[9].ToString();
            lab11.Text = lists[10].ToString();
        }
    }
}