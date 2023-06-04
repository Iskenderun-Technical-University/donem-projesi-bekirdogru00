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
using System.Diagnostics.Eventing.Reader;

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ödemeler : Form
    {
        SqlConnection bagla = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=kayitekle;Integrated Security=True");

        public ödemeler()
        {
            InitializeComponent();
        }

        private void FillName()
        {
            bagla.Open();
            SqlCommand komut = new SqlCommand("SELECT adsoyad FROM kayitekle", bagla);
            SqlDataReader rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("adsoyad", typeof(string));
            dt.Load(rdr);
            adsoyadcb.ValueMember = "adsoyad";
            adsoyadcb.DataSource = dt;
            bagla.Close();
        }

        private void uyeler()
        {
            bagla.Open();
            string query = "SELECT * FROM OdemeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, bagla);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            bagla.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            anasayfa an1 = new anasayfa();
            an1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (adsoyadcb.Text == "" || ucrettb.Text == "")
            {
                MessageBox.Show("Eksik bilgi");
            }
            else
            {
                string odemeperiyot = Periyot.Value.Month.ToString() + Periyot.Value.Year.ToString();
                bagla.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT count(*) FROM OdemeTbl WHERE Ouye = '" + adsoyadcb.SelectedValue.ToString() + "' AND Oay = '" + odemeperiyot + "'", bagla);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Ödeme Zaten Yapıldı");
                }
                else
                {
                    string query = "INSERT INTO OdemeTbl VALUES ('" + odemeperiyot + "', '" + adsoyadcb.SelectedValue.ToString() + "', " + ucrettb.Text + ")";
                    SqlCommand komut = new SqlCommand(query, bagla);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla Ödendi. Bizi tercih ettiğiniz için teşekkürler");
                }
                bagla.Close();
                uyeler();
            }
        }

        private void ödemeler_Load(object sender, EventArgs e)
        {
            FillName();
            uyeler();
        }
    }
}
