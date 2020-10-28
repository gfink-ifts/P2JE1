namespace Equipo1
{
    partial class PRODUCTOS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gb_Campos = new System.Windows.Forms.GroupBox();
            this.gb_editarCiudad = new System.Windows.Forms.GroupBox();
            this.cbo_ciudad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_precioCiudad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_modificaAgrega = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_precioPais = new System.Windows.Forms.TextBox();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.chk_modificar = new System.Windows.Forms.CheckBox();
            this.cbo_Pais = new System.Windows.Forms.ComboBox();
            this.gb_nuevasCiudades = new System.Windows.Forms.GroupBox();
            this.txt_precioCiudad3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_precioCiudad2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_precioCiudad1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_ciudad3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ciudad2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ciudad1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_Campos.SuspendLayout();
            this.gb_editarCiudad.SuspendLayout();
            this.gb_nuevasCiudades.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destinos :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 373);
            this.dataGridView1.TabIndex = 0;
            // 
            // gb_Campos
            // 
            this.gb_Campos.Controls.Add(this.gb_editarCiudad);
            this.gb_Campos.Controls.Add(this.label4);
            this.gb_Campos.Controls.Add(this.label2);
            this.gb_Campos.Controls.Add(this.btn_modificaAgrega);
            this.gb_Campos.Controls.Add(this.label1);
            this.gb_Campos.Controls.Add(this.txt_precioPais);
            this.gb_Campos.Controls.Add(this.txt_pais);
            this.gb_Campos.Controls.Add(this.chk_modificar);
            this.gb_Campos.Controls.Add(this.cbo_Pais);
            this.gb_Campos.Controls.Add(this.gb_nuevasCiudades);
            this.gb_Campos.Location = new System.Drawing.Point(490, 12);
            this.gb_Campos.Name = "gb_Campos";
            this.gb_Campos.Size = new System.Drawing.Size(334, 403);
            this.gb_Campos.TabIndex = 1;
            this.gb_Campos.TabStop = false;
            this.gb_Campos.Text = "Edición de Campos :";
            // 
            // gb_editarCiudad
            // 
            this.gb_editarCiudad.Controls.Add(this.cbo_ciudad);
            this.gb_editarCiudad.Controls.Add(this.label3);
            this.gb_editarCiudad.Controls.Add(this.txt_precioCiudad);
            this.gb_editarCiudad.Controls.Add(this.label5);
            this.gb_editarCiudad.Location = new System.Drawing.Point(6, 120);
            this.gb_editarCiudad.Name = "gb_editarCiudad";
            this.gb_editarCiudad.Size = new System.Drawing.Size(314, 95);
            this.gb_editarCiudad.TabIndex = 17;
            this.gb_editarCiudad.TabStop = false;
            this.gb_editarCiudad.Text = "Editar Ciudad";
            // 
            // cbo_ciudad
            // 
            this.cbo_ciudad.FormattingEnabled = true;
            this.cbo_ciudad.Location = new System.Drawing.Point(55, 45);
            this.cbo_ciudad.Name = "cbo_ciudad";
            this.cbo_ciudad.Size = new System.Drawing.Size(121, 21);
            this.cbo_ciudad.TabIndex = 10;
            this.cbo_ciudad.SelectionChangeCommitted += new System.EventHandler(this.cbo_ciudad_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ciudad :";
            // 
            // txt_precioCiudad
            // 
            this.txt_precioCiudad.Location = new System.Drawing.Point(247, 45);
            this.txt_precioCiudad.Name = "txt_precioCiudad";
            this.txt_precioCiudad.Size = new System.Drawing.Size(49, 20);
            this.txt_precioCiudad.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Precio :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Pais :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Precio :";
            // 
            // btn_modificaAgrega
            // 
            this.btn_modificaAgrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificaAgrega.Location = new System.Drawing.Point(48, 357);
            this.btn_modificaAgrega.Name = "btn_modificaAgrega";
            this.btn_modificaAgrega.Size = new System.Drawing.Size(238, 35);
            this.btn_modificaAgrega.TabIndex = 12;
            this.btn_modificaAgrega.Text = "Agregar Destino";
            this.btn_modificaAgrega.UseVisualStyleBackColor = true;
            this.btn_modificaAgrega.Click += new System.EventHandler(this.btn_modificaAgrega_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Destino :";
            // 
            // txt_precioPais
            // 
            this.txt_precioPais.Location = new System.Drawing.Point(253, 81);
            this.txt_precioPais.Name = "txt_precioPais";
            this.txt_precioPais.Size = new System.Drawing.Size(49, 20);
            this.txt_precioPais.TabIndex = 3;
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(61, 81);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(100, 20);
            this.txt_pais.TabIndex = 2;
            // 
            // chk_modificar
            // 
            this.chk_modificar.AutoSize = true;
            this.chk_modificar.Location = new System.Drawing.Point(9, 33);
            this.chk_modificar.Name = "chk_modificar";
            this.chk_modificar.Size = new System.Drawing.Size(69, 17);
            this.chk_modificar.TabIndex = 1;
            this.chk_modificar.Text = "Modificar";
            this.chk_modificar.UseVisualStyleBackColor = true;
            this.chk_modificar.CheckedChanged += new System.EventHandler(this.chk_modificar_CheckedChanged);
            // 
            // cbo_Pais
            // 
            this.cbo_Pais.FormattingEnabled = true;
            this.cbo_Pais.Location = new System.Drawing.Point(165, 31);
            this.cbo_Pais.Name = "cbo_Pais";
            this.cbo_Pais.Size = new System.Drawing.Size(121, 21);
            this.cbo_Pais.TabIndex = 0;
            this.cbo_Pais.SelectionChangeCommitted += new System.EventHandler(this.cbo_Pais_SelectionChangeCommitted);
            // 
            // gb_nuevasCiudades
            // 
            this.gb_nuevasCiudades.Controls.Add(this.txt_precioCiudad3);
            this.gb_nuevasCiudades.Controls.Add(this.txt_ciudad3);
            this.gb_nuevasCiudades.Controls.Add(this.label8);
            this.gb_nuevasCiudades.Controls.Add(this.label9);
            this.gb_nuevasCiudades.Controls.Add(this.txt_ciudad2);
            this.gb_nuevasCiudades.Controls.Add(this.label7);
            this.gb_nuevasCiudades.Controls.Add(this.txt_precioCiudad2);
            this.gb_nuevasCiudades.Controls.Add(this.txt_ciudad1);
            this.gb_nuevasCiudades.Controls.Add(this.label6);
            this.gb_nuevasCiudades.Controls.Add(this.label10);
            this.gb_nuevasCiudades.Controls.Add(this.label11);
            this.gb_nuevasCiudades.Controls.Add(this.txt_precioCiudad1);
            this.gb_nuevasCiudades.Location = new System.Drawing.Point(9, 221);
            this.gb_nuevasCiudades.Name = "gb_nuevasCiudades";
            this.gb_nuevasCiudades.Size = new System.Drawing.Size(311, 130);
            this.gb_nuevasCiudades.TabIndex = 16;
            this.gb_nuevasCiudades.TabStop = false;
            this.gb_nuevasCiudades.Text = "Crear Ciudades";
            // 
            // txt_precioCiudad3
            // 
            this.txt_precioCiudad3.Location = new System.Drawing.Point(253, 93);
            this.txt_precioCiudad3.Name = "txt_precioCiudad3";
            this.txt_precioCiudad3.Size = new System.Drawing.Size(49, 20);
            this.txt_precioCiudad3.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Precio 3 :";
            // 
            // txt_precioCiudad2
            // 
            this.txt_precioCiudad2.Location = new System.Drawing.Point(253, 58);
            this.txt_precioCiudad2.Name = "txt_precioCiudad2";
            this.txt_precioCiudad2.Size = new System.Drawing.Size(49, 20);
            this.txt_precioCiudad2.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(195, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Precio 2 :";
            // 
            // txt_precioCiudad1
            // 
            this.txt_precioCiudad1.Location = new System.Drawing.Point(253, 23);
            this.txt_precioCiudad1.Name = "txt_precioCiudad1";
            this.txt_precioCiudad1.Size = new System.Drawing.Size(49, 20);
            this.txt_precioCiudad1.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(195, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Precio 1 :";
            // 
            // txt_ciudad3
            // 
            this.txt_ciudad3.Location = new System.Drawing.Point(67, 93);
            this.txt_ciudad3.Name = "txt_ciudad3";
            this.txt_ciudad3.Size = new System.Drawing.Size(100, 20);
            this.txt_ciudad3.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ciudad 3 :";
            // 
            // txt_ciudad2
            // 
            this.txt_ciudad2.Location = new System.Drawing.Point(67, 58);
            this.txt_ciudad2.Name = "txt_ciudad2";
            this.txt_ciudad2.Size = new System.Drawing.Size(100, 20);
            this.txt_ciudad2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ciudad 2 :";
            // 
            // txt_ciudad1
            // 
            this.txt_ciudad1.Location = new System.Drawing.Point(67, 23);
            this.txt_ciudad1.Name = "txt_ciudad1";
            this.txt_ciudad1.Size = new System.Drawing.Size(100, 20);
            this.txt_ciudad1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ciudad 1 :";
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(744, 436);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(80, 42);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // PRODUCTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 490);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.gb_Campos);
            this.Controls.Add(this.groupBox1);
            this.Name = "PRODUCTOS";
            this.Text = "PRODUCTOS";
            this.Load += new System.EventHandler(this.PRODUCTOS_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_Campos.ResumeLayout(false);
            this.gb_Campos.PerformLayout();
            this.gb_editarCiudad.ResumeLayout(false);
            this.gb_editarCiudad.PerformLayout();
            this.gb_nuevasCiudades.ResumeLayout(false);
            this.gb_nuevasCiudades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gb_Campos;
        private System.Windows.Forms.Button btn_modificaAgrega;
        private System.Windows.Forms.ComboBox cbo_ciudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_precioPais;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.CheckBox chk_modificar;
        private System.Windows.Forms.ComboBox cbo_Pais;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_precioCiudad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gb_nuevasCiudades;
        private System.Windows.Forms.GroupBox gb_editarCiudad;
        private System.Windows.Forms.TextBox txt_precioCiudad3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_precioCiudad2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_precioCiudad1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_ciudad3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ciudad2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ciudad1;
        private System.Windows.Forms.Label label6;
    }
}