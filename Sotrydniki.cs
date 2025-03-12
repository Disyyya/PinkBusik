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
    public partial class Sotrydniki : Form
    {
        public Sotrydniki()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=Disya;Initial Catalog=bus1;Integrated Security=True");

        private void Addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sID_tb.Text == ""||sLogin_tb.Text == "" || sPassword_tb.Text == "" || sRoleCB.Text == "")
                    MessageBox.Show("Не во всех полях есть данные");
                else
                {
                    Con.Open();

                    // Проверка, существует ли уже такой продукт
                    string checkQuery = "SELECT COUNT(*) FROM register where id_sotr=" + sID_tb.Text + ";";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, Con))
                    {
                        checkCmd.Parameters.AddWithValue("id_sotr", sID_tb.Text);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Аккаунт с таким ID уже существует!");
                            Con.Close();
                        }

                        else
                        {
                            Con.Close();
                            Con.Open();
                            string query = "insert into register values(" + sID_tb.Text + ",'" + sLogin_tb.Text + "', '" + sPassword_tb.Text + "', '" + sRoleCB.Text + "')";
                            SqlCommand cmd = new SqlCommand(query, Con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Сотрудник добавлен успешно!");
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
            string query = "select * from register";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SotrudnicDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Sotrydniki_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sID_tb.Text == "" || sLogin_tb.Text == "" || sPassword_tb.Text == "" || sRoleCB.Text == "")
                    MessageBox.Show("Не во всех полях есть данные");
                else
                {
                    Con.Open();
                    string query = "update register set Login='" + sLogin_tb.Text + "', Password='" + sPassword_tb.Text + "',Admin_or_polz='" + sRoleCB.Text + "' WHERE id_sotr="+sID_tb.Text+" ;";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Сотрудник Успешно обновлен");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SotrudnicDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = SotrudnicDGV.Rows[e.RowIndex];
            sID_tb.Text = selectedRow.Cells[0].Value.ToString();
            sLogin_tb.Text = selectedRow.Cells[1].Value.ToString();
            sPassword_tb.Text = selectedRow.Cells[2].Value.ToString();
            sRoleCB.Text = selectedRow.Cells[3].Value.ToString();
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

        private void label3_Click(object sender, EventArgs e)
        {
            Hide();
            Form Passahir = new Passahir();
            Passahir.Show();
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

        private void label6_Click(object sender, EventArgs e)
        {
            Hide();
            Form Avtobus = new Avtobus();
            Avtobus.Show();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sLogin_tb.Text == "")
                {
                    MessageBox.Show("Выберите Сотрудника для удаления");
                }
                else
                {
                    Con.Open();
                    string query = "delete from register where Login='" + sLogin_tb.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Сотрудник удален Успешно!");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
