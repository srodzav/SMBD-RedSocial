﻿namespace RedSocial
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
            this.SuspendLayout();
            // 
            // btnPersona
            // 
            this.btnPersona.Location = new System.Drawing.Point(12, 12);
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
            this.btnAmigo.Name = "btnAmigo";
            this.btnAmigo.Size = new System.Drawing.Size(129, 58);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnNotificacion);
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
    }
}

