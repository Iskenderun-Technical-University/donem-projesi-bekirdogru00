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
            string query = "select * from kayitekle";
            SqlDataAdapter sda = new SqlDataAdapter(query, bagla);
            var ds = new DataSet();
            sda.Fill(ds);
            bagla.Close();

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
        int key = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                key = Convert.ToInt32(row.Cells[0].Value.ToString());
                adsoyadtb.Text = row.Cells[1].Value.ToString();
                telnotb.Text = row.Cells[2].Value.ToString();
                yaştb.Text = row.Cells[3].Value.ToString();
                kangrubucb.SelectedItem = row.Cells[4].Value.ToString();
                cinsiyetcb.SelectedItem = row.Cells[5].Value.ToString();
                ücrettb.Text = row.Cells[6].Value.ToString();

              
            }
        }




    }
}