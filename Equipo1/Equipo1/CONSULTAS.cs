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

            rdb_unVendedor_CheckedChanged(null, null);
            rdb_unPais_CheckedChanged(null, null);
        }


        private void rdb_unVendedor_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rdb_unVendedor.Checked)
            {
                cbo_vendedor.Enabled = true;
                CargaCombos("vende");

            }
            else
            {
                DataTable consultaTodos = infoConsultas("Vendedor", 0);
                cbo_vendedor.Text = "";
                cbo_vendedor.Enabled = false;
                dataGrid_Vendedores.DataSource = consultaTodos;

                // Info a Mostrar en Labels
                EstadisticasVende(consultaTodos);
            }
        }
        private void cbo_vendedor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idVende = Convert.ToInt16(cbo_vendedor.SelectedValue);

            DataTable TablaVendedores = infoConsultas("Vendedor", idVende); ;

            dataGrid_Vendedores.DataSource = TablaVendedores;

            // Info a Mostrar en Labels
            EstadisticasVende(TablaVendedores);
        }



        private void rdb_unPais_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_unPais.Checked)
            {
                cbo_Paises.Enabled = true;
                CargaCombos("pais");

            }
            else
            {
                DataTable consultaTodos = infoConsultas("Destino", 0);
                cbo_Paises.Text = "";
                cbo_Paises.Enabled = false;
                dataGridDestinos.DataSource = consultaTodos;
                dataGridDestinos.Columns[2].Visible = false;
                dataGridDestinos.Columns[4].Visible = false;

                // Info a Mostrar en Labels
                EstadisticasPais(consultaTodos);
            }
        }
        private void cbo_Paises_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idPais = Convert.ToInt16(cbo_Paises.SelectedValue);

            // dataGridDestinos.DataSource = infoConsultas("Destino", idPais);

            DataTable TablaPais = infoConsultas("Destino", idPais); ;

            dataGridDestinos.DataSource = TablaPais;

            // Info a Mostrar en Labels
            EstadisticasPais(TablaPais);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        /*  ------------------  */
        /*  Funciones Propias:  */
        /*  ------------------  */

        // Carga DataGridView

        private DataTable infoConsultas(string tabla, int idFiltro)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            string info = "";

            //string infoDestinos = "SELECT v.idVentas, v.Fecha_de_Venta AS Fecha, (c.Ciudad + ' - ' + p.Pais) as Destino, c.Precio, v.Cantidad_Pasajeros AS Pasajeros, v.Gasto_Total " +
            //                        "FROM Ventas AS v, Paises as p, Ciudades as c where v.idCiudad = c.idCiudad AND p.idPais = c.idPais ";
            string infoDestinos = "SELECT v.idVentas, v.Fecha_de_Venta AS Fecha, v.idCiudad, c.Ciudad, p.idPais, p.Pais, c.Precio, " +
                                    "v.Cantidad_Pasajeros as Pasajeros, v.Gasto_Total AS Ingresos " +
                                    "FROM Ventas AS v, Paises AS p, Ciudades AS c WHERE v.idCiudad = c.idCiudad AND p.idPais = c.idPais ";

            string infoVendedores = "SELECT R.idVendedor, S.Fecha_de_Venta AS Fecha, (R.Apellido + ' ' + R.Nombre) AS Nombre, S.Gasto_Total AS Vendido " +
                                        "FROM Vendedores AS R, Ventas AS S WHERE R.idVendedor = S.idVendedor ";

            if(idFiltro != 0)
            {
                infoDestinos += "AND v.idPais = @idPais";
                infoVendedores += "AND S.idVendedor = @idVende";
            }

            switch (tabla)
            {
                case "Vendedor":
                    info = infoVendedores;
                    break;
                case "Destino":
                    info = infoDestinos;
                    break;
            }

            da = new SqlDataAdapter(info, cn);
            da.SelectCommand.Parameters.AddWithValue("@idPais", idFiltro.ToString());
            da.SelectCommand.Parameters.AddWithValue("@idVende", idFiltro);
            cn.Open();
            da.Fill(dt);
            cn.Close();

            return dt;
        }


        private void CargaCombos(string combo)
        {
            SqlDataAdapter da;
            DataTable dtV = new DataTable();
            DataTable dtP = new DataTable();

            string listaVendedores = "SELECT idVendedor, (Apellido + ' ' + Nombre) AS Nombre FROM Vendedores ORDER BY Nombre";
            string listaPaises = "SELECT * FROM Paises ORDER BY Pais";

            cn.Open();
            if (combo == "vende")
            {
                da = new SqlDataAdapter(listaVendedores, cn);
                da.Fill(dtV);

                cbo_vendedor.DataSource = dtV;
                cbo_vendedor.ValueMember = "idVendedor";
                cbo_vendedor.DisplayMember = "Nombre";
            }
            if (combo == "pais")
            {
                da = new SqlDataAdapter(listaPaises, cn);
                da.Fill(dtP);

                cbo_Paises.DataSource = dtP;
                cbo_Paises.ValueMember = "idPais";
                cbo_Paises.DisplayMember = "Pais";
            }
            cn.Close();
        }

        private void EstadisticasVende(DataTable tabla)
        {
            if (tabla.Rows.Count > 0)
            {
                string nombreV = tabla.Rows[0][2].ToString();
                int maxVenta = Convert.ToInt16(tabla.Rows[0][3]);
                double promedioV;
                int numeroVentas = tabla.Rows.Count;
                int ventasAcum = 0;

                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    int venta = Convert.ToInt16(tabla.Rows[i][3]);
                    ventasAcum += venta;

                    if (venta > maxVenta)
                    {
                        maxVenta = venta;
                        nombreV = tabla.Rows[i][2].ToString();
                    }
                }
                promedioV = ventasAcum / numeroVentas;

                lbl_vendeMejorNombre.Text = nombreV;
                lbl_vendeMejorMonto.Text = maxVenta.ToString();
                lbl_vendePromMonto.Text = promedioV.ToString();
                lbl_numeroVentas.Text = numeroVentas.ToString();
                lbl_acumVendido.Text = ventasAcum.ToString();
            }
            else
            {
                MessageBox.Show("No hay datos para calcular.");
                Limpia_lbl("", gb_vendedoresResul);
            }
        }


        private void EstadisticasPais(DataTable tabla)
        {

            if (tabla.Rows.Count > 0)
            {
                string paisMasV = tabla.Rows[0][5].ToString();
                int maxVenta = Convert.ToInt16(tabla.Rows[0][8]);
                int ventasAcum = 0;
                string ciudadCara = tabla.Rows[0][3].ToString();
                string ciudadBarata = tabla.Rows[0][3].ToString();
                int precioAlto = Convert.ToInt16(tabla.Rows[0][6]);
                int precioBajo = Convert.ToInt16(tabla.Rows[0][6]);

                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    int precio = Convert.ToInt16(tabla.Rows[i][6]);
                    int venta = Convert.ToInt16(tabla.Rows[i][8]);

                    ventasAcum += venta;

                    if (venta > maxVenta)
                    {
                        maxVenta = venta;
                        paisMasV = tabla.Rows[i][5].ToString();
                    }
                    if(precio > precioAlto)
                    {
                        precioAlto = precio;
                        ciudadCara = tabla.Rows[i][3].ToString();
                    }
                    if(precio < precioBajo)
                    {
                        precioBajo = precio;
                        ciudadBarata = tabla.Rows[i][3].ToString();
                    }

                }

                lbl_paisMejorNombre.Text = paisMasV;
                lbl_paisMejorMonto.Text = maxVenta.ToString();
                lbl_paisAcumulado.Text = ventasAcum.ToString();
                lbl_ciudadCara.Text = ciudadCara.ToString();
                lbl_ciudadBatara.Text = ciudadBarata.ToString();
            }
            else
            {
                MessageBox.Show("No hay datos para calcular.");
                Limpia_lbl("", gb_destinosResul);
            }
        }

        private void Limpia_lbl(string palabraTxt, GroupBox gb)
        {
            foreach (Control miControl in gb.Controls)
            {
                if (miControl is Label)
                {
                    miControl.Text = palabraTxt;
                }
            }
        }
    }
}
