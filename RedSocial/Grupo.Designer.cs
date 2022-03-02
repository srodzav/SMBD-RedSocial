namespace RedSocial
{
    partial class Grupo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtErrores = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxCreadorGrupo = new System.Windows.Forms.ComboBox();
            this.txtDescripcionGrupo = new System.Windows.Forms.TextBox();
            this.lblGrupoImagen = new System.Windows.Forms.Label();
            this.btnImagenGrupo = new System.Windows.Forms.Button();
            this.lblNombreGrupo = new System.Windows.Forms.Label();
            this.lblCreador = new System.Windows.Forms.Label();
            this.txtNombreGrupo = new System.Windows.Forms.TextBox();
            this.lblImgGrupo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(13, 200);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(775, 237);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Base de Datos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 211);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtErrores);
            this.groupBox3.Location = new System.Drawing.Point(576, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 181);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Errores";
            // 
            // txtErrores
            // 
            this.txtErrores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrores.Location = new System.Drawing.Point(7, 20);
            this.txtErrores.Multiline = true;
            this.txtErrores.Name = "txtErrores";
            this.txtErrores.ReadOnly = true;
            this.txtErrores.Size = new System.Drawing.Size(199, 155);
            this.txtErrores.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Location = new System.Drawing.Point(453, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 181);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(7, 129);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 36);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(7, 80);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 34);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(7, 30);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 33);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxCreadorGrupo);
            this.groupBox1.Controls.Add(this.txtDescripcionGrupo);
            this.groupBox1.Controls.Add(this.lblGrupoImagen);
            this.groupBox1.Controls.Add(this.btnImagenGrupo);
            this.groupBox1.Controls.Add(this.lblNombreGrupo);
            this.groupBox1.Controls.Add(this.lblCreador);
            this.groupBox1.Controls.Add(this.txtNombreGrupo);
            this.groupBox1.Controls.Add(this.lblImgGrupo);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 181);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // cboxCreadorGrupo
            // 
            this.cboxCreadorGrupo.FormattingEnabled = true;
            this.cboxCreadorGrupo.Location = new System.Drawing.Point(164, 68);
            this.cboxCreadorGrupo.Name = "cboxCreadorGrupo";
            this.cboxCreadorGrupo.Size = new System.Drawing.Size(249, 21);
            this.cboxCreadorGrupo.TabIndex = 19;
            // 
            // txtDescripcionGrupo
            // 
            this.txtDescripcionGrupo.Location = new System.Drawing.Point(164, 123);
            this.txtDescripcionGrupo.Multiline = true;
            this.txtDescripcionGrupo.Name = "txtDescripcionGrupo";
            this.txtDescripcionGrupo.Size = new System.Drawing.Size(250, 52);
            this.txtDescripcionGrupo.TabIndex = 18;
            // 
            // lblGrupoImagen
            // 
            this.lblGrupoImagen.AutoSize = true;
            this.lblGrupoImagen.ForeColor = System.Drawing.Color.Red;
            this.lblGrupoImagen.Location = new System.Drawing.Point(323, 98);
            this.lblGrupoImagen.Name = "lblGrupoImagen";
            this.lblGrupoImagen.Size = new System.Drawing.Size(91, 13);
            this.lblGrupoImagen.TabIndex = 17;
            this.lblGrupoImagen.Text = "Imagen sin cargar";
            // 
            // btnImagenGrupo
            // 
            this.btnImagenGrupo.Location = new System.Drawing.Point(164, 93);
            this.btnImagenGrupo.Name = "btnImagenGrupo";
            this.btnImagenGrupo.Size = new System.Drawing.Size(153, 23);
            this.btnImagenGrupo.TabIndex = 16;
            this.btnImagenGrupo.Text = "Cargar";
            this.btnImagenGrupo.UseVisualStyleBackColor = true;
            this.btnImagenGrupo.Click += new System.EventHandler(this.btnImagenGrupo_Click);
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreGrupo.Location = new System.Drawing.Point(20, 40);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(139, 20);
            this.lblNombreGrupo.TabIndex = 9;
            this.lblNombreGrupo.Text = "Nombre del grupo:";
            // 
            // lblCreador
            // 
            this.lblCreador.AutoSize = true;
            this.lblCreador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreador.Location = new System.Drawing.Point(20, 66);
            this.lblCreador.Name = "lblCreador";
            this.lblCreador.Size = new System.Drawing.Size(70, 20);
            this.lblCreador.TabIndex = 10;
            this.lblCreador.Text = "Creador:";
            // 
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.Location = new System.Drawing.Point(165, 42);
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            this.txtNombreGrupo.Size = new System.Drawing.Size(249, 20);
            this.txtNombreGrupo.TabIndex = 13;
            // 
            // lblImgGrupo
            // 
            this.lblImgGrupo.AutoSize = true;
            this.lblImgGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImgGrupo.Location = new System.Drawing.Point(20, 93);
            this.lblImgGrupo.Name = "lblImgGrupo";
            this.lblImgGrupo.Size = new System.Drawing.Size(138, 20);
            this.lblImgGrupo.TabIndex = 11;
            this.lblImgGrupo.Text = "Imagen de Grupo:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(20, 120);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(96, 20);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // Grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Grupo";
            this.Text = "Grupo";
            this.Load += new System.EventHandler(this.Grupo_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtErrores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGrupoImagen;
        private System.Windows.Forms.Button btnImagenGrupo;
        private System.Windows.Forms.Label lblNombreGrupo;
        private System.Windows.Forms.Label lblCreador;
        private System.Windows.Forms.TextBox txtNombreGrupo;
        private System.Windows.Forms.Label lblImgGrupo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcionGrupo;
        private System.Windows.Forms.ComboBox cboxCreadorGrupo;
    }
}