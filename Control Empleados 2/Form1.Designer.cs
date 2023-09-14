namespace Control_Empleados_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnControlHorarios = new FontAwesome.Sharp.IconButton();
            this.btnReporteAsistencias = new FontAwesome.Sharp.IconButton();
            this.btnColtrolAsistencias = new FontAwesome.Sharp.IconButton();
            this.btnMensajes = new FontAwesome.Sharp.IconButton();
            this.btnAgregarEmpleados = new FontAwesome.Sharp.IconButton();
            this.PanelEscritorio = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmpPlanta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumEmp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.PanelEscritorio.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnControlHorarios);
            this.panelMenu.Controls.Add(this.btnReporteAsistencias);
            this.panelMenu.Controls.Add(this.btnColtrolAsistencias);
            this.panelMenu.Controls.Add(this.btnMensajes);
            this.panelMenu.Controls.Add(this.btnAgregarEmpleados);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(800, 95);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 55;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(676, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSalir.Size = new System.Drawing.Size(124, 95);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnControlHorarios
            // 
            this.btnControlHorarios.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnControlHorarios.FlatAppearance.BorderSize = 0;
            this.btnControlHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlHorarios.IconChar = FontAwesome.Sharp.IconChar.SchoolCircleCheck;
            this.btnControlHorarios.IconColor = System.Drawing.Color.Black;
            this.btnControlHorarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnControlHorarios.IconSize = 55;
            this.btnControlHorarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnControlHorarios.Location = new System.Drawing.Point(534, 0);
            this.btnControlHorarios.Name = "btnControlHorarios";
            this.btnControlHorarios.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnControlHorarios.Size = new System.Drawing.Size(130, 95);
            this.btnControlHorarios.TabIndex = 4;
            this.btnControlHorarios.Text = "Control De &Horarios";
            this.btnControlHorarios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnControlHorarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnControlHorarios.UseVisualStyleBackColor = true;
            this.btnControlHorarios.Click += new System.EventHandler(this.btnControlHorarios_Click);
            // 
            // btnReporteAsistencias
            // 
            this.btnReporteAsistencias.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReporteAsistencias.FlatAppearance.BorderSize = 0;
            this.btnReporteAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteAsistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteAsistencias.IconChar = FontAwesome.Sharp.IconChar.Television;
            this.btnReporteAsistencias.IconColor = System.Drawing.Color.Black;
            this.btnReporteAsistencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReporteAsistencias.IconSize = 55;
            this.btnReporteAsistencias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReporteAsistencias.Location = new System.Drawing.Point(402, 0);
            this.btnReporteAsistencias.Name = "btnReporteAsistencias";
            this.btnReporteAsistencias.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnReporteAsistencias.Size = new System.Drawing.Size(132, 95);
            this.btnReporteAsistencias.TabIndex = 3;
            this.btnReporteAsistencias.Text = "&Reporte De Asistencias";
            this.btnReporteAsistencias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReporteAsistencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReporteAsistencias.UseVisualStyleBackColor = true;
            this.btnReporteAsistencias.Click += new System.EventHandler(this.btnReporteAsistencias_Click);
            // 
            // btnColtrolAsistencias
            // 
            this.btnColtrolAsistencias.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnColtrolAsistencias.FlatAppearance.BorderSize = 0;
            this.btnColtrolAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColtrolAsistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColtrolAsistencias.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnColtrolAsistencias.IconColor = System.Drawing.Color.Black;
            this.btnColtrolAsistencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnColtrolAsistencias.IconSize = 55;
            this.btnColtrolAsistencias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnColtrolAsistencias.Location = new System.Drawing.Point(272, 0);
            this.btnColtrolAsistencias.Name = "btnColtrolAsistencias";
            this.btnColtrolAsistencias.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnColtrolAsistencias.Size = new System.Drawing.Size(130, 95);
            this.btnColtrolAsistencias.TabIndex = 2;
            this.btnColtrolAsistencias.Text = "&Control De Asistencias";
            this.btnColtrolAsistencias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnColtrolAsistencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnColtrolAsistencias.UseVisualStyleBackColor = true;
            this.btnColtrolAsistencias.Click += new System.EventHandler(this.btnColtrolAsistencias_Click);
            // 
            // btnMensajes
            // 
            this.btnMensajes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMensajes.FlatAppearance.BorderSize = 0;
            this.btnMensajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensajes.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.btnMensajes.IconColor = System.Drawing.Color.Black;
            this.btnMensajes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMensajes.IconSize = 55;
            this.btnMensajes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMensajes.Location = new System.Drawing.Point(143, 0);
            this.btnMensajes.Name = "btnMensajes";
            this.btnMensajes.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnMensajes.Size = new System.Drawing.Size(129, 95);
            this.btnMensajes.TabIndex = 1;
            this.btnMensajes.Text = "&Mensajes";
            this.btnMensajes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMensajes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMensajes.UseVisualStyleBackColor = true;
            this.btnMensajes.Click += new System.EventHandler(this.btnMensajes_Click);
            // 
            // btnAgregarEmpleados
            // 
            this.btnAgregarEmpleados.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgregarEmpleados.FlatAppearance.BorderSize = 0;
            this.btnAgregarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmpleados.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnAgregarEmpleados.IconColor = System.Drawing.Color.Black;
            this.btnAgregarEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarEmpleados.IconSize = 55;
            this.btnAgregarEmpleados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarEmpleados.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarEmpleados.Name = "btnAgregarEmpleados";
            this.btnAgregarEmpleados.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAgregarEmpleados.Size = new System.Drawing.Size(143, 95);
            this.btnAgregarEmpleados.TabIndex = 0;
            this.btnAgregarEmpleados.Text = "&Empleados";
            this.btnAgregarEmpleados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarEmpleados.UseVisualStyleBackColor = true;
            this.btnAgregarEmpleados.Click += new System.EventHandler(this.btnAgregarEmpleados_Click);
            // 
            // PanelEscritorio
            // 
            this.PanelEscritorio.BackColor = System.Drawing.Color.AliceBlue;
            this.PanelEscritorio.Controls.Add(this.panel1);
            this.PanelEscritorio.Controls.Add(this.lblHora);
            this.PanelEscritorio.Controls.Add(this.label1);
            this.PanelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelEscritorio.Location = new System.Drawing.Point(0, 95);
            this.PanelEscritorio.Name = "PanelEscritorio";
            this.PanelEscritorio.Size = new System.Drawing.Size(800, 420);
            this.PanelEscritorio.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRegistros);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblEmpPlanta);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNumEmp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(19, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 313);
            this.panel1.TabIndex = 2;
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Location = new System.Drawing.Point(222, 154);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(0, 18);
            this.lblRegistros.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Empleados registrados:";
            // 
            // lblEmpPlanta
            // 
            this.lblEmpPlanta.AutoSize = true;
            this.lblEmpPlanta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpPlanta.Location = new System.Drawing.Point(306, 78);
            this.lblEmpPlanta.Name = "lblEmpPlanta";
            this.lblEmpPlanta.Size = new System.Drawing.Size(0, 18);
            this.lblEmpPlanta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de empleados en planta:";
            // 
            // lblNumEmp
            // 
            this.lblNumEmp.AutoSize = true;
            this.lblNumEmp.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEmp.Location = new System.Drawing.Point(222, 14);
            this.lblNumEmp.Name = "lblNumEmp";
            this.lblNumEmp.Size = new System.Drawing.Size(0, 18);
            this.lblNumEmp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero de empleados:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(669, 18);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(112, 38);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.PanelEscritorio);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 554);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Personal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.PanelEscritorio.ResumeLayout(false);
            this.PanelEscritorio.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnControlHorarios;
        private FontAwesome.Sharp.IconButton btnReporteAsistencias;
        private FontAwesome.Sharp.IconButton btnColtrolAsistencias;
        private FontAwesome.Sharp.IconButton btnMensajes;
        private FontAwesome.Sharp.IconButton btnAgregarEmpleados;
        private System.Windows.Forms.Panel PanelEscritorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEmpPlanta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumEmp;
        private System.Windows.Forms.Label label2;
    }
}

