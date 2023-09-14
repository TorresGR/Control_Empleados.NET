namespace Control_Empleados_2.Forms
{
    partial class FormAsistenciaCont
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Observaciones = new System.Windows.Forms.Label();
            this.rtxtObservaciones = new System.Windows.Forms.RichTextBox();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.rbtSalida = new System.Windows.Forms.RadioButton();
            this.rbtEntrada = new System.Windows.Forms.RadioButton();
            this.btnActualSalida = new System.Windows.Forms.Button();
            this.btnActualEntrada = new System.Windows.Forms.Button();
            this.dtSalida = new System.Windows.Forms.DateTimePicker();
            this.dtEntrada = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gboxListaAsist = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxTurnoLa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtFecha1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RangoBusqueda = new System.Windows.Forms.GroupBox();
            this.rbtnHorasTrabajadas = new System.Windows.Forms.RadioButton();
            this.rbtEntreFechas = new System.Windows.Forms.RadioButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gboxListaAsist.SuspendLayout();
            this.RangoBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.iconButton4);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 420);
            this.panel1.TabIndex = 1;
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 98);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(126, 46);
            this.iconButton4.TabIndex = 4;
            this.iconButton4.Text = "Asistencias pendientes";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 49);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(126, 49);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.Text = "Lista de asistencia diaria";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 3);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(126, 46);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "Asistencia manual";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 3);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.Observaciones);
            this.groupBox1.Controls.Add(this.rtxtObservaciones);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.rbtSalida);
            this.groupBox1.Controls.Add(this.rbtEntrada);
            this.groupBox1.Controls.Add(this.btnActualSalida);
            this.groupBox1.Controls.Add(this.btnActualEntrada);
            this.groupBox1.Controls.Add(this.dtSalida);
            this.groupBox1.Controls.Add(this.dtEntrada);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.picFoto);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(129, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 420);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asistencia manual";
            // 
            // Observaciones
            // 
            this.Observaciones.AutoSize = true;
            this.Observaciones.Location = new System.Drawing.Point(282, 279);
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Size = new System.Drawing.Size(78, 13);
            this.Observaciones.TabIndex = 48;
            this.Observaciones.Text = "Observaciones";
            // 
            // rtxtObservaciones
            // 
            this.rtxtObservaciones.BackColor = System.Drawing.Color.AliceBlue;
            this.rtxtObservaciones.Location = new System.Drawing.Point(285, 293);
            this.rtxtObservaciones.Name = "rtxtObservaciones";
            this.rtxtObservaciones.Size = new System.Drawing.Size(358, 121);
            this.rtxtObservaciones.TabIndex = 47;
            this.rtxtObservaciones.Text = "";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnGuardar.IconColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 30;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(507, 227);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 38);
            this.btnGuardar.TabIndex = 46;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // rbtSalida
            // 
            this.rbtSalida.AutoSize = true;
            this.rbtSalida.Location = new System.Drawing.Point(16, 368);
            this.rbtSalida.Name = "rbtSalida";
            this.rbtSalida.Size = new System.Drawing.Size(54, 17);
            this.rbtSalida.TabIndex = 45;
            this.rbtSalida.TabStop = true;
            this.rbtSalida.Text = "Salida";
            this.rbtSalida.UseVisualStyleBackColor = true;
            this.rbtSalida.CheckedChanged += new System.EventHandler(this.rbtSalida_CheckedChanged);
            // 
            // rbtEntrada
            // 
            this.rbtEntrada.AutoSize = true;
            this.rbtEntrada.Location = new System.Drawing.Point(16, 321);
            this.rbtEntrada.Name = "rbtEntrada";
            this.rbtEntrada.Size = new System.Drawing.Size(62, 17);
            this.rbtEntrada.TabIndex = 44;
            this.rbtEntrada.TabStop = true;
            this.rbtEntrada.Text = "Entrada";
            this.rbtEntrada.UseVisualStyleBackColor = true;
            this.rbtEntrada.CheckedChanged += new System.EventHandler(this.rbtEntrada_CheckedChanged);
            // 
            // btnActualSalida
            // 
            this.btnActualSalida.Location = new System.Drawing.Point(192, 368);
            this.btnActualSalida.Name = "btnActualSalida";
            this.btnActualSalida.Size = new System.Drawing.Size(48, 20);
            this.btnActualSalida.TabIndex = 43;
            this.btnActualSalida.Text = "Actual";
            this.btnActualSalida.UseVisualStyleBackColor = true;
            this.btnActualSalida.Click += new System.EventHandler(this.btnActualSalida_Click);
            // 
            // btnActualEntrada
            // 
            this.btnActualEntrada.Location = new System.Drawing.Point(192, 321);
            this.btnActualEntrada.Name = "btnActualEntrada";
            this.btnActualEntrada.Size = new System.Drawing.Size(48, 20);
            this.btnActualEntrada.TabIndex = 42;
            this.btnActualEntrada.Text = "Actual";
            this.btnActualEntrada.UseVisualStyleBackColor = true;
            this.btnActualEntrada.Click += new System.EventHandler(this.btnActualEntrada_Click);
            // 
            // dtSalida
            // 
            this.dtSalida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtSalida.Location = new System.Drawing.Point(102, 368);
            this.dtSalida.Name = "dtSalida";
            this.dtSalida.Size = new System.Drawing.Size(84, 20);
            this.dtSalida.TabIndex = 41;
            // 
            // dtEntrada
            // 
            this.dtEntrada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtEntrada.Location = new System.Drawing.Point(102, 321);
            this.dtEntrada.Name = "dtEntrada";
            this.dtEntrada.Size = new System.Drawing.Size(84, 20);
            this.dtEntrada.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(99, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = " Hora de salida";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(99, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = " Hora de entrada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "No hay un empleado seleccionado";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(468, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "  Fotografía";
            // 
            // picFoto
            // 
            this.picFoto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picFoto.BackColor = System.Drawing.Color.LightBlue;
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFoto.Location = new System.Drawing.Point(471, 49);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(172, 172);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 35;
            this.picFoto.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscar.Location = new System.Drawing.Point(75, 23);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(269, 20);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.Text = "Buscar";
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(459, 227);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // gboxListaAsist
            // 
            this.gboxListaAsist.Controls.Add(this.label8);
            this.gboxListaAsist.Controls.Add(this.cboxTurnoLa);
            this.gboxListaAsist.Controls.Add(this.label7);
            this.gboxListaAsist.Controls.Add(this.linkLabel2);
            this.gboxListaAsist.Controls.Add(this.linkLabel1);
            this.gboxListaAsist.Controls.Add(this.TxtFiltro);
            this.gboxListaAsist.Controls.Add(this.label6);
            this.gboxListaAsist.Controls.Add(this.label5);
            this.gboxListaAsist.Controls.Add(this.dtFecha2);
            this.gboxListaAsist.Controls.Add(this.dtFecha1);
            this.gboxListaAsist.Controls.Add(this.label4);
            this.gboxListaAsist.Controls.Add(this.iconButton1);
            this.gboxListaAsist.Controls.Add(this.label3);
            this.gboxListaAsist.Controls.Add(this.label2);
            this.gboxListaAsist.Controls.Add(this.RangoBusqueda);
            this.gboxListaAsist.Controls.Add(this.dataGridView2);
            this.gboxListaAsist.Location = new System.Drawing.Point(129, 0);
            this.gboxListaAsist.Name = "gboxListaAsist";
            this.gboxListaAsist.Size = new System.Drawing.Size(655, 420);
            this.gboxListaAsist.TabIndex = 49;
            this.gboxListaAsist.TabStop = false;
            this.gboxListaAsist.Text = "Lista de Asistencia Diaria";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Turno";
            // 
            // cboxTurnoLa
            // 
            this.cboxTurnoLa.FormattingEnabled = true;
            this.cboxTurnoLa.Items.AddRange(new object[] {
            "Todos",
            "Diurno",
            "Nocturno",
            "Mañana"});
            this.cboxTurnoLa.Location = new System.Drawing.Point(450, 37);
            this.cboxTurnoLa.Name = "cboxTurnoLa";
            this.cboxTurnoLa.Size = new System.Drawing.Size(80, 21);
            this.cboxTurnoLa.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Filtro";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(529, 147);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(114, 13);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "LISTAR EMPLEADOS";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(859, 401);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Location = new System.Drawing.Point(188, 80);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(247, 20);
            this.TxtFiltro.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Inicio";
            // 
            // dtFecha2
            // 
            this.dtFecha2.Location = new System.Drawing.Point(322, 37);
            this.dtFecha2.Name = "dtFecha2";
            this.dtFecha2.Size = new System.Drawing.Size(112, 20);
            this.dtFecha2.TabIndex = 7;
            // 
            // dtFecha1
            // 
            this.dtFecha1.Location = new System.Drawing.Point(188, 37);
            this.dtFecha1.Name = "dtFecha1";
            this.dtFecha1.Size = new System.Drawing.Size(112, 20);
            this.dtFecha1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "No Disponible";
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconButton1.IconColor = System.Drawing.SystemColors.HotTrack;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(545, 29);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(103, 77);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "BUSCAR";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "====>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "====>";
            // 
            // RangoBusqueda
            // 
            this.RangoBusqueda.Controls.Add(this.rbtnHorasTrabajadas);
            this.RangoBusqueda.Controls.Add(this.rbtEntreFechas);
            this.RangoBusqueda.Location = new System.Drawing.Point(9, 19);
            this.RangoBusqueda.Name = "RangoBusqueda";
            this.RangoBusqueda.Size = new System.Drawing.Size(129, 138);
            this.RangoBusqueda.TabIndex = 1;
            this.RangoBusqueda.TabStop = false;
            this.RangoBusqueda.Text = "Rango de la busqueda";
            // 
            // rbtnHorasTrabajadas
            // 
            this.rbtnHorasTrabajadas.AutoSize = true;
            this.rbtnHorasTrabajadas.Location = new System.Drawing.Point(7, 62);
            this.rbtnHorasTrabajadas.Name = "rbtnHorasTrabajadas";
            this.rbtnHorasTrabajadas.Size = new System.Drawing.Size(109, 17);
            this.rbtnHorasTrabajadas.TabIndex = 1;
            this.rbtnHorasTrabajadas.TabStop = true;
            this.rbtnHorasTrabajadas.Text = "Horas Trabajadas";
            this.rbtnHorasTrabajadas.UseVisualStyleBackColor = true;
            // 
            // rbtEntreFechas
            // 
            this.rbtEntreFechas.AutoSize = true;
            this.rbtEntreFechas.Location = new System.Drawing.Point(7, 20);
            this.rbtEntreFechas.Name = "rbtEntreFechas";
            this.rbtEntreFechas.Size = new System.Drawing.Size(88, 17);
            this.rbtEntreFechas.TabIndex = 0;
            this.rbtEntreFechas.TabStop = true;
            this.rbtEntreFechas.Text = "Entre Fechas";
            this.rbtEntreFechas.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 163);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(642, 251);
            this.dataGridView2.TabIndex = 0;
            // 
            // FormAsistenciaCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(784, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxListaAsist);
            this.Name = "FormAsistenciaCont";
            this.Text = "FormMensajeCont";
            this.Load += new System.EventHandler(this.FormAsistenciaCont_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gboxListaAsist.ResumeLayout(false);
            this.gboxListaAsist.PerformLayout();
            this.RangoBusqueda.ResumeLayout(false);
            this.RangoBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtSalida;
        private System.Windows.Forms.DateTimePicker dtEntrada;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnActualSalida;
        private System.Windows.Forms.Button btnActualEntrada;
        private System.Windows.Forms.RadioButton rbtSalida;
        private System.Windows.Forms.RadioButton rbtEntrada;
        private System.Windows.Forms.RichTextBox rtxtObservaciones;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Label Observaciones;
        private System.Windows.Forms.GroupBox gboxListaAsist;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox RangoBusqueda;
        private System.Windows.Forms.RadioButton rbtnHorasTrabajadas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFecha2;
        private System.Windows.Forms.DateTimePicker dtFecha1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RadioButton rbtEntreFechas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxTurnoLa;
    }
}