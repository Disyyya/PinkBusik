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

namespace KURSOVAYA
{
    public partial class emMainForm : Form
    {
        public emMainForm()
        {
            InitializeComponent();
        }

        private void emMainForm_Load(object sender, EventArgs e)
        {
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=Disya;Initial Catalog=bus1;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from Reisy";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BusList.DataSource = ds.Tables[0];
            Con.Close();
            query = "select * from avtobus";
            sda = new SqlDataAdapter(query, Con);
            builder = new SqlCommandBuilder(sda);
            ds = new DataSet();
            sda.Fill(ds);
            AvtobusDGV.DataSource = ds.Tables[0];
            Con.Close();
            Con.Open();
            query = "select * from voditel";
            sda = new SqlDataAdapter(query, Con);
            builder = new SqlCommandBuilder(sda);
            ds = new DataSet();
            sda.Fill(ds);
            VoditelDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Hide();
            Form emReisy = new emReisy();
            emReisy.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Hide();
            Form emVoditel = new emVoditel();
            emVoditel.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Hide();
            Form emPasahir = new emPasahir();
            emPasahir.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Hide();
            Form emAvtobus = new emAvtobus();
            emAvtobus.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Hide();
            Form emBilet = new emBilet();
            emBilet.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form Login = new Login();
            Login.Show();
        }
    }
}
