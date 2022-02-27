namespace RedSocial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabDatos = new System.Windows.Forms.TabControl();
            this.tabPersona = new System.Windows.Forms.TabPage();
            this.lblPersonaImagen = new System.Windows.Forms.Label();
            this.btnImagenPersona = new System.Windows.Forms.Button();
            this.lblPersonaNombre = new System.Windows.Forms.Label();
            this.cboxRolPersona = new System.Windows.Forms.ComboBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsernamePersona = new System.Windows.Forms.TextBox();
            this.lblImgPerfil = new System.Windows.Forms.Label();
            this.txtNombrePersona = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtErrores = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.tabDatos.SuspendLayout();
            this.tabPersona.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabDatos);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(579, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // tabDatos
            // 
            this.tabDatos.Controls.Add(this.tabPersona);
            this.tabDatos.Controls.Add(this.tabPage2);
            this.tabDatos.Location = new System.Drawing.Point(8, 25);
            this.tabDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDatos.Name = "tabDatos";
            this.tabDatos.SelectedIndex = 0;
            this.tabDatos.Size = new System.Drawing.Size(563, 192);
            this.tabDatos.TabIndex = 3;
            // 
            // tabPersona
            // 
            this.tabPersona.Controls.Add(this.lblPersonaImagen);
            this.tabPersona.Controls.Add(this.btnImagenPersona);
            this.tabPersona.Controls.Add(this.lblPersonaNombre);
            this.tabPersona.Controls.Add(this.cboxRolPersona);
            this.tabPersona.Controls.Add(this.lblUsername);
            this.tabPersona.Controls.Add(this.txtUsernamePersona);
            this.tabPersona.Controls.Add(this.lblImgPerfil);
            this.tabPersona.Controls.Add(this.txtNombrePersona);
            this.tabPersona.Controls.Add(this.lblRol);
            this.tabPersona.Location = new System.Drawing.Point(4, 25);
            this.tabPersona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPersona.Name = "tabPersona";
            this.tabPersona.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPersona.Size = new System.Drawing.Size(555, 163);
            this.tabPersona.TabIndex = 0;
            this.tabPersona.Text = "Persona";
            this.tabPersona.UseVisualStyleBackColor = true;
            // 
            // lblPersonaImagen
            // 
            this.lblPersonaImagen.AutoSize = true;
            this.lblPersonaImagen.ForeColor = System.Drawing.Color.Red;
            this.lblPersonaImagen.Location = new System.Drawing.Point(412, 90);
            this.lblPersonaImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonaImagen.Name = "lblPersonaImagen";
            this.lblPersonaImagen.Size = new System.Drawing.Size(121, 17);
            this.lblPersonaImagen.TabIndex = 8;
            this.lblPersonaImagen.Text = "Imagen sin cargar";
            // 
            // btnImagenPersona
            // 
            this.btnImagenPersona.Location = new System.Drawing.Point(188, 84);
            this.btnImagenPersona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImagenPersona.Name = "btnImagenPersona";
            this.btnImagenPersona.Size = new System.Drawing.Size(216, 28);
            this.btnImagenPersona.TabIndex = 7;
            this.btnImagenPersona.Text = "Cargar";
            this.btnImagenPersona.UseVisualStyleBackColor = true;
            this.btnImagenPersona.Click += new System.EventHandler(this.btnImagenPersona_Click);
            // 
            // lblPersonaNombre
            // 
            this.lblPersonaNombre.AutoSize = true;
            this.lblPersonaNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonaNombre.Location = new System.Drawing.Point(8, 18);
            this.lblPersonaNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonaNombre.Name = "lblPersonaNombre";
            this.lblPersonaNombre.Size = new System.Drawing.Size(87, 25);
            this.lblPersonaNombre.TabIndex = 0;
            this.lblPersonaNombre.Text = "Nombre:";
            // 
            // cboxRolPersona
            // 
            this.cboxRolPersona.FormattingEnabled = true;
            this.cboxRolPersona.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.cboxRolPersona.Location = new System.Drawing.Point(188, 119);
            this.cboxRolPersona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxRolPersona.Name = "cboxRolPersona";
            this.cboxRolPersona.Size = new System.Drawing.Size(344, 24);
            this.cboxRolPersona.TabIndex = 6;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(8, 50);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(108, 25);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsernamePersona
            // 
            this.txtUsernamePersona.Location = new System.Drawing.Point(188, 53);
            this.txtUsernamePersona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsernamePersona.Name = "txtUsernamePersona";
            this.txtUsernamePersona.Size = new System.Drawing.Size(344, 22);
            this.txtUsernamePersona.TabIndex = 5;
            // 
            // lblImgPerfil
            // 
            this.lblImgPerfil.AutoSize = true;
            this.lblImgPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImgPerfil.Location = new System.Drawing.Point(8, 84);
            this.lblImgPerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImgPerfil.Name = "lblImgPerfil";
            this.lblImgPerfil.Size = new System.Drawing.Size(158, 25);
            this.lblImgPerfil.TabIndex = 2;
            this.lblImgPerfil.Text = "Imagen de Perfil:";
            // 
            // txtNombrePersona
            // 
            this.txtNombrePersona.Location = new System.Drawing.Point(188, 21);
            this.txtNombrePersona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombrePersona.Name = "txtNombrePersona";
            this.txtNombrePersona.Size = new System.Drawing.Size(344, 22);
            this.txtNombrePersona.TabIndex = 4;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(8, 117);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(46, 25);
            this.lblRol.TabIndex = 3;
            this.lblRol.Text = "Rol:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(555, 163);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Location = new System.Drawing.Point(604, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(156, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(9, 159);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 44);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(9, 98);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(132, 42);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(9, 37);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 41);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtErrores);
            this.groupBox3.Location = new System.Drawing.Point(768, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(283, 223);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Errores";
            // 
            // txtErrores
            // 
            this.txtErrores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrores.Location = new System.Drawing.Point(9, 25);
            this.txtErrores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtErrores.Multiline = true;
            this.txtErrores.Name = "txtErrores";
            this.txtErrores.ReadOnly = true;
            this.txtErrores.Size = new System.Drawing.Size(264, 190);
            this.txtErrores.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(17, 247);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(1033, 292);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Base de Datos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1012, 260);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "SMBD Red Social";
            this.groupBox1.ResumeLayout(false);
            this.tabDatos.ResumeLayout(false);
            this.tabPersona.ResumeLayout(false);
            this.tabPersona.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabDatos;
        private System.Windows.Forms.TabPage tabPersona;
        private System.Windows.Forms.Button btnImagenPersona;
        private System.Windows.Forms.Label lblPersonaNombre;
        private System.Windows.Forms.ComboBox cboxRolPersona;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsernamePersona;
        private System.Windows.Forms.Label lblImgPerfil;
        private System.Windows.Forms.TextBox txtNombrePersona;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPersonaImagen;
        private System.Windows.Forms.TextBox txtErrores;
    }
}

