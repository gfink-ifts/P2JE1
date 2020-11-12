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
        

        private void PRODUCTOS_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
            chk_modificar.Checked = false;
            chk_modificar_CheckedChanged(null, null);
            dataGridView1.DataSource = InfoDataGrid();
            dataGridView1.Columns[0].Visible = false;
            
        }

        private void chk_modificar_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_modificar.Checked)
            {
                btn_borraDestino.Visible = true;
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
                btn_borraDestino.Visible = false;
                btn_borraDestino.Enabled = false;
                btn_modificaAgrega.Text = "Agregar Destinos";
                cbo_Pais.Enabled = false;
                PrendeApaga(true, gb_nuevasCiudades);
                BorraTodo("", 0, gb_nuevasCiudades);
                BorraTodo("",0, gb_editarCiudad);
                PrendeApaga(false, gb_editarCiudad);
                BorraTodo("", 0, gb_Campos);

            }
        }


        // OPTIMIZAR CON FUNCION DATATABLE dentro de los combos ! ! ! ! ! ! ! ! ! ! ! ! 

        private void cbo_Pais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Variable para cargar el combo de Ciudades y para la consulta que llena los txt_pais
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
            btn_borraDestino.Enabled = true;

            PrendeApaga(true, gb_editarCiudad);
            CargaCombos(false, true, pais);
            // BorraTodo("", 0, gb_editarCiudad);
            // cbo_ciudad.Text = "Seleccione Ciudad";
            // cbo_ciudad.SelectedIndex = 2;
            cbo_ciudad_SelectionChangeCommitted(null, null);
        }

        private void cbo_ciudad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Variable para la consulta que llena los txt_ciudadNwe y txt_precioCiudad
            string ciudad = cbo_ciudad.SelectedValue.ToString();


            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Ciudades WHERE idCiudad = @idCiudad";
            cn.Open();
            da = new SqlDataAdapter(consulta, cn);
            da.SelectCommand.Parameters.AddWithValue("@idCiudad", ciudad);
            da.Fill(dt);
            cn.Close();

            txt_precioCiudad.Text = dt.Rows[0][2].ToString();
            txt_ciudadNew.Text = dt.Rows[0][1].ToString();
        }

        private void btn_modificaAgrega_Click(object sender, EventArgs e)
        {
            if (checkVacios(gb_Campos) && checkVacios(gb_editarCiudad) && checkVacios(gb_nuevasCiudades))
            {
                // Variables con las instrucciones para la base de datos:
                string instruccion = "";
                string instrucModifica = "UPDATE Paises SET Pais = @pais where idPais = @idPais " +
                                            "UPDATE Ciudades SET Precio = @precioCiudad where idCiudad = @idCiudad " +
                                            "UPDATE Ciudades SET Ciudad = @Ciudad where idCiudad = @idCiudad ";

                string instrucNuevo = "INSERT INTO Paises (Pais) VALUES (@pais) " +
                                        "INSERT INTO Ciudades(Ciudad, Precio, idPais) VALUES(@ciudad1, @precioCiudad1, (SELECT MAX(idPais) FROM Paises)) " +
                                        "INSERT INTO Ciudades(Ciudad, Precio, idPais) VALUES(@ciudad2, @precioCiudad2, (SELECT MAX(idPais) FROM Paises)) " +
                                        "INSERT INTO Ciudades(Ciudad, Precio, idPais) VALUES(@ciudad3, @precioCiudad3, (SELECT MAX(idPais) FROM Paises))";

                // Mensajes de confirmación:
                string mensaje = "";
                string mensajeModficado = "Datos modificado Correctamente";
                string mensajeNuevo = "Destinos nuevos ingresados Correctamente";


                // Variables para los Campos ingresados por el usuario común a las 2 instrucciones:
                string pais = txt_pais.Text;    // @pais

                SqlCommand comando;

                if (chk_modificar.Checked)
                {
                    // Variables para UPDATE
                    string idPais = cbo_Pais.SelectedValue.ToString();      // @idPais
                    string idCiudad = cbo_ciudad.SelectedValue.ToString();  // @idCiudad
                    string precioCiudad = txt_precioCiudad.Text;            // @precioCiudad
                    string nombreCiudad = txt_ciudadNew.Text;

                    instruccion = instrucModifica;
                    mensaje = mensajeModficado;
                    comando = new SqlCommand(instruccion, cn);
                    comando.Parameters.AddWithValue("@idPais", idPais);
                    comando.Parameters.AddWithValue("@idCiudad", idCiudad);
                    comando.Parameters.AddWithValue("@precioCiudad", precioCiudad);
                    comando.Parameters.AddWithValue("@Ciudad", nombreCiudad);

                }
                else
                {
                    // Variables para INSERT
                    string ciudad1 = txt_ciudad1.Text;                  // @ciudad1
                    string ciudad2 = txt_ciudad2.Text;                  // @ciudad2
                    string ciudad3 = txt_ciudad3.Text;                  // @ciudad3
                    string precioCiudad1 = txt_precioCiudad1.Text;      // @precioCiudad1
                    string precioCiudad2 = txt_precioCiudad2.Text;      // @precioCiudad2
                    string precioCiudad3 = txt_precioCiudad3.Text;      // @precioCiudad3

                    instruccion = instrucNuevo;
                    mensaje = mensajeNuevo;
                    comando = new SqlCommand(instruccion, cn);
                    comando.Parameters.AddWithValue("@ciudad1", ciudad1);
                    comando.Parameters.AddWithValue("@ciudad2", ciudad2);
                    comando.Parameters.AddWithValue("@ciudad3", ciudad3);
                    comando.Parameters.AddWithValue("@precioCiudad1", precioCiudad1);
                    comando.Parameters.AddWithValue("@precioCiudad2", precioCiudad2);
                    comando.Parameters.AddWithValue("@precioCiudad3", precioCiudad3);

                }

                // Este Value es común a las 2 instrucciones, por eso queda fuera del if()
                comando.Parameters.AddWithValue("@pais", pais);


                // Para el control de errores en tiempo de ejecución                
                try
                {
                    cn.Open();
                    int respuesta = comando.ExecuteNonQuery();
                    // MessageBox.Show(respuesta.ToString());  // TEST - Verifica respuesta

                    if (respuesta > 0)
                    {
                        MessageBox.Show(mensaje);
                        cn.Close();

                        // Para que se actualice la grilla de productos 
                        dataGridView1.DataSource = InfoDataGrid();
                        dataGridView1.Columns[0].Visible = false;

                        chk_modificar.Checked = false;

                        // Es necesario ejecutar esto, xq el chk_modificar no cambia de estado cuando hace una actualización
                        chk_modificar_CheckedChanged(null, null);
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

        private void btn_borraDestino_Click(object sender, EventArgs e)
        {
            string pais = cbo_Pais.Text;
            string idPais = cbo_Pais.SelectedValue.ToString();

            DialogResult elimina = MessageBox.Show("Se eliminará " + pais.ToUpper() + " y todas sus ciudades." + Environment.NewLine +
                "Desea continuar ?", "Borrar Destino (" + pais + ") de la Base de Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (elimina == DialogResult.Yes)
            {
                string borraPais = "DELETE FROM Paises WHERE idPais = @idPais";
                string borraCiudad = "DELETE FROM Ciudades WHERE idPais = @idPais";

                SqlCommand comandoP = new SqlCommand(borraPais, cn);
                SqlCommand comandoC = new SqlCommand(borraCiudad, cn);
                comandoP.Parameters.AddWithValue("@idPais", idPais);
                comandoC.Parameters.AddWithValue("@idPais", idPais);

                try
                {
                    cn.Open();
                    int respuestaP = comandoP.ExecuteNonQuery();
                    int respuestaC = comandoC.ExecuteNonQuery();

                    if (respuestaP > 0 || respuestaC > 0)
                    {
                        MessageBox.Show("Se eliminó " + respuestaP + " Pais y " + respuestaC + " Ciudades");
                        cn.Close();

                        // Actualiza la grilla
                        dataGridView1.DataSource = InfoDataGrid();
                        dataGridView1.Columns[0].Visible = false;

                        chk_modificar.Checked = false;
                        //chk_modificar_CheckedChanged(null, null);  no es necesario xq chk_modificar cambia de estado !
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();
                }

            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        /*  ------------------  */
        /*  Funciones Propias:  */
        /*  ------------------  */

        // Para DataGridView
        private DataTable InfoDataGrid()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string consulta = "SELECT P.*, c.Ciudad, c.Precio " +
                                "FROM Paises AS p, Ciudades AS c " +
                                "WHERE p.idPais = c.idPais ORDER BY P.Pais ";

            da = new SqlDataAdapter(consulta, cn);
            cn.Open();
            da.Fill(dt);
            cn.Close();
            
            return dt;
        }


        // Carga los combos de Paises y Ciudades
        private void CargaCombos(bool pais = true, bool ciudad = false, int idPais = 0)
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

        private void txt_precioCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }            
        }
    }
}
