﻿namespace Equipo1
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
            this.btn_Nueva_Venta = new System.Windows.Forms.Button();
            this.cbo_Clientes = new System.Windows.Forms.ComboBox();
            this.cbo_PAIS = new System.Windows.Forms.ComboBox();
            this.cbo_VENDEDOR = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupVentas = new System.Windows.Forms.GroupBox();
            this.groupDESTINO = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
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
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_vendedor = new System.Windows.Forms.Label();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.lbl_pre = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_apellido_cliente = new System.Windows.Forms.Label();
            this.lbl_apelli_vende = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupVentas.SuspendLayout();
            this.groupDESTINO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ventasGeneral)).BeginInit();
            this.gru_consulta_ventas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupVentas.Enter += new System.EventHandler(this.groupVentas_Enter);
            // 
            // groupDESTINO
            // 
            this.groupDESTINO.Controls.Add(this.lbl_precio);
            this.groupDESTINO.Controls.Add(this.label6);
            this.groupDESTINO.Controls.Add(this.radioButton3);
            this.groupDESTINO.Controls.Add(this.radioButton2);
            this.groupDESTINO.Controls.Add(this.radioButton1);
            this.groupDESTINO.Controls.Add(this.label2);
            this.groupDESTINO.Controls.Add(this.cbo_PAIS);
            this.groupDESTINO.Location = new System.Drawing.Point(281, 9);
            this.groupDESTINO.Name = "groupDESTINO";
            this.groupDESTINO.Size = new System.Drawing.Size(334, 84);
            this.groupDESTINO.TabIndex = 17;
            this.groupDESTINO.TabStop = false;
            this.groupDESTINO.Text = "DESTINO";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(243, 61);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(134, 61);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 61);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
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
            this.dataGrid_ventasGeneral.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
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
            this.cbo_orden.Size = new System.Drawing.Size(181, 21);
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.label6.Location = new System.Drawing.Point(252, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "PRECIO";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(299, 27);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(35, 13);
            this.lbl_precio.TabIndex = 24;
            this.lbl_precio.Text = "label7";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Location = new System.Drawing.Point(70, 10);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(35, 13);
            this.lbl_cliente.TabIndex = 16;
            this.lbl_cliente.Text = "label7";
            // 
            // lbl_vendedor
            // 
            this.lbl_vendedor.AutoSize = true;
            this.lbl_vendedor.Location = new System.Drawing.Point(273, 10);
            this.lbl_vendedor.Name = "lbl_vendedor";
            this.lbl_vendedor.Size = new System.Drawing.Size(35, 13);
            this.lbl_vendedor.TabIndex = 17;
            this.lbl_vendedor.Text = "label8";
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Location = new System.Drawing.Point(467, 10);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(35, 13);
            this.lbl_pais.TabIndex = 18;
            this.lbl_pais.Text = "label9";
            // 
            // lbl_pre
            // 
            this.lbl_pre.AutoSize = true;
            this.lbl_pre.Location = new System.Drawing.Point(685, 10);
            this.lbl_pre.Name = "lbl_pre";
            this.lbl_pre.Size = new System.Drawing.Size(41, 13);
            this.lbl_pre.TabIndex = 19;
            this.lbl_pre.Text = "label10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "CLIENTE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "VENDEDOR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(418, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "PAIS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(595, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "PRECIO TOTAL";
            // 
            // lbl_apellido_cliente
            // 
            this.lbl_apellido_cliente.AutoSize = true;
            this.lbl_apellido_cliente.Location = new System.Drawing.Point(111, 10);
            this.lbl_apellido_cliente.Name = "lbl_apellido_cliente";
            this.lbl_apellido_cliente.Size = new System.Drawing.Size(41, 13);
            this.lbl_apellido_cliente.TabIndex = 24;
            this.lbl_apellido_cliente.Text = "label11";
            // 
            // lbl_apelli_vende
            // 
            this.lbl_apelli_vende.AutoSize = true;
            this.lbl_apelli_vende.Location = new System.Drawing.Point(323, 10);
            this.lbl_apelli_vende.Name = "lbl_apelli_vende";
            this.lbl_apelli_vende.Size = new System.Drawing.Size(41, 13);
            this.lbl_apelli_vende.TabIndex = 25;
            this.lbl_apelli_vende.Text = "label11";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.lbl_apelli_vende);
            this.groupBox1.Controls.Add(this.lbl_apellido_cliente);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_pre);
            this.groupBox1.Controls.Add(this.lbl_pais);
            this.groupBox1.Controls.Add(this.lbl_vendedor);
            this.groupBox1.Controls.Add(this.lbl_cliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 40);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // VENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_fechaalta);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gru_consulta_ventas);
            this.Controls.Add(this.groupVentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_Clientes);
            this.Name = "VENTAS";
            this.Text = "VENTAS";
            this.Load += new System.EventHandler(this.VENTAS_Load);
            this.groupVentas.ResumeLayout(false);
            this.groupVentas.PerformLayout();
            this.groupDESTINO.ResumeLayout(false);
            this.groupDESTINO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ventasGeneral)).EndInit();
            this.gru_consulta_ventas.ResumeLayout(false);
            this.gru_consulta_ventas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_fechaalta;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_vendedor;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.Label lbl_pre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_apellido_cliente;
        private System.Windows.Forms.Label lbl_apelli_vende;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}