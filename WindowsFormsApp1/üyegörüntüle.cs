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

namespace WindowsFormsApp1
{
    public partial class üyegörüntüle : Form
    {
        public üyegörüntüle()
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

        private void button1_Click(object sender, EventArgs e)
        {
            bagla.Open();
            SqlCommand komut = new SqlCommand("Select * from kayitekle where adsoyad like '%"+ textBox1.Text+ "%'",bagla);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource= ds.Tables[0];
            bagla.Close();
           
        }

        private void üyegörüntüle_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
