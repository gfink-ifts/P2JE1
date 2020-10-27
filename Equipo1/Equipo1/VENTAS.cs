using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Equipo1
{
    public partial class VENTAS : Form
    {
        public string cadenaConex;
        SqlConnection cn;

        public VENTAS()
        {
            InitializeComponent();
        }

        private void VENTAS_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
            lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cargarcomboCLIENTE();
            cargarcomboVENDEDOR();
        }
        void cargarcomboCLIENTE()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            string consulta = "SELECT idCliente, nombre, apellido FROM clientes";
            cn.Open();
            da = new SqlDataAdapter(consulta, cn);
            da.Fill(dt);
            cn.Close();
            cbo_Clientes.DataSource = dt;
            dt.Columns.Add("NOMBRECOMPLETO", typeof(string), "Nombre + '  ' + Apellido");
            cbo_Clientes.ValueMember = "idCliente";
            cbo_Clientes.DisplayMember = "NOMBRECOMPLETO";
                            
        }
        void cargarcomboVENDEDOR()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            string consulta = "SELECT idVendedor, nombre, apellido FROM Vendedores";
            cn.Open();
            da = new SqlDataAdapter(consulta, cn);
            da.Fill(dt);
            cn.Close();
            cbo_VENDEDOR.DataSource = dt;
            dt.Columns.Add("NOMBRECOMPLETO", typeof(string), "Nombre + '  ' + Apellido");
            cbo_VENDEDOR.ValueMember = "idVendedor";
            cbo_VENDEDOR.DisplayMember = "NOMBRECOMPLETO";

        }
    }
}
