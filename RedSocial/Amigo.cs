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
    public partial class Amigo : Form
    {
        SqlConnection conexion;
        string amigo;
        string agrega_amigo;
        Boolean amistad;
        string fecharegistro;

        string cadena;
        public Amigo()
        {
            conexion = new SqlConnection("server= DESKTOP-OBF530T\\SQLEXPRESS ; database=RedSocial ; integrated security = true");
            conexion.Open();
            InitializeComponent();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            muestraDB();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboxAmigos.Text != "" && cboxAmigoAgregar.Text != "" )
            {
                amigo = cboxAmigos.ValueMember;
                agrega_amigo = cboxAmigoAgregar.ValueMember;
                amistad = cbAmistad.Checked;

                DateTime s = DateTime.Today;
                fecharegistro = s.ToString("yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                
                cadena = "INSERT INTO Amigo (id_persona, id_persona_amigo, solicitud_amistad, fecha_inicio_amistad) " +
                    "VALUES (" + amigo + "," + agrega_amigo + ","+ (amistad ? "1" : "0") + ",'" + fecharegistro + "')";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();

                muestraDB();
                conexion.Close();
            }
        }

        public void muestraDB()
        {
            cadena = "SELECT * FROM Amigo";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cadena, conexion);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
        private void Amigo_Load(object sender, EventArgs e)
        {
            using (SqlDataAdapter sda = new SqlDataAdapter("SELECT id_persona,nombre FROM Persona", conexion))
            {
                //Fill the DataTable with records from Table.
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Insert the Default Item to DataTable.
                DataRow row = dt.NewRow();
                row[0] = 0;
                row[1] = "Please select";
                dt.Rows.InsertAt(row, 0);

                //Assign DataTable as DataSource.
                cboxAmigos.DataSource = dt;
                cboxAmigos.DisplayMember = "nombre";
                cboxAmigos.ValueMember = "id_persona";

                cboxAmigoAgregar.DataSource = dt;
                cboxAmigoAgregar.DisplayMember = "nombre";
                cboxAmigoAgregar.ValueMember = "id_persona";
            }

            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT id_persona,nombre FROM Persona", conexion))
            {
                //Fill the DataTable with records from Table.
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //Insert the Default Item to DataTable.
                DataRow row = dataTable.NewRow();
                row[0] = 0;
                row[1] = "Please select";
                dataTable.Rows.InsertAt(row, 0);

                //Assign DataTable as DataSource.

                cboxAmigoAgregar.DataSource = dataTable;
                cboxAmigoAgregar.DisplayMember = "nombre";
                cboxAmigoAgregar.ValueMember = "id_persona";
            }
        }
    }
}
