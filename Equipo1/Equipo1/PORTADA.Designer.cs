﻿namespace Equipo1
{
    partial class PORTADA
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
            this.btn_Agre_o_Mod_Cliente = new System.Windows.Forms.Button();
            this.btn_Agr_o_Mod_Produ = new System.Windows.Forms.Button();
            this.btn_Agre_o_Modi_Ventas = new System.Windows.Forms.Button();
            this.btn_Consultas = new System.Windows.Forms.Button();
            this.gru_Viajes = new System.Windows.Forms.GroupBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_vendedores = new System.Windows.Forms.Button();
            this.gru_Viajes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Agre_o_Mod_Cliente
            // 
            this.btn_Agre_o_Mod_Cliente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Agre_o_Mod_Cliente.Location = new System.Drawing.Point(35, 35);
            this.btn_Agre_o_Mod_Cliente.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Agre_o_Mod_Cliente.Name = "btn_Agre_o_Mod_Cliente";
            this.btn_Agre_o_Mod_Cliente.Size = new System.Drawing.Size(139, 45);
            this.btn_Agre_o_Mod_Cliente.TabIndex = 0;
            this.btn_Agre_o_Mod_Cliente.Text = "CLIENTE";
            this.btn_Agre_o_Mod_Cliente.UseVisualStyleBackColor = true;
            this.btn_Agre_o_Mod_Cliente.Click += new System.EventHandler(this.btn_git_Click);
            // 
            // btn_Agr_o_Mod_Produ
            // 
            this.btn_Agr_o_Mod_Produ.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Agr_o_Mod_Produ.Location = new System.Drawing.Point(35, 192);
            this.btn_Agr_o_Mod_Produ.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Agr_o_Mod_Produ.Name = "btn_Agr_o_Mod_Produ";
            this.btn_Agr_o_Mod_Produ.Size = new System.Drawing.Size(139, 45);
            this.btn_Agr_o_Mod_Produ.TabIndex = 1;
            this.btn_Agr_o_Mod_Produ.Text = "PRODUCTO";
            this.btn_Agr_o_Mod_Produ.UseVisualStyleBackColor = true;
            this.btn_Agr_o_Mod_Produ.Click += new System.EventHandler(this.btn_Agr_o_Mod_Produ_Click);
            // 
            // btn_Agre_o_Modi_Ventas
            // 
            this.btn_Agre_o_Modi_Ventas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Agre_o_Modi_Ventas.Location = new System.Drawing.Point(310, 35);
            this.btn_Agre_o_Modi_Ventas.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Agre_o_Modi_Ventas.Name = "btn_Agre_o_Modi_Ventas";
            this.btn_Agre_o_Modi_Ventas.Size = new System.Drawing.Size(139, 45);
            this.btn_Agre_o_Modi_Ventas.TabIndex = 2;
            this.btn_Agre_o_Modi_Ventas.Text = "VENTAS";
            this.btn_Agre_o_Modi_Ventas.UseVisualStyleBackColor = true;
            this.btn_Agre_o_Modi_Ventas.Click += new System.EventHandler(this.btn_Agre_o_Modi_Ventas_Click);
            // 
            // btn_Consultas
            // 
            this.btn_Consultas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Consultas.Location = new System.Drawing.Point(310, 192);
            this.btn_Consultas.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Consultas.Name = "btn_Consultas";
            this.btn_Consultas.Size = new System.Drawing.Size(139, 45);
            this.btn_Consultas.TabIndex = 3;
            this.btn_Consultas.Text = "CONSULTAS";
            this.btn_Consultas.UseVisualStyleBackColor = true;
            this.btn_Consultas.Click += new System.EventHandler(this.btn_Consultas_Click);
            // 
            // gru_Viajes
            // 
            this.gru_Viajes.Controls.Add(this.btn_vendedores);
            this.gru_Viajes.Controls.Add(this.btn_Consultas);
            this.gru_Viajes.Controls.Add(this.btn_Agre_o_Modi_Ventas);
            this.gru_Viajes.Controls.Add(this.btn_Agr_o_Mod_Produ);
            this.gru_Viajes.Controls.Add(this.btn_Agre_o_Mod_Cliente);
            this.gru_Viajes.Location = new System.Drawing.Point(27, 12);
            this.gru_Viajes.Name = "gru_Viajes";
            this.gru_Viajes.Size = new System.Drawing.Size(482, 268);
            this.gru_Viajes.TabIndex = 4;
            this.gru_Viajes.TabStop = false;
            this.gru_Viajes.Text = "                                                           AGENCIA DE VIAJES";
            // 
            // btn_Salir
            // 
            this.btn_Salir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Salir.Location = new System.Drawing.Point(192, 286);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(149, 31);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "CERRAR APLICACIÓN";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_vendedores
            // 
            this.btn_vendedores.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_vendedores.Location = new System.Drawing.Point(172, 112);
            this.btn_vendedores.Margin = new System.Windows.Forms.Padding(2);
            this.btn_vendedores.Name = "btn_vendedores";
            this.btn_vendedores.Size = new System.Drawing.Size(139, 45);
            this.btn_vendedores.TabIndex = 4;
            this.btn_vendedores.Text = "VENDEDORES";
            this.btn_vendedores.UseVisualStyleBackColor = true;
            this.btn_vendedores.Click += new System.EventHandler(this.btn_vendedores_Click);
            // 
            // PORTADA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 329);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.gru_Viajes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PORTADA";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gru_Viajes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Agre_o_Mod_Cliente;
        private System.Windows.Forms.Button btn_Agr_o_Mod_Produ;
        private System.Windows.Forms.Button btn_Agre_o_Modi_Ventas;
        private System.Windows.Forms.Button btn_Consultas;
        private System.Windows.Forms.GroupBox gru_Viajes;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_vendedores;
    }
}

