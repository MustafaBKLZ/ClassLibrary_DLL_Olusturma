using System;
using System.Windows.Forms;
using MustafaDLL;
namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Hesaplamalar.Toplama(5, 6, 6).ToString());
        }
    }
}
