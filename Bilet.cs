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
    public partial class Bilet : Form
    {
        public Bilet()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=Disya;Initial Catalog=bus1;Integrated Security=True");

        private void Addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (bilet_idtb.Text == "" || bReisid_tb.Text == "" || bNomerPas_tb.Text == "" || bilet_NumMesta_tb.Text == "" || bStatus_tb.Text == "" || bCost_tb.Text == "")
                    MessageBox.Show("Не во всех полях есть данные");
                else
                {
                    Con.Open();

                    // Проверка, существует ли уже такой продукт
                    string checkQuery = "SELECT COUNT(*) FROM bilet where ID_bilet=" + bilet_idtb.Text + ";";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, Con))
                    {
                        checkCmd.Parameters.AddWithValue("ID_bilet", bilet_idtb.Text);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Билет с таким ID уже существует!");
                            Con.Close();
                        }

                        else
                        {
                            Con.Close();
                            Con.Open();
                           
                            string query = "insert into bilet values(" + bilet_idtb.Text + ", " + bReisid_tb.Text + ", " + bNomerPas_tb.Text + "," + bilet_NumMesta_tb.Text + "," + bCost_tb.Text + ",'" + bStatus_tb.Text + "')";
                            SqlCommand cmd = new SqlCommand(query, Con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Билет добавлен успешно!");
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
            string query = "select * from bilet";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BiletDGV.DataSource = ds.Tables[0];
            Con.Close();
            Con.Open();
            query = "select * from Reisy";
            sda = new SqlDataAdapter(query, Con);
            builder = new SqlCommandBuilder(sda);
            ds = new DataSet();
            sda.Fill(ds);
            BusList.DataSource = ds.Tables[0];
            Con.Close();
            Con.Open();
            query = "select * from passahir";
            sda = new SqlDataAdapter(query, Con);
            builder = new SqlCommandBuilder(sda);
            ds = new DataSet();
            sda.Fill(ds);
            PasahirDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Bilet_Load(object sender, EventArgs e)
        {
            populate();
            
        }

       
        private void BiletDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = BiletDGV.Rows[e.RowIndex];
            bilet_idtb.Text = selectedRow.Cells[0].Value.ToString();
            bReisid_tb.Text = selectedRow.Cells[1].Value.ToString();
            bNomerPas_tb.Text = selectedRow.Cells[2].Value.ToString();
            bilet_NumMesta_tb.Text = selectedRow.Cells[3].Value.ToString();
            bCost_tb.Text = selectedRow.Cells[4].Value.ToString();
            bStatus_tb.Text = selectedRow.Cells[5].Value.ToString();
            
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (bilet_idtb.Text == "" || bReisid_tb.Text == "" || bNomerPas_tb.Text == "" || bilet_NumMesta_tb.Text == "" || bStatus_tb.Text == "" || bCost_tb.Text == "")
                    MessageBox.Show("Не во всех полях есть данные");
                else
                {
                    Con.Open();
                    ;

                    string query = "update bilet set ID_Reisy=" + bReisid_tb.Text + ",ID_Passahir=" + bNomerPas_tb.Text + ",Nomer_mesta=" + bilet_NumMesta_tb.Text + ", cost=" + bCost_tb.Text + ", Status='" + bStatus_tb.Text + "' WHERE ID_bilet=" + bilet_idtb.Text + ";";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Билет Успешно обновлен");
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
                if (bilet_idtb.Text == "")
                {
                    MessageBox.Show("Выберите Билет для удаления");
                }
                else
                {
                    Con.Open();
                    string query = "delete from bilet where ID_bilet=" + bilet_idtb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Билет удален Успешно!");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Hide();
            Form Reisy = new Reisy();
            Reisy.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Hide();
            Form Voditel = new Voditel();
            Voditel.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Hide();
            Form Passahir = new Passahir();
            Passahir.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Hide();
            Form Avtobus = new Avtobus();
            Avtobus.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form Login = new Login();
            Login.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Hide();
            Form Sotrydniki = new Sotrydniki();
            Sotrydniki.Show();
        }
    }
}
