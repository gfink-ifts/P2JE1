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
            string consulta = "SELECT VEN.idVendedor ven.Nombre, VEN.Apellido " +
                                "FROM Ventas AS V, Vendedores AS ven, Paises AS p, Ciudades AS c";

            // FALTA SEGUIR 


            da = new SqlDataAdapter(consulta, cn);
            cn.Open();
            da.Fill(dt);
            cn.Close();
            dataGrid_Vendedores.DataSource = dt;
            dataGrid_Vendedores.Columns[0].Visible = false;
        }
    }
}
