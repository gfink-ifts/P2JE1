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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_precioCiudad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_modificaAgrega = new System.Windows.Forms.Button();
            this.chk_nuevaCiudad = new System.Windows.Forms.CheckBox();
            this.cbo_ciudad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ciudadNew = new System.Windows.Forms.TextBox();
            this.txt_precioPais = new System.Windows.Forms.TextBox();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.chk_modificar = new System.Windows.Forms.CheckBox();
            this.cbo_Pais = new System.Windows.Forms.ComboBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destinos :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(482, 329);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_precioCiudad);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_modificaAgrega);
            this.groupBox2.Controls.Add(this.chk_nuevaCiudad);
            this.groupBox2.Controls.Add(this.cbo_ciudad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_ciudadNew);
            this.groupBox2.Controls.Add(this.txt_precioPais);
            this.groupBox2.Controls.Add(this.txt_pais);
            this.groupBox2.Controls.Add(this.chk_modificar);
            this.groupBox2.Controls.Add(this.cbo_Pais);
            this.groupBox2.Location = new System.Drawing.Point(511, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 354);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edición de Campos :";
            // 
            // txt_precioCiudad
            // 
            this.txt_precioCiudad.Location = new System.Drawing.Point(182, 251);
            this.txt_precioCiudad.Name = "txt_precioCiudad";
            this.txt_precioCiudad.Size = new System.Drawing.Size(121, 20);
            this.txt_precioCiudad.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Precio :";
            // 
            // btn_modificaAgrega
            // 
            this.btn_modificaAgrega.Location = new System.Drawing.Point(31, 325);
            this.btn_modificaAgrega.Name = "btn_modificaAgrega";
            this.btn_modificaAgrega.Size = new System.Drawing.Size(272, 23);
            this.btn_modificaAgrega.TabIndex = 12;
            this.btn_modificaAgrega.Text = "Agregar Destino";
            this.btn_modificaAgrega.UseVisualStyleBackColor = true;
            // 
            // chk_nuevaCiudad
            // 
            this.chk_nuevaCiudad.AutoSize = true;
            this.chk_nuevaCiudad.Location = new System.Drawing.Point(6, 171);
            this.chk_nuevaCiudad.Name = "chk_nuevaCiudad";
            this.chk_nuevaCiudad.Size = new System.Drawing.Size(94, 17);
            this.chk_nuevaCiudad.TabIndex = 11;
            this.chk_nuevaCiudad.Text = "Nueva Ciudad";
            this.chk_nuevaCiudad.UseVisualStyleBackColor = true;
            this.chk_nuevaCiudad.CheckedChanged += new System.EventHandler(this.chk_nuevaCiudad_CheckedChanged);
            // 
            // cbo_ciudad
            // 
            this.cbo_ciudad.FormattingEnabled = true;
            this.cbo_ciudad.Location = new System.Drawing.Point(182, 169);
            this.cbo_ciudad.Name = "cbo_ciudad";
            this.cbo_ciudad.Size = new System.Drawing.Size(121, 21);
            this.cbo_ciudad.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nueva Ciudad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ciudad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Precio :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pais de Destino :";
            // 
            // txt_ciudadNew
            // 
            this.txt_ciudadNew.Location = new System.Drawing.Point(182, 210);
            this.txt_ciudadNew.Name = "txt_ciudadNew";
            this.txt_ciudadNew.Size = new System.Drawing.Size(121, 20);
            this.txt_ciudadNew.TabIndex = 5;
            // 
            // txt_precioPais
            // 
            this.txt_precioPais.Location = new System.Drawing.Point(182, 128);
            this.txt_precioPais.Name = "txt_precioPais";
            this.txt_precioPais.Size = new System.Drawing.Size(121, 20);
            this.txt_precioPais.TabIndex = 3;
            // 
            // txt_pais
            // 
            this.txt_pais.Location = new System.Drawing.Point(182, 87);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(121, 20);
            this.txt_pais.TabIndex = 2;
            // 
            // chk_modificar
            // 
            this.chk_modificar.AutoSize = true;
            this.chk_modificar.Location = new System.Drawing.Point(6, 34);
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
            this.cbo_Pais.Location = new System.Drawing.Point(182, 32);
            this.cbo_Pais.Name = "cbo_Pais";
            this.cbo_Pais.Size = new System.Drawing.Size(121, 21);
            this.cbo_Pais.TabIndex = 0;
            this.cbo_Pais.SelectionChangeCommitted += new System.EventHandler(this.cbo_Pais_SelectionChangeCommitted);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(749, 415);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // PRODUCTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PRODUCTOS";
            this.Text = "PRODUCTOS";
            this.Load += new System.EventHandler(this.PRODUCTOS_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_modificaAgrega;
        private System.Windows.Forms.CheckBox chk_nuevaCiudad;
        private System.Windows.Forms.ComboBox cbo_ciudad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ciudadNew;
        private System.Windows.Forms.TextBox txt_precioPais;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.CheckBox chk_modificar;
        private System.Windows.Forms.ComboBox cbo_Pais;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_precioCiudad;
        private System.Windows.Forms.Label label5;
    }
}