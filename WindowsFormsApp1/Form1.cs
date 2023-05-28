using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            con = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=guvenlik;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM parola WHERE ad='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'";

            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("GİRİŞ BAŞARILI");
                anasayfa gecis = new anasayfa();
                gecis.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("YANLIŞ KULLANICI ADI VEYA ŞİFRE");
            }
            con.Close();
        }
    }
}

