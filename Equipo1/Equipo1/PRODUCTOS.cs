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
    public partial class PRODUCTOS : Form
    {
        public string cadenaConex;
        SqlConnection cn;

        public PRODUCTOS()
        {
            InitializeComponent();
        }


        /*
         *  Ver probleme @idCiudad  y  precio ciudades uruguay alto 50         *          
         */


        private void PRODUCTOS_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
            chk_modificar.Checked = false;
            chk_modificar_CheckedChanged(null, null);

            CargarDataGrid();
        }

        private void chk_modificar_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_modificar.Checked)
            {
                btn_modificaAgrega.Text = "Modificar Destino";
                cbo_Pais.Enabled = true;
                CargaCombos();  // Por defecto solo carga el Combo Pais
                BorraTodo("", 0, gb_nuevasCiudades);
                BorraTodo("", 0,gb_Campos);
                PrendeApaga(false, gb_nuevasCiudades);
                cbo_Pais.Text = "Seleccione un Pais";

            }
            else
            {
                btn_modificaAgrega.Text = "Agregar Destinos";
                cbo_Pais.Enabled = false;
                //cbo_ciudad.Enabled = false;
                //txt_precioCiudad.Enabled = false;
                PrendeApaga(true, gb_nuevasCiudades);
                BorraTodo("",0, gb_editarCiudad);
                BorraTodo("", 0, gb_Campos);
                PrendeApaga(false, gb_editarCiudad);

            }
        }

        private void cbo_Pais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Variable para cargar el combo de Ciudades y para la consulta que llena los txt_pais y txt_precioPais
            int pais = Convert.ToInt16(cbo_Pais.SelectedValue);

            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Paises WHERE idPais = @idPais";
            cn.Open();
            da = new SqlDataAdapter(consulta, cn);
            da.SelectCommand.Parameters.AddWithValue("@idPais", pais.ToString());
            da.Fill(dt);
            cn.Close();

            txt_pais.Text = dt.Rows[0][1].ToString();
            txt_precioPais.Text = dt.Rows[0][2].ToString();

            cbo_ciudad.Enabled = true;
            txt_precioCiudad.Enabled = true;

            CargaCombos(false, true, pais);
        }


        private void cbo_ciudad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Variable para la consulta que llena los txt_precioCiudad
            string ciudad = cbo_Pais.SelectedValue.ToString();

            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Ciudades WHERE idCiudad = @idCiudad";
            cn.Open();
            da = new SqlDataAdapter(consulta, cn);
            da.SelectCommand.Parameters.AddWithValue("@idCiudad", ciudad);
            da.Fill(dt);
            cn.Close();

            txt_precioCiudad.Text = dt.Rows[0][2].ToString();
        }


        private void btn_modificaAgrega_Click(object sender, EventArgs e)
        {
            if (checkVacios(gb_Campos) && checkVacios(gb_editarCiudad) && checkVacios(gb_nuevasCiudades))
            {
                // Variables con las instrucciones para la base de datos:
                string instruccion = "";
                string instrucModifica = "UPDATE Paises SET Pais = @pais, Precio = @precioPais where idPais = @idPais " +
                                            "UPDATE Ciudades SET Precio = @precioCiudad where idCiudad = @idCiudad";

                string instrucNuevo = "INSERT INTO Paises (Pais, Precio) VALUES (@pais, @precioPais) " +
                                        "INSERT INTO Ciudades(Ciudad, Precio, idPais) VALUES(@ciuda1, @precioCiuda1, (SELECT MAX(idPais) FROM Paises)) " +
                                        "INSERT INTO Ciudades(Ciudad, Precio, idPais) VALUES(@ciuda2, @precioCiuda2, (SELECT MAX(idPais) FROM Paises)) " +
                                        "INSERT INTO Ciudades(Ciudad, Precio, idPais) VALUES(@ciuda3, @precioCiuda3, (SELECT MAX(idPais) FROM Paises))";

                // Mensajes de confirmación:
                string mensaje = "";
                string mensajeModficado = "Datos modificado Correctamente";
                string mensajeNuevo = "Destinos nuevos ingresados Correctamente";


                // Variables para los Campos ingresados por el usuario:
                // Para Modificar o Agregar
                string pais = txt_pais.Text;                    // @pais
                string precioPais = txt_precioPais.Text;        // @precioPais

                // Para UPDATE
                string idPais = cbo_Pais.SelectedValue.ToString();      // @idPais       ver si pincha
                string idCiudad = cbo_ciudad.SelectedValue.ToString();   // @idCiudad    ver si pincha
                string precioCiudad = txt_precioCiudad.Text;            // @precioCiudad

                // Para INSERT
                string ciudad1 = txt_ciudad1.Text;                  // @ciudad1
                string ciudad2 = txt_ciudad2.Text;                  // @ciudad2
                string ciudad3 = txt_ciudad3.Text;                  // @ciudad3
                string precioCiudad1 = txt_precioCiudad1.Text;      // @precioCiudad1
                string precioCiudad2 = txt_precioCiudad2.Text;      // @precioCiudad2
                string precioCiudad3 = txt_precioCiudad3.Text;      // @precioCiudad3

                SqlCommand comando;

                if (chk_modificar.Checked)
                {
                    instruccion = instrucModifica;
                    mensaje = mensajeModficado;
                }
                else
                {
                    instruccion = instrucNuevo;
                    mensaje = mensajeNuevo;
                }

                // idPais = cbo_Pais.SelectedValue.ToString();   // si pincha poner esta linea

                comando = new SqlCommand(instruccion, cn);
                comando.Parameters.AddWithValue("@pais", pais);
                comando.Parameters.AddWithValue("@precioPais", precioPais);
                comando.Parameters.AddWithValue("@idPais", idPais);
                comando.Parameters.AddWithValue("@precioCiudad", precioCiudad);
                comando.Parameters.AddWithValue("@ciudad1", ciudad1);
                comando.Parameters.AddWithValue("@ciudad2", ciudad2);
                comando.Parameters.AddWithValue("@ciudad3", ciudad3);
                comando.Parameters.AddWithValue("@precioCiudad1", precioCiudad1);
                comando.Parameters.AddWithValue("@precioCiudad2", precioCiudad2);
                comando.Parameters.AddWithValue("@precioCiudad3", precioCiudad3);


                // Para el control de errores en tiempo de ejecución                
                try
                {
                    // MessageBox.Show(descripcion + " " + precio + " " + idTipo); //TEST - Verifica datos OK
                    cn.Open();
                    int respuesta = comando.ExecuteNonQuery();
                    // MessageBox.Show(respuesta.ToString());  // TEST - Verifica respuesta

                    if (respuesta > 0)
                    {
                        MessageBox.Show(mensaje);
                        cn.Close();
                        CargarDataGrid(); // Para que se actualice la grilla de productos 
                        chk_modificar.Checked = false;
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
                MessageBox.Show("Complete todos los campos...", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void btn_salir_Click(object sender, EventArgs e)
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
            string consulta = "SELECT P.*, c.Ciudad, c.Precio AS Adicional " +
                                "FROM Paises AS p, Ciudades AS c " +
                                "WHERE p.idPais = c.idPais ";
            da = new SqlDataAdapter(consulta, cn);
            cn.Open();
            da.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }

            // Carga los combos de Paises y Ciudades
        void CargaCombos(bool pais = true, bool ciudad = false, int idPais = 0)
        {
            SqlDataAdapter da;
            DataTable dtP = new DataTable();
            DataTable dtC = new DataTable();

            string consultaPais = "SELECT idPais, Pais FROM Paises ORDER BY Pais";
            string consultaCiudad = "SELECT idCiudad, Ciudad FROM Ciudades WHERE idPais = @Pais ORDER BY Ciudad";
            string indicePais = idPais.ToString();

            cn.Open();
            if (pais)
            {
                da = new SqlDataAdapter(consultaPais, cn);
                da.Fill(dtP);

                cbo_Pais.DataSource = dtP;
                cbo_Pais.ValueMember = "idPais";
                cbo_Pais.DisplayMember = "Pais";
                cbo_Pais.Text = "Seleccione un Pais";
            }
            if (ciudad)
            {
                da = new SqlDataAdapter(consultaCiudad, cn);
                da.SelectCommand.Parameters.AddWithValue("@Pais", indicePais);
                da.Fill(dtC);

                cbo_ciudad.DataSource = dtC;
                cbo_ciudad.ValueMember = "idCiudad";
                cbo_ciudad.DisplayMember = "Ciudad";
            }
            cn.Close();
        }

            // Borra los textBox y comboBox que están habilitados en el form o dentro de un groupBox
        private void BorraTodo(string palabraTxt, int comBoxValue, GroupBox gb = null)
        {
            if (gb == null)
            {
                foreach (Control miControl in this.Controls)
                {
                    if (miControl is TextBox)
                    {
                        miControl.Text = palabraTxt;
                    }
                    if (miControl is ComboBox)
                    {
                        ((ComboBox)miControl).SelectedValue = comBoxValue;
                    }
                }
            }
            else
            {
                foreach (Control miControl in gb.Controls)
                {
                    if (miControl is TextBox)
                    {
                        miControl.Text = palabraTxt;
                    }
                    if (miControl is ComboBox)
                    {
                        ((ComboBox)miControl).SelectedValue = comBoxValue;
                    }
                }
            }
        }

            // Habilita o deshabilita textBox y comboBox dentro de cada comboBox
        private void PrendeApaga(bool onoff, GroupBox gb = null)
        {
            if (gb == null)
            {
                foreach (Control miControl in this.Controls)
                {
                    if (miControl is TextBox)
                    {
                        miControl.Enabled = onoff;
                    }
                    if (miControl is ComboBox)
                    {
                        ((ComboBox)miControl).Enabled = onoff;
                    }
                }
            }
            else
            {
                foreach (Control miControl in gb.Controls)
                {
                    if (miControl is TextBox)
                    {
                        miControl.Enabled = onoff;
                    }
                    if (miControl is ComboBox)
                    {
                        ((ComboBox)miControl).Enabled = onoff;
                    }
                }
            }
        }

            // Verifica si los textBox habilitados están vacios, al igual que los comboBox
            // dentro de los diferentes groupBox
        Boolean checkVacios(GroupBox gb)
        {
            Boolean respuesta = true;
            foreach (Control c in gb.Controls)
            {
                if (c is TextBox)
                {
                    if ((c as TextBox).Enabled == true && (c as TextBox).Text == "")
                    {
                        respuesta = false;
                    }
                }
                if (c is ComboBox)
                {
                    if ((c as ComboBox).Enabled == true && (c as ComboBox).SelectedValue == null)
                    {
                        respuesta = false;
                    }
                }
            }
            return respuesta;
        }

    }
}
