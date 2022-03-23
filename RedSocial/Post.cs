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
    public partial class Post : Form
    {
        SqlConnection conexion;
        string cadena;
        string id_persona;
        string tipo;
        string descripcion;
        string reacciones;
        string fecharegistro;
        string id_post;

        public Post()
        {
            conexion = new SqlConnection("server= DESKTOP-OBF530T\\SQLEXPRESS ; database=RedSocial ; integrated security = true");
            conexion.Open();
            //conexion = new SqlConnection("server=MINIGODDARD;database=RedSocial;integrated security = true");
            InitializeComponent();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            muestraDB();
        }

        public void muestraDB()
        {
            cadena = "SELECT po.id_post, CONCAT(p.id_persona, '-' ,p.nombre_red_social) as persona, po.tipo, po.descripcion, po.num_reacciones AS numero_reacciones, po.fecha_post FROM Post AS po " +
                "INNER JOIN Persona AS p " +
                "ON po.id_persona = p.id_persona;";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cadena, conexion);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            id_persona = cboxAutorPost.SelectedValue.ToString();
            tipo = txtTipo.SelectedItem.ToString();
            descripcion = txtDescripcionPost.Text;
            reacciones = txtReaccionesPost.Text;
            DateTime s = DateTime.Today;
            fecharegistro = s.ToString("yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);

            cadena = $"INSERT INTO Post (id_persona, tipo, descripcion, num_reacciones, fecha_post) VALUES ({id_persona},'{tipo}','{descripcion}','{reacciones}','{fecharegistro}')";
            
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();

            cboxAutorPost.SelectedIndex = 0;
            txtTipo.Text = "";
            txtDescripcionPost.Text = "";
            txtReaccionesPost.Text = "";
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            muestraDB();
        }

        private void Post_Load(object sender, EventArgs e)
        {
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT id_persona,nombre,nombre_red_social FROM Persona", conexion))
            {
                //Fill the DataTable with records from Table.
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Insert the Default Item to DataTable.
                DataRow row = dt.NewRow();
                row[0] = 0;
                dt.Rows.InsertAt(row, 0);

                //Assign DataTable as DataSource.
                cboxAutorPost.DataSource = dt;

                dt.Columns.Add(
                "name",
                typeof(string),
                "id_persona + ' - ' + nombre_red_social");

                cboxAutorPost.DisplayMember = "name";
                cboxAutorPost.ValueMember = "id_persona";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            cadena = "DELETE FROM Post WHERE id_post = " + id_post;

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();

            cboxAutorPost.SelectedIndex = 0;
            txtTipo.Text = "";
            txtDescripcionPost.Text = "";
            txtReaccionesPost.Text = "";
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            muestraDB();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                id_post = row.Cells[0].Value.ToString();

                cboxAutorPost.SelectedIndex = 0;

                cboxAutorPost.SelectedText = row.Cells[1].Value.ToString();
                string[] data = row.Cells[1].Value.ToString().Split('-');
                cboxAutorPost.SelectedValue = data[0];

                txtTipo.Text = row.Cells[2].Value.ToString();
                txtDescripcionPost.Text = row.Cells[3].Value.ToString();
                txtReaccionesPost.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var stringNumber = cboxAutorPost.Text;
            int numericValue;
            bool isNumberPersona = int.TryParse(stringNumber, out numericValue);

            cadena =
                "UPDATE Post SET id_persona=" + (isNumberPersona == true ? cboxAutorPost.Text : cboxAutorPost.SelectedValue) +
                ", tipo='" + txtTipo.Text +
                "', descripcion='" + txtDescripcionPost.Text +
                "', num_reacciones=" + txtReaccionesPost.Text + " WHERE id_post = " + id_post;

            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();

            cboxAutorPost.SelectedIndex = 0;
            txtTipo.Text = "";
            txtDescripcionPost.Text = "";
            txtReaccionesPost.Text = "";
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            muestraDB();

            muestraDB();
        }
    }
}
