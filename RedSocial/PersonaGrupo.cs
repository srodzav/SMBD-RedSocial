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
    public partial class PersonaGrupo : Form
    {
        SqlConnection conexion;
        string cadena;
        string id_persona, id_persona_T;
        string id_grupo, id_grupo_T;
        public PersonaGrupo()
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
            //cadena = "SELECT A.id_grupo, CONCAT(P.id_persona, '-' ,P.nombre_red_social) as amigo,A.nombre, A.imagen, A.descripcion, A.fecha_creacion " +
            //    "FROM Grupo A " +
            //    "INNER JOIN Persona AS P " +
            //    "ON A.id_creador = P.id_persona;";
            cadena = "SELECT * FROM PersonaGrupo";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cadena, conexion);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (cboxNombreGrupoPG.Text != "" && cboxCreadorGrupoPG.Text != "")
            {
                id_persona = cboxCreadorGrupoPG.SelectedValue.ToString();
                id_grupo = cboxNombreGrupoPG.SelectedValue.ToString();

                cadena = "INSERT INTO PersonaGrupo (id_persona, id_grupo) " +
                    "VALUES ('" + id_persona + "','" + id_grupo + "')";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();

                cboxNombreGrupoPG.Text = "";
                cboxCreadorGrupoPG.Text = "";

                muestraDB();
                conexion.Close();
            }
        }

        private void PersonaGrupo_Load(object sender, EventArgs e)
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

                cboxCreadorGrupoPG.DataSource = dt;
                dt.Columns.Add(
                "name",
                typeof(string),
                "id_persona + ' - ' + nombre");

                cboxCreadorGrupoPG.DisplayMember = "name";
                cboxCreadorGrupoPG.ValueMember = "id_persona";
            }
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT id_grupo,nombre FROM Grupo", conexion))
            {
                //Fill the DataTable with records from Table.
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Insert the Default Item to DataTable.
                DataRow row = dt.NewRow();
                row[0] = 0;
                dt.Rows.InsertAt(row, 0);

                cboxNombreGrupoPG.DataSource = dt;
                dt.Columns.Add(
                "name",
                typeof(string),
                "id_grupo + ' - ' + nombre");

                cboxNombreGrupoPG.DisplayMember = "name";
                cboxNombreGrupoPG.ValueMember = "id_grupo";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            cadena = "DELETE FROM PersonaGrupo WHERE id_persona = " + id_persona_T + " AND id_grupo = " + id_grupo_T;

            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();


            cboxNombreGrupoPG.SelectedIndex = 0;
            cboxCreadorGrupoPG.SelectedIndex = 0;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            muestraDB();
            conexion.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            id_persona = cboxCreadorGrupoPG.SelectedValue.ToString();
            id_grupo = cboxNombreGrupoPG.SelectedValue.ToString();

            cadena =
                "UPDATE PersonaGrupo SET id_persona=" + id_persona + ", id_grupo=" + id_grupo + 
                " WHERE id_persona = " + id_persona_T + " AND id_grupo = " + id_grupo_T;
            MessageBox.Show(cadena);
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            cboxNombreGrupoPG.Text = "";
            cboxCreadorGrupoPG.Text = "";

            muestraDB();
            comando.Connection.Close();
            conexion.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                
                cboxNombreGrupoPG.SelectedText = row.Cells[1].Value.ToString();
                cboxCreadorGrupoPG.SelectedText = row.Cells[0].Value.ToString();

                id_persona_T = row.Cells[0].Value.ToString();
                id_grupo_T = row.Cells[1].Value.ToString();
            }
        }
    }
}
