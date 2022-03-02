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
    public partial class Grupo : Form
    {
        SqlConnection conexion;
        string id_grupo;
        string id_creador;
        string nombre;
        string descripcion;
        string imagen;
        string fechacreacion;
        string cadena;
        public Grupo()
        {
            conexion = new SqlConnection("server=MINIGODDARD;database=RedSocial;integrated security = true");
            InitializeComponent();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            muestraDB();
            Creador_Load();
        }

        public void muestraDB()
        {
            cadena = "SELECT * FROM GRUPO";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cadena, conexion);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txtNombreGrupo.Text != "" && cboxCreadorGrupo.Text != "" && txtDescripcionGrupo.Text != "")
            {
                nombre = txtNombreGrupo.Text;
                id_creador = cboxCreadorGrupo.Text;
                descripcion = txtDescripcionGrupo.Text;

                DateTime s = DateTime.Today;
                fechacreacion = s.ToString("yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);

                if (imagen == "") { imagen = ""; }
                //cadena = "INSERT INTO Grupo (id_creador, nombre, descripcion, imagen, fecha_creacion) " +
                //    "VALUES ('" + id_creador + "','" + nombre + "','" + descripcion + "','" + imagen + "','" + fechacreacion + "')";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();

                txtNombreGrupo.Text = "";
                cboxCreadorGrupo.Text = "";
                txtDescripcionGrupo.Text = "";
                lblGrupoImagen.ForeColor = System.Drawing.Color.Red;
                lblGrupoImagen.Text = "Imagen sin cargar";

                muestraDB();
                conexion.Close();
            }
        }

        private void btnImagenGrupo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                imagen = openFileDialog1.SafeFileName;
                lblGrupoImagen.ForeColor = System.Drawing.Color.Green;
                lblGrupoImagen.Text = imagen;
            }
        }

        private void Creador_Load()
        {
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT id_persona,nombre FROM Persona", conexion))
            {
                //Fill the DataTable with records from Table.
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Insert the Default Item to DataTable.
                DataRow row = dt.NewRow();
                row[0] = 0;
                dt.Rows.InsertAt(row, 0);

                //Assign DataTable as DataSource.
                cboxCreadorGrupo.DataSource = dt;
                cboxCreadorGrupo.DisplayMember = "nombre";
                cboxCreadorGrupo.ValueMember = "id_persona";
            }
        }
    }
}
