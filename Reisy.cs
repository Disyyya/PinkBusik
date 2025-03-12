using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSOVAYA
{
    public partial class Reisy : Form
    {
        public Reisy()
        {
            InitializeComponent();
            dataOTtp.Format = DateTimePickerFormat.Custom;
            dataOTtp.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dataOTtp.ShowUpDown = true;
            dataPRIBtp.Format = DateTimePickerFormat.Custom;
            dataPRIBtp.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            dataPRIBtp.ShowUpDown = true;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=Disya;Initial Catalog=bus1;Integrated Security=True");

        private void Addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (reisy_numtb.Text == "" || reisy_idvodtb.Text == "" || reisy_IdAvttb.Text == ""  || reisy_mestoOTtb.Text == "" || reisy_mestoNAZtb.Text == "")
                    MessageBox.Show("Не во всех полях есть данные");
                else
                {
                    Con.Open();

                    // Проверка, существует ли уже такой продукт
                    string checkQuery = "SELECT COUNT(*) FROM Reisy where ID_Reisy=" + reisy_numtb.Text + ";";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, Con))
                    {
                        checkCmd.Parameters.AddWithValue("ID_Reisy", reisy_numtb.Text);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Рейс с таким ID уже существует!");
                            Con.Close();
                        }

                        else
                        {
                            Con.Close();
                            Con.Open();
                            string formattedDate = dataOTtp.Value.ToString("yyyy-MM-dd HH:mm:ss");
                            string formattedDate1 = dataPRIBtp.Value.ToString("yyyy-MM-dd HH:mm:ss");

                            string query = "insert into Reisy values(" + reisy_numtb.Text + ", " + reisy_idvodtb.Text + ", " + reisy_IdAvttb.Text + ",'" + reisy_mestoOTtb.Text + "','" + reisy_mestoNAZtb.Text + "','" + formattedDate + "', '" + formattedDate1 + "')";
                            SqlCommand cmd = new SqlCommand(query, Con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Рейс добавлен успешно!");
                            
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
            string query = "select * from Reisy";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BusList.DataSource = ds.Tables[0];
            
        }


       

        private void Reisy_Load(object sender, EventArgs e)
        {
            fillcombo();
            populate();
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (reisy_numtb.Text == "" || reisy_idvodtb.Text == "" || reisy_IdAvttb.Text == "" || reisy_mestoOTtb.Text == "" || reisy_mestoNAZtb.Text == "")
                    MessageBox.Show("Не во всех полях есть данные");
                else
                {
                    Con.Open();

                    // Проверка, что введенные даты находятся в допустимом диапазоне
                    DateTime otpravleniya;
                    DateTime prebytiya;

                    if (!DateTime.TryParseExact(dataOTtp.Text, "MM/dd/yyyy hh:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out otpravleniya) ||
                    !DateTime.TryParseExact(dataPRIBtp.Text, "MM/dd/yyyy hh:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out prebytiya))
                    {
                        MessageBox.Show("Недопустимые значения даты и времени.");
                        
                        return;
                    }

                    if (otpravleniya < SqlDateTime.MinValue.Value || otpravleniya > SqlDateTime.MaxValue.Value ||
                    prebytiya < SqlDateTime.MinValue.Value || prebytiya > SqlDateTime.MaxValue.Value)
                    {
                        MessageBox.Show("Значения даты и времени выходят за пределы допустимого диапазона.");
                        
                        return;
                    }

                    string query = "UPDATE Reisy SET ID_Voditel=@ID_Voditel, ID_avtobus=@ID_avtobus, Mesto_otpravleniya=@Mesto_otpravleniya, Mesto_naznacheniya=@Mesto_naznacheniya, Data_Vremya_Otpravleniya=@Data_Vremya_Otpravleniya, Data_Vremya_Prebytiya=@Data_Vremya_Prebytiya WHERE ID_Reisy=@ID_Reisy;";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@ID_Reisy", reisy_numtb.Text);
                        cmd.Parameters.AddWithValue("@ID_Voditel", reisy_idvodtb.Text);
                        cmd.Parameters.AddWithValue("@ID_avtobus", reisy_IdAvttb.Text);
                        cmd.Parameters.AddWithValue("@Mesto_otpravleniya", reisy_mestoOTtb.Text);
                        cmd.Parameters.AddWithValue("@Mesto_naznacheniya", reisy_mestoNAZtb.Text);
                        cmd.Parameters.AddWithValue("@Data_Vremya_Otpravleniya", otpravleniya);
                        cmd.Parameters.AddWithValue("@Data_Vremya_Prebytiya", prebytiya);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Рейс успешно обновлен");
                    
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BusList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                DataGridViewRow selectedRow = BusList.Rows[e.RowIndex];
                reisy_numtb.Text = selectedRow.Cells[0].Value.ToString();
                reisy_idvodtb.Text = selectedRow.Cells[1].Value.ToString();
                reisy_IdAvttb.Text = selectedRow.Cells[2].Value.ToString();
                reisy_mestoOTtb.Text = selectedRow.Cells[3].Value.ToString();
                reisy_mestoNAZtb.Text = selectedRow.Cells[4].Value.ToString();
                dataOTtp.Text = selectedRow.Cells[5].Value.ToString();
                dataPRIBtp.Text = selectedRow.Cells[6].Value.ToString();


        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (reisy_numtb.Text == "")
                {
                    MessageBox.Show("Выберите рейс для удаления");
                }
                else
                {
                    Con.Open();

                    // Удаление связанных записей из таблицы bilet
                    string deleteBiletQuery = "DELETE FROM bilet WHERE ID_Reisy=" + reisy_numtb.Text;
                    SqlCommand deleteBiletCmd = new SqlCommand(deleteBiletQuery, Con);
                    deleteBiletCmd.ExecuteNonQuery();

                    // Удаление рейса
                    string deleteReisyQuery = "DELETE FROM Reisy WHERE ID_Reisy=" + reisy_numtb.Text;
                    SqlCommand deleteReisyCmd = new SqlCommand(deleteReisyQuery, Con);
                    deleteReisyCmd.ExecuteNonQuery();

                    MessageBox.Show("Рейс удален Успешно!");
                    
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void label4_Click(object sender, EventArgs e)
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
        private void BusList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (BusList.Columns[e.ColumnIndex].Name == "Data_Vremya_Otpravleniya" && e.Value != null)
            {
                e.Value = DateTime.Parse(e.Value.ToString()).ToString("MM.dd.yyyy HH:mm:ss");
                e.FormattingApplied = true;
            }
            if (BusList.Columns[e.ColumnIndex].Name == "Data_Vremya_Prebytiya" && e.Value != null)
            {
                e.Value = DateTime.Parse(e.Value.ToString()).ToString("MM.dd.yyyy HH:mm:ss");
                e.FormattingApplied = true;
            }
        }
        private void label14_Click(object sender, EventArgs e)
        {
            Hide();
            Form Sotrydniki = new Sotrydniki();
            Sotrydniki.Show();
        }

        private void idReisaCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }

            Con.Open();

            SqlCommand query = new SqlCommand("SELECT * FROM Reisy WHERE ID_Reisy = @ID_Reisy", Con);
            query.Parameters.AddWithValue("@ID_Reisy", idReisaCB.Text);

            SqlDataAdapter sda = new SqlDataAdapter(query);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);

            BusList.DataSource = ds.Tables[0];

           
        }

        private void fillcombo()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }

            Con.Open();
            SqlCommand cmd = new SqlCommand("select ID_Reisy from Reisy", Con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_Reisy", typeof(string));
            dt.Load(rdr);
            idReisaCB.ValueMember = "ID_Reisy";
            idReisaCB.DataSource = dt;
            Con.Close();
        }


        private void tbre_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
