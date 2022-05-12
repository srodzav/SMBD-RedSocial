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
    public partial class Compartir : Form
    {
        SqlConnection conexion;
        string cadena;
        string id_compartido;
        string id_postt;
        string id_personaa;
        string fecha_compartido;

        public Compartir()
        {
            conexion = new SqlConnection("server= DESKTOP-OBF530T\\SQLEXPRESS ; database=RedSocial ; integrated security = true");
            //conexion = new SqlConnection("server=MINIGODDARD;database=RedSocial;integrated security = true");
            InitializeComponent();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            muestraDB();
        }

        private void muestraDB()
        {
            cadena = "SELECT id_compartir, CONCAT(pe.id_persona, ' - ' ,pe.nombre_red_social) AS Persona, CONCAT(p.id_post, ' - ', p.descripcion) AS Post, fecha_compartido FROM Compartir as c inner join Post as p on c.id_post = p.id_post inner join Persona as pe on pe.id_persona = c.id_persona";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cadena, conexion);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (cboxPersona.Text != "" && cboxPost.Text != "")
            {
                id_postt = cboxPost.SelectedValue.ToString();
                id_personaa = cboxPersona.SelectedValue.ToString();

                DateTime s = DateTime.Today;
                fecha_compartido = s.ToString("yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);

                cadena = "INSERT INTO Compartir (id_post, id_persona) " +
                    "VALUES ('" + id_postt + "','" + id_personaa + "')";


                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();

                cboxPersona.Text = "";
                cboxPost.Text = "";

                muestraDB();
                conexion.Close();

                cboxPost.Text = "";
                cboxPersona.Text = "";

                muestraDB();
                conexion.Close();
            }
        }

        private void Compartir_Load(object sender, EventArgs e)
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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            cadena =
                "DELETE FROM Compartir WHERE id_compartir = " + id_compartido;

            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            muestraDB();
            comando.Connection.Close();
            conexion.Close();

            cboxPost.Text = "";
            cboxPersona.Text = "";
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                cboxPost.Text = row.Cells[1].Value.ToString();
                cboxPersona.Text = row.Cells[2].Value.ToString();


                id_compartido = row.Cells[0].Value.ToString();

                string[] data = row.Cells[1].Value.ToString().Split('-');
                cboxPersona.SelectedValue = data[0];

                string[] data2 = row.Cells[2].Value.ToString().Split('-');
                cboxPost.SelectedValue = data2[0];
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            cadena =
                "UPDATE Compartir SET " +
                " id_post='" + cboxPost.SelectedValue + "', id_persona='" + cboxPersona.SelectedValue + "' " +
                " WHERE id_compartir = " +
                id_compartido + ";";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            muestraDB();
            comando.Connection.Close();
            conexion.Close();

            cboxPost.Text = "";
            cboxPersona.Text = "";
        }
    }
}
