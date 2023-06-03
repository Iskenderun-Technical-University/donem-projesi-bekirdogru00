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
          
                adsoyadtb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                telnotb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                yaştb.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                kangrubucb.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                cinsiyetcb.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                ücrettb.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            }
        }






    }
