namespace KURSOVAYA
{
    partial class emBilet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emBilet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PasahirDGV = new System.Windows.Forms.DataGridView();
            this.BusList = new System.Windows.Forms.DataGridView();
            this.bCost_tb = new System.Windows.Forms.TextBox();
            this.bNomerPas_tb = new System.Windows.Forms.TextBox();
            this.bReisid_tb = new System.Windows.Forms.TextBox();
            this.BiletDGV = new System.Windows.Forms.DataGridView();
            this.bStatus_tb = new System.Windows.Forms.TextBox();
            this.bilet_idtb = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.bilet_NumMesta_tb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbmest_ot = new System.Windows.Forms.Label();
            this.lbcost = new System.Windows.Forms.Label();
            this.picQR = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbO = new System.Windows.Forms.Label();
            this.lbI = new System.Windows.Forms.Label();
            this.lbF = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lbMestPrib = new System.Windows.Forms.Label();
            this.lbDataOt = new System.Windows.Forms.Label();
            this.lbDataPrib = new System.Windows.Forms.Label();
            this.lbNomAvt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasahirDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BiletDGV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
            this.panel1.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(69, 432);
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
            this.label5.Location = new System.Drawing.Point(64, 212);
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
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(64, 382);
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
            this.label11.Location = new System.Drawing.Point(64, 319);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 31);
            this.label11.TabIndex = 10;
            this.label11.Text = "Водитель";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(64, 264);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 31);
            this.label12.TabIndex = 9;
            this.label12.Text = "Рейсы";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(52, 708);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasahirDGV
            // 
            this.PasahirDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.PasahirDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PasahirDGV.GridColor = System.Drawing.SystemColors.HotTrack;
            this.PasahirDGV.Location = new System.Drawing.Point(559, 566);
            this.PasahirDGV.Margin = new System.Windows.Forms.Padding(4);
            this.PasahirDGV.Name = "PasahirDGV";
            this.PasahirDGV.RowHeadersWidth = 62;
            this.PasahirDGV.RowTemplate.Height = 28;
            this.PasahirDGV.Size = new System.Drawing.Size(1004, 247);
            this.PasahirDGV.TabIndex = 73;
            // 
            // BusList
            // 
            this.BusList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.BusList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BusList.Cursor = System.Windows.Forms.Cursors.Default;
            this.BusList.GridColor = System.Drawing.SystemColors.HotTrack;
            this.BusList.Location = new System.Drawing.Point(559, 337);
            this.BusList.Margin = new System.Windows.Forms.Padding(4);
            this.BusList.Name = "BusList";
            this.BusList.RowHeadersWidth = 62;
            this.BusList.RowTemplate.Height = 28;
            this.BusList.Size = new System.Drawing.Size(1020, 222);
            this.BusList.TabIndex = 72;
            // 
            // bCost_tb
            // 
            this.bCost_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCost_tb.Location = new System.Drawing.Point(324, 436);
            this.bCost_tb.Margin = new System.Windows.Forms.Padding(4);
            this.bCost_tb.Name = "bCost_tb";
            this.bCost_tb.Size = new System.Drawing.Size(221, 29);
            this.bCost_tb.TabIndex = 71;
            // 
            // bNomerPas_tb
            // 
            this.bNomerPas_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bNomerPas_tb.Location = new System.Drawing.Point(323, 292);
            this.bNomerPas_tb.Margin = new System.Windows.Forms.Padding(4);
            this.bNomerPas_tb.Name = "bNomerPas_tb";
            this.bNomerPas_tb.Size = new System.Drawing.Size(220, 29);
            this.bNomerPas_tb.TabIndex = 70;
            this.bNomerPas_tb.Text = " ";
            // 
            // bReisid_tb
            // 
            this.bReisid_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bReisid_tb.Location = new System.Drawing.Point(321, 220);
            this.bReisid_tb.Margin = new System.Windows.Forms.Padding(4);
            this.bReisid_tb.Name = "bReisid_tb";
            this.bReisid_tb.Size = new System.Drawing.Size(221, 29);
            this.bReisid_tb.TabIndex = 68;
            this.bReisid_tb.Text = " ";
            // 
            // BiletDGV
            // 
            this.BiletDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.BiletDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BiletDGV.GridColor = System.Drawing.SystemColors.HotTrack;
            this.BiletDGV.Location = new System.Drawing.Point(559, 65);
            this.BiletDGV.Margin = new System.Windows.Forms.Padding(4);
            this.BiletDGV.Name = "BiletDGV";
            this.BiletDGV.RowHeadersWidth = 62;
            this.BiletDGV.RowTemplate.Height = 28;
            this.BiletDGV.Size = new System.Drawing.Size(957, 265);
            this.BiletDGV.TabIndex = 67;
            this.BiletDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BiletDGV_CellContentClick);
            // 
            // bStatus_tb
            // 
            this.bStatus_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStatus_tb.Location = new System.Drawing.Point(325, 506);
            this.bStatus_tb.Margin = new System.Windows.Forms.Padding(4);
            this.bStatus_tb.Name = "bStatus_tb";
            this.bStatus_tb.Size = new System.Drawing.Size(220, 29);
            this.bStatus_tb.TabIndex = 66;
            // 
            // bilet_idtb
            // 
            this.bilet_idtb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bilet_idtb.Location = new System.Drawing.Point(321, 150);
            this.bilet_idtb.Margin = new System.Windows.Forms.Padding(4);
            this.bilet_idtb.Name = "bilet_idtb";
            this.bilet_idtb.Size = new System.Drawing.Size(220, 29);
            this.bilet_idtb.TabIndex = 63;
            this.bilet_idtb.Text = " ";
            // 
            // Addbutton
            // 
            this.Addbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addbutton.ForeColor = System.Drawing.Color.DarkRed;
            this.Addbutton.Location = new System.Drawing.Point(324, 565);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(223, 58);
            this.Addbutton.TabIndex = 59;
            this.Addbutton.Text = "Добавить";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // bilet_NumMesta_tb
            // 
            this.bilet_NumMesta_tb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bilet_NumMesta_tb.Location = new System.Drawing.Point(324, 364);
            this.bilet_NumMesta_tb.Margin = new System.Windows.Forms.Padding(4);
            this.bilet_NumMesta_tb.Name = "bilet_NumMesta_tb";
            this.bilet_NumMesta_tb.Size = new System.Drawing.Size(219, 29);
            this.bilet_NumMesta_tb.TabIndex = 65;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Brown;
            this.label13.Location = new System.Drawing.Point(299, 11);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(429, 37);
            this.label13.TabIndex = 76;
            this.label13.Text = "Добавить  и распечатать билет";
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
            this.panel2.TabIndex = 74;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(320, 631);
            this.button2.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 58);
            this.button2.TabIndex = 75;
            this.button2.Text = "Чек";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.DarkRed;
            this.button3.Location = new System.Drawing.Point(320, 699);
            this.button3.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 58);
            this.button3.TabIndex = 76;
            this.button3.Text = "Отчистить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbmest_ot
            // 
            this.lbmest_ot.AutoSize = true;
            this.lbmest_ot.Location = new System.Drawing.Point(651, 114);
            this.lbmest_ot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmest_ot.Name = "lbmest_ot";
            this.lbmest_ot.Size = new System.Drawing.Size(80, 16);
            this.lbmest_ot.TabIndex = 178;
            this.lbmest_ot.Text = "место отпр";
            this.lbmest_ot.Visible = false;
            // 
            // lbcost
            // 
            this.lbcost.AutoSize = true;
            this.lbcost.Location = new System.Drawing.Point(664, 158);
            this.lbcost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcost.Name = "lbcost";
            this.lbcost.Size = new System.Drawing.Size(40, 16);
            this.lbcost.TabIndex = 176;
            this.lbcost.Text = "Цена";
            this.lbcost.Visible = false;
            // 
            // picQR
            // 
            this.picQR.ImageRotate = 0F;
            this.picQR.Location = new System.Drawing.Point(572, 212);
            this.picQR.Margin = new System.Windows.Forms.Padding(4);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(29, 23);
            this.picQR.TabIndex = 174;
            this.picQR.TabStop = false;
            this.picQR.Visible = false;
            // 
            // lbO
            // 
            this.lbO.AutoSize = true;
            this.lbO.Location = new System.Drawing.Point(584, 165);
            this.lbO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbO.Name = "lbO";
            this.lbO.Size = new System.Drawing.Size(70, 16);
            this.lbO.TabIndex = 173;
            this.lbO.Text = "Отчество";
            this.lbO.Visible = false;
            // 
            // lbI
            // 
            this.lbI.AutoSize = true;
            this.lbI.Location = new System.Drawing.Point(584, 134);
            this.lbI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbI.Name = "lbI";
            this.lbI.Size = new System.Drawing.Size(33, 16);
            this.lbI.TabIndex = 172;
            this.lbI.Text = "Имя";
            this.lbI.Visible = false;
            // 
            // lbF
            // 
            this.lbF.AutoSize = true;
            this.lbF.Location = new System.Drawing.Point(584, 103);
            this.lbF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbF.Name = "lbF";
            this.lbF.Size = new System.Drawing.Size(66, 16);
            this.lbF.TabIndex = 171;
            this.lbF.Text = "Фамилия";
            this.lbF.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(321, 416);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 184;
            this.label6.Text = "Цена";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(320, 272);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 23);
            this.label9.TabIndex = 183;
            this.label9.Text = "ID пасажира";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(320, 201);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 23);
            this.label8.TabIndex = 182;
            this.label8.Text = "ID рейса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(323, 486);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 181;
            this.label3.Text = "Статус:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(319, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 179;
            this.label1.Text = "ID билета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(321, 345);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 180;
            this.label2.Text = "Номер места";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lbMestPrib
            // 
            this.lbMestPrib.AutoSize = true;
            this.lbMestPrib.Location = new System.Drawing.Point(747, 114);
            this.lbMestPrib.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMestPrib.Name = "lbMestPrib";
            this.lbMestPrib.Size = new System.Drawing.Size(81, 16);
            this.lbMestPrib.TabIndex = 185;
            this.lbMestPrib.Text = "место приб";
            this.lbMestPrib.Visible = false;
            // 
            // lbDataOt
            // 
            this.lbDataOt.AutoSize = true;
            this.lbDataOt.Location = new System.Drawing.Point(747, 158);
            this.lbDataOt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDataOt.Name = "lbDataOt";
            this.lbDataOt.Size = new System.Drawing.Size(56, 16);
            this.lbDataOt.TabIndex = 186;
            this.lbDataOt.Text = "дата от";
            this.lbDataOt.Visible = false;
            // 
            // lbDataPrib
            // 
            this.lbDataPrib.AutoSize = true;
            this.lbDataPrib.Location = new System.Drawing.Point(892, 181);
            this.lbDataPrib.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDataPrib.Name = "lbDataPrib";
            this.lbDataPrib.Size = new System.Drawing.Size(73, 16);
            this.lbDataPrib.TabIndex = 187;
            this.lbDataPrib.Text = "дата приб";
            this.lbDataPrib.Visible = false;
            // 
            // lbNomAvt
            // 
            this.lbNomAvt.AutoSize = true;
            this.lbNomAvt.Location = new System.Drawing.Point(856, 130);
            this.lbNomAvt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomAvt.Name = "lbNomAvt";
            this.lbNomAvt.Size = new System.Drawing.Size(82, 16);
            this.lbNomAvt.TabIndex = 188;
            this.lbNomAvt.Text = "номер авто";
            this.lbNomAvt.Visible = false;
            // 
            // emBilet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1579, 814);
            this.Controls.Add(this.lbNomAvt);
            this.Controls.Add(this.lbDataPrib);
            this.Controls.Add(this.lbDataOt);
            this.Controls.Add(this.lbMestPrib);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PasahirDGV);
            this.Controls.Add(this.BusList);
            this.Controls.Add(this.bCost_tb);
            this.Controls.Add(this.bNomerPas_tb);
            this.Controls.Add(this.bReisid_tb);
            this.Controls.Add(this.bStatus_tb);
            this.Controls.Add(this.bilet_idtb);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.bilet_NumMesta_tb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbmest_ot);
            this.Controls.Add(this.lbcost);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.lbO);
            this.Controls.Add(this.lbI);
            this.Controls.Add(this.lbF);
            this.Controls.Add(this.BiletDGV);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "emBilet";
            this.Load += new System.EventHandler(this.emBilet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasahirDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BusList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BiletDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView PasahirDGV;
        private System.Windows.Forms.DataGridView BusList;
        private System.Windows.Forms.TextBox bCost_tb;
        private System.Windows.Forms.TextBox bNomerPas_tb;
        private System.Windows.Forms.TextBox bReisid_tb;
        private System.Windows.Forms.DataGridView BiletDGV;
        private System.Windows.Forms.TextBox bStatus_tb;
        private System.Windows.Forms.TextBox bilet_idtb;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.TextBox bilet_NumMesta_tb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbmest_ot;
        private System.Windows.Forms.Label lbcost;
        private Guna.UI2.WinForms.Guna2PictureBox picQR;
        private System.Windows.Forms.Label lbO;
        private System.Windows.Forms.Label lbI;
        private System.Windows.Forms.Label lbF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lbMestPrib;
        private System.Windows.Forms.Label lbDataOt;
        private System.Windows.Forms.Label lbDataPrib;
        private System.Windows.Forms.Label lbNomAvt;
    }
}