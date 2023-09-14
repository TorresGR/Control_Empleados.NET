using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Shapes;


namespace Control_Empleados_2.Forms
{
    public partial class FormAsistenciaCont : Form
    {
        public string fecha = DateTime.Now.ToString("yyyy-MM-dd");
        int ID;
        Boolean a;

        public byte[] imagenByte;

        SqlConnection conexion;

        string query;

        public FormAsistenciaCont(SqlConnection Conexion)
        {
            InitializeComponent();
            conexion = Conexion;
        }
        //Funciones
        public void Cargarview()
        {

            string query = "SELECT b.Id_Empleado, CONCAT(b.nombre, ' ', b.apellido) AS 'nombre y apellido', a.Fecha, a.HoraEntrada, a.HoraSalida, a.Estado, a.Observaciones " +
                "FROM  Empleado b " +
                "LEFT JOIN RegistroEmp a ON a.Id_Empleados = b.ID_Empleado " +
                "WHERE a.Fecha = @Fecha OR a.Fecha IS NULL " +
                "UNION SELECT b.Id_Empleado, CONCAT(b.nombre, ' ', b.apellido) AS 'nombre y apellido', NULL AS Fecha, NULL AS HoraEntrada, NULL AS HoraSalida, NULL AS Estado, NULL AS Observaciones " +
                "FROM Empleado b WHERE b.ID_Empleado NOT IN (SELECT Id_Empleados FROM RegistroEmp WHERE Fecha = @Fecha) ";

            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                command.Parameters.AddWithValue("@Fecha", fecha);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }
        //Lista de asistencia diaria
        public void ListarEmpleados()
        {
            if (cboxTurnoLa.Text=="Todos")
            {
                cboxTurnoLa.Text = "";
            }
            try
            {
                query = "SELECT ID_Empleado,concat(Nombre,' ',Apellido) AS 'Nombre y Apellido', Cargo, Turno, Cuil " +
                    "FROM Empleado " +
                    "WHERE (concat(Nombre, ' ', Apellido) LIKE '%" + TxtFiltro.Text + "%' OR ID_Empleado LIKE '%" + TxtFiltro.Text + "%') AND Turno LIKE '%"+cboxTurnoLa.Text+"%'";
                
                if (rbtEntreFechas.Checked == true)
                {
                    query = "SELECT ID_Empleado,concat(Nombre,' ',Apellido) AS 'Nombre y Apellido', Fecha, HoraEntrada, HoraSalida, Estado, Observaciones FROM VistaAsistencia WHERE Fecha BETWEEN @Fecha1 AND @Fecha2 " +
                        " AND Turno LIKE '%"+cboxTurnoLa.Text+"%' AND(concat(Nombre, ' ', Apellido) LIKE '%" + TxtFiltro.Text + "%' OR ID_Empleado LIKE '%" + TxtFiltro.Text + "%')";

                }
                if (rbtnHorasTrabajadas.Checked == true)
                {
                    query = "SELECT ID_Empleado,concat(Nombre,' ',Apellido) AS 'Nombre y Apellido', SUM(DATEDIFF(HOUR, HoraEntrada, HoraSalida)) " +
                        "FROM VistaAsistencia WHERE Fecha BETWEEN @Fecha1 AND @Fecha2 AND Turno LIKE '%"+cboxTurnoLa.Text+"%' AND( concat(Nombre, ' ', Apellido) LIKE '%" + TxtFiltro.Text + "%' OR ID_Empleado LIKE '%" + TxtFiltro.Text + "%' )" +
                        " GROUP BY ID_Empleado, Nombre, Apellido;";
                }
                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Fecha1", SqlDbType.Date).Value = dtFecha1.Value.Date;
                    command.Parameters.AddWithValue("@Fecha2", SqlDbType.Date).Value = dtFecha2.Value.Date;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView2.DataSource = dataTable;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error inesperado");
            }
        }
        //************************//

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void FormAsistenciaCont_Load(object sender, EventArgs e)
        {
            Cargarview();
            dtEntrada.Format = DateTimePickerFormat.Custom;
            dtEntrada.CustomFormat = "HH:mm";
            dtSalida.Format = DateTimePickerFormat.Custom;
            dtSalida.CustomFormat = "HH:mm";
            dtEntrada.Value = DateTimePicker.MinimumDateTime;
            dtSalida.Value = DateTimePicker.MinimumDateTime;
            dtEntrada.Enabled = false;
            dtSalida.Enabled = false;
            btnActualEntrada.Enabled = false;
            btnActualSalida.Enabled = false;
            rbtSalida.Enabled = false;
            rbtEntrada.Enabled = false;
            btnGuardar.Enabled = false;
            rtxtObservaciones.Enabled = false;
            gboxListaAsist.Visible= false;
            dtFecha1.Format= DateTimePickerFormat.Custom;
            dtFecha2.Format= DateTimePickerFormat.Custom;
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            /*query = "SELECT * FROM VistaAsistencia WHERE CONCAT(id_empleado, CONCAT(Nombre, apellido) AS 'Nombre y Apellido', Fecha, HoraEntrada, HoraSalida, Estado) LIKE '%" + txtBuscar.Text + "%'";
           
            
            SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
            DataTable dataTable = new DataTable();
            adaptador.Fill(dataTable);
            dataGridView1.DataSource = dataTable;*/

            string query = "SELECT b.Id_Empleado, CONCAT(b.nombre, ' ', b.apellido) AS 'nombre y apellido', a.Fecha, a.HoraEntrada, a.HoraSalida, a.Estado, a.Observaciones " +
              "FROM  Empleado b " +
              "LEFT JOIN RegistroEmp a ON a.Id_Empleados = b.ID_Empleado " +
              "WHERE (a.Fecha = @Fecha OR a.Fecha IS NULL) AND CONCAT(b.Id_Empleado, ' ', b.nombre, ' ', b.apellido) LIKE '%" + txtBuscar.Text + "%' "+
              "UNION " +
              "SELECT b.Id_Empleado, CONCAT(b.nombre, ' ', b.apellido) AS 'nombre y apellido', NULL AS Fecha, NULL AS HoraEntrada, NULL AS HoraSalida, NULL AS Estado, NULL AS Observaciones " +
              "FROM Empleado b WHERE (b.ID_Empleado NOT IN (SELECT Id_Empleados FROM RegistroEmp WHERE Fecha = @Fecha)) AND CONCAT(b.Id_Empleado, ' ', b.nombre, ' ', b.apellido) LIKE '%" + txtBuscar.Text +"%'";

            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                command.Parameters.AddWithValue("@Fecha", fecha);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rbtEntrada.Checked = false;
            rbtSalida.Checked=false;
            if (e.RowIndex >= 0)
            {
                a = true;
                rbtEntrada.Enabled = a;
                rbtSalida.Enabled = a;
            }
            else
            {
                a = false;
                rbtEntrada.Enabled = a;
                rbtSalida.Enabled = a;
            }

            try
            {
                ID = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM EMPLEADO WHERE ID_Empleado =" + ID, conexion);
                SqlDataReader lector;
                lector = comando.ExecuteReader();
                if (lector.Read() & a == true)
                {
                    label1.Text = lector["Nombre"].ToString();
                    label1.Text +=" "+ lector["Apellido"].ToString();
                    imagenByte = (byte[])lector["Foto"];
                    /*rtxtObservaciones.Text = lector["Observaciones"].ToString();*/

                    btnGuardar.Enabled = false;
                }
                else
                {
                    label1.Text = "no hay un empleado seleccionado";

                    btnGuardar.Enabled = false;
                }

                conexion.Close();
                using (MemoryStream ms = new MemoryStream(imagenByte))
                {
                    Image imagen = Image.FromStream(ms);
                    picFoto.Image = imagen;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void rbtEntrada_CheckedChanged(object sender, EventArgs e)
        {
                dtSalida.Value = DateTimePicker.MinimumDateTime;

                rtxtObservaciones.Enabled = true;
                dtEntrada.Enabled = true;
                btnActualEntrada.Enabled = true;
                dtSalida.Enabled = false;
                btnActualSalida.Enabled = false;
                dtEntrada.Focus();
                btnGuardar.Enabled = true;
        }

        private void btnActualEntrada_Click(object sender, EventArgs e)
        {
            dtEntrada.Value = DateTime.Now;
        }

        private void btnActualSalida_Click(object sender, EventArgs e)
        {
            dtSalida.Value = DateTime.Now;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                ID = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);
                string Fechav = Convert.ToString(this.dataGridView1.SelectedRows[0].Cells[2].Value);

                string horaEntrada = dtEntrada.Value.ToString("H:mm");
                string horaSalida = dtSalida.Value.ToString("H:mm");
            conexion.Close();
            conexion.Open();

                if (rbtEntrada.Checked & (Fechav == null || Fechav == ""))
                {
                    query = "INSERT INTO RegistroEmp (ID_Empleados, Fecha,horaEntrada,Observaciones) VALUES (@ID_Empleados,@Fecha,@horaEntrada,@Observaciones)";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.Parameters.AddWithValue("@ID_Empleados", ID);
                        command.Parameters.Add("@Fecha", fecha);
                        command.Parameters.AddWithValue("@horaEntrada", horaEntrada);
                        command.Parameters.AddWithValue("@Observaciones",rtxtObservaciones.Text);

                        command.ExecuteNonQuery();
                        Cargarview();
                    }
                }
                if(rbtEntrada.Checked & Fechav != null & Fechav!="")
                {
                    DialogResult result = MessageBox.Show("Estas apunto de cambiar el horario de entrada ¿Deseas continuar?", "Confirmación", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            query = "UPDATE RegistroEmp SET  Horaentrada= @Horaentrada, Observaciones=@Observaciones WHERE Fecha=@Fecha AND ID_Empleados=@ID_Empleados";
                             using (SqlCommand command = new SqlCommand(query, conexion))
                             {
                                command.Parameters.AddWithValue("@Horaentrada", horaEntrada);
                                command.Parameters.AddWithValue("@Observaciones", rtxtObservaciones.Text);
                                command.Parameters.AddWithValue("@Fecha", fecha);
                                command.Parameters.AddWithValue("@ID_Empleados", ID);
                                command.ExecuteNonQuery();
                                Cargarview();
                             }

                        }
                        catch (Exception)
                        {
                            return;
                        }
                        finally { conexion.Close(); }
                    }
                    else
                    {
                    MessageBox.Show("El registro no se ha modificado");
                    }
                }
                if (rbtSalida.Checked)
                {  
                    query = "UPDATE RegistroEmp SET  HoraSalida= @HoraSalida WHERE Fecha=@Fecha AND ID_Empleados=@ID_Empleados";
                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {   
                        command.Parameters.AddWithValue("@HoraSalida", horaSalida);
                        command.Parameters.AddWithValue("@Fecha", fecha);
                        command.Parameters.AddWithValue("@ID_Empleados", ID);
                        command.ExecuteNonQuery();
                        Cargarview();
                    }
                }
                conexion.Close();
            }
            catch
            { MessageBox.Show("Seleccione toda la fila que desee modificar"); }
            finally { }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            gboxListaAsist.Visible = true;
            ListarEmpleados();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            gboxListaAsist.Visible = false;
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
           ListarEmpleados();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cboxTurnoLa.Text == "Todos")
            {
                cboxTurnoLa.Text = "";
            }
            query = "SELECT ID_Empleado,concat(Nombre,' ',Apellido) AS 'Nombre y Apellido', Cargo, Turno, Cuil " +
                      "FROM Empleado " +
                      "WHERE (concat(Nombre, ' ', Apellido) LIKE '%" + TxtFiltro.Text + "%' OR ID_Empleado LIKE '%" + TxtFiltro.Text + "%') AND Turno LIKE '%" + cboxTurnoLa.Text + "%'";

            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                command.Parameters.AddWithValue("@Fecha1", SqlDbType.Date).Value = dtFecha1.Value.Date;
                command.Parameters.AddWithValue("@Fecha2", SqlDbType.Date).Value = dtFecha2.Value.Date;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView2.DataSource = dataTable;
                }
            }
        }

        private void rbtSalida_CheckedChanged(object sender, EventArgs e)
        {
            dtEntrada.Value = DateTimePicker.MinimumDateTime;

            dtEntrada.Enabled = false;
            btnActualEntrada.Enabled = false;
            dtSalida.Enabled = true;
            btnActualSalida.Enabled = true;
            dtEntrada.Focus();
            rtxtObservaciones.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            Cargarview();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
