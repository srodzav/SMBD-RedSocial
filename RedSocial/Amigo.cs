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

        string id_amigo;
        string id_persona;
        string id_persona_amigo;
        string solicitud_amistad;
        public Amigo()
        {
            conexion = new SqlConnection("server= DESKTOP-OBF530T\\SQLEXPRESS ; database=RedSocial ; integrated security = true");
            //conexion = new SqlConnection("server=MINIGODDARD;database=RedSocial;integrated security = true");
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
                amigo = cboxAmigos.SelectedValue.ToString();
                agrega_amigo = cboxAmigoAgregar.SelectedValue.ToString();
                amistad = cbAmistad.Checked;

                DateTime s = DateTime.Today;
                fecharegistro = s.ToString("yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                
                cadena = "INSERT INTO Amigo (id_persona, id_persona_amigo, solicitud_amistad, fecha_inicio_amistad) " +
                    "VALUES (" + amigo + "," + agrega_amigo + ","+ (amistad ? "1" : "0") + ",'" + fecharegistro + "')";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();

                cboxAmigos.SelectedIndex = 0;
                cboxAmigoAgregar.SelectedIndex = 0;
                cbAmistad.Checked = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;

                muestraDB();
            }
        }

        public void muestraDB()
        {

            cadena = "SELECT A.id_amigo, CONCAT(P.id_persona, '-' ,P.nombre_red_social) as persona , CONCAT(Pe.id_persona, '-' ,Pe.nombre_red_social) as amigo,A.solicitud_amistad, A.fecha_inicio_amistad " +
                "FROM Amigo A " +
                "INNER JOIN Persona AS P " +
                "ON A.id_persona = P.id_persona " +
                "INNER JOIN Persona AS Pe " +
                "ON A.id_persona_amigo = Pe.id_persona;";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cadena, conexion);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        
        private void Amigo_Load(object sender, EventArgs e)
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
                cboxAmigos.DataSource = dt;

                dt.Columns.Add(
                "name",
                typeof(string),
                "id_persona + ' - ' + nombre_red_social");

                cboxAmigos.DisplayMember = "name";
                cboxAmigos.ValueMember = "id_persona";
            }

            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT id_persona,nombre,nombre_red_social FROM Persona", conexion))
            {
                //Fill the DataTable with records from Table.
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //Insert the Default Item to DataTable.
                DataRow row = dataTable.NewRow();
                row[0] = 0;
                dataTable.Rows.InsertAt(row, 0);

                //Assign DataTable as DataSource.

                cboxAmigoAgregar.DataSource = dataTable;
                dataTable.Columns.Add(
                "name",
                typeof(string),
                "id_persona + ' - ' + nombre_red_social");

                cboxAmigoAgregar.DisplayMember = "name";
                cboxAmigoAgregar.ValueMember = "id_persona";
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                id_amigo = row.Cells[0].Value.ToString();

                cboxAmigos.SelectedIndex = 0;
                cboxAmigoAgregar.SelectedIndex = 0;

                cboxAmigos.SelectedText= row.Cells[1].Value.ToString();
                string[] data = row.Cells[1].Value.ToString().Split('-');
                cboxAmigos.SelectedValue = data[0];

                cboxAmigoAgregar.SelectedText = row.Cells[2].Value.ToString();
                string[] data2 = row.Cells[2].Value.ToString().Split('-');
                cboxAmigoAgregar.SelectedValue = data2[0];

                id_persona = row.Cells[1].Value.ToString();
                id_persona_amigo = row.Cells[2].Value.ToString();
                solicitud_amistad = row.Cells[3].Value.ToString();
                
                cbAmistad.Checked = solicitud_amistad.ToString() == "False" ? false : true;
                
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            id_persona = cboxAmigos.Text;
            id_persona_amigo = cboxAmigoAgregar.Text;

            var stringNumber = cboxAmigos.Text;
            int numericValue;
            bool isNumberPersona = int.TryParse(stringNumber, out numericValue);
            stringNumber = cboxAmigoAgregar.Text;
            bool isNumberAmigo = int.TryParse(stringNumber, out numericValue);

            cadena =
                "UPDATE Amigo SET id_persona=" + (isNumberPersona == true ? cboxAmigos.Text : cboxAmigos.SelectedValue) + 
                ", id_persona_amigo=" + (isNumberAmigo == true ? cboxAmigoAgregar.Text : cboxAmigoAgregar.SelectedValue) + 
                ", solicitud_amistad=" + (cbAmistad.Checked == false ? 0 : 1) +" WHERE id_amigo = " + id_amigo;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();

            cboxAmigos.SelectedIndex = 0;
            cboxAmigoAgregar.SelectedIndex = 0;
            cbAmistad.Checked = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            muestraDB();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cadena = "DELETE FROM Amigo WHERE id_amigo = " + id_amigo;

            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();


            cboxAmigos.SelectedIndex = 0;
            cboxAmigoAgregar.SelectedIndex = 0;
            cbAmistad.Checked = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            muestraDB();
        }
    }
}
