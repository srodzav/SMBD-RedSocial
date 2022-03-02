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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                id_grupo = row.Cells[0].Value.ToString();
                cboxCreadorGrupo.SelectedIndex = 0;
                cboxCreadorGrupo.SelectedText = row.Cells[1].Value.ToString();
                id_creador = row.Cells[1].Value.ToString();
                nombre = row.Cells[2].Value.ToString();
                descripcion = row.Cells[3].Value.ToString();
                imagen = row.Cells[4].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            id_creador = txtNombreGrupo.Text;
            nombre = cboxCreadorGrupo.Text;
            imagen = lblGrupoImagen.Text;
            descripcion = txtDescripcionGrupo.Text;

            cadena =
                "UPDATE Grupo SET id_creador='"+id_creador+"', nombre='"+nombre+"', descripcion='"+descripcion+"', imagen='"+imagen+"' " +
                "WHERE id_grupo = '"+id_grupo;

            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            muestraDB();
            comando.Connection.Close();
            conexion.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cadena = "DELETE FROM Grupo WHERE id_grupo = " + id_grupo;

            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();

            txtNombreGrupo.Text = "";
            cboxCreadorGrupo.SelectedIndex = 0;
            txtDescripcionGrupo.Text = "";

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            muestraDB();
            comando.Connection.Close();
            conexion.Close();
        }
    }
}
