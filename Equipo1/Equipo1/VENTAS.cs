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
            cbo_orden.Items.Add("ORDENAR DE MENOR A MAYOR");
            cbo_orden.Items.Add("ORDENAR DE MAYOR A MENOR");            
            
            ReiniciaCombo();    // Inicia los combos desde una función
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
                int calculo = Convert.ToInt16(lbl_precio.Text) * Convert.ToInt16(txt_cant_PERS.Text);
                string fecha;

                // Se agrega @Gasto_Total y @idCiudad a la instrucción por modificación en la Base de Datos + Variables correspondientes
                string instruccion = "INSERT INTO Ventas(Fecha_de_Venta, idVendedor, idPais, idCliente, Cantidad_Pasajeros, Gasto_Total, idCiudad) " +
                                    "VALUES(@fecha, @idvendedor, @idpais, @idcliente, @Cantidad_Pasajeros, @Gasto_total, @idCiudad) ";

                string mensajeNuevo = "Venta nueva ingresada Correctamente";
                fecha = txt_fechaalta.Text;
                string idvendedor = "";
                string idpais = "";
                string idTcliente = "";
                string cantidadpasajeros = txt_cant_PERS.Text;
                string gastototal = calculo.ToString();     // Var 1
                string idciudad = "";       // Var 2
                

                SqlCommand comando;


                idvendedor = cbo_VENDEDOR.SelectedValue.ToString();
                idpais = cbo_PAIS.SelectedValue.ToString();
                idTcliente = cbo_Clientes.SelectedValue.ToString();
                idciudad = cbo_CIUDADES.SelectedValue.ToString();

                comando = new SqlCommand(instruccion, cn);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@idvendedor", idvendedor);
                comando.Parameters.AddWithValue("@idpais", idpais);
                comando.Parameters.AddWithValue("@idcliente", idTcliente);
                comando.Parameters.AddWithValue("@Cantidad_Pasajeros", cantidadpasajeros);
                comando.Parameters.AddWithValue("@Gasto_total", gastototal);    // Add 1
                comando.Parameters.AddWithValue("@idCiudad", idciudad);         // Add 2


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

            //  VER DE ACA EN ADELANTE  !  !  !  !  !
            /*
            string idventa = "";
            string pais = cbo_PAIS.SelectedValue.ToString();
            SqlDataAdapter da,daCantidad,daciudad;
            DataTable dt = new DataTable();
            DataTable dtCantidad = new DataTable();
            DataTable dtciudad = new DataTable();

            string consultaciudad = "select c.Ciudad,c.Precio  " +
                                    "from Paises as p, Ciudades as c " +
                                    "where p.idPais = c.idPais and p.idPais = @idpais";


            string consulta = "select cl.Nombre,cl.apellido,ven.Nombre,ven.apellido, p.Pais ,v.Fecha_de_Venta,v.Cantidad_Pasajeros " +
                              "from Ventas as v,Vendedores as ven, Clientes as cl, Paises as p " +
                              "where cl.idCliente = v.idCliente and ven.idVendedor = v.idVendedor and v.idPais = p.idPais and v.idVentas = @idventa ";

         
            string consultaCantidad = "select count (idVentas)  as cantidad from Ventas";

            daciudad = new SqlDataAdapter(consultaciudad, cn);
            daCantidad = new SqlDataAdapter(consultaCantidad, cn);
            da = new SqlDataAdapter(consulta, cn);
            cn.Open();
            daciudad.SelectCommand.Parameters.AddWithValue("@idpais", pais);

            daciudad.Fill(dtciudad);
            
            daCantidad.Fill(dtCantidad);
            
            idventa = dtCantidad.Rows[0][0].ToString();
                                           
            da.SelectCommand.Parameters.AddWithValue("@idventa", idventa);
            

            int preciototal = Convert.ToInt32(txt_cant_PERS.Text) * Convert.ToInt32(lbl_precio.Text);

            da.Fill(dt);
            cn.Close();
            */
            //  HASTA ACA   !  !  !  !  !


            lbl_cliente.Text = cbo_Clientes.Text;   // dt.Rows[0][0].ToString();
            // lbl_apellido_cliente.Text = dt.Rows[0][1].ToString();
            lbl_vendedor.Text = cbo_VENDEDOR.Text;  // dt.Rows[0][2].ToString();
            // lbl_apelli_vende.Text = dt.Rows[0][3].ToString();
            lbl_pais.Text = cbo_PAIS.Text;          // dt.Rows[0][4].ToString();
            lbl_pre.Text = lbl_precio.Text;
            lbl_ciudad.Text = cbo_CIUDADES.Text;

            ReiniciaCombo();    // Reinicia combos txt y lbl

            // ESTO SE VA X LOS RADIOS --- AHORA HAY Un COMBO
            //if (radioButton1.Checked)
            //{
            //    lbl_ciudad_cargada.Text = dtciudad.Rows[0][0].ToString();
            //    lbl_precio.Text = dtciudad.Rows[0][1].ToString();
            //}
            //if (radioButton2.Checked)
            //{
            //    lbl_ciudad_cargada.Text = dtciudad.Rows[1][0].ToString();
            //    lbl_precio.Text = dtciudad.Rows[1][1].ToString();
            //}
            //if (radioButton3.Checked)
            //{
            //    lbl_ciudad_cargada.Text = dtciudad.Rows[2][0].ToString();
            //    lbl_precio.Text = dtciudad.Rows[2][1].ToString();
            //}


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

            string consulta = "SELECT * FROM Ciudades WHERE idPais = @idpais";
            //string consulta = "select c.Ciudad,c.Precio  " +
            //                    "from Paises as p, Ciudades as c "+
            //                    "where p.idPais = c.idPais and p.idPais = @idpais";
            da = new SqlDataAdapter(consulta, cn);
            da.SelectCommand.Parameters.AddWithValue("@idpais", pais);
            da.Fill(dt);
            cn.Close();

            // Se carga el nuevo Combo de Ciudades
            cbo_CIUDADES.DataSource = dt;
            cbo_CIUDADES.ValueMember = "idCiudad";
            cbo_CIUDADES.DisplayMember = "Ciudad";

            //if (dt.Rows.Count > 0)
            //{
            //    Cambio de 3_Radios x 1_Combo
            //    radioButton1.Text = dt.Rows[0][0].ToString();
            //    radioButton2.Text = dt.Rows[1][0].ToString();
            //    radioButton3.Text = dt.Rows[2][0].ToString();
            //    lbl_precio.Text = dt.Rows[0][1].ToString();
            //}
            //else
            //{
            //    MessageBox.Show("No se encontró información");
            //}

            cbo_CIUDADES.Enabled = true;               
        }
   
        private void btn_Ver_Ventas_Click(object sender, EventArgs e)
        {
            string seleccion = "";
            // string orden = "",query="";
            seleccion = cbo_orden.SelectedItem.ToString();

            // Nueva consulta...
            string query = "SELECT v.idVentas, v.Fecha_de_Venta, (cl.Nombre + ' ' + cl.Apellido) AS Cliente, " +
                "v.Cantidad_Pasajeros AS Pasajeros, (ven.Nombre + ' ' + ven.Apellido) as Vendedor, " +
                "p.Pais, c.Ciudad, c.Precio as Precio_Ciudad, v.Gasto_Total " +
                "FROM Ventas AS v, Vendedores AS ven, Clientes AS cl, Paises AS p, Ciudades AS c " +
                "WHERE v.idVendedor = ven.idVendedor AND v.idCliente = cl.idCliente AND v.idPais = p.idPais AND v.idCiudad = c.idCiudad " +
                "ORDER BY Cliente ";

            //if (seleccion == "ORDENAR DE MENOR A MAYOR")
            //{
            //    query = "select cl.Nombre,cl.Apellido, v.Cantidad_Pasajeros, ven.Nombre, ven.Apellido, v.idVentas, p.Pais, v.Fecha_de_Venta, p.Precio+c.Precio as total " +
            //                   "from Ventas as v,Vendedores as ven, Clientes as cl, Paises as p, Ciudades as c " +
            //                   "where cl.idCliente = v.idCliente and ven.idVendedor = v.idVendedor and v.idPais = p.idPais and p.idPais = c.idPais " +
            //                   "order by cl.nombre asc";
            //}
            //if (seleccion == "ORDENAR DE MAYOR A MENOR")
            //{
            //     query = "select cl.Nombre,cl.Apellido, v.Cantidad_Pasajeros, ven.Nombre, ven.Apellido, v.idVentas, p.Pais, v.Fecha_de_Venta, p.Precio+c.Precio as total " +
            //                   "from Ventas as v,Vendedores as ven, Clientes as cl, Paises as p, Ciudades as c " +
            //                   "where cl.idCliente = v.idCliente and ven.idVendedor = v.idVendedor and v.idPais = p.idPais and p.idPais = c.idPais " +
            //                   "order by cl.nombre desc";
            //}

            if (seleccion == "ORDENAR DE MAYOR A MENOR")
            {
                query += "DESC";
            }

            SqlDataAdapter da;
            DataTable dt = new DataTable();
            
            cn.Open();
            da = new SqlDataAdapter(query, cn);
            
            // da.SelectCommand.Parameters.AddWithValue("@orden", orden);

            da.Fill(dt);           
            dataGrid_ventasGeneral.DataSource = dt;
            cn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_CIUDADES_SelectionChangeCommitted(object sender, EventArgs e)
        {

            string idciudad = cbo_CIUDADES.SelectedValue.ToString();

            string query = "SELECT * FROM Ciudades WHERE idCiudad = @idciudad";

            SqlDataAdapter da;
            DataTable dt = new DataTable();

            cn.Open();
            da = new SqlDataAdapter(query, cn);

            da.SelectCommand.Parameters.AddWithValue("@idciudad", idciudad);

            da.Fill(dt);
            // dataGrid_ventasGeneral.DataSource = dt;
            cn.Close();

            lbl_precio.Text = dt.Rows[0][2].ToString();
        }

        private void cbo_Clientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbo_VENDEDOR.Enabled = true;
        }

        private void cbo_VENDEDOR_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbo_PAIS.Enabled = true;
        }

        // Función de presentación...
        private void ReiniciaCombo()
        {
            cargarcomboCLIENTE();
            cargarcomboVENDEDOR();
            cargarcomboPais();

            cbo_Clientes.Text = "Seleccione";
            cbo_VENDEDOR.Text = "Seleccione";
            cbo_VENDEDOR.Enabled = false;
            cbo_PAIS.Text = "Seleccione";
            cbo_PAIS.Enabled = false;
            cbo_CIUDADES.Text = "Seleccione";
            cbo_CIUDADES.Enabled = false;

            lbl_precio.Text = "";
            txt_cant_PERS.Text = "";

            cbo_orden.SelectedItem = "ORDENAR DE MENOR A MAYOR";
        }




        private void btn_carga_Click(object sender, EventArgs e)
        {


        }
        private void cbo_orden_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
        private void groupVentas_Enter(object sender, EventArgs e)
        {

        }

    }
}

