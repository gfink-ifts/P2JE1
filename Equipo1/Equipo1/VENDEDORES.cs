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
    public partial class VENDEDORES : Form
    {
        public string cadenaConex;
        SqlConnection cn;

        public VENDEDORES()
        {
            InitializeComponent();
        }

        private void VENDEDORES_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
            cargaDatos("grid");
            chk_borrar.Checked = false;
            chk_borrar_CheckedChanged(null, null);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (chkVacios())
            {
                SqlCommand comando;

                string cadena = "INSERT INTO Vendedores (Nombre, Apellido) VALUES (@nomb, @apell)";

                string nombre = txt_nombre.Text;
                string apellodo = txt_apellido.Text;

                comando = new SqlCommand(cadena, cn);
                comando.Parameters.AddWithValue("@nomb", nombre);
                comando.Parameters.AddWithValue("@apell", apellodo);

                try
                {
                    cn.Open();
                    int confirma = comando.ExecuteNonQuery();
                    if (confirma == 1)
                    {
                        MessageBox.Show("Vendedor ingresado correctamente", "Nuevo Vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cn.Close();
                        cargaDatos("grid");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cn.Close();
                }

                txt_nombre.Text = "";
                txt_apellido.Text = "";
            }
            else
            {
                MessageBox.Show("Complete todos los campos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btn_borrar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt16(cbo_vendedor.SelectedValue);

            if( valor != 0)
            {

                string idVende = cbo_vendedor.SelectedValue.ToString();
                string nombreVende = cbo_vendedor.SelectedItem.ToString();  // no funciona

                DialogResult r = MessageBox.Show("Se eliminará el vendedor " + Environment.NewLine + Environment.NewLine +
                                    "Desea continuar?", "Baja de Vendedor", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                       
                if(r == DialogResult.Yes)
                {
                    SqlCommand comando;

                    string borrar = "DELETE FROM Vendedores WHERE idVendedor = @idVende";

                    comando = new SqlCommand(borrar, cn);

                    comando.Parameters.AddWithValue("@idVende", idVende);

                    try
                    {
                        cn.Open();
                        int confirma = comando.ExecuteNonQuery();
                        if (confirma == 1)
                        {
                            MessageBox.Show("Vendedor eliminado correctamente", "Baja de Vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cn.Close();
                            cargaDatos("grid");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cn.Close();
                    }
                    cargaDatos("combo");

                }
            }
            else
            {
                MessageBox.Show("Elija un Vendedor", "Falta Seleccion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void chk_borrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_borrar.Checked)
            {
                txt_nombre.Enabled = false;
                txt_apellido.Enabled = false;
                button1.Enabled = false;
                cbo_vendedor.Enabled = true;
                btn_borrar.Enabled = true;
                cargaDatos("combo");
            }
            else
            {
                cbo_vendedor.Enabled = false;
                btn_borrar.Enabled = false;
                txt_nombre.Enabled = true;
                txt_apellido.Enabled = true;
                button1.Enabled = true;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        /*  ------------------  */
        /*  Funciones Propias:  */
        /*  ------------------  */

        void cargaDatos(string donde)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            string consulta = "SELECT * FROM Vendedores";

            da = new SqlDataAdapter(consulta, cn);
            cn.Open();
            da.Fill(dt);
            cn.Close();
            
            if(donde == "grid")
            {
                dataGrid_Vendedores.DataSource = dt;
            }
            if(donde == "combo")
            {
                cbo_vendedor.DataSource = dt;
                dt.Columns.Add("NombreCompleto", typeof(string), "Nombre + ' ' + Apellido");
                cbo_vendedor.DisplayMember = "NombreCompleto";
                cbo_vendedor.ValueMember = "idVendedor";
                cbo_vendedor.SelectedValue = 0;
                cbo_vendedor.Text = "Seleccione Vendedor";
            }
        }

        Boolean chkVacios()
        {
            bool rta = true;

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if((c as TextBox).Text == "")
                    {
                        rta = false;
                    }
                }
            }

            return rta;
        }

    }
}
