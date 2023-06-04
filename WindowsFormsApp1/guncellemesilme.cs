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
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class guncellemesilme : Form
    {
        SqlConnection bagla = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=kayitekle;Integrated Security=True");
        private int selectedRowKey = 0;

        public guncellemesilme()
        {
            InitializeComponent();
        }

        private void uyeler()
        {
            string query = "SELECT * FROM kayitekle";
            SqlDataAdapter sda = new SqlDataAdapter(query, bagla);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                adsoyadtb.Text = row.Cells[0].Value.ToString();
                telnotb.Text = row.Cells[1].Value.ToString();
                yaştb.Text = row.Cells[2].Value.ToString();
                kangrubucb.Text = row.Cells[3].Value.ToString();
                cinsiyetcb.Text = row.Cells[4].Value.ToString();
                ücrettb.Text = row.Cells[5].Value.ToString();

                selectedRowKey = Convert.ToInt32(row.Cells["id"].Value);
            }
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
            if (selectedRowKey == 0 || string.IsNullOrEmpty(adsoyadtb.Text) || string.IsNullOrEmpty(telnotb.Text) || string.IsNullOrEmpty(yaştb.Text) || string.IsNullOrEmpty(kangrubucb.Text) || string.IsNullOrEmpty(cinsiyetcb.Text) || string.IsNullOrEmpty(ücrettb.Text))
            {
                MessageBox.Show("Eksik bilgi");
            }
            else
            {
                try
                {
                    bagla.Open();
                    string sorgu = "UPDATE kayitekle SET adsoyad=@adsoyad, telno=@telno, yaş=@yaş, kangrubu=@kangrubu, cinsiyet=@cinsiyet, ücret=@ücret WHERE id=@id";
                    SqlCommand komut = new SqlCommand(sorgu, bagla);
                    komut.Parameters.AddWithValue("@adsoyad", adsoyadtb.Text);
                    komut.Parameters.AddWithValue("@telno", telnotb.Text);
                    komut.Parameters.AddWithValue("@yaş", yaştb.Text);
                    komut.Parameters.AddWithValue("@kangrubu", kangrubucb.Text);
                    komut.Parameters.AddWithValue("@cinsiyet", cinsiyetcb.Text);
                    komut.Parameters.AddWithValue("@ücret", ücrettb.Text);
                    komut.Parameters.AddWithValue("@id", selectedRowKey);

                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye başarıyla güncellendi");
                    bagla.Close();
                    uyeler();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
