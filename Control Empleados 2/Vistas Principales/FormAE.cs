using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Collections;
using System.Security.Cryptography.X509Certificates;
using Control_Empleados_2.clases;

namespace Control_Empleados_2.Forms
{
    public partial class FormAE : Form 

    {
        // variable publica int para verificaion de edicion
        public int ID = 0;
        //conexion
        SqlConnection conexion;
        // variable glovar query
        public string query = "";
        //imagen
        public byte[] imagenByte;

        //FUNCIONES
        public void Cargarview()
        {
            query = "SELECT ID_Empleado,Apellido,Nombre,Cuil,Cargo,Turno,Telefono FROM Empleado ORDER BY Apellido";
            SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
            DataTable dataTable = new DataTable();
            adaptador.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        public void CargaDatos()
        {
            conexion.Open();
            //validaciones
            string genero = dmnGenero.Text;
            string estCivil = dmnEstadoCivil.Text;
            string turno = dmnTurno.Text;
            string horaEntrada = dtEntrada.Value.ToString("H:mm");
            string horaSalida = dtSalida.Value.ToString("H:mm");

            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                command.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                command.Parameters.AddWithValue("@Cuil", txtCuil.Text);
                command.Parameters.AddWithValue("@Cargo", txtCargo.Text);
                command.Parameters.AddWithValue("@EstadoCivil", estCivil);
                command.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@Nacimiento", SqlDbType.Date).Value = dtNacimiento.Value.Date;
                command.Parameters.AddWithValue("@Genero", genero);
                command.Parameters.AddWithValue("@Turno", turno);
                command.Parameters.AddWithValue("@HoraEntrada", horaEntrada);
                command.Parameters.AddWithValue("@HoraSalida", horaSalida);
                command.Parameters.AddWithValue("@FechaDeIngreso", SqlDbType.Date).Value = dtFechaAltaEmpleado.Value.Date;
                command.Parameters.AddWithValue("@Telefono", txtNumero.Text);
                command.Parameters.AddWithValue("@TelefonoFamiliar", txtNumFamiliar.Text);
                //imagen
                command.Parameters.AddWithValue("@Foto", imagenByte);
                command.ExecuteNonQuery();
            }
        }

        public void ClearFormulario()
        {
            txtApellido.Text = "";
            txtCargo.Text = "";
            txtBuscar.Text = "";
            txtCuil.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtNombre.Text = "";
            txtNumero.Text = "";
            txtNumFamiliar.Text = "";
            dtSalida.Text = "";
            dtEntrada.Text = "";
            dtFechaAltaEmpleado.Text = "";
            dtNacimiento.Text = "";
           dmnGenero.Text = "";
            dmnTurno.Text = "";
            dmnEstadoCivil.Text = "";
            picFoto.Image = null;
        }
        /*----------------------*/

        //BOOLEANOS
        public bool validarFormulario()
        {
            return
                txtNombre.Text == "" ||
                txtApellido.Text == "" ||
                txtCuil.Text == "" ||
                txtCargo.Text == "" ||
                txtDireccion.Text == "";
        }
        /*----------------------*/
        public FormAE(SqlConnection Conexion)
        {
            InitializeComponent();
            conexion = Conexion;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void FormAE_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            dtEntrada.Format = DateTimePickerFormat.Custom;
            dtEntrada.CustomFormat = "HH:mm";
            dtSalida.Format = DateTimePickerFormat.Custom;
            dtSalida.CustomFormat = "HH:mm";
            dtFechaAltaEmpleado.Format = DateTimePickerFormat.Custom;
            dtFechaAltaEmpleado.CustomFormat = "dd/MM/yy";
            dtNacimiento.Format = DateTimePickerFormat.Custom;
            dtNacimiento.CustomFormat = "dd/MM/yy";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            //condicional para checkear campos vacios
            if (validarFormulario())
            {
                MessageBox.Show("Complete los datos para agregar el nuevo empleado..");
            }
            else
            {
                //variable queri local
                query = "INSERT INTO Empleado (Nombre,Apellido,Cuil,Cargo,EstadoCivil,Direccion,Email,Nacimiento,Genero,Turno,HoraEntrada,HoraSalida,FechaDeIngreso,Telefono,TelefonoFamiliar,Foto) VALUES " +
                    "(@Nombre,@Apellido,@Cuil,@Cargo,@EstadoCivil,@Direccion,@Email,@Nacimiento,@Genero,@Turno,@HoraEntrada,@HoraSalida,@FechaDeIngreso,@Telefono,@TelefonoFamiliar,@Foto)";
                //llamo funcion para subir los datos a la tabla

                try
                {
                    CargaDatos();
                    conexion.Close();
                    MessageBox.Show("Se ha añadido el empleado correctamente.");
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR: Ya existe un empleado con ese Cuil.");
                }
                finally { conexion.Close(); }
                ClearFormulario();
            }
        }

        public void lnkFoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //guarda la imagen en memoria
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                picFoto.Image = Image.FromFile(imagePath);
                picFoto.SizeMode = PictureBoxSizeMode.Zoom;
                MemoryStream memoria = new MemoryStream();
                picFoto.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Jpeg);
                imagenByte = memoria.ToArray();
            }
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            if (grupboxEmpleados.Visible == true)
            {
                grupboxEmpleados.Visible = false;
                Cargarview();
            }
            else
            {
                grupboxEmpleados.Visible = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            //condicional para checkear campos vacios
            if (validarFormulario())
            {
                MessageBox.Show("Complete los datos para modificar el empleado..");
            }
            else
            {
                try
                {
                    //variable queri local
                    query = "UPDATE Empleado SET " +
                      "Nombre=@Nombre, Apellido=@Apellido, Cuil=@Cuil, Cargo=@Cargo, EstadoCivil=@EstadoCivil, " +
                      "Direccion=@Direccion, Email=@Email, Nacimiento=@Nacimiento, Genero=@Genero, Turno=@Turno, " +
                      "HoraEntrada=@HoraEntrada, HoraSalida=@HoraSalida, FechaDeIngreso=@FechaDeIngreso, " +
                      "Telefono=@Telefono, TelefonoFamiliar=@TelefonoFamiliar, Foto=@Foto " +
                      "WHERE ID_Empleado=" + @ID;
                    //llamo funcion para subir los datos a la tabla
                    CargaDatos();
                    MessageBox.Show("Se han modificado los datos correctamente");
                }
                catch (Exception)
                {
                    MessageBox.Show("Seleccione un empleado de la lista para poder modificalo\nTen en cuenta que la referencia utilizada de actualizacion es el ID");
                }
               
                finally { conexion.Close(); }
                ClearFormulario();
            }
            conexion.Close();
            ID = 0;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            query = "SELECT ID_Empleado,Apellido,Nombre,Cuil,Cargo,Turno,Telefono FROM Empleado WHERE Apellido LIKE '%" + txtBuscar.Text + "%' OR  Nombre LIKE '%" + txtBuscar.Text + "%' OR Cuil LIKE '%" + txtBuscar.Text + "%' OR Cargo LIKE '%" + txtBuscar.Text + "%' OR Turno LIKE '%" + txtBuscar.Text + "%' ORDER BY Apellido";
            SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
            DataTable dataTable = new DataTable();
            adaptador.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = false;
            try
            {
                //Seleccionar el id del empleado
                ID = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);
                grupboxEmpleados.Visible = true;
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT * FROM Empleado WHERE ID_Empleado =" + ID, conexion);
                SqlDataReader lector;
                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    txtNombre.Text = lector["Nombre"].ToString();
                    txtApellido.Text = lector["Apellido"].ToString();
                    txtCuil.Text = lector["Cuil"].ToString();
                    txtCargo.Text = lector["Cargo"].ToString();
                    dmnEstadoCivil.Text = lector["EstadoCivil"].ToString();
                    txtDireccion.Text = lector["Direccion"].ToString();
                    txtEmail.Text = lector["email"].ToString();
                    dtNacimiento.Text = lector["Nacimiento"].ToString();
                    dmnGenero.Text = lector["Genero"].ToString();
                    dmnTurno.Text = lector["Turno"].ToString();
                    dtEntrada.Text = lector["HoraEntrada"].ToString();
                    dtSalida.Text = lector["HoraSalida"].ToString();
                    dtFechaAltaEmpleado.Text = lector["FechaDeIngreso"].ToString();
                    txtNumero.Text = lector["Telefono"].ToString();
                    txtNumFamiliar.Text = lector["TelefonoFamiliar"].ToString();
                    imagenByte = (byte[])lector["Foto"];
                }
                conexion.Close();
                //asigna la variable de tipo imagen byte al picture box
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
 
            DialogResult result = MessageBox.Show("Estas apunto de eliminar un empleado¿Desea continuar?", "Confirmación", MessageBoxButtons.OKCancel);
            if (result==DialogResult.OK)
            {
                try
                {
                    conexion.Open();
                    ID = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);
                    SqlCommand command = new SqlCommand("DELETE FROM Empleado WHERE ID_Empleado=" + ID, conexion);
                    command.ExecuteNonQuery();
                    conexion.Close();
                    Cargarview();
                }
                catch (Exception)
                {
                    return;
                }
                finally { conexion.Close(); }
            }
            else 
            {
                MessageBox.Show("El empleado NO se a eliminado");
            }

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            ClearFormulario();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
