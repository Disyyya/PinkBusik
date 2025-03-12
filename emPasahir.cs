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
    public partial class emPasahir : Form
    {
        public emPasahir()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=Disya;Initial Catalog=bus1;Integrated Security=True");

        private void Addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (pasahir_id.Text == "" || pasahir_name.Text == "" || pasahir_lastname.Text == "" || pasahir_phone.Text == "")
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

        private void emPasahir_Load(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {
            Hide();
            Form emReisy = new emReisy();
            emReisy.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Hide();
            Form emVoditel = new emVoditel();
            emVoditel.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Hide();
            Form emAvtobus = new emAvtobus();
            emAvtobus.Show();
        }

        private void label7_Click(object sender, EventArgs e)
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

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            Form emMainForm = new emMainForm();
            emMainForm.Show();
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
    }
    }

