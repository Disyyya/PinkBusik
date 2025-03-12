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
    public partial class emAvtobus : Form
    {
        public emAvtobus()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=Disya;Initial Catalog=bus1;Integrated Security=True");

        private void Addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (avtobusid_tb.Text == "" || avtobusNum_tb.Text == "" || avtobustVMEST_tb.Text == "")
                    MessageBox.Show("Не во всех полях есть данные");
                else
                {
                    Con.Open();

                    // Проверка, существует ли уже такой продукт
                    string checkQuery = "SELECT COUNT(*) FROM avtobus where ID_avtobus=" + avtobusid_tb.Text + ";";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, Con))
                    {
                        checkCmd.Parameters.AddWithValue("ID_avtobus", avtobusid_tb.Text);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Автобус с таким ID уже существует!");
                            Con.Close();
                        }

                        else
                        {
                            Con.Close();
                            Con.Open();
                            string query = "insert into avtobus values(" + avtobusid_tb.Text + ", '" + avtobusNum_tb.Text + "', '" + avtobustVMEST_tb.Text + "')";
                            SqlCommand cmd = new SqlCommand(query, Con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Автобус добавлен успешно!");
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
            string query = "select * from avtobus";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AvtobusDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void AvtobusDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = AvtobusDGV.Rows[e.RowIndex];
            avtobusid_tb.Text = selectedRow.Cells[0].Value.ToString();
            avtobusNum_tb.Text = selectedRow.Cells[1].Value.ToString();
            avtobustVMEST_tb.Text = selectedRow.Cells[2].Value.ToString();
        }

        private void emAvtobus_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label10_Click(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {
            Hide();
            Form emPasahir = new emPasahir();
            emPasahir.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (avtobusid_tb.Text == "")
                    {
                        MessageBox.Show("Выберите Автобус для удаления");
                    }
                    else
                    {
                        Con.Open();
                        string query = "delete from avtobus where ID_avtobus=" + avtobusid_tb.Text + "";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Автобус удален Успешно!");
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
}
