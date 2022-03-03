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
    public partial class Notificacion : Form
    {
        SqlConnection conexion;
        string cadena;

        string id_notificacion;
        string id_persona;
        string id_quien_compartio;
        string mensaje_txt;
        string fecharegistro;
        Boolean visto;

        public Notificacion()
        {
            //conexion = new SqlConnection("server= DESKTOP-OBF530T\\SQLEXPRESS ; database=RedSocial ; integrated security = true");
            conexion = new SqlConnection("server=MINIGODDARD;database=RedSocial;integrated security = true");
            conexion.Open();
            InitializeComponent();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            muestraDB();
        }

        public void muestraDB()
        {
            cadena = "SELECT * FROM Notificacion";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cadena, conexion);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cboxPersona.Text != "" && cboxQuienCompartio.Text != "")
            {
                id_persona = cboxPersona.SelectedValue.ToString();
                id_quien_compartio = cboxQuienCompartio.SelectedValue.ToString();
                mensaje_txt = mensaje.Text;
                visto = cbVisto.Checked;

                DateTime s = DateTime.Today;
                fecharegistro = s.ToString("yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);

                cadena = "INSERT INTO Notificacion (id_persona, id_quien_compartio, mensaje, visto,fecha_notficacion) " +
                    "VALUES (" + id_persona + "," + id_quien_compartio + ",'" + mensaje_txt + "'," + (visto ? "1" : "0") + ",'" + fecharegistro + "')";
                MessageBox.Show(cadena);
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();

                cboxPersona.SelectedIndex = 0;
                cboxQuienCompartio.SelectedIndex = 0;
                mensaje.Text = "";
                cbVisto.Checked = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;

                muestraDB();
            }
        }

        private void Notificacion_Load(object sender, EventArgs e)
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

                //Assign DataTable as DataSource.
                cboxPersona.DataSource = dt;

                dt.Columns.Add(
                "name",
                typeof(string),
                "id_persona + ' - ' + nombre");

                cboxPersona.DisplayMember = "name";
                cboxPersona.ValueMember = "id_persona";
            }

            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT id_persona,nombre FROM Persona", conexion))
            {
                //Fill the DataTable with records from Table.
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //Insert the Default Item to DataTable.
                DataRow row = dataTable.NewRow();
                row[0] = 0;
                dataTable.Rows.InsertAt(row, 0);

                //Assign DataTable as DataSource.

                cboxQuienCompartio.DataSource = dataTable;
                dataTable.Columns.Add(
                "name",
                typeof(string),
                "id_persona + ' - ' + nombre");

                cboxQuienCompartio.DisplayMember = "name";
                cboxQuienCompartio.ValueMember = "id_persona";
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                id_notificacion = row.Cells[0].Value.ToString();

                cboxPersona.SelectedIndex = 0;
                cboxQuienCompartio.SelectedIndex = 0;

                cboxPersona.SelectedText = row.Cells[1].Value.ToString();
                cboxQuienCompartio.SelectedText = row.Cells[2].Value.ToString();
                mensaje.Text = row.Cells[3].Value.ToString();

                id_persona = row.Cells[1].Value.ToString();
                id_quien_compartio = row.Cells[2].Value.ToString();
                mensaje_txt = row.Cells[3].Value.ToString();
                string visto = row.Cells[4].Value.ToString();

                cbVisto.Checked = visto.ToString() == "False" ? false : true;

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var stringNumber = cboxPersona.Text;
            int numericValue;
            bool isNumberPersona = int.TryParse(stringNumber, out numericValue);
            stringNumber = cboxQuienCompartio.Text;
            bool isNumberAmigo = int.TryParse(stringNumber, out numericValue);

            cadena =
                "UPDATE Notificacion SET id_persona=" + (isNumberPersona == true ? cboxPersona.Text : cboxPersona.SelectedValue) +
                ", id_quien_compartio=" + (isNumberAmigo == true ? cboxQuienCompartio.Text : cboxQuienCompartio.SelectedValue) +
                ", mensaje='" + mensaje.Text +
                "', visto=" + (cbVisto.Checked == false ? 0 : 1) + " WHERE id_notificacion = " + id_notificacion;
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();

            cboxPersona.SelectedIndex = 0;
            cboxQuienCompartio.SelectedIndex = 0;
            mensaje.Text = "";
            cbVisto.Checked = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            muestraDB();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cadena = "DELETE FROM Notificacion WHERE id_notificacion = " + id_notificacion;

            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();


            cboxPersona.SelectedIndex = 0;
            cboxQuienCompartio.SelectedIndex = 0;
            mensaje.Text = "";
            cbVisto.Checked = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            muestraDB();
        }
    }
}
