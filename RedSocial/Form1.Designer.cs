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
            this.SuspendLayout();
            // 
            // btnPersona
            // 
            this.btnPersona.Location = new System.Drawing.Point(9, 10);
            this.btnPersona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(97, 47);
            this.btnPersona.TabIndex = 0;
            this.btnPersona.Text = "Persona";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // btnAmigo
            // 
            this.btnAmigo.Location = new System.Drawing.Point(110, 10);
            this.btnAmigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAmigo.Name = "btnAmigo";
            this.btnAmigo.Size = new System.Drawing.Size(97, 47);
            this.btnAmigo.TabIndex = 1;
            this.btnAmigo.Text = "Amigo";
            this.btnAmigo.UseVisualStyleBackColor = true;
            this.btnAmigo.Click += new System.EventHandler(this.btnAmigo_Click);
            // 
            // btnNotificacion
            // 
            this.btnNotificacion.Location = new System.Drawing.Point(12, 76);
            this.btnNotificacion.Name = "btnNotificacion";
            this.btnNotificacion.Size = new System.Drawing.Size(129, 58);
            this.btnNotificacion.TabIndex = 2;
            this.btnNotificacion.Text = "Notificacion";
            this.btnNotificacion.UseVisualStyleBackColor = true;
            this.btnNotificacion.Click += new System.EventHandler(this.btnNotificacion_Click);
            // btnGrupo
            // 
            this.btnGrupo.Location = new System.Drawing.Point(212, 10);
            this.btnGrupo.Name = "btnGrupo";
            this.btnGrupo.Size = new System.Drawing.Size(97, 47);
            this.btnGrupo.TabIndex = 2;
            this.btnGrupo.Text = "Grupo";
            this.btnGrupo.UseVisualStyleBackColor = true;
            this.btnGrupo.Click += new System.EventHandler(this.btnGrupo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnNotificacion);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGrupo);
            this.Controls.Add(this.btnAmigo);
            this.Controls.Add(this.btnPersona);
            this.Name = "Form1";
            this.Text = "SMBD Red Social";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.Button btnAmigo;
        private System.Windows.Forms.Button btnNotificacion;
        private System.Windows.Forms.Button btnGrupo;
    }
}

