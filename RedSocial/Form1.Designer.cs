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
            this.btnPersona = new System.Windows.Forms.Button();
            this.btnAmigo = new System.Windows.Forms.Button();
            this.btnNotificacion = new System.Windows.Forms.Button();
            this.btnGrupo = new System.Windows.Forms.Button();
            this.btnRecurso = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnPersonaGrupo = new System.Windows.Forms.Button();
            this.btnComentario = new System.Windows.Forms.Button();
            this.btnContenido = new System.Windows.Forms.Button();
            this.compartir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersona
            // 
            this.btnPersona.Location = new System.Drawing.Point(12, 12);
            this.btnPersona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(129, 58);
            this.btnPersona.TabIndex = 0;
            this.btnPersona.Text = "Persona";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // btnAmigo
            // 
            this.btnAmigo.Location = new System.Drawing.Point(147, 12);
            this.btnAmigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAmigo.Name = "btnAmigo";
            this.btnAmigo.Size = new System.Drawing.Size(129, 58);
            this.btnAmigo.TabIndex = 1;
            this.btnAmigo.Text = "Amigo";
            this.btnAmigo.UseVisualStyleBackColor = true;
            this.btnAmigo.Click += new System.EventHandler(this.btnAmigo_Click);
            // 
            // btnNotificacion
            // 
            this.btnNotificacion.Location = new System.Drawing.Point(10, 62);
            this.btnNotificacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnNotificacion.Name = "btnNotificacion";
            this.btnNotificacion.Size = new System.Drawing.Size(128, 71);
            this.btnNotificacion.TabIndex = 2;
            this.btnNotificacion.Text = "Notificacion";
            this.btnNotificacion.UseVisualStyleBackColor = true;
            this.btnNotificacion.Click += new System.EventHandler(this.btnNotificacion_Click);
            // 
            // btnGrupo
            // 
            this.btnGrupo.Location = new System.Drawing.Point(212, 10);
            this.btnGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrupo.Name = "btnGrupo";
            this.btnGrupo.Size = new System.Drawing.Size(129, 58);
            this.btnGrupo.TabIndex = 2;
            this.btnGrupo.Text = "Grupo";
            this.btnGrupo.UseVisualStyleBackColor = true;
            this.btnGrupo.Click += new System.EventHandler(this.btnGrupo_Click);
            // 
            // btnRecurso
            // 
            this.btnRecurso.Location = new System.Drawing.Point(110, 64);
            this.btnRecurso.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecurso.Name = "btnRecurso";
            this.btnRecurso.Size = new System.Drawing.Size(97, 56);
            this.btnRecurso.TabIndex = 3;
            this.btnRecurso.Text = "Recurso";
            this.btnRecurso.UseVisualStyleBackColor = true;
            this.btnRecurso.Click += new System.EventHandler(this.btnRecurso_Click);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(212, 64);
            this.btnPost.Margin = new System.Windows.Forms.Padding(4);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(97, 56);
            this.btnPost.TabIndex = 3;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnPersonaGrupo
            // 
            this.btnPersonaGrupo.Location = new System.Drawing.Point(316, 10);
            this.btnPersonaGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.btnPersonaGrupo.Name = "btnPersonaGrupo";
            this.btnPersonaGrupo.Size = new System.Drawing.Size(129, 58);
            this.btnPersonaGrupo.TabIndex = 4;
            this.btnPersonaGrupo.Text = "Persona-Grupo";
            this.btnPersonaGrupo.UseVisualStyleBackColor = true;
            this.btnPersonaGrupo.Click += new System.EventHandler(this.btnPersonaGrupo_Click);
            // 
            // btnComentario
            // 
            this.btnComentario.Location = new System.Drawing.Point(316, 64);
            this.btnComentario.Name = "btnComentario";
            this.btnComentario.Size = new System.Drawing.Size(97, 56);
            this.btnComentario.TabIndex = 5;
            this.btnComentario.Text = "Comentario";
            this.btnComentario.UseVisualStyleBackColor = true;
            this.btnComentario.Click += new System.EventHandler(this.btnComentario_Click);
            // 
            // btnContenido
            // 
            this.btnContenido.Location = new System.Drawing.Point(12, 168);
            this.btnContenido.Name = "btnContenido";
            this.btnContenido.Size = new System.Drawing.Size(97, 56);
            this.btnContenido.TabIndex = 6;
            this.btnContenido.Text = "Contenido";
            this.btnContenido.UseVisualStyleBackColor = true;
            this.btnContenido.Click += new System.EventHandler(this.btnContenido_Click);
            // 
            // compartir
            // 
            this.compartir.Location = new System.Drawing.Point(115, 168);
            this.compartir.Name = "compartir";
            this.compartir.Size = new System.Drawing.Size(97, 56);
            this.compartir.TabIndex = 7;
            this.compartir.Text = "Compartir";
            this.compartir.UseVisualStyleBackColor = true;
            this.compartir.Click += new System.EventHandler(this.compartir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.compartir);
            this.Controls.Add(this.btnContenido);
            this.Controls.Add(this.btnComentario);
            this.Controls.Add(this.btnRecurso);
            this.Controls.Add(this.btnPersonaGrupo);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnNotificacion);
            this.Controls.Add(this.btnGrupo);
            this.Controls.Add(this.btnAmigo);
            this.Controls.Add(this.btnPersona);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "SMBD Red Social";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.Button btnAmigo;
        private System.Windows.Forms.Button btnNotificacion;
        private System.Windows.Forms.Button btnGrupo;
        private System.Windows.Forms.Button btnRecurso;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnPersonaGrupo;
        private System.Windows.Forms.Button btnComentario;
        private System.Windows.Forms.Button btnContenido;
        private System.Windows.Forms.Button compartir;
    }
}

