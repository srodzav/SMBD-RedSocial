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
using System.IO;

namespace RedSocial
{
    public partial class Recurso : Form
    {
        SqlConnection conexion;
        string id_recurso;
        string cadena;
        string ruta;
        string tipo;
        string tamano;

        public Recurso()
        {
            //conexion = new SqlConnection("server= DESKTOP-OBF530T\\SQLEXPRESS ; database=RedSocial ; integrated security = true");
            conexion = new SqlConnection("server=MINIGODDARD;database=RedSocial;integrated security = true");
            InitializeComponent();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            muestraDB();
        }

        public void muestraDB()
        {
            cadena = "SELECT * FROM Recurso";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cadena, conexion);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Recurso_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (ruta != "")
            {
                cadena = "INSERT INTO Recurso (ruta, tipo, tamano) " +
                "VALUES ('" + ruta + "','" + tipo + "','" + tamano + "')";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                lblTamanoRecurso.Text = "";
                lblTipoRecurso.Text = "";
                lblRecursoImagen.ForeColor = System.Drawing.Color.Red;
                lblRecursoImagen.Text = "Imagen sin cargar";
                ruta = "";
                muestraDB();
            }
            conexion.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                id_recurso = row.Cells[0].Value.ToString();
                lblRecursoImagen.Text = row.Cells[1].Value.ToString();
                lblTipoRecurso.Text = row.Cells[2].Value.ToString();
                lblTamanoRecurso.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            cadena =
                "UPDATE Recurso SET " +
                "ruta='" + lblRecursoImagen.Text + "', tipo='" +
                lblTipoRecurso.Text + "', tamano='" + lblTamanoRecurso.Text + "' WHERE id_recurso = " +
                id_recurso;

            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();

            lblTamanoRecurso.Text = "";
            lblTipoRecurso.Text = "";
            lblRecursoImagen.ForeColor = System.Drawing.Color.Red;
            lblRecursoImagen.Text = "Imagen sin cargar";
            ruta = "";
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            muestraDB();
            conexion.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            cadena =
                "DELETE FROM Recurso WHERE id_recurso = " + id_recurso;

            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();

            //txtRuta.Text = "";
            //txtTipo.Text = "";
            //txtTamano.Text = "";
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            muestraDB();
            conexion.Close();
        }

        private void btnImagenRecurso_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Recurso (JPG,PNG,.MP4)|*.JPG;*.PNG;*.MP4;";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                ruta = openFileDialog1.FileName;
                tipo = Path.GetExtension(openFileDialog1.FileName);
                lblTipoRecurso.Text = tipo;
                tamano = new FileInfo(openFileDialog1.FileName).Length.ToString();
                lblTamanoRecurso.Text = tamano;
                lblRecursoImagen.ForeColor = System.Drawing.Color.Green;
                lblRecursoImagen.Text = ruta;
            }

        }
    }
}
