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
        string persona;
        string post;
        string comentario;
        string fecha_comentario;
        string id;
        string id_comentario;

        public Comentario()
        {
            //conexion = new SqlConnection("server= DESKTOP-OBF530T\\SQLEXPRESS ; database=RedSocial ; integrated security = true");
            conexion = new SqlConnection("server=MINIGODDARD;database=RedSocial;integrated security = true");
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
                persona = cboxPersona.Text;
                post = cboxPost.Text;
                comentario = txtComentario.Text;
                DateTime s = DateTime.Today;
                fecha_comentario = s.ToString("yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);

                cadena = "INSERT INTO Comentario (id_post, id_persona, comentario, fecha_comentario) " +
                    "VALUES ('" + post + "','" + persona + "','" + comentario + "','" + fecha_comentario + "')";

                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();

                cboxPersona.Text = "";
                cboxPost.Text = "";
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
                "id_post='" + post + "', id_persona='" +
                persona + "', comentario='" + comentario + " WHERE id_persona = " +
                id;

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
            conexion.Open();
            cadena =
                "DELETE FROM Persona WHERE id_comentario = " + id_comentario;

            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            muestraDB();
            comando.Connection.Close();
            conexion.Close();
        }

        private void Comentario_Load(object sender, EventArgs e)
        {
            //cboxPersona.DataSource = nebulae;
            //cboxPost.DataSource = nebulae;
        }

        public void muestraDB()
        {
            cadena = "SELECT * FROM Comentario";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cadena, conexion);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }


    }
}
