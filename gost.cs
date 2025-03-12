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
    public partial class gost : Form
    {
        public gost()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=Disya;Initial Catalog=bus1;Integrated Security=True");

        private void fillcombo()
        {
            
            Con.Open();
            SqlCommand cmd = new SqlCommand("select ID_Reisy from Reisy", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_Reisy", typeof(string));
            dt.Load(rdr);
            idReisaCB.ValueMember = "ID_Reisy";
            idReisaCB.DataSource = dt;
            Con.Close();
            Con.Open();
            cmd = new SqlCommand("SELECT Imya + ' ' + Familiya AS FullName, Imya FROM voditel", Con);
            rdr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Columns.Add("FullName", typeof(string));
            dt.Load(rdr);
            fioVodCB.ValueMember = "FullName";
            fioVodCB.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                nameVOD.Text = dt.Rows[0]["Imya"].ToString();
            }
            
            





        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Con.ConnectionString))
            {
                con.Open();

                string query = "SELECT * FROM Reisy WHERE ID_Reisy = @ID_Reisy";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID_Reisy", idReisaCB.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);

                DataView dv = new DataView(ds.Tables[0]);
                DataTable filteredTable = dv.ToTable(false, "ID_Voditel", "ID_avtobus", "Mesto_otpravleniya", "Mesto_naznacheniya", "Data_Vremya_Otpravleniya", "Data_Vremya_Prebytiya");

                goBusList.DataSource = filteredTable;
            }
        }


        private void gost_Load(object sender, EventArgs e)
        {
            fillcombo();

            using (SqlConnection con = new SqlConnection(Con.ConnectionString))
            {
                con.Open();
                string query = "SELECT * FROM Reisy";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                goBusList.DataSource = ds.Tables[0];
            }
        }


        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (fioVodCB.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)fioVodCB.SelectedItem;
                nameVOD.Text = selectedRow["Imya"].ToString();
            }

            using (SqlConnection con = new SqlConnection(Con.ConnectionString))
            {
                con.Open();

                string query = "SELECT * FROM voditel WHERE Imya = @Imya";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Imya", nameVOD.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    idVOD.Text = reader["ID_Voditel"].ToString();
                }
            }

            using (SqlConnection con = new SqlConnection(Con.ConnectionString))
            {
                con.Open();

                int iddd = int.Parse(idVOD.Text);
                string query = "SELECT * FROM Reisy WHERE ID_Voditel = @ID_Voditel";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID_Voditel", idVOD.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);

                DataView dv = new DataView(ds.Tables[0]);
                DataTable filteredTable = dv.ToTable(false, "ID_Voditel", "ID_avtobus", "Mesto_otpravleniya", "Mesto_naznacheniya", "Data_Vremya_Otpravleniya", "Data_Vremya_Prebytiya");

                goBusList.DataSource = filteredTable;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form Login = new Login();
            Login.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
