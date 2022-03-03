﻿namespace RedSocial
{
    partial class Post
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
            this.lblPersonaPost = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.cboxAutorPost = new System.Windows.Forms.ComboBox();
            this.cboxTipoPost = new System.Windows.Forms.ComboBox();
            this.txtDescripcionPost = new System.Windows.Forms.TextBox();
            this.txtReaccionesPost = new System.Windows.Forms.TextBox();
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtReaccionesPost);
            this.groupBox1.Controls.Add(this.txtDescripcionPost);
            this.groupBox1.Controls.Add(this.cboxTipoPost);
            this.groupBox1.Controls.Add(this.cboxAutorPost);
            this.groupBox1.Controls.Add(this.lblPersonaPost);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.lblRol);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 181);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // lblPersonaPost
            // 
            this.lblPersonaPost.AutoSize = true;
            this.lblPersonaPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonaPost.Location = new System.Drawing.Point(20, 40);
            this.lblPersonaPost.Name = "lblPersonaPost";
            this.lblPersonaPost.Size = new System.Drawing.Size(52, 20);
            this.lblPersonaPost.TabIndex = 9;
            this.lblPersonaPost.Text = "Autor:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(20, 66);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 20);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(20, 93);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(96, 20);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(19, 145);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(97, 20);
            this.lblRol.TabIndex = 12;
            this.lblRol.Text = "Reacciones:";
            // 
            // cboxAutorPost
            // 
            this.cboxAutorPost.FormattingEnabled = true;
            this.cboxAutorPost.Location = new System.Drawing.Point(123, 42);
            this.cboxAutorPost.Name = "cboxAutorPost";
            this.cboxAutorPost.Size = new System.Drawing.Size(305, 21);
            this.cboxAutorPost.TabIndex = 13;
            // 
            // cboxTipoPost
            // 
            this.cboxTipoPost.FormattingEnabled = true;
            this.cboxTipoPost.Location = new System.Drawing.Point(123, 68);
            this.cboxTipoPost.Name = "cboxTipoPost";
            this.cboxTipoPost.Size = new System.Drawing.Size(305, 21);
            this.cboxTipoPost.TabIndex = 14;
            // 
            // txtDescripcionPost
            // 
            this.txtDescripcionPost.Location = new System.Drawing.Point(123, 95);
            this.txtDescripcionPost.Multiline = true;
            this.txtDescripcionPost.Name = "txtDescripcionPost";
            this.txtDescripcionPost.Size = new System.Drawing.Size(305, 43);
            this.txtDescripcionPost.TabIndex = 15;
            // 
            // txtReaccionesPost
            // 
            this.txtReaccionesPost.Location = new System.Drawing.Point(123, 144);
            this.txtReaccionesPost.Name = "txtReaccionesPost";
            this.txtReaccionesPost.Size = new System.Drawing.Size(305, 20);
            this.txtReaccionesPost.TabIndex = 16;
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Post";
            this.Text = "Post";
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
        private System.Windows.Forms.Label lblPersonaPost;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtReaccionesPost;
        private System.Windows.Forms.TextBox txtDescripcionPost;
        private System.Windows.Forms.ComboBox cboxTipoPost;
        private System.Windows.Forms.ComboBox cboxAutorPost;
    }
}