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
            

            cbo_orden.Items.Add("MAYOR VENTA");
            cbo_orden.Items.Add("MENOR VENTA");
            cbo_orden.Items.Add("FECHA MAS RECIENTE");
            cbo_orden.Items.Add("FECHA MENOS RECIENTE");
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

                // Variables con las instrucciones para la base de datos:
                string fecha;               
                string instruccion = "INSERT INTO Ventas(Fecha_de_Venta, idVendedor,idPais,idCliente,Cantidad_Pasajeros) " +
                                        "VALUES (@fecha, @idvendedor, @idpais,@idcliente,@Cantidad_Pasajeros)";
                
                // Mensajes de confirmación:
                
                
                string mensajeNuevo = "Venta nueva ingresada Correctamente";


                // Campos ingresados por el usuario para insertar a la instrucción de la dB
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

                // Para el control de errores en tiempo de ejecución                
                try
                {
                    // MessageBox.Show(descripcion + " " + precio + " " + idTipo); //TEST - Verifica datos OK
                    cn.Open();
                    int respuesta = comando.ExecuteNonQuery();
                    // MessageBox.Show(respuesta.ToString());  // TEST - Verifica respuesta

                    if (respuesta == 1)
                    {
                        MessageBox.Show(mensajeNuevo);
                        cn.Close();
                    }

                }
                //catch (SqlException sqlEx)
                //{
                //    MessageBox.Show(sqlEx.Message);
                //    cn.Close();
                //}
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
        }//FUNCION VER SI LOS CONTROLES ESTAN VACIOS
    }
}
