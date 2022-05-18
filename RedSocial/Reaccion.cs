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
    public partial class Reaccion : Form
    {
        SqlConnection conexion;
        string cadena;
        string id_reaccion;
        string id_persona;
        string id_persona_que_reacciona;
        string tipo;
        string id_post;
        string fecha_reaccion;

        public Reaccion()
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
            cadena = "SELECT id_reaccion, p.nombre , CONCAT(Pe.nombre,' - ',po.descripcion) as post, R.tipo FROM Reaccion R " +
                "Inner join Persona p on p.id_persona = R.id_persona Inner join Post Po on R.id_persona_que_reacciona = Po.id_post " +
                "Inner join Persona pe on pe.id_persona = Po.id_persona";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cadena, conexion);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
     
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                cboxPost.Text = row.Cells[2].Value.ToString();
                cboxPersona.Text = row.Cells[1].Value.ToString();
                cboxTipo.Text = row.Cells[3].Value.ToString();
                id_reaccion = row.Cells[0].Value.ToString();
            }
        }

        private void Reaccion_Load(object sender, EventArgs e)
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

                cboxPersona.DataSource = dt;
                dt.Columns.Add(
                "name",
                typeof(string),
                "id_persona + ' - ' + nombre");

                cboxPersona.DisplayMember = "name";
                cboxPersona.ValueMember = "id_persona";
            }
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT id_persona,nombre FROM Persona", conexion))
            {
                //Fill the DataTable with records from Table.
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Insert the Default Item to DataTable.
                DataRow row = dt.NewRow();
                row[0] = 0;
                dt.Rows.InsertAt(row, 0);
                
            }
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT po.id_post as id_post, pe.nombre as nombre, po.tipo as tipo, po.fecha_post as fecha FROM Post po INNER JOIN Persona pe ON Po.id_persona = Pe.id_persona", conexion))
            {
                //Fill the DataTable with records from Table.
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Insert the Default Item to DataTable.
                DataRow row = dt.NewRow();
                row[0] = 0;
                dt.Rows.InsertAt(row, 0);
                cboxPost.DataSource = dt;
                dt.Columns.Add(
                "name",
                typeof(string),
                "nombre + ' - ' + tipo + ' - ' + fecha");

                cboxPost.DisplayMember = "name";
                cboxPost.ValueMember = "id_post";
            }
            cboxTipo.Items.Add("1 - Me gusta");
            cboxTipo.Items.Add("2 - Me encanta");
            cboxTipo.Items.Add("3 - Me divierte");
            cboxTipo.Items.Add("4 - Me entristece");
            cboxTipo.Items.Add("5 - Me enoja");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (cboxPersona.Text != "" && cboxPost.Text != ""  && cboxTipo.Text != "")
            {
                id_post = cboxPost.SelectedValue.ToString();
                
                id_persona = cboxPersona.SelectedValue.ToString();
                //id_persona_que_reacciona = cboxAutor.SelectedValue.ToString();
                tipo = cboxTipo.Text;

                String post = cboxPost.Text;
                String[] post_slt = post.Split();
                

                DateTime s = DateTime.Today;
                fecha_reaccion = s.ToString("yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);

                cadena = "INSERT INTO Reaccion (id_persona, id_persona_que_reacciona, tipo, fecha_reaccion) " +
                    "VALUES ('" + id_persona + $"', {id_post} ,'" + tipo + "','" + fecha_reaccion + "')";

                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();

                cboxPersona.Text = "";
                cboxPost.Text = "";
                cboxTipo.Text = "";

                muestraDB();
                conexion.Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            cadena =
                "UPDATE Reaccion SET " +
                " tipo='" + cboxTipo.Text + "' WHERE id_reaccion = '" +
                id_reaccion + "';";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            muestraDB();
            comando.Connection.Close();
            conexion.Close();

            cboxPersona.Text = "";
            cboxPost.Text = "";
            cboxTipo.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            cadena =
                "DELETE FROM Reaccion WHERE id_reaccion = " + id_reaccion;

            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            muestraDB();
            comando.Connection.Close();
            conexion.Close();

            cboxPersona.Text = "";
            cboxPost.Text = "";
            cboxTipo.Text = "";
        }
    }
}
