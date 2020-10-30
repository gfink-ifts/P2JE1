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
    public partial class CONSULTAS : Form
    {
        public string cadenaConex;
        SqlConnection cn;

        public CONSULTAS()
        {
            InitializeComponent();
        }

        private void CONSULTAS_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
            rdb_todos.Checked = true;
            rdb_todasCiudades.Checked = true;
            CargarDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // Funciones Propias:
        // ------------------------------------------

        // Carga DataGridView
        void CargarDataGrid()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string consultaVenta = "SELECT V.Fecha_de_Venta, VDOR.idVendedor, VDOR.Nombre + ' ' + VDOR.Apellido AS Vendedor, (P.Precio * V.Cantidad_Pasajeros) AS Monto " +
                                    "FROM Ventas AS V, Vendedores AS VDOR, Paises AS P " +
                                    "WHERE V.idVendedor = VDOR.idVendedor AND V.idPais = P.idPais";
            string ventaPlus = " and VDOR.idVendedor = 1";

            string consultaDestino = "SELECT VEN.idVendedor ven.Nombre, VEN.Apellido " +
                    "FROM Ventas AS V, Vendedores AS ven, Paises AS p, Ciudades AS c";

            // FALTA SEGUIR 

            if (rdb_todos.Checked)
            {
                da = new SqlDataAdapter(consultaVenta, cn);
            }
            else
            {
                da = new SqlDataAdapter(consultaVenta + ventaPlus, cn);
            }

            cn.Open();
            da.Fill(dt);
            cn.Close();
            dataGrid_Vendedores.DataSource = dt;
            dataGrid_Vendedores.Columns[0].Visible = false;
            dataGrid_Vendedores.Columns[1].Visible = false;

        }

        private void rdb_unVendedor_CheckedChanged(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

    }
}
