using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.kayitekleDataSetTableAdapters;

namespace WindowsFormsApp1
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyeekle üyeekle = new uyeekle();
            üyeekle.Show();
            Hide();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fiyat f1 = new fiyat();
            f1.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ödemeler o1 = new ödemeler();
            o1.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            guncellemesilme g1 = new guncellemesilme();
            g1.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            üyegörüntüle ug1 = new üyegörüntüle();
            ug1.Show();
            Hide();
        }
    }
}
