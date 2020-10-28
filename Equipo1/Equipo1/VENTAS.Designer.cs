namespace Equipo1
{
    partial class VENTAS
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
            this.dataGrid_Venta_Nueva = new System.Windows.Forms.DataGridView();
            this.btn_Nueva_Venta = new System.Windows.Forms.Button();
            this.cbo_Clientes = new System.Windows.Forms.ComboBox();
            this.cbo_PAIS = new System.Windows.Forms.ComboBox();
            this.cbo_VENDEDOR = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupVentas = new System.Windows.Forms.GroupBox();
            this.groupDESTINO = new System.Windows.Forms.GroupBox();
            this.txt_cant_ciudades = new System.Windows.Forms.Label();
            this.txt_Cantidad_Ciudades = new System.Windows.Forms.TextBox();
            this.btn_carga = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_cant_PERS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGrid_ventasGeneral = new System.Windows.Forms.DataGridView();
            this.gru_consulta_ventas = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_orden = new System.Windows.Forms.ComboBox();
            this.btn_Ver_Ventas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_fechaalta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Venta_Nueva)).BeginInit();
            this.groupVentas.SuspendLayout();
            this.groupDESTINO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ventasGeneral)).BeginInit();
            this.gru_consulta_ventas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid_Venta_Nueva
            // 
            this.dataGrid_Venta_Nueva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Venta_Nueva.Location = new System.Drawing.Point(12, 138);
            this.dataGrid_Venta_Nueva.Name = "dataGrid_Venta_Nueva";
            this.dataGrid_Venta_Nueva.Size = new System.Drawing.Size(759, 67);
            this.dataGrid_Venta_Nueva.TabIndex = 0;
            // 
            // btn_Nueva_Venta
            // 
            this.btn_Nueva_Venta.Location = new System.Drawing.Point(6, 19);
            this.btn_Nueva_Venta.Name = "btn_Nueva_Venta";
            this.btn_Nueva_Venta.Size = new System.Drawing.Size(97, 30);
            this.btn_Nueva_Venta.TabIndex = 1;
            this.btn_Nueva_Venta.Text = "NUEVA VENTA";
            this.btn_Nueva_Venta.UseVisualStyleBackColor = true;
            this.btn_Nueva_Venta.Click += new System.EventHandler(this.btn_Nueva_Venta_Click);
            // 
            // cbo_Clientes
            // 
            this.cbo_Clientes.FormattingEnabled = true;
            this.cbo_Clientes.Location = new System.Drawing.Point(83, 6);
            this.cbo_Clientes.Name = "cbo_Clientes";
            this.cbo_Clientes.Size = new System.Drawing.Size(123, 21);
            this.cbo_Clientes.TabIndex = 4;
            // 
            // cbo_PAIS
            // 
            this.cbo_PAIS.FormattingEnabled = true;
            this.cbo_PAIS.Location = new System.Drawing.Point(106, 24);
            this.cbo_PAIS.Name = "cbo_PAIS";
            this.cbo_PAIS.Size = new System.Drawing.Size(123, 21);
            this.cbo_PAIS.TabIndex = 5;
            this.cbo_PAIS.SelectionChangeCommitted += new System.EventHandler(this.cbo_PAIS_SelectionChangeCommitted);
            // 
            // cbo_VENDEDOR
            // 
            this.cbo_VENDEDOR.FormattingEnabled = true;
            this.cbo_VENDEDOR.Location = new System.Drawing.Point(139, 40);
            this.cbo_VENDEDOR.Name = "cbo_VENDEDOR";
            this.cbo_VENDEDOR.Size = new System.Drawing.Size(123, 21);
            this.cbo_VENDEDOR.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "VENDEDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "PAIS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "CLIENTE";
            // 
            // groupVentas
            // 
            this.groupVentas.Controls.Add(this.groupDESTINO);
            this.groupVentas.Controls.Add(this.txt_cant_PERS);
            this.groupVentas.Controls.Add(this.label4);
            this.groupVentas.Controls.Add(this.label1);
            this.groupVentas.Controls.Add(this.cbo_VENDEDOR);
            this.groupVentas.Controls.Add(this.btn_Nueva_Venta);
            this.groupVentas.Location = new System.Drawing.Point(28, 33);
            this.groupVentas.Name = "groupVentas";
            this.groupVentas.Size = new System.Drawing.Size(734, 99);
            this.groupVentas.TabIndex = 10;
            this.groupVentas.TabStop = false;
            this.groupVentas.Text = "VENTAS";
            // 
            // groupDESTINO
            // 
            this.groupDESTINO.Controls.Add(this.txt_cant_ciudades);
            this.groupDESTINO.Controls.Add(this.txt_Cantidad_Ciudades);
            this.groupDESTINO.Controls.Add(this.btn_carga);
            this.groupDESTINO.Controls.Add(this.checkBox3);
            this.groupDESTINO.Controls.Add(this.checkBox2);
            this.groupDESTINO.Controls.Add(this.checkBox1);
            this.groupDESTINO.Controls.Add(this.label2);
            this.groupDESTINO.Controls.Add(this.cbo_PAIS);
            this.groupDESTINO.Location = new System.Drawing.Point(281, 9);
            this.groupDESTINO.Name = "groupDESTINO";
            this.groupDESTINO.Size = new System.Drawing.Size(334, 84);
            this.groupDESTINO.TabIndex = 17;
            this.groupDESTINO.TabStop = false;
            this.groupDESTINO.Text = "DESTINO";
            // 
            // txt_cant_ciudades
            // 
            this.txt_cant_ciudades.AutoSize = true;
            this.txt_cant_ciudades.Location = new System.Drawing.Point(234, 39);
            this.txt_cant_ciudades.Name = "txt_cant_ciudades";
            this.txt_cant_ciudades.Size = new System.Drawing.Size(65, 13);
            this.txt_cant_ciudades.TabIndex = 19;
            this.txt_cant_ciudades.Text = "CANTIDAD:";
            // 
            // txt_Cantidad_Ciudades
            // 
            this.txt_Cantidad_Ciudades.Location = new System.Drawing.Point(302, 35);
            this.txt_Cantidad_Ciudades.Name = "txt_Cantidad_Ciudades";
            this.txt_Cantidad_Ciudades.Size = new System.Drawing.Size(26, 20);
            this.txt_Cantidad_Ciudades.TabIndex = 18;
            // 
            // btn_carga
            // 
            this.btn_carga.Location = new System.Drawing.Point(263, 9);
            this.btn_carga.Name = "btn_carga";
            this.btn_carga.Size = new System.Drawing.Size(71, 24);
            this.btn_carga.TabIndex = 17;
            this.btn_carga.Text = "CARGA";
            this.btn_carga.UseVisualStyleBackColor = true;
            this.btn_carga.Click += new System.EventHandler(this.btn_carga_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(248, 61);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(135, 61);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 61);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txt_cant_PERS
            // 
            this.txt_cant_PERS.Location = new System.Drawing.Point(634, 41);
            this.txt_cant_PERS.Name = "txt_cant_PERS";
            this.txt_cant_PERS.Size = new System.Drawing.Size(80, 20);
            this.txt_cant_PERS.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CANTIDAD";
            // 
            // dataGrid_ventasGeneral
            // 
            this.dataGrid_ventasGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_ventasGeneral.Location = new System.Drawing.Point(12, 49);
            this.dataGrid_ventasGeneral.Name = "dataGrid_ventasGeneral";
            this.dataGrid_ventasGeneral.Size = new System.Drawing.Size(759, 145);
            this.dataGrid_ventasGeneral.TabIndex = 11;
            // 
            // gru_consulta_ventas
            // 
            this.gru_consulta_ventas.Controls.Add(this.label5);
            this.gru_consulta_ventas.Controls.Add(this.cbo_orden);
            this.gru_consulta_ventas.Controls.Add(this.btn_Ver_Ventas);
            this.gru_consulta_ventas.Controls.Add(this.dataGrid_ventasGeneral);
            this.gru_consulta_ventas.Location = new System.Drawing.Point(0, 216);
            this.gru_consulta_ventas.Name = "gru_consulta_ventas";
            this.gru_consulta_ventas.Size = new System.Drawing.Size(798, 208);
            this.gru_consulta_ventas.TabIndex = 12;
            this.gru_consulta_ventas.TabStop = false;
            this.gru_consulta_ventas.Text = "VENTAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "ORDENAR";
            // 
            // cbo_orden
            // 
            this.cbo_orden.FormattingEnabled = true;
            this.cbo_orden.Location = new System.Drawing.Point(521, 19);
            this.cbo_orden.Name = "cbo_orden";
            this.cbo_orden.Size = new System.Drawing.Size(134, 21);
            this.cbo_orden.TabIndex = 15;
            this.cbo_orden.SelectionChangeCommitted += new System.EventHandler(this.cbo_orden_SelectionChangeCommitted);
            // 
            // btn_Ver_Ventas
            // 
            this.btn_Ver_Ventas.Location = new System.Drawing.Point(73, 19);
            this.btn_Ver_Ventas.Name = "btn_Ver_Ventas";
            this.btn_Ver_Ventas.Size = new System.Drawing.Size(99, 21);
            this.btn_Ver_Ventas.TabIndex = 14;
            this.btn_Ver_Ventas.Text = "TOTAL VENTAS";
            this.btn_Ver_Ventas.UseVisualStyleBackColor = true;
            this.btn_Ver_Ventas.Click += new System.EventHandler(this.btn_Ver_Ventas_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 21);
            this.button1.TabIndex = 13;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(752, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(19, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txt_fechaalta
            // 
            this.txt_fechaalta.Location = new System.Drawing.Point(662, 6);
            this.txt_fechaalta.Name = "txt_fechaalta";
            this.txt_fechaalta.Size = new System.Drawing.Size(84, 20);
            this.txt_fechaalta.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // VENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_fechaalta);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gru_consulta_ventas);
            this.Controls.Add(this.groupVentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_Clientes);
            this.Controls.Add(this.dataGrid_Venta_Nueva);
            this.Name = "VENTAS";
            this.Text = "VENTAS";
            this.Load += new System.EventHandler(this.VENTAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Venta_Nueva)).EndInit();
            this.groupVentas.ResumeLayout(false);
            this.groupVentas.PerformLayout();
            this.groupDESTINO.ResumeLayout(false);
            this.groupDESTINO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ventasGeneral)).EndInit();
            this.gru_consulta_ventas.ResumeLayout(false);
            this.gru_consulta_ventas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_Venta_Nueva;
        private System.Windows.Forms.Button btn_Nueva_Venta;
        private System.Windows.Forms.ComboBox cbo_Clientes;
        private System.Windows.Forms.ComboBox cbo_PAIS;
        private System.Windows.Forms.ComboBox cbo_VENDEDOR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupVentas;
        private System.Windows.Forms.TextBox txt_cant_PERS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGrid_ventasGeneral;
        private System.Windows.Forms.GroupBox gru_consulta_ventas;
        private System.Windows.Forms.Button btn_Ver_Ventas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_orden;
        private System.Windows.Forms.GroupBox groupDESTINO;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_fechaalta;
        private System.Windows.Forms.Button btn_carga;
        private System.Windows.Forms.Label txt_cant_ciudades;
        private System.Windows.Forms.TextBox txt_Cantidad_Ciudades;
        private System.Windows.Forms.Label label6;
    }
}