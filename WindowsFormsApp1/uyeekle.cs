using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class uyeekle : Form
    {
        public uyeekle()
        {
            InitializeComponent();
        }

        private void uyeekle_Load(object sender, EventArgs e)
        {

        }

        SqlConnection bagla = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=kayitekle;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO kayitekle (adsoyad, telno, yaş, kangrubu, cinsiyet, ücret) VALUES (@ad, @telno, @yaş, @kangrubu, @cinsiyet, @ücret)";
            SqlCommand komut = new SqlCommand(sorgu, bagla);
            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.Parameters.AddWithValue("@telno", textBox2.Text);
            komut.Parameters.AddWithValue("@yaş", textBox3.Text);
            komut.Parameters.AddWithValue("@kangrubu", comboBox2.Text);
            komut.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);
            komut.Parameters.AddWithValue("@ücret", textBox6.Text);
            bagla.Open();
            komut.ExecuteNonQuery();
            MessageBox.Show("Kaydınız başarılı");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox6.Clear();
            bagla.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            anasayfa an1 = new anasayfa();
            an1.Show();
        }
    }
}
