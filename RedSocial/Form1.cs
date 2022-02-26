using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;


namespace RedSocial
{
    public partial class Form1 : Form
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

        string cadena;

        public Form1()
        {
            conexion = new SqlConnection("server=MINIGODDARD ; database=RedSocial ; integrated security = true");
            InitializeComponent();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            muestraDB();
        }

        public void muestraDB()
        {
            cadena = "SELECT * FROM Persona";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cadena, conexion);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtNombrePersona.Text != "" && txtUsernamePersona.Text != "" && cboxRolPersona.Text != "")
            {
                nombre = txtNombrePersona.Text;
                username = txtUsernamePersona.Text;
                if (cboxRolPersona.Text == "Administrador")
                { rol = 2; }else { rol = 1; }

                DateTime s = DateTime.Today;

                fecharegistro = s.ToShortDateString();
                MessageBox.Show(fecharegistro);

                if ( imagen == "") { imagen = ""; }
                cadena = "INSERT INTO Persona (nombre, nombre_red_social, imagen_perfil, rol, numero_amigos, fecha_registro) " +
                    "VALUES ('"+nombre+"','"+username+"','"+imagen+"','"+rol+"','"+numamigos+"','"+fecharegistro+"')";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();

                txtNombrePersona.Text = "";
                txtUsernamePersona.Text = "";
                cboxRolPersona.Text = "";
                lblPersonaImagen.ForeColor = System.Drawing.Color.Red;
                lblPersonaImagen.Text = "Imagen sin cargar";

                muestraDB();
                conexion.Close();
            }
        }

        private void btnImagenPersona_Click(object sender, EventArgs e)
        {
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
