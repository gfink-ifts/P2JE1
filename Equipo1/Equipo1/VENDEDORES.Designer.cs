namespace Equipo1
{
    partial class VENDEDORES
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_Vendedores = new System.Windows.Forms.DataGridView();
            this.gb_baja = new System.Windows.Forms.GroupBox();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.cbo_vendedor = new System.Windows.Forms.ComboBox();
            this.chk_borrar = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_test = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Vendedores)).BeginInit();
            this.gb_baja.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 30);
            this.button1.TabIndex = 26;
            this.button1.Text = "Ingresar Vendedor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "APELLIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "NOMBRE";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(213, 302);
            this.txt_apellido.Multiline = true;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(118, 23);
            this.txt_apellido.TabIndex = 19;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(56, 302);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(118, 23);
            this.txt_nombre.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "CARGA DE VENDEDOR";
            // 
            // dataGrid_Vendedores
            // 
            this.dataGrid_Vendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Vendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Vendedores.Location = new System.Drawing.Point(54, 37);
            this.dataGrid_Vendedores.Name = "dataGrid_Vendedores";
            this.dataGrid_Vendedores.ReadOnly = true;
            this.dataGrid_Vendedores.Size = new System.Drawing.Size(277, 228);
            this.dataGrid_Vendedores.TabIndex = 14;
            // 
            // gb_baja
            // 
            this.gb_baja.Controls.Add(this.btn_borrar);
            this.gb_baja.Controls.Add(this.cbo_vendedor);
            this.gb_baja.Controls.Add(this.chk_borrar);
            this.gb_baja.Location = new System.Drawing.Point(12, 387);
            this.gb_baja.Name = "gb_baja";
            this.gb_baja.Size = new System.Drawing.Size(360, 81);
            this.gb_baja.TabIndex = 27;
            this.gb_baja.TabStop = false;
            this.gb_baja.Text = "Baja de Vendedor";
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(266, 18);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(73, 45);
            this.btn_borrar.TabIndex = 2;
            this.btn_borrar.Text = "Borrar\r\nVendedor";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // cbo_vendedor
            // 
            this.cbo_vendedor.FormattingEnabled = true;
            this.cbo_vendedor.Location = new System.Drawing.Point(119, 30);
            this.cbo_vendedor.Name = "cbo_vendedor";
            this.cbo_vendedor.Size = new System.Drawing.Size(121, 21);
            this.cbo_vendedor.TabIndex = 1;
            // 
            // chk_borrar
            // 
            this.chk_borrar.AutoSize = true;
            this.chk_borrar.Location = new System.Drawing.Point(6, 32);
            this.chk_borrar.Name = "chk_borrar";
            this.chk_borrar.Size = new System.Drawing.Size(93, 17);
            this.chk_borrar.TabIndex = 0;
            this.chk_borrar.Text = "Habilitar Bajas";
            this.chk_borrar.UseVisualStyleBackColor = true;
            this.chk_borrar.CheckedChanged += new System.EventHandler(this.chk_borrar_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(278, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_test
            // 
            this.lbl_test.AutoSize = true;
            this.lbl_test.Location = new System.Drawing.Point(12, 471);
            this.lbl_test.Name = "lbl_test";
            this.lbl_test.Size = new System.Drawing.Size(35, 13);
            this.lbl_test.TabIndex = 29;
            this.lbl_test.Text = "label3";
            // 
            // VENDEDORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 527);
            this.Controls.Add(this.lbl_test);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gb_baja);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_Vendedores);
            this.Name = "VENDEDORES";
            this.Text = "VENDEDORES";
            this.Load += new System.EventHandler(this.VENDEDORES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Vendedores)).EndInit();
            this.gb_baja.ResumeLayout(false);
            this.gb_baja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid_Vendedores;
        private System.Windows.Forms.GroupBox gb_baja;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.ComboBox cbo_vendedor;
        private System.Windows.Forms.CheckBox chk_borrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_test;
    }
}