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
    public partial class CLIENTE : Form
    {
        public string cadenaConex;
        SqlConnection cn;

        public CLIENTE()
        {
            InitializeComponent();
        }

        private void CLIENTE_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
            cbo_clientes.Enabled = false;
            cargarcombo();
            dataGrid_Cliente.DataSource = gridClientes();
        }

        private void chk_modificar_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_modificar.Checked)
            {
                btn_agregar.Text = "MODIFICAR";
                cargarcombo(); 
                cbo_clientes.Enabled = true;
            }
            else
            {
                btn_agregar.Text = "NUEVO CLIENTE";
                cbo_clientes.Enabled = false;
            }
            vaciarTextboxes();
        }

        private void cbo_clientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (chk_modificar.Checked)
            {
                string formato = "yyyy-MM-dd";  // Para respetar el formato de fecha en el txt_fecha (1)
                string cliente = cbo_clientes.SelectedValue.ToString();
                                                                      
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                cn.Open();
                string query = "SELECT * FROM clientes where idcliente = @cliente";
                da = new SqlDataAdapter(query, cn);
                da.SelectCommand.Parameters.AddWithValue("@cliente", cliente);
                da.Fill(dt);
                cn.Close();

                // Soluciona problema de fecha en el txt al tomar el cliente del combo para modificar (2)
                DateTime dia = Convert.ToDateTime(dt.Rows[0][5]);   

                if (dt.Rows.Count > 0)
                {
                    txt_nombre.Text = dt.Rows[0][1].ToString();
                    txt_apellido.Text = dt.Rows[0][2].ToString();
                    txt_direccion.Text = dt.Rows[0][3].ToString();
                    txt_ciudad.Text = dt.Rows[0][4].ToString();

                    // se cambia esto "dt.Rows[0][5].ToString();" para solucionar formato de fecha (junto con la linea de arriba) (3)
                    txt_fecha.Text = dia.ToString(formato);
                }
                else
                {
                    MessageBox.Show("NO SE ENCONTRO INFORMACION");

                }

            }

        }

        void cargarcombo()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            string consulta = "SELECT idcliente, nombre, apellido FROM clientes";
            cn.Open();
            da = new SqlDataAdapter(consulta, cn);
            da.Fill(dt);
            cn.Close();
            cbo_clientes.DataSource = dt;
            dt.Columns.Add("NOMBRECOMPLETO", typeof(string), "nombre + '  ' + apellido"); 
            cbo_clientes.ValueMember = "idcliente";
            cbo_clientes.DisplayMember = "NOMBRECOMPLETO";

        }

        Boolean checkVacios()
        {
            Boolean respuesta = true;
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    if ((c as TextBox).Text == "")
                    {
                        respuesta = false;
                    }
                }
            }
            return respuesta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            string formato = "yyyy-MM-dd";

            txt_fecha.Text = fecha.ToString(formato);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (checkVacios())
            {
                string nombre, apellido, direccion, ciudad, fecha;
                string cliente = "";//VARIANTE PARA TOMAR EL ID DEL CLIENTE ELEGIDO
                int respuesta;//PARA GUARDAR LA DEVOLUCION DEL SQL SI SE MODIFICO ALGUNA LINEA
                nombre = txt_nombre.Text;
                apellido = txt_apellido.Text;
                direccion = txt_direccion.Text;
                ciudad = txt_ciudad.Text;
                fecha = txt_fecha.Text;

                SqlCommand comando;

                string quarryalta = "INSERT INTO CLIENTES (nombre, apellido,direccion,ciudad,Fecha_de_Alta) VALUES (@nombre, @apellido,@direccion,@ciudad,@fecha)";
                string quarryupdate = "UPDATE CLIENTES SET nombre = @nombre, apellido = @apellido, direccion=@direccion, ciudad = @ciudad, Fecha_de_Alta=@fecha WHERE idcliente = @cliente";
                string consulta;
                string mensajealta = "USUARIO CREADO";
                string mensajeupdate = "USUARIO MODIFICADO";
                string mensaje = "";

                if (chk_modificar.Checked)
                {
                    
                    consulta = quarryupdate;
                    cliente = cbo_clientes.SelectedValue.ToString();
                    mensaje = mensajeupdate;

                }
                else
                {
                    consulta = quarryalta;
                    mensaje = mensajealta;
                }
                comando = new SqlCommand(consulta, cn);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@ciudad", ciudad);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@cliente", cliente);

                cn.Open();

                try
                {
                    respuesta = comando.ExecuteNonQuery();
                    if (respuesta == 1)
                    {
                        MessageBox.Show(mensaje);
                        cn.Close();
                       
                        if (chk_modificar.Checked)//verifica que si el chk esta tildado
                        {
                            vaciarTextboxes();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }
                vaciarTextboxes(); // Borrar siempre los txt
                dataGrid_Cliente.DataSource = gridClientes();   // Actualiza el DataGrid

            }
            else
            {
                MessageBox.Show("Por favor completar todos los campos");
            }
        }

        void vaciarTextboxes()
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Text = "";
                }
            }
        }

        // Funciona para cargar el DataGrid
        private DataTable gridClientes()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Clientes"; // ORDER BY Apellido"; // - Opcional -

            da = new SqlDataAdapter(consulta, cn);
            cn.Open();
            da.Fill(dt);
            cn.Close();

            return dt;
        }

    }
}
