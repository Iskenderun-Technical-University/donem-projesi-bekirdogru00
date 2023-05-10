
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = null;
            try
            {
                baglanti = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=DbSporsalonu;Integrated Security=True;");
                baglanti.Open();

                SqlCommand sqlKomut = new SqlCommand("SELECT MusteriID, MusteriAdi, TelNo, KanGrubu, Cinsiyet FROM MusteriBilgi", baglanti);
                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string MusteriID = sqlDataReader[0].ToString();
                    string MusteriAdi = sqlDataReader[1].ToString();
                    string TelNo = sqlDataReader[2].ToString();
                    string KanGrubu = sqlDataReader[3].ToString();
                    string Cinsiyet = sqlDataReader[4].ToString();
                    richTextBox1.Text = richTextBox1.Text + MusteriID + " " + MusteriAdi + " tel no : " + TelNo + " kangrubu:" + KanGrubu + " cinsiyet:" + Cinsiyet + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.ToString());
            }
            finally
            {
                if (baglanti != null)
                    baglanti.Close();
            }
        }
    }
}