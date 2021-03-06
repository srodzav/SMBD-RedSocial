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
        string id_persona;

        public Grupo()
        {// Conexiones necesarias para la base de datos
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

        public void muestraDB()
        {
            // Query para seleccionar el nombre del grupo, y realiza un inner join para el creador del grupo
            cadena = "SELECT A.id_grupo, CONCAT(P.id_persona, '-' ,P.nombre_red_social) as amigo,A.nombre, A.imagen, A.descripcion, A.fecha_creacion " +
                "FROM Grupo A " +
                "INNER JOIN Persona AS P " +
                "ON A.id_creador = P.id_persona;";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cadena, conexion);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Se abre la conexión
            conexion.Open();
            if (txtNombreGrupo.Text != "" && cboxCreadorGrupo.Text != "" && txtDescripcionGrupo.Text != "")
            {
                // Se guardan las variables de los formularios
                nombre = txtNombreGrupo.Text;
                id_creador = cboxCreadorGrupo.SelectedValue.ToString();
                descripcion = txtDescripcionGrupo.Text;
                // Guardamos la fecha de creacion del grupo
                DateTime s = DateTime.Today;
                fechacreacion = s.ToString("yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);     
                if (imagen == "") { imagen = ""; }
                // Creacion del query para instertar en la base de datos
                cadena = "INSERT INTO Grupo (id_creador, nombre, descripcion, imagen, fecha_creacion) " +
                    "VALUES ('" + id_creador + "','" + nombre + "','" + descripcion + "','" + imagen + "','" + fechacreacion + "')";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                // Limpieza de formularios
                txtNombreGrupo.Text = "";
                cboxCreadorGrupo.Text = "";
                txtDescripcionGrupo.Text = "";
                lblGrupoImagen.ForeColor = System.Drawing.Color.Red;
                lblGrupoImagen.Text = "Imagen sin cargar";
                // Actualiza la base de datos y cierra la conexion
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
       
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                id_grupo = row.Cells[0].Value.ToString();

                cboxCreadorGrupo.SelectedIndex = 0;
                //cboxCreadorGrupo.SelectedText = row.Cells[1].Value.ToString();

                cboxCreadorGrupo.SelectedText = row.Cells[1].Value.ToString();
                string[] data = row.Cells[1].Value.ToString().Split('-');
                cboxCreadorGrupo.SelectedValue = data[0];

                txtNombreGrupo.Text = row.Cells[2].Value.ToString();
                txtDescripcionGrupo.Text = row.Cells[3].Value.ToString();
                lblGrupoImagen.ForeColor = System.Drawing.Color.Green;
                lblGrupoImagen.Text = row.Cells[4].Value.ToString();
               
                id_creador = row.Cells[1].Value.ToString();
                nombre = row.Cells[2].Value.ToString();
                descripcion = row.Cells[3].Value.ToString();
                imagen = row.Cells[4].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Se crea la conexion y se guardan las variables de los formularios
            conexion.Open();
            id_creador = cboxCreadorGrupo.SelectedValue.ToString();
            nombre = txtNombreGrupo.Text;
            imagen = lblGrupoImagen.Text;
            descripcion = txtDescripcionGrupo.Text;
            // Se crea el query de inserción
            cadena =
                "UPDATE Grupo SET id_creador="+id_creador+", nombre='"+nombre+"', descripcion='"+descripcion+"', imagen='"+imagen+"' " +
                "WHERE id_grupo = "+id_grupo;
            // Se ejecuta
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            // Se limpian los formularios y se desactivan los botones
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            txtNombreGrupo.Text = "";
            cboxCreadorGrupo.Text = "";
            txtDescripcionGrupo.Text = "";
            lblGrupoImagen.ForeColor = System.Drawing.Color.Red;
            lblGrupoImagen.Text = "Imagen sin cargar";
            // Se actualiza la base de datos y se cierra la conexion
            muestraDB();
            comando.Connection.Close();
            conexion.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            cadena = "DELETE FROM Grupo WHERE id_grupo = " + id_grupo;

            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();

            txtNombreGrupo.Text = "";
            cboxCreadorGrupo.SelectedIndex = 0;
            txtDescripcionGrupo.Text = "";

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            txtNombreGrupo.Text = "";
            cboxCreadorGrupo.Text = "";
            txtDescripcionGrupo.Text = "";
            lblGrupoImagen.ForeColor = System.Drawing.Color.Red;
            lblGrupoImagen.Text = "Imagen sin cargar";

            muestraDB();
            comando.Connection.Close();
            conexion.Close();
        }

        private void Grupo_Load(object sender, EventArgs e)
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

                cboxCreadorGrupo.DataSource = dt;
                dt.Columns.Add(
                "name",
                typeof(string),
                "id_persona + ' - ' + nombre");

                cboxCreadorGrupo.DisplayMember = "name";
                cboxCreadorGrupo.ValueMember = "id_persona";
            }
        }
    }
}
