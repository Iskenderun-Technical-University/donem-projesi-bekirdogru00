using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class guncellemesilme : Form
    {
        public guncellemesilme()
        {
            InitializeComponent();
        }

        SqlConnection bagla = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=kayitekle;Integrated Security=True");
        private void uyeler()
        {
            bagla.Open();
            string query = "select *from kayitekle";
            SqlDataAdapter sda = new SqlDataAdapter(query, bagla);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            bagla.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            anasayfa an1 = new anasayfa();
            an1.Show();
        }

        private void guncellemesilme_Load(object sender, EventArgs e)
        {
            uyeler();
        }
        int key = 0;
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            adsoyadtb.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            telnotb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            yaştb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            kangrubucb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cinsiyetcb.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ücrettb.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string adsoyad = adsoyadtb.Text;

            if (string.IsNullOrEmpty(adsoyad))
            {
                MessageBox.Show("Silinecek üyenin adını ve soyadını giriniz.");
            }
            else
            {
                try
                {
                    string sorgu = "DELETE FROM kayitekle WHERE adsoyad = @adsoyad";
                    SqlCommand komut = new SqlCommand(sorgu, bagla);
                    komut.Parameters.AddWithValue("@adsoyad", adsoyad);
                    bagla.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye başarıyla silindi.");
                    bagla.Close();
                    uyeler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Güncellenecek üyeyi seçiniz.");
            }
            else
            {
                try
                {
                    string sorgu = "UPDATE kayitekle SET adsoyad=@adsoyad, telno=@telno, yaş=@yaş, kangrubu=@kangrubu, cinsiyet=@cinsiyet, ücret=@ücret WHERE id=@id";
                    SqlCommand komut = new SqlCommand(sorgu, bagla);
                    komut.Parameters.AddWithValue("@adsoyad", adsoyadtb.Text);
                    komut.Parameters.AddWithValue("@telno", telnotb.Text);
                    komut.Parameters.AddWithValue("@yaş", yaştb.Text);
                    komut.Parameters.AddWithValue("@kangrubu", kangrubucb.Text);
                    komut.Parameters.AddWithValue("@cinsiyet", cinsiyetcb.Text);
                    komut.Parameters.AddWithValue("@ücret", ücrettb.Text);
                    komut.Parameters.AddWithValue("@id", key);
                    bagla.Open();
                    komut.ExecuteNonQuery();
                    bagla.Close();
                    uyeler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}