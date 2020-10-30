namespace Equipo1
{
    partial class CONSULTAS
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
            this.gb_Vendedores = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGrid_Vendedores = new System.Windows.Forms.DataGridView();
            this.gb_vendedoresResul = new System.Windows.Forms.GroupBox();
            this.lbl_totalVendido = new System.Windows.Forms.Label();
            this.lbl_vendeMejorNombre = new System.Windows.Forms.Label();
            this.lbl_nueroVentas = new System.Windows.Forms.Label();
            this.lbl_vendeMejorMonto = new System.Windows.Forms.Label();
            this.lbl_vendePromMonto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb_unVendedor = new System.Windows.Forms.RadioButton();
            this.rdb_todos = new System.Windows.Forms.RadioButton();
            this.cbo_vendedor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_destinos = new System.Windows.Forms.GroupBox();
            this.dataGridDestinos = new System.Windows.Forms.DataGridView();
            this.gb_destinosResul = new System.Windows.Forms.GroupBox();
            this.lbl_paisMejorNombre = new System.Windows.Forms.Label();
            this.lbl_ciudadMenos = new System.Windows.Forms.Label();
            this.lbl_paisMejorMonto = new System.Windows.Forms.Label();
            this.lbl_ciudadMas = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbo_años = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdb_todasCiudades = new System.Windows.Forms.RadioButton();
            this.rdb_unaCiudad = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_Vendedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Vendedores)).BeginInit();
            this.gb_vendedoresResul.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_destinos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDestinos)).BeginInit();
            this.gb_destinosResul.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Vendedores
            // 
            this.gb_Vendedores.Controls.Add(this.label17);
            this.gb_Vendedores.Controls.Add(this.dataGrid_Vendedores);
            this.gb_Vendedores.Controls.Add(this.gb_vendedoresResul);
            this.gb_Vendedores.Controls.Add(this.label4);
            this.gb_Vendedores.Controls.Add(this.label3);
            this.gb_Vendedores.Controls.Add(this.label2);
            this.gb_Vendedores.Controls.Add(this.label1);
            this.gb_Vendedores.Location = new System.Drawing.Point(12, 132);
            this.gb_Vendedores.Name = "gb_Vendedores";
            this.gb_Vendedores.Size = new System.Drawing.Size(455, 344);
            this.gb_Vendedores.TabIndex = 0;
            this.gb_Vendedores.TabStop = false;
            this.gb_Vendedores.Text = "Vendedores :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(250, 191);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Venta Acumulada :";
            // 
            // dataGrid_Vendedores
            // 
            this.dataGrid_Vendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Vendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Vendedores.Location = new System.Drawing.Point(6, 19);
            this.dataGrid_Vendedores.Name = "dataGrid_Vendedores";
            this.dataGrid_Vendedores.ReadOnly = true;
            this.dataGrid_Vendedores.Size = new System.Drawing.Size(232, 319);
            this.dataGrid_Vendedores.TabIndex = 11;
            // 
            // gb_vendedoresResul
            // 
            this.gb_vendedoresResul.Controls.Add(this.lbl_totalVendido);
            this.gb_vendedoresResul.Controls.Add(this.lbl_vendeMejorNombre);
            this.gb_vendedoresResul.Controls.Add(this.lbl_nueroVentas);
            this.gb_vendedoresResul.Controls.Add(this.lbl_vendeMejorMonto);
            this.gb_vendedoresResul.Controls.Add(this.lbl_vendePromMonto);
            this.gb_vendedoresResul.Location = new System.Drawing.Point(353, 9);
            this.gb_vendedoresResul.Name = "gb_vendedoresResul";
            this.gb_vendedoresResul.Size = new System.Drawing.Size(96, 265);
            this.gb_vendedoresResul.TabIndex = 11;
            this.gb_vendedoresResul.TabStop = false;
            // 
            // lbl_totalVendido
            // 
            this.lbl_totalVendido.AutoSize = true;
            this.lbl_totalVendido.Location = new System.Drawing.Point(6, 182);
            this.lbl_totalVendido.Name = "lbl_totalVendido";
            this.lbl_totalVendido.Size = new System.Drawing.Size(43, 13);
            this.lbl_totalVendido.TabIndex = 13;
            this.lbl_totalVendido.Text = "$ Acum";
            // 
            // lbl_vendeMejorNombre
            // 
            this.lbl_vendeMejorNombre.AutoSize = true;
            this.lbl_vendeMejorNombre.Location = new System.Drawing.Point(6, 35);
            this.lbl_vendeMejorNombre.Name = "lbl_vendeMejorNombre";
            this.lbl_vendeMejorNombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_vendeMejorNombre.TabIndex = 7;
            this.lbl_vendeMejorNombre.Text = "Nombre";
            // 
            // lbl_nueroVentas
            // 
            this.lbl_nueroVentas.AutoSize = true;
            this.lbl_nueroVentas.Location = new System.Drawing.Point(6, 146);
            this.lbl_nueroVentas.Name = "lbl_nueroVentas";
            this.lbl_nueroVentas.Size = new System.Drawing.Size(59, 13);
            this.lbl_nueroVentas.TabIndex = 10;
            this.lbl_nueroVentas.Text = "Nro ventas";
            // 
            // lbl_vendeMejorMonto
            // 
            this.lbl_vendeMejorMonto.AutoSize = true;
            this.lbl_vendeMejorMonto.Location = new System.Drawing.Point(6, 72);
            this.lbl_vendeMejorMonto.Name = "lbl_vendeMejorMonto";
            this.lbl_vendeMejorMonto.Size = new System.Drawing.Size(36, 13);
            this.lbl_vendeMejorMonto.TabIndex = 8;
            this.lbl_vendeMejorMonto.Text = "Max $";
            // 
            // lbl_vendePromMonto
            // 
            this.lbl_vendePromMonto.AutoSize = true;
            this.lbl_vendePromMonto.Location = new System.Drawing.Point(6, 109);
            this.lbl_vendePromMonto.Name = "lbl_vendePromMonto";
            this.lbl_vendePromMonto.Size = new System.Drawing.Size(40, 13);
            this.lbl_vendePromMonto.TabIndex = 9;
            this.lbl_vendePromMonto.Text = "Prom $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ventas Realizadas :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Promedio de Venta :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Record de Venta :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mejor Vendedor :";
            // 
            // rdb_unVendedor
            // 
            this.rdb_unVendedor.AutoSize = true;
            this.rdb_unVendedor.Location = new System.Drawing.Point(95, 32);
            this.rdb_unVendedor.Name = "rdb_unVendedor";
            this.rdb_unVendedor.Size = new System.Drawing.Size(77, 17);
            this.rdb_unVendedor.TabIndex = 0;
            this.rdb_unVendedor.TabStop = true;
            this.rdb_unVendedor.Text = "Vendedor :";
            this.rdb_unVendedor.UseVisualStyleBackColor = true;
            this.rdb_unVendedor.CheckedChanged += new System.EventHandler(this.rdb_unVendedor_CheckedChanged);
            // 
            // rdb_todos
            // 
            this.rdb_todos.AutoSize = true;
            this.rdb_todos.Location = new System.Drawing.Point(95, 67);
            this.rdb_todos.Name = "rdb_todos";
            this.rdb_todos.Size = new System.Drawing.Size(55, 17);
            this.rdb_todos.TabIndex = 1;
            this.rdb_todos.TabStop = true;
            this.rdb_todos.Text = "Todos";
            this.rdb_todos.UseVisualStyleBackColor = true;
            // 
            // cbo_vendedor
            // 
            this.cbo_vendedor.FormattingEnabled = true;
            this.cbo_vendedor.Location = new System.Drawing.Point(200, 31);
            this.cbo_vendedor.Name = "cbo_vendedor";
            this.cbo_vendedor.Size = new System.Drawing.Size(121, 21);
            this.cbo_vendedor.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_unVendedor);
            this.groupBox1.Controls.Add(this.cbo_vendedor);
            this.groupBox1.Controls.Add(this.rdb_todos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 114);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrado de Ventas:";
            // 
            // gb_destinos
            // 
            this.gb_destinos.Controls.Add(this.dataGridDestinos);
            this.gb_destinos.Controls.Add(this.gb_destinosResul);
            this.gb_destinos.Controls.Add(this.label13);
            this.gb_destinos.Controls.Add(this.label14);
            this.gb_destinos.Controls.Add(this.label15);
            this.gb_destinos.Controls.Add(this.label16);
            this.gb_destinos.Location = new System.Drawing.Point(473, 132);
            this.gb_destinos.Name = "gb_destinos";
            this.gb_destinos.Size = new System.Drawing.Size(458, 344);
            this.gb_destinos.TabIndex = 12;
            this.gb_destinos.TabStop = false;
            this.gb_destinos.Text = "Destinos :";
            // 
            // dataGridDestinos
            // 
            this.dataGridDestinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDestinos.Location = new System.Drawing.Point(6, 19);
            this.dataGridDestinos.Name = "dataGridDestinos";
            this.dataGridDestinos.Size = new System.Drawing.Size(232, 319);
            this.dataGridDestinos.TabIndex = 11;
            // 
            // gb_destinosResul
            // 
            this.gb_destinosResul.Controls.Add(this.lbl_paisMejorNombre);
            this.gb_destinosResul.Controls.Add(this.lbl_ciudadMenos);
            this.gb_destinosResul.Controls.Add(this.lbl_paisMejorMonto);
            this.gb_destinosResul.Controls.Add(this.lbl_ciudadMas);
            this.gb_destinosResul.Location = new System.Drawing.Point(372, 9);
            this.gb_destinosResul.Name = "gb_destinosResul";
            this.gb_destinosResul.Size = new System.Drawing.Size(80, 265);
            this.gb_destinosResul.TabIndex = 11;
            this.gb_destinosResul.TabStop = false;
            // 
            // lbl_paisMejorNombre
            // 
            this.lbl_paisMejorNombre.AutoSize = true;
            this.lbl_paisMejorNombre.Location = new System.Drawing.Point(6, 35);
            this.lbl_paisMejorNombre.Name = "lbl_paisMejorNombre";
            this.lbl_paisMejorNombre.Size = new System.Drawing.Size(27, 13);
            this.lbl_paisMejorNombre.TabIndex = 7;
            this.lbl_paisMejorNombre.Text = "Pais";
            // 
            // lbl_ciudadMenos
            // 
            this.lbl_ciudadMenos.AutoSize = true;
            this.lbl_ciudadMenos.Location = new System.Drawing.Point(6, 146);
            this.lbl_ciudadMenos.Name = "lbl_ciudadMenos";
            this.lbl_ciudadMenos.Size = new System.Drawing.Size(40, 13);
            this.lbl_ciudadMenos.TabIndex = 10;
            this.lbl_ciudadMenos.Text = "Ciudad";
            // 
            // lbl_paisMejorMonto
            // 
            this.lbl_paisMejorMonto.AutoSize = true;
            this.lbl_paisMejorMonto.Location = new System.Drawing.Point(6, 72);
            this.lbl_paisMejorMonto.Name = "lbl_paisMejorMonto";
            this.lbl_paisMejorMonto.Size = new System.Drawing.Size(36, 13);
            this.lbl_paisMejorMonto.TabIndex = 8;
            this.lbl_paisMejorMonto.Text = "Max $";
            // 
            // lbl_ciudadMas
            // 
            this.lbl_ciudadMas.AutoSize = true;
            this.lbl_ciudadMas.Location = new System.Drawing.Point(6, 109);
            this.lbl_ciudadMas.Name = "lbl_ciudadMas";
            this.lbl_ciudadMas.Size = new System.Drawing.Size(40, 13);
            this.lbl_ciudadMas.TabIndex = 9;
            this.lbl_ciudadMas.Text = "Ciudad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(246, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Ciudad menos Visitada :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(285, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Mejor Vendido :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(270, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Mejor Vendido ($) :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(258, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Ciudad más Visitada :";
            // 
            // cbo_años
            // 
            this.cbo_años.FormattingEnabled = true;
            this.cbo_años.Location = new System.Drawing.Point(174, 31);
            this.cbo_años.Name = "cbo_años";
            this.cbo_años.Size = new System.Drawing.Size(109, 21);
            this.cbo_años.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdb_todasCiudades);
            this.groupBox5.Controls.Add(this.cbo_años);
            this.groupBox5.Controls.Add(this.rdb_unaCiudad);
            this.groupBox5.Location = new System.Drawing.Point(473, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(314, 114);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filtrado por Ciudad :";
            // 
            // rdb_todasCiudades
            // 
            this.rdb_todasCiudades.AutoSize = true;
            this.rdb_todasCiudades.Location = new System.Drawing.Point(24, 67);
            this.rdb_todasCiudades.Name = "rdb_todasCiudades";
            this.rdb_todasCiudades.Size = new System.Drawing.Size(118, 17);
            this.rdb_todasCiudades.TabIndex = 1;
            this.rdb_todasCiudades.TabStop = true;
            this.rdb_todasCiudades.Text = "Todos las Ciudades";
            this.rdb_todasCiudades.UseVisualStyleBackColor = true;
            // 
            // rdb_unaCiudad
            // 
            this.rdb_unaCiudad.AutoSize = true;
            this.rdb_unaCiudad.Location = new System.Drawing.Point(24, 32);
            this.rdb_unaCiudad.Name = "rdb_unaCiudad";
            this.rdb_unaCiudad.Size = new System.Drawing.Size(144, 17);
            this.rdb_unaCiudad.TabIndex = 0;
            this.rdb_unaCiudad.TabStop = true;
            this.rdb_unaCiudad.Text = "Seleccionar una Ciudad :";
            this.rdb_unaCiudad.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(810, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cerrar\r\nConsultas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CONSULTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gb_destinos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_Vendedores);
            this.Name = "CONSULTAS";
            this.Text = "CONSULTAS";
            this.Load += new System.EventHandler(this.CONSULTAS_Load);
            this.gb_Vendedores.ResumeLayout(false);
            this.gb_Vendedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Vendedores)).EndInit();
            this.gb_vendedoresResul.ResumeLayout(false);
            this.gb_vendedoresResul.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_destinos.ResumeLayout(false);
            this.gb_destinos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDestinos)).EndInit();
            this.gb_destinosResul.ResumeLayout(false);
            this.gb_destinosResul.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Vendedores;
        private System.Windows.Forms.DataGridView dataGrid_Vendedores;
        private System.Windows.Forms.GroupBox gb_vendedoresResul;
        private System.Windows.Forms.Label lbl_vendeMejorNombre;
        private System.Windows.Forms.Label lbl_nueroVentas;
        private System.Windows.Forms.Label lbl_vendeMejorMonto;
        private System.Windows.Forms.Label lbl_vendePromMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb_unVendedor;
        private System.Windows.Forms.RadioButton rdb_todos;
        private System.Windows.Forms.ComboBox cbo_vendedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gb_destinos;
        private System.Windows.Forms.DataGridView dataGridDestinos;
        private System.Windows.Forms.GroupBox gb_destinosResul;
        private System.Windows.Forms.Label lbl_paisMejorNombre;
        private System.Windows.Forms.Label lbl_ciudadMenos;
        private System.Windows.Forms.Label lbl_paisMejorMonto;
        private System.Windows.Forms.Label lbl_ciudadMas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbo_años;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdb_todasCiudades;
        private System.Windows.Forms.RadioButton rdb_unaCiudad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_totalVendido;
    }
}