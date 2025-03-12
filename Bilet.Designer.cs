namespace KURSOVAYA
{
    partial class Bilet
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
            this.bNomerPas_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bReisid_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BiletDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bStatus_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bilet_idtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bilet_NumMesta_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bCost_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BusList = new System.Windows.Forms.DataGridView();
            this.PasahirDGV = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.BiletDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasahirDGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bNomerPas_tb
            // 
            this.bNomerPas_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bNomerPas_tb.Location = new System.Drawing.Point(307, 292);
            this.bNomerPas_tb.Margin = new System.Windows.Forms.Padding(4);
            this.bNomerPas_tb.Name = "bNomerPas_tb";
            this.bNomerPas_tb.Size = new System.Drawing.Size(220, 29);
            this.bNomerPas_tb.TabIndex = 54;
            this.bNomerPas_tb.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(301, 265);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 23);
            this.label9.TabIndex = 53;
            this.label9.Text = "ID пасажира";
            // 
            // bReisid_tb
            // 
            this.bReisid_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bReisid_tb.Location = new System.Drawing.Point(305, 220);
            this.bReisid_tb.Margin = new System.Windows.Forms.Padding(4);
            this.bReisid_tb.Name = "bReisid_tb";
            this.bReisid_tb.Size = new System.Drawing.Size(221, 29);
            this.bReisid_tb.TabIndex = 52;
            this.bReisid_tb.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(301, 193);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 23);
            this.label8.TabIndex = 51;
            this.label8.Text = "ID рейса";
            // 
            // BiletDGV
            // 
            this.BiletDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.BiletDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BiletDGV.GridColor = System.Drawing.SystemColors.HotTrack;
            this.BiletDGV.Location = new System.Drawing.Point(543, 65);
            this.BiletDGV.Margin = new System.Windows.Forms.Padding(4);
            this.BiletDGV.Name = "BiletDGV";
            this.BiletDGV.RowHeadersWidth = 62;
            this.BiletDGV.RowTemplate.Height = 28;
            this.BiletDGV.Size = new System.Drawing.Size(957, 265);
            this.BiletDGV.TabIndex = 50;
            this.BiletDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BiletDGV_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(52, 708);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bStatus_tb
            // 
            this.bStatus_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStatus_tb.Location = new System.Drawing.Point(309, 506);
            this.bStatus_tb.Margin = new System.Windows.Forms.Padding(4);
            this.bStatus_tb.Name = "bStatus_tb";
            this.bStatus_tb.Size = new System.Drawing.Size(220, 29);
            this.bStatus_tb.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(304, 479);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "Статус:";
            // 
            // bilet_idtb
            // 
            this.bilet_idtb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bilet_idtb.Location = new System.Drawing.Point(305, 150);
            this.bilet_idtb.Margin = new System.Windows.Forms.Padding(4);
            this.bilet_idtb.Name = "bilet_idtb";
            this.bilet_idtb.Size = new System.Drawing.Size(220, 29);
            this.bilet_idtb.TabIndex = 45;
            this.bilet_idtb.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(300, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 44;
            this.label1.Text = "ID билета";
            // 
            // Deletebutton
            // 
            this.Deletebutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deletebutton.Location = new System.Drawing.Point(308, 708);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(223, 60);
            this.Deletebutton.TabIndex = 43;
            this.Deletebutton.Text = "Удалить";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Editbutton
            // 
            this.Editbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Editbutton.Location = new System.Drawing.Point(309, 633);
            this.Editbutton.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(221, 58);
            this.Editbutton.TabIndex = 42;
            this.Editbutton.Text = "Изменить";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addbutton.Location = new System.Drawing.Point(308, 565);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(223, 58);
            this.Addbutton.TabIndex = 41;
            this.Addbutton.Text = "Добавить";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(64, 493);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Билет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(64, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Автобус";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(64, 447);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 31);
            this.label10.TabIndex = 11;
            this.label10.Text = "Пассажир";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(64, 350);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 31);
            this.label11.TabIndex = 10;
            this.label11.Text = "Водитель";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // bilet_NumMesta_tb
            // 
            this.bilet_NumMesta_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bilet_NumMesta_tb.Location = new System.Drawing.Point(308, 364);
            this.bilet_NumMesta_tb.Margin = new System.Windows.Forms.Padding(4);
            this.bilet_NumMesta_tb.Name = "bilet_NumMesta_tb";
            this.bilet_NumMesta_tb.Size = new System.Drawing.Size(219, 29);
            this.bilet_NumMesta_tb.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(303, 337);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = "Номер места";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 814);
            this.panel1.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(64, 397);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 31);
            this.label7.TabIndex = 61;
            this.label7.Text = "Сотрудники";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(64, 299);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 31);
            this.label12.TabIndex = 9;
            this.label12.Text = "Рейсы";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // bCost_tb
            // 
            this.bCost_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCost_tb.Location = new System.Drawing.Point(308, 436);
            this.bCost_tb.Margin = new System.Windows.Forms.Padding(4);
            this.bCost_tb.Name = "bCost_tb";
            this.bCost_tb.Size = new System.Drawing.Size(221, 29);
            this.bCost_tb.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(303, 409);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 55;
            this.label6.Text = "Цена";
            // 
            // BusList
            // 
            this.BusList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.BusList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BusList.Cursor = System.Windows.Forms.Cursors.Default;
            this.BusList.GridColor = System.Drawing.SystemColors.HotTrack;
            this.BusList.Location = new System.Drawing.Point(543, 337);
            this.BusList.Margin = new System.Windows.Forms.Padding(4);
            this.BusList.Name = "BusList";
            this.BusList.RowHeadersWidth = 62;
            this.BusList.RowTemplate.Height = 28;
            this.BusList.Size = new System.Drawing.Size(1020, 222);
            this.BusList.TabIndex = 57;
            // 
            // PasahirDGV
            // 
            this.PasahirDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.PasahirDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PasahirDGV.GridColor = System.Drawing.SystemColors.HotTrack;
            this.PasahirDGV.Location = new System.Drawing.Point(543, 566);
            this.PasahirDGV.Margin = new System.Windows.Forms.Padding(4);
            this.PasahirDGV.Name = "PasahirDGV";
            this.PasahirDGV.RowHeadersWidth = 62;
            this.PasahirDGV.RowTemplate.Height = 28;
            this.PasahirDGV.Size = new System.Drawing.Size(1004, 247);
            this.PasahirDGV.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Brown;
            this.label13.Location = new System.Drawing.Point(299, 11);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(582, 37);
            this.label13.TabIndex = 76;
            this.label13.Text = "Добавить или убрать билет в базе данных";
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
            this.panel2.TabIndex = 59;
            // 
            // Bilet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1579, 814);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PasahirDGV);
            this.Controls.Add(this.BusList);
            this.Controls.Add(this.bCost_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bNomerPas_tb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bReisid_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BiletDGV);
            this.Controls.Add(this.bStatus_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bilet_idtb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.bilet_NumMesta_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bilet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Bilet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BiletDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasahirDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bNomerPas_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bReisid_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView BiletDGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bStatus_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bilet_idtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox bilet_NumMesta_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox bCost_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView BusList;
        private System.Windows.Forms.DataGridView PasahirDGV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
    }
}