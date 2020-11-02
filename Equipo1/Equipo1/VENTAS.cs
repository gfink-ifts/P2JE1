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
            
            cargarcomboCLIENTE();
            cargarcomboVENDEDOR();
            cargarcomboPais();
            

            cbo_orden.Items.Add("ORDENAR DE MENOR A MAYOR");
            cbo_orden.Items.Add("ORDENAR DE MAYOR A MENOR");
            
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
        void cargarcomboPais()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            string consulta = "SELECT idPais, Pais FROM Paises";
            cn.Open();
            da = new SqlDataAdapter(consulta, cn);
            da.Fill(dt);
            cn.Close();
            cbo_PAIS.DataSource = dt;            
            cbo_PAIS.ValueMember = "idPais";
            cbo_PAIS.DisplayMember = "Pais";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            string formato = "yyyy-MM-dd";

            txt_fechaalta.Text = fecha.ToString(formato);
        }
       
        private void btn_Nueva_Venta_Click(object sender, EventArgs e)
        {
            if (checkVacios())
            {              
                string fecha;               
                string instruccion = "INSERT INTO Ventas(Fecha_de_Venta, idVendedor,idPais,idCliente,Cantidad_Pasajeros) " +
                                        "VALUES (@fecha, @idvendedor, @idpais,@idcliente,@Cantidad_Pasajeros)";
                string mensajeNuevo = "Venta nueva ingresada Correctamente";
                fecha = txt_fechaalta.Text;
                string idvendedor = "";
                string idpais = "";
                string idTcliente = "";
                string cantidadpasajeros = txt_cant_PERS.Text;
                

                SqlCommand comando;


                idTcliente = cbo_Clientes.SelectedValue.ToString();
                idpais = cbo_PAIS.SelectedValue.ToString();
                idvendedor = cbo_VENDEDOR.SelectedValue.ToString();

               
                comando = new SqlCommand(instruccion, cn);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@idvendedor", idvendedor);
                comando.Parameters.AddWithValue("@idpais", idpais);
                comando.Parameters.AddWithValue("@idcliente", idTcliente);
                comando.Parameters.AddWithValue("@Cantidad_Pasajeros", cantidadpasajeros);

                           
                try
                {
                    
                    cn.Open();
                    int respuesta = comando.ExecuteNonQuery();
                   

                    if (respuesta == 1)
                    {
                        MessageBox.Show(mensajeNuevo);
                        cn.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
            }
            else
            {
                MessageBox.Show("Faltan campos");
            }
            string idventa = "";
            
            SqlDataAdapter da,daCantidad;
            DataTable dt = new DataTable();
            DataTable dtCantidad = new DataTable();
            
            
            string consulta = "select v.Fecha_de_Venta,cl.Nombre,cl.Apellido,v.Cantidad_Pasajeros, ven.Nombre,ven.Apellido,p.Precio + c.Precio as total " +
                              "from Ventas as v,Vendedores as ven, Clientes as cl, Paises as p, Ciudades as c " +
                              "where cl.idCliente = v.idCliente and ven.idVendedor = v.idVendedor and v.idPais = p.idPais and p.idPais = c.idPais  and v.idVentas = @idventa ";

            string consultaCantidad = "select count (idVentas)  as cantidad from Ventas";

            daCantidad = new SqlDataAdapter(consultaCantidad, cn);
            da = new SqlDataAdapter(consulta, cn);
            cn.Open();
            
            daCantidad.Fill(dtCantidad);
            
            idventa = dtCantidad.Rows[0][0].ToString();
                                           
            da.SelectCommand.Parameters.AddWithValue("@idventa", idventa);
            

            da.Fill(dt);
            dataGrid_Venta_Nueva.DataSource = dt;
            cn.Close();

        }
        Boolean checkVacios()
        {
            Boolean respuesta = true;

            
            foreach (Control c in this.Controls)
            {
                
                if (c is TextBox)
                {
                    if ((c as TextBox).Text == "")
                    {
                        respuesta = false;
                        foreach (Control d in groupVentas.Controls)
                        {

                            if (d is TextBox)
                            {
                                if ((d as TextBox).Text == "")
                                {
                                    respuesta = false;
                                    foreach (Control f in groupDESTINO.Controls)
                                    {

                                        if (f is TextBox)
                                        {
                                            if ((f as TextBox).Text == "")
                                            {
                                                respuesta = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return respuesta;
        }

        private void cbo_PAIS_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
                string pais = cbo_PAIS.SelectedValue.ToString();
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                cn.Open();
                string consulta = "select c.Ciudad "+
                                  "from Paises as p, Ciudades as c "+
                                  "where p.idPais = c.idPais and p.idPais = @idpais";
                da = new SqlDataAdapter(consulta, cn);
                da.SelectCommand.Parameters.AddWithValue("@idpais", pais);
                da.Fill(dt);
                cn.Close();
                if (dt.Rows.Count > 0)
                {
                    radioButton1.Text = dt.Rows[0][0].ToString();
                    radioButton2.Text = dt.Rows[1][0].ToString();
                    radioButton3.Text = dt.Rows[2][0].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró información");
                }
               
    }

        private void btn_carga_Click(object sender, EventArgs e)
        {
           
            
        }

        private void cbo_orden_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void btn_Ver_Ventas_Click(object sender, EventArgs e)
        {
            string seleccion = "";
            string orden = "",query="";
            seleccion = cbo_orden.SelectedItem.ToString();

            if (seleccion == "ORDENAR DE MENOR A MAYOR")
            {
                query = "select cl.Nombre,cl.Apellido, v.Cantidad_Pasajeros, ven.Nombre, ven.Apellido, v.idVentas, p.Pais, v.Fecha_de_Venta, p.Precio+c.Precio as total " +
                               "from Ventas as v,Vendedores as ven, Clientes as cl, Paises as p, Ciudades as c " +
                               "where cl.idCliente = v.idCliente and ven.idVendedor = v.idVendedor and v.idPais = p.idPais and p.idPais = c.idPais " +
                               "order by cl.nombre asc";
            }
            if (seleccion == "ORDENAR DE MAYOR A MENOR")
            {
                 query = "select cl.Nombre,cl.Apellido, v.Cantidad_Pasajeros, ven.Nombre, ven.Apellido, v.idVentas, p.Pais, v.Fecha_de_Venta, p.Precio+c.Precio as total " +
                               "from Ventas as v,Vendedores as ven, Clientes as cl, Paises as p, Ciudades as c " +
                               "where cl.idCliente = v.idCliente and ven.idVendedor = v.idVendedor and v.idPais = p.idPais and p.idPais = c.idPais " +
                               "order by cl.nombre desc";

            }
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            
            cn.Open();
            da = new SqlDataAdapter(query, cn);

            
            da.SelectCommand.Parameters.AddWithValue("@orden", orden);

            da.Fill(dt);           
            dataGrid_ventasGeneral.DataSource = dt;
            cn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupVentas_Enter(object sender, EventArgs e)
        {

        }
    }
}

