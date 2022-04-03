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
    public partial class Comentario : Form
    {
        SqlConnection conexion;
        string cadena;
        string id_comentario;
        string id_postt;
        string id_personaa;
        string comentario;
        string fecha_comentario;

        public Comentario()
        {
            conexion = new SqlConnection("server= DESKTOP-OBF530T\\SQLEXPRESS ; database=RedSocial ; integrated security = true");
            //conexion = new SqlConnection("server=MINIGODDARD;database=RedSocial;integrated security = true");
            InitializeComponent();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            muestraDB();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (cboxPersona.Text != "" && cboxPost.Text != "" && txtComentario.Text != "")
            {
                id_postt = cboxPost.SelectedValue.ToString();
                id_personaa = cboxPersona.SelectedValue.ToString();
                comentario = txtComentario.Text;

                DateTime s = DateTime.Today;
                fecha_comentario = s.ToString("yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);

                cadena = "INSERT INTO Comentario (id_post, id_persona, comentario, fecha_comentario) " +
                    "VALUES ('" + id_postt + "','" + id_personaa + "','" + comentario + "','" + fecha_comentario + "')";

                
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();

                cboxPersona.Text = "";
                cboxPost.Text = "";
                txtComentario.Text = "";

                muestraDB();
                conexion.Close();

                cboxPost.Text = "";
                cboxPersona.Text = "";
                txtComentario.Text = "";

                muestraDB();
                conexion.Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            cadena =
                "UPDATE Comentario SET " +
                " comentario='" + txtComentario.Text + "' WHERE id_comentario = '" +
                id_comentario + "';";

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
            txtComentario.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            cadena =
                "DELETE FROM Comentario WHERE id_comentario = " + id_comentario;

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
            txtComentario.Text = "";

        }

        private void Comentario_Load(object sender, EventArgs e)
        {
            /*SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Persona", conexion);
            conexion.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            while(sqlReader.Read())
            {
                cboxPersona.Items.Add(sqlReader["nombre_red_social"].ToString());
            }
            conexion.Close();*/
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

        public void muestraDB()
        {
            cadena = "SELECT id_comentario, CONCAT(pe.id_persona, ' - ' ,pe.nombre_red_social) AS Persona, CONCAT(p.id_post, ' - ', p.descripcion) AS Post, c.comentario AS Comentario FROM Comentario as c inner join Post as p on c.id_post = p.id_post inner join Persona as pe on pe.id_persona = c.id_persona";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cadena, conexion);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void cboxPersona_SelectedValueChanged(object sender, EventArgs e)
        {
            /*cboxPost.Items.Clear();
            id_persona = cboxPersona.Text;
            cadena = $"SELECT id_persona FROM Persona WHERE nombre_red_social = '{id_persona}'";
            SqlCommand sqlCmd = new SqlCommand(cadena, conexion);
            conexion.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            while (sqlReader.Read())
            {
                id_persona = (sqlReader["id_persona"].ToString());
            }
            conexion.Close();

            cadena = $"SELECT descripcion FROM Post WHERE id_persona = '{id_persona}'";
            sqlCmd = new SqlCommand(cadena, conexion);
            conexion.Open();
            sqlReader = sqlCmd.ExecuteReader();
            while (sqlReader.Read())
            {
                cboxPost.Items.Add(sqlReader["descripcion"].ToString());
            }
            conexion.Close();*/
        }
        
        private void cboxPost_SelectedValueChanged(object sender, EventArgs e)
        { 
            /*id_post = cboxPost.Text;
            cadena = $"SELECT id_post FROM Post WHERE descripcion = '{id_post}'";
            SqlCommand sqlCmd = new SqlCommand(cadena, conexion);
            conexion.Open();
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            while (sqlReader.Read())
            {
                id_post = (sqlReader["id_post"].ToString());
            }
            conexion.Close();*/
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
                txtComentario.Text = row.Cells[3].Value.ToString();

                string[] data = row.Cells[1].Value.ToString().Split('-');
                cboxPersona.SelectedValue = data[0];

                id_comentario = row.Cells[0].Value.ToString();

                string[] data2 = row.Cells[2].Value.ToString().Split('-');
                cboxPost.SelectedValue = data2[0];
            }
        }
    }
}
