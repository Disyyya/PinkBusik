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
    public partial class Passahir : Form
    {
        public Passahir()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=Disya;Initial Catalog=bus1;Integrated Security=True");

        private void Addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (pasahir_id.Text == "" || pasahir_name.Text == "" || pasahir_lastname.Text == "" || pasahir_phone.Text == "" )
                    MessageBox.Show("Не во всех полях есть данные");
                else
                {
                    Con.Open();

                    // Проверка, существует ли уже такой продукт
                    string checkQuery = "SELECT COUNT(*) FROM passahir where ID_Passahir=" + pasahir_id.Text + ";";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, Con))
                    {
                        checkCmd.Parameters.AddWithValue("ID_Passahir", pasahir_id.Text);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Пассажир с таким ID уже существует!");
                            Con.Close();
                        }

                        else
                        {
                            Con.Close();
                            Con.Open();
                            string query = "insert into passahir values(" + pasahir_id.Text + ", '" + pasahir_name.Text + "', '" + pasahir_lastname.Text + "','" + pasahir_phone.Text + "')";
                            SqlCommand cmd = new SqlCommand(query, Con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Пассажир добавлен успешно!");
                            Con.Close();
                            populate();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from passahir";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PasahirDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Passahir_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void PasahirDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = PasahirDGV.Rows[e.RowIndex];
            pasahir_id.Text = selectedRow.Cells[0].Value.ToString();
            pasahir_name.Text = selectedRow.Cells[1].Value.ToString();
            pasahir_lastname.Text = selectedRow.Cells[2].Value.ToString();
            pasahir_phone.Text = selectedRow.Cells[3].Value.ToString();
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (pasahir_id.Text == "" || pasahir_name.Text == "" || pasahir_lastname.Text == "" || pasahir_phone.Text == "")
                    MessageBox.Show("Не во всех полях есть данные");
                else
                {
                    Con.Open();
                    string query = "update passahir set Imya='" + pasahir_name.Text + "',Familiya='" + pasahir_lastname.Text + "',Nomer_Telephona='" + pasahir_phone.Text + "' WHERE ID_Passahir=" + pasahir_id.Text + ";";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Пассажир Успешно обновлен");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (pasahir_id.Text == "")
                {
                    MessageBox.Show("Выберите Пассажира для удаления");
                }
                else
                {
                    Con.Open();
                    string query = "delete from passahir where ID_Passahir=" + pasahir_id.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Пассажир удален Успешно!");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Hide();
            Form Reisy = new Reisy();
            Reisy.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Hide();
            Form Voditel = new Voditel();
            Voditel.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Hide();
            Form Avtobus = new Avtobus();
            Avtobus.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Hide();
            Form Bilet = new Bilet();
            Bilet.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form Login = new Login();
            Login.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Hide();
            Form Sotrydniki = new Sotrydniki();
            Sotrydniki.Show();
        }
    }
}
