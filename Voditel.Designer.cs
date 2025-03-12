namespace KURSOVAYA
{
    partial class Voditel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.VoditelDGV = new System.Windows.Forms.DataGridView();
            this.voditel_numUDtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.voditel_idtb = new System.Windows.Forms.TextBox();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.voditel_phone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.voditel_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.voditel_lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.FIOVodCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nameVOD = new System.Windows.Forms.Label();
            this.tbre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VoditelDGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(347, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 54;
            this.label8.Text = "ID водителя";
            // 
            // VoditelDGV
            // 
            this.VoditelDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.VoditelDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VoditelDGV.GridColor = System.Drawing.SystemColors.HotTrack;
            this.VoditelDGV.Location = new System.Drawing.Point(377, 313);
            this.VoditelDGV.Margin = new System.Windows.Forms.Padding(4);
            this.VoditelDGV.Name = "VoditelDGV";
            this.VoditelDGV.RowHeadersWidth = 62;
            this.VoditelDGV.RowTemplate.Height = 28;
            this.VoditelDGV.Size = new System.Drawing.Size(1173, 486);
            this.VoditelDGV.TabIndex = 51;
            this.VoditelDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VoditelDGV_CellContentClick);
            // 
            // voditel_numUDtb
            // 
            this.voditel_numUDtb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.voditel_numUDtb.Location = new System.Drawing.Point(891, 186);
            this.voditel_numUDtb.Margin = new System.Windows.Forms.Padding(4);
            this.voditel_numUDtb.Name = "voditel_numUDtb";
            this.voditel_numUDtb.Size = new System.Drawing.Size(335, 29);
            this.voditel_numUDtb.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(888, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 23);
            this.label3.TabIndex = 49;
            this.label3.Text = "Номер удостоверения";
            // 
            // voditel_idtb
            // 
            this.voditel_idtb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.voditel_idtb.Location = new System.Drawing.Point(351, 118);
            this.voditel_idtb.Margin = new System.Windows.Forms.Padding(4);
            this.voditel_idtb.Name = "voditel_idtb";
            this.voditel_idtb.Size = new System.Drawing.Size(244, 29);
            this.voditel_idtb.TabIndex = 46;
            this.voditel_idtb.Text = " ";
            // 
            // Deletebutton
            // 
            this.Deletebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deletebutton.ForeColor = System.Drawing.Color.DarkRed;
            this.Deletebutton.Location = new System.Drawing.Point(585, 256);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(205, 45);
            this.Deletebutton.TabIndex = 44;
            this.Deletebutton.Text = "Удалить";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addbutton.ForeColor = System.Drawing.Color.DarkRed;
            this.Addbutton.Location = new System.Drawing.Point(377, 259);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(194, 42);
            this.Addbutton.TabIndex = 42;
            this.Addbutton.Text = "Добавить";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // voditel_phone
            // 
            this.voditel_phone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.voditel_phone.Location = new System.Drawing.Point(351, 186);
            this.voditel_phone.Margin = new System.Windows.Forms.Padding(4);
            this.voditel_phone.Name = "voditel_phone";
            this.voditel_phone.Size = new System.Drawing.Size(244, 29);
            this.voditel_phone.TabIndex = 60;
            this.voditel_phone.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(347, 159);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 23);
            this.label9.TabIndex = 59;
            this.label9.Text = "Номер телефона";
            // 
            // voditel_name
            // 
            this.voditel_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.voditel_name.Location = new System.Drawing.Point(625, 118);
            this.voditel_name.Margin = new System.Windows.Forms.Padding(4);
            this.voditel_name.Name = "voditel_name";
            this.voditel_name.Size = new System.Drawing.Size(221, 29);
            this.voditel_name.TabIndex = 58;
            this.voditel_name.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(621, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 23);
            this.label1.TabIndex = 57;
            this.label1.Text = "Имя";
            // 
            // voditel_lastname
            // 
            this.voditel_lastname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.voditel_lastname.Location = new System.Drawing.Point(890, 118);
            this.voditel_lastname.Margin = new System.Windows.Forms.Padding(4);
            this.voditel_lastname.Name = "voditel_lastname";
            this.voditel_lastname.Size = new System.Drawing.Size(336, 29);
            this.voditel_lastname.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(887, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 55;
            this.label2.Text = "Фамилия";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(64, 455);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "Билет";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(64, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "Автобус";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(64, 409);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пассажир";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 708);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(64, 360);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Водитель";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(64, 313);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "Рейсы";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label13);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(283, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1296, 57);
            this.panel2.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Brown;
            this.label13.Location = new System.Drawing.Point(323, 11);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(631, 37);
            this.label13.TabIndex = 63;
            this.label13.Text = "Добавить или убрать водителя в базе данных";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 814);
            this.panel1.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(1275, 86);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(247, 28);
            this.label12.TabIndex = 64;
            this.label12.Text = "Найти водителя по ФИО";
            // 
            // FIOVodCB
            // 
            this.FIOVodCB.BackColor = System.Drawing.Color.Transparent;
            this.FIOVodCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FIOVodCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FIOVodCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FIOVodCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FIOVodCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FIOVodCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.FIOVodCB.ItemHeight = 30;
            this.FIOVodCB.Location = new System.Drawing.Point(1243, 118);
            this.FIOVodCB.Margin = new System.Windows.Forms.Padding(4);
            this.FIOVodCB.Name = "FIOVodCB";
            this.FIOVodCB.Size = new System.Drawing.Size(307, 36);
            this.FIOVodCB.TabIndex = 63;
            // 
            // nameVOD
            // 
            this.nameVOD.AutoSize = true;
            this.nameVOD.Location = new System.Drawing.Point(1532, 62);
            this.nameVOD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameVOD.Name = "nameVOD";
            this.nameVOD.Size = new System.Drawing.Size(44, 16);
            this.nameVOD.TabIndex = 65;
            this.nameVOD.Text = "label3";
            this.nameVOD.Visible = false;
            // 
            // tbre
            // 
            this.tbre.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbre.ForeColor = System.Drawing.Color.Maroon;
            this.tbre.Location = new System.Drawing.Point(1378, 263);
            this.tbre.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tbre.Name = "tbre";
            this.tbre.Size = new System.Drawing.Size(172, 41);
            this.tbre.TabIndex = 66;
            this.tbre.Text = "Вернуть таблицу";
            this.tbre.UseVisualStyleBackColor = true;
            this.tbre.Click += new System.EventHandler(this.tbre_Click);
            // 
            // Voditel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1579, 814);
            this.Controls.Add(this.tbre);
            this.Controls.Add(this.nameVOD);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.FIOVodCB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.voditel_phone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.voditel_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.voditel_lastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.VoditelDGV);
            this.Controls.Add(this.voditel_numUDtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.voditel_idtb);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Addbutton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Voditel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Voditel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VoditelDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView VoditelDGV;
        private System.Windows.Forms.TextBox voditel_numUDtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox voditel_idtb;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.TextBox voditel_phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox voditel_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox voditel_lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox FIOVodCB;
        private System.Windows.Forms.Label nameVOD;
        private System.Windows.Forms.Button tbre;
    }
}