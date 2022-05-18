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
        { // Conexiones necesarias para la base de datos
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
            // Creacion del query
            cadena = "SELECT CONCAT(P.id_persona, '-' ,P.nombre_red_social) as Persona,CONCAT(G.id_grupo, '-' ,G.nombre) as Grupo " +
                "FROM PersonaGrupo A INNER JOIN Persona AS P ON A.id_persona = P.id_persona INNER JOIN Grupo AS G ON A.id_grupo = G.id_grupo;";
            // Se llenan los datos
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cadena, conexion);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboxNombreGrupoPG.Text != "" && cboxCreadorGrupoPG.Text != "")
            {
                /*id_persona = cboxCreadorGrupoPG.SelectedValue.ToString();
                id_grupo = cboxNombreGrupoPG.SelectedValue.ToString();
                cadena = "INSERT INTO PersonaGrupo (id_persona, id_grupo) " +
                    "VALUES ('" + id_persona + "','" + id_grupo + "')";
                try
                {
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("No es posible agregar fila duplicada");
                }
                
                    "VALUES ('" + id_persona + "','" + id_grupo + "') WHERE id_persona";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();

                cboxNombreGrupoPG.Text = "";
                cboxCreadorGrupoPG.Text = "";

                muestraDB();*/
            }
        }

        private void PersonaGrupo_Load(object sender, EventArgs e)
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

                cboxCreadorGrupoPG.DataSource = dt;
                dt.Columns.Add(
                "name",
                typeof(string),
                "id_persona + ' - ' + nombre_red_social");

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
            // Se crea el query para eliminar de la base de datos
            cadena = "DELETE FROM PersonaGrupo WHERE id_persona = " + id_persona_T + " AND id_grupo = " + id_grupo_T;
            // Se ejecuta el comando
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            // Se limpian los formularios, se desactivan los botones y se actualiza la base de datos
            cboxNombreGrupoPG.SelectedIndex = 0;
            cboxCreadorGrupoPG.SelectedIndex = 0;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            muestraDB();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Se guardan los valores de los formularios
            id_persona = cboxCreadorGrupoPG.SelectedValue.ToString();
            id_grupo = cboxNombreGrupoPG.SelectedValue.ToString();
            // Se crea el query
            cadena =
                "UPDATE PersonaGrupo SET id_persona=" + id_persona + ", id_grupo=" + id_grupo + 
                " WHERE id_persona = " + id_persona_T + " AND id_grupo = " + id_grupo_T;
            // Se ejecuta el comando
            try
            {
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
            }
            catch (Exception) // Caso contrario muestra un error debido a que la fila esta duplicada
            {
                MessageBox.Show("No es posible modificar fila duplicada");
            }
            // Se desactivan los botones, se limpian los formularios y se actualiza la base de datos
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            cboxNombreGrupoPG.Text = "";
            cboxCreadorGrupoPG.Text = "";
            muestraDB();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                
                //cboxNombreGrupoPG.SelectedText = row.Cells[1].Value.ToString();
                cboxNombreGrupoPG.SelectedText = row.Cells[1].Value.ToString();
                string[] data = row.Cells[1].Value.ToString().Split('-');
                cboxNombreGrupoPG.SelectedValue = data[0];

                //cboxCreadorGrupoPG.SelectedText = row.Cells[0].Value.ToString();

                cboxCreadorGrupoPG.SelectedText = row.Cells[0].Value.ToString();
                string[] data2 = row.Cells[0].Value.ToString().Split('-');
                cboxCreadorGrupoPG.SelectedValue = data2[0];


                id_persona_T = data2[0];
                id_grupo_T = data[0];
            }
        }
    }
}
