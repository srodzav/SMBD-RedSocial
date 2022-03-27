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
    public partial class Contenido : Form
    {
        private SqlConnection conexion;
        string cadena;
        string id_post;
        string id_recurso;
        string id_contenido;

        public Contenido()
        {
            conexion = new SqlConnection("server= DESKTOP-OBF530T\\SQLEXPRESS ; database=RedSocial ; integrated security = true");
            //conexion = new SqlConnection("server=MINIGODDARD;database=RedSocial;integrated security = true");
            conexion.Open();
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
            cadena = "SELECT A.id_contenido, CONCAT (P.id_post, '-' , pe.nombre, '/' , P.tipo ,'/' ,P.fecha_post  ) as post,CONCAT(G.id_recurso, '-' , RIGHT(G.ruta, CHARINDEX('\\',REVERSE(G.ruta))-1) ) as Ruta FROM Contenido A" +
                " INNER JOIN Post AS P ON A.id_post = P.id_post INNER JOIN Recurso AS G ON A.id_objeto = G.id_recurso INNER JOIN Persona pe ON P.id_persona = Pe.id_persona";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cadena, conexion);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Contenido_Load(object sender, EventArgs e)
        {
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT po.id_post as id_post, pe.nombre as nombre, po.tipo as tipo, po.fecha_post as fecha FROM Post po INNER JOIN Persona pe ON Po.id_persona = Pe.id_persona", conexion))
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
                "nombre + ' - ' + tipo + ' - ' + fecha");

                cboxCreadorGrupoPG.DisplayMember = "name";
                cboxCreadorGrupoPG.ValueMember = "id_post";
            }
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT id_recurso, RIGHT(ruta, CHARINDEX('\\',REVERSE(ruta))-1) as ruta FROM Recurso", conexion))
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
                "id_recurso + ' - ' + ruta");

                cboxNombreGrupoPG.DisplayMember = "name";
                cboxNombreGrupoPG.ValueMember = "id_recurso";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboxNombreGrupoPG.Text != "" && cboxCreadorGrupoPG.Text != "")
            {
                id_post = cboxCreadorGrupoPG.SelectedValue.ToString();
                id_recurso = cboxNombreGrupoPG.SelectedValue.ToString();
                // cadena = "INSERT INTO Contenido (id_post, id_objeto) " +
                //    "VALUES ('" + id_post + "','" + id_recurso + "')";

                if (cboxCreadorGrupoPG.Text.Contains("Imagen"))
                {
                    if (cboxNombreGrupoPG.Text.Contains(".png") || cboxNombreGrupoPG.Text.Contains(".jpg"))
                    {
                        cadena = " declare @tipo_post AS VARCHAR(100); " +
                       " declare @tipo_file AS VARCHAR(100); " +
                       $" select @tipo_post = p.tipo , @tipo_file = r.tipo from Post p join Recurso r on 1=1 where id_post = {id_post} and id_recurso = {id_recurso}; " +
                       " IF ( @tipo_post = 'Imagen') " +
                       " IF (@tipo_file = '.jpg' or @tipo_file = '.png')" +
                       $" INSERT INTO Contenido (id_post, id_objeto) VALUES ({id_post}, {id_recurso}); " +
                       " ELSE " +
                       " IF (@tipo_file = '.mp4') " +
                       $" INSERT INTO Contenido (id_post, id_objeto) VALUES ({id_post}, {id_recurso}); ";
                    }
                    else
                    {
                        MessageBox.Show("No es el mismo tipo de dato");
                    }
                }
                else
                {
                    if (cboxNombreGrupoPG.Text.Contains(".mp4"))
                    {

                        cadena = " declare @tipo_post AS VARCHAR(100); " +
                      " declare @tipo_file AS VARCHAR(100); " +
                      $" select @tipo_post = p.tipo , @tipo_file = r.tipo from Post p join Recurso r on 1=1 where id_post = {id_post} and id_recurso = {id_recurso}; " +
                      " IF ( @tipo_post = 'Imagen') " +
                      " IF (@tipo_file = '.jpg' or @tipo_file = '.png')" +
                      $" INSERT INTO Contenido (id_post, id_objeto) VALUES ({id_post}, {id_recurso}); " +
                      " ELSE " +
                      " IF (@tipo_file = '.mp4') " +
                      $" INSERT INTO Contenido (id_post, id_objeto) VALUES ({id_post}, {id_recurso}); ";
                    }
                    else
                    {
                        MessageBox.Show("No es el mismo tipo de dato");
                    }
                }



                    try
                {
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("No es posible agregar fila duplicada");
                }

                cboxNombreGrupoPG.Text = "";
                cboxCreadorGrupoPG.Text = "";

                muestraDB();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            cadena =
                "UPDATE Contenido SET id_post=" + cboxCreadorGrupoPG.SelectedValue.ToString() + ", id_objeto=" + cboxNombreGrupoPG.SelectedValue.ToString() +
                " WHERE id_contenido = " + id_contenido;
            try
            {
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("No es posible modificar fila duplicada");
            }

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
                id_contenido = row.Cells[0].Value.ToString();
                //cboxNombreGrupoPG.SelectedText = row.Cells[1].Value.ToString();
                cboxCreadorGrupoPG.SelectedText = row.Cells[1].Value.ToString();
                string[] data2 = row.Cells[1].Value.ToString().Split('-');
                cboxCreadorGrupoPG.SelectedValue = data2[0];
                
                //cboxNombreGrupoPG.SelectedText = row.Cells[1].Value.ToString();
                cboxNombreGrupoPG.SelectedText = row.Cells[2].Value.ToString();
                string[] data = row.Cells[2].Value.ToString().Split('-');
                cboxNombreGrupoPG.SelectedValue = data[0];


                id_post = data2[0];
                id_recurso = data[0];
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cadena = "DELETE FROM Contenido WHERE id_contenido = " + id_contenido  ;

            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();


            cboxNombreGrupoPG.SelectedIndex = 0;
            cboxCreadorGrupoPG.SelectedIndex = 0;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            muestraDB();
        }
    }
}
