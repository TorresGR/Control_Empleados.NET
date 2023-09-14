using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Empleados_2.Forms;
using FontAwesome.Sharp;
using System.Data.SqlClient;
using Microsoft.Azure.CognitiveServices.Vision.Face;
using System.Net.Configuration;
using System.Collections;

namespace Control_Empleados_2
{
    public partial class Form1 : Form
    {
       //conexion sql client
       SqlConnection Conexion=new SqlConnection ("Data Source=DESKTOP-0A8IGJP;database=DBEmpleados;integrated security=true");
        private IconButton currentbtn;
        private Panel leftBorderBtn;

        // almacena formulario hijo actual
        private Form currentChildForm;

        //abrir formulario hijo en el formulario principal
        private void OpenChilForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelEscritorio.Controls.Add(childForm);
            PanelEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //constructor panel
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 95);
            panelMenu.Controls.Add(leftBorderBtn);
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
        }

        //metodo resalta boton activo
        private void botonActivado(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
               botonDesactivado();
                //boton
                currentbtn = (IconButton)senderBtn;
                currentbtn.BackColor = Color.RoyalBlue;
                currentbtn.ForeColor = Color.Gold;
                currentbtn.IconColor = Color.Gold;
                // izquierda borde boton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(currentbtn.Location.X, 0);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void botonDesactivado()
        {
            if (currentChildForm != null)
            {
                //boton
                currentbtn.BackColor = Color.RoyalBlue;
                currentbtn.ForeColor = Color.Black;
                currentbtn.IconColor = Color.Black;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //cadenas de conexion
            string enPlanta = "SELECT COUNT(*) FROM (SELECT b.Id_Empleado " +
                "FROM Empleado b "
                +"INNER JOIN RegistroEmp a ON a.Id_Empleados = b.ID_Empleado " +
                "WHERE a.Fecha = @Fecha AND a.HoraEntrada IS NOT NULL AND a.HoraSalida IS NULL " +
                "GROUP BY b.Id_Empleado) AS Result";

            string registrados = "SELECT COUNT(*) FROM (SELECT b.Id_Empleado " +
                "FROM  Empleado b " +"INNER JOIN RegistroEmp a ON a.Id_Empleados = b.ID_Empleado " +
                "WHERE a.Fecha = @Fecha AND a.HoraEntrada IS NOT NULL AND a.HoraSalida IS NOT NULL " + 
                "GROUP BY b.Id_Empleado) AS Result";

            string NumEmp = "SELECT COUNT(*) FROM Empleado";

            int numeroEmpleados = 0;
            int EmpleadosRegistrados = 0;
            int empleadosEnPlanta = 0;

            Conexion.Open();
            //Numero de empleados  
            using (SqlCommand command = new SqlCommand(NumEmp, Conexion))
            {
                numeroEmpleados = (int)command.ExecuteScalar();
            }
            //Empleados en planta
            using (SqlCommand commandR = new SqlCommand(registrados, Conexion))
            {
                commandR.Parameters.AddWithValue("@Fecha", DateTime.Now.ToString("yyyy-MM-dd"));
                EmpleadosRegistrados = (int)commandR.ExecuteScalar();
            }
            //Empleados en planta
            using (SqlCommand command = new SqlCommand(enPlanta, Conexion))
            {
                command.Parameters.AddWithValue("@Fecha", DateTime.Now.ToString("yyyy-MM-dd"));
                empleadosEnPlanta = (int)command.ExecuteScalar();
            }
            Conexion.Close();
            //imprime los datos en los lbl
            lblEmpPlanta.Text = empleadosEnPlanta.ToString();
            lblRegistros.Text = EmpleadosRegistrados.ToString();
            lblNumEmp.Text = numeroEmpleados.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarEmpleados_Click(object sender, EventArgs e)
        { 
            botonActivado(sender, Color.Gold);
            OpenChilForm(new FormAE(Conexion));
        }

        private void btnMensajes_Click(object sender, EventArgs e)
        {
            botonActivado(sender, Color.Gold);
            OpenChilForm(new FormMensajes());
        }

        private void btnColtrolAsistencias_Click(object sender, EventArgs e)
        {
            botonActivado(sender, Color.Gold);
            OpenChilForm(new FormAsistenciaCont(Conexion));
        }

        private void btnReporteAsistencias_Click(object sender, EventArgs e)
        {
            botonActivado(sender, Color.Gold);
            OpenChilForm(new FormRepAsist());
        }

        private void btnControlHorarios_Click(object sender, EventArgs e)
        {

            botonActivado(sender, Color.Gold);
            OpenChilForm(new FormContHorarios());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
