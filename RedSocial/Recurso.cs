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
            conexion = new SqlConnection("server= DESKTOP-OBF530T\\SQLEXPRESS ; database=RedSocial ; integrated security = true");
            //conexion = new SqlConnection("server=MINIGODDARD;database=RedSocial;integrated security = true");
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
            if ( txtRuta.Text != "" &&  txtTipo.Text != "" && txtTamano.Text != "")
            {
                ruta = txtRuta.Text;
                tipo = txtTipo.Text;
                tamano = txtTamano.Text;
                
                cadena = "INSERT INTO Recurso (ruta, tipo, tamano) " +
                    "VALUES ('" + ruta + "','" + tipo + "','" + tamano + "')";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();

                txtRuta.Text = "";
                txtTipo.Text = "";
                txtTamano.Text = "";

                muestraDB();
                conexion.Close();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                id_recurso = row.Cells[0].Value.ToString();
                txtRuta.Text = row.Cells[1].Value.ToString();
                txtTipo.Text = row.Cells[2].Value.ToString();
                txtTamano.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            cadena =
                "UPDATE Recurso SET " +
                "ruta='" + txtRuta.Text + "', tipo='" +
                txtTipo.Text + "', tamano='" + txtTamano.Text + "' WHERE id_recurso = " +
                id_recurso;

            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();

            txtRuta.Text = "";
            txtTipo.Text = "";
            txtTamano.Text = "";
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

            txtRuta.Text = "";
            txtTipo.Text = "";
            txtTamano.Text = "";
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            muestraDB();
            conexion.Close();
        }
    }
}
