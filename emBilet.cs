using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KURSOVAYA
{
    public partial class emBilet : Form
    {
        public emBilet()
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

        private void button3_Click(object sender, EventArgs e)
        {
            bilet_idtb.Text = "";
            bReisid_tb.Text = "";
            bNomerPas_tb.Text = "";
            bilet_NumMesta_tb.Text = "";
            bCost_tb.Text = "";
            bStatus_tb.Text = "";
        }

        private void emBilet_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            

            string query = $"SELECT * FROM passahir WHERE ID_Passahir = '{bNomerPas_tb.Text}'";

            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                
                lbF.Text = reader["Imya"].ToString();
                lbI.Text = reader["Familiya"].ToString();
                lbO.Text = reader["Nomer_Telephona"].ToString();

            }
            Con.Close();
            Con.Open();
           

            query = $"SELECT * FROM Reisy WHERE ID_Reisy = '{bReisid_tb.Text}'";

            cmd = new SqlCommand(query, Con);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                
                
                lbmest_ot.Text = reader["Mesto_otpravleniya"].ToString();
                lbMestPrib.Text = reader["Mesto_naznacheniya"].ToString();
                lbDataOt.Text = reader["Data_Vremya_Otpravleniya"].ToString();
                lbDataPrib.Text = reader["Data_Vremya_Prebytiya"].ToString();
                lbNomAvt.Text = reader["ID_avtobus"].ToString();



            }
            
            lbcost.Text = bCost_tb.Text;
            
            Con.Close();
            Con.Open();


            query = $"SELECT * FROM avtobus WHERE ID_avtobus = '{lbNomAvt.Text}'";

            cmd = new SqlCommand(query, Con);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                lbNomAvt.Text = reader["Nomer_avtobusa"].ToString();
                

            }
            Con.Close();
            Con.Open();
            query = $"SELECT * FROM passahir WHERE Imya = '{lbF.Text}' and Familiya = '{lbI.Text}'";

            cmd = new SqlCommand(query, Con);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
 
                lbF.Text = reader["Imya"].ToString();
                lbI.Text = reader["Familiya"].ToString();
            }
            Con.Close();
           


            string txtQrCode = "Автовокзал ':Розовый Бусик'" + "\nБИЛЕТ" + "\nНомер автобуса: " + lbNomAvt.Text + "\nНомер места: " + bilet_NumMesta_tb.Text + $"\nПокупатель: {lbF.Text} {lbI.Text}" + "\nНомер телефона: " + lbO.Text + "\nНомер билета: " + bilet_idtb.Text + "\nМесто отправления: " + lbmest_ot.Text + "\nМесто назначения: " + lbMestPrib.Text +
    "\nДата отправления: " + lbDataOt.Text + "\nДата прибытия: " + lbDataPrib.Text + $"\nСтоимость: "+ lbcost.Text;



            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txtQrCode, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            picQR.Image = code.GetGraphic(5);

            if (bilet_idtb.Text == "" || bReisid_tb.Text == "" || bNomerPas_tb.Text == "" || bilet_NumMesta_tb.Text == "" || bStatus_tb.Text == "" || bCost_tb.Text == "")
                MessageBox.Show("Не выбран билет");
            else
            {
                printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 415, 500);
                // Привязка PrintDocument к PrintPreviewDialog
                printPreviewDialog1.Document = printDocument1;

                // Отображение предварительного просмотра
                printPreviewDialog1.ShowDialog();


            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string Фио = $"{lbF.Text.Trim()} {lbI.Text.Trim()}";

            // Создание градиентной кисти
            using (LinearGradientBrush gradientBrush = new LinearGradientBrush(
                        new Rectangle(0, 0, e.PageBounds.Width, e.PageBounds.Height),
                        Color.LightPink,  // светло-розовый
                        Color.DeepPink,   // темно-розовый
                        LinearGradientMode.Vertical))
            {
                // Настройка шрифтов
                Font headerFont = new Font("Century Gothic", 12, FontStyle.Bold);
                Font bodyFont = new Font("Century Gothic", 10, FontStyle.Bold);

                // Рисование текстов с использованием градиентной кисти
                e.Graphics.DrawString("Автовокзал 'Розовый Бусик'", headerFont, gradientBrush, new Point(70));
                e.Graphics.DrawString("ЧЕК ПОКУПКИ БИЛЕТА:", bodyFont, gradientBrush, new Point(10, 25));
                e.Graphics.DrawString("Покупатель: " + Фио, bodyFont, gradientBrush, new Point(10, 50));
                e.Graphics.DrawString("Номер билета: " + bilet_idtb.Text, bodyFont, gradientBrush, new Point(10, 70));
                e.Graphics.DrawString("Номер автобуса: " + lbNomAvt.Text, bodyFont, gradientBrush, new Point(10, 90));
                e.Graphics.DrawString("Номер места: " + bilet_NumMesta_tb.Text, bodyFont, gradientBrush, new Point(10, 110));
                e.Graphics.DrawString("Дата отправления: " + lbDataOt.Text, bodyFont, gradientBrush, new Point(10, 130));
                e.Graphics.DrawString("Дата прибытия: " + lbDataPrib.Text, bodyFont, gradientBrush, new Point(10, 150));
                e.Graphics.DrawString("Место отправления: " + lbmest_ot.Text, bodyFont, gradientBrush, new Point(10, 170));
                e.Graphics.DrawString("Место назначения: " + lbMestPrib.Text, bodyFont, gradientBrush, new Point(10, 190));
                e.Graphics.DrawString("Стоимость: " + lbcost.Text + " руб.", new Font("Century Gothic", 12, FontStyle.Bold), gradientBrush, new Point(10, 210));

                // Рисование QR-кода
                int newWidth = picQR.Width / 2;
                int newHeight = picQR.Height / 2;
                e.Graphics.DrawImage(picQR.Image, new Rectangle(80, 240, 250, 250));
            }
        }


        private void label12_Click(object sender, EventArgs e)
        {
            Hide();
            Form emReisy = new emReisy();
            emReisy.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Hide();
            Form emVoditel = new emVoditel();
            emVoditel.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Hide();
            Form emPasahir = new emPasahir();
            emPasahir.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Hide();
            Form emAvtobus = new emAvtobus();
            emAvtobus.Show();
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
    }
}
