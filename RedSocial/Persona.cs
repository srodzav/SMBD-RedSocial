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

namespace RedSocial
{
    public partial class Persona : Form
    {
        SqlConnection conexion;
        string nombre_t;
        string username_t;
        string imagen_t;
        int rol_t;

        string nombre;
        string username;
        string imagen;
        int rol;
        int numamigos = 0;
        string fecharegistro;
        string id_persona;

        string cadena;

        public Persona()
        { // Conexiones necesarias para la base de datos
            // PC-1
            conexion = new SqlConnection("server= DESKTOP-OBF530T\\SQLEXPRESS ; database=RedSocial ; integrated security = true");
            // PC-2
            //conexion = new SqlConnection("server=MINIGODDARD;database=RedSocial;integrated security = true");
            InitializeComponent();
            // Desactivar botones de modificar y eliminar.
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            // Mostrar la base de datos
            muestraDB();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Se abre la conexión
            conexion.Open();
            // Se verifica que los formularios contengan texto
            if (txtNombrePersona.Text != "" && txtUsernamePersona.Text != "" && cboxRolPersona.Text != "")
            {
                // Se guardan los datos en variables para insertar
                nombre = txtNombrePersona.Text;
                username = txtUsernamePersona.Text;
                if (cboxRolPersona.Text == "Administrador")
                { rol = 2; }
                else { rol = 1; }
                // Se guarda la fecha actual
                DateTime s = DateTime.Today;
                fecharegistro = s.ToString("yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                // Si no se selecciona una imagen asigna null a la imagen.
                if (imagen == "") { imagen = ""; }
                // Cadena para insertar los datos en la base de datos y posteriormente se ejecuta
                cadena = "INSERT INTO Persona (nombre, nombre_red_social, imagen_perfil, rol, numero_amigos, fecha_registro) " +
                    "VALUES ('" + nombre + "','" + username + "','" + imagen + "','" + rol + "','" + numamigos + "','" + fecharegistro + "')";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                // Se limpian los formularios
                txtNombrePersona.Text = "";
                txtUsernamePersona.Text = "";
                cboxRolPersona.Text = "";
                lblPersonaImagen.ForeColor = System.Drawing.Color.Red;
                lblPersonaImagen.Text = "Imagen sin cargar";
                // Se actualiza la base de datos y se cierra la conexion
                muestraDB();
                conexion.Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Se abre la conexión
            conexion.Open();
            // Se guardan los datos en variables
            reemplazaDB();
            // Se crea el query
            cadena =
                "UPDATE Persona SET " +
                "nombre='" + nombre + "', nombre_red_social='" +
                username + "', imagen_perfil='" + imagen + "', numero_amigos=" + numamigos + " WHERE id_persona = " +
                id_persona;
            // Se ejecuta el comando
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1) // Si se realiza la modificacion se limpian los registros
            {
                txtNombrePersona.Text = "";
                txtUsernamePersona.Text = "";
                cboxRolPersona.Text = "";
                lblPersonaImagen.ForeColor = System.Drawing.Color.Red;
                lblPersonaImagen.Text = "Imagen sin cargar";
                txtErrores.Text = "";
            }
            else // En caso contrario se muestra un error
            {
                txtErrores.Text = "No se afectó ninguna fila";
            }
            // Se desactivan los botones de modificar y eliminar
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            // Se acutaliza la base de datos y se cierra la conexion
            muestraDB();
            comando.Connection.Close();
            conexion.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Se abre la conexion 
            conexion.Open();
            // Se buscan los datos
            reemplazaDB();
            // Se crea el query
            cadena =
                "DELETE FROM Persona WHERE id_persona = " + id_persona;
            // Se ejecuta el comando
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1) // Si el comando fue exitoso se limpian los registros
            {
                txtNombrePersona.Text = "";
                txtUsernamePersona.Text = "";
                cboxRolPersona.Text = "";
                lblPersonaImagen.ForeColor = System.Drawing.Color.Red;
                lblPersonaImagen.Text = "Imagen sin cargar";
                txtErrores.Text = "";
            }
            else // En caso contrario se muestra un error
            {
                txtErrores.Text = "No se afectó ninguna fila";
            }
            // Se desactivan los botones de modificar y eliminar
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            // Se actaliza la base de datos y se cierra la conexion
            muestraDB();
            comando.Connection.Close();
            conexion.Close();
        }

        private void reemplazaDB()
        {
            nombre = txtNombrePersona.Text;
            username = txtUsernamePersona.Text;
            imagen = lblPersonaImagen.Text;
            if (cboxRolPersona.Text == "Administrador")
            { rol = 2; }
            else { rol = 1; }
        }

        private void buscaDB()
        {
            nombre_t = txtNombrePersona.Text;
            username_t = txtUsernamePersona.Text;
            imagen_t = lblPersonaImagen.Text;
            if (cboxRolPersona.Text == "Administrador")
            { rol_t = 2; }
            else { rol_t = 1; }
        }

        public void muestraDB()
        {
            // Query para mostrar toda la tabla de persona
            cadena = "SELECT * FROM Persona";
            // Comando a ejecutar con la conexión deseada
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cadena, conexion);
            DataTable dt = new DataTable();
            // Se llena el dataGridView con los datos del comando a ejecutar
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        { // Evento de seleccion de finla
            if (e.RowIndex >= 0)
            {
                // Se habilitan los botones
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                lblPersonaImagen.ForeColor = System.Drawing.Color.Green;
                // Se guardan los datos en variables
                id_persona = row.Cells[0].Value.ToString();
                txtNombrePersona.Text = row.Cells[1].Value.ToString();
                txtUsernamePersona.Text = row.Cells[2].Value.ToString();
                lblPersonaImagen.Text = row.Cells[3].Value.ToString();
                if (row.Cells[4].Value.ToString() == "1")
                {
                    cboxRolPersona.Text = "Administrador";
                }
                else { cboxRolPersona.Text = "Usuario"; }
                numamigos = Int32.Parse(row.Cells[5].Value.ToString());
                fecharegistro = row.Cells[6].Value.ToString();
                txtErrores.Text = "";
                
                if (txtNombrePersona.Text != "" && txtUsernamePersona.Text != "" && lblPersonaImagen.Text != "" && cboxRolPersona.Text != "")
                {
                    buscaDB();
                }
                else
                {
                    txtErrores.Text = "No contiene datos el renglon seleccionado";
                }
            }
        }

        private void btnImagenPersona_Click_1(object sender, EventArgs e)
        {
            // Funcion que permite seleccionar una imagen 
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                imagen = openFileDialog1.SafeFileName;
                lblPersonaImagen.ForeColor = System.Drawing.Color.Green;
                lblPersonaImagen.Text = imagen;
            }
        }
    }
}
