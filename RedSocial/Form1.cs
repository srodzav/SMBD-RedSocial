using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;


namespace RedSocial
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            new Persona().Show();
        }

        private void btnAmigo_Click(object sender, EventArgs e)
        {
            new Amigo().Show();
        }

        private void btnNotificacion_Click(object sender, EventArgs e)
        {
            new Notificacion().Show();
        }
        
        private void btnGrupo_Click(object sender, EventArgs e)
        {
            new Grupo().Show();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            new Post().Show();
        }

        private void btnPersonaGrupo_Click(object sender, EventArgs e)
        {
            new PersonaGrupo().Show();
        }
    }
}
