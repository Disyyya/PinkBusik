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
    public partial class Login : Form
    {
        DataBase database = new DataBase();

        public Login()
        {
            InitializeComponent();
            
        }
        
        public string LabelValue
        {
            get { return Lable_chek.Text; }
            set { Lable_chek.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginuser = textBox1_login.Text;
            var passuser = textBox2_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string qwerysting = $"select Login Password from register where Login = '{loginuser}' and Password = '{passuser}'";
            SqlCommand command = new SqlCommand(qwerysting, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count == 1)
            {

                SqlDataAdapter adapter1 = new SqlDataAdapter();
                DataTable table1 = new DataTable();

                string querystring1 = $"SELECT Login, Password, Admin_or_polz FROM register WHERE Login = '{loginuser}' AND Password = '{passuser}' AND Admin_or_polz = 'admin'";

                var Login = loginuser;
                var password = passuser;
                SqlCommand command1 = new SqlCommand(querystring1, database.getConnection());

                adapter1.SelectCommand = command1;
                adapter1.Fill(table1);

                if (table1.Rows.Count == 1)
                {
                    Lable_chek.Text = "1";
                    
                    MessageBox.Show("Вы успешно вошли как админ!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    Form ReisyForm = new Reisy();
                    ReisyForm.Show();
                    textBox1_login.Text = "";
                    textBox2_password.Text = "";
                }
                else
                {
                    Lable_chek.Text = "0";
                   
                    MessageBox.Show("Вы успешно вошли как сотрудник!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    
                    Form emMainForm = new emMainForm();
                    emMainForm.Show();
                    

                    textBox1_login.Text = "";
                    textBox2_password.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        private void Login_Load(object sender, EventArgs e)
        {
            textBox2_password.PasswordChar = '☼';
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            textBox2_password.PasswordChar = '☼';
            offpb.Visible = true;
            onpb.Visible = false;
        }

        private void offpb_Click(object sender, EventArgs e)
        {
            textBox2_password.PasswordChar = '\0';
            offpb.Visible = false;
            onpb.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Hide();

            Form gost = new gost();
            gost.Show();
        }
    }
}
