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
            chk_nuevaCiudad.Checked = false;
            cbo_Pais.Enabled = false;
            cbo_ciudad.Enabled = false;
            txt_ciudadNew.Enabled = false;
            txt_precioCiudad.Enabled = false;
            CargarDataGrid();
        }

        private void chk_modificar_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_modificar.Checked)
            {
                cbo_Pais.Enabled = true;
                CargaCombos();  // Por defecto solo carga el Combo Pais
            }
            else
            {
                cbo_Pais.Enabled = false;
                cbo_Pais.Text = "Seleccione un Pais";

            }
        }

        private void cbo_Pais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int pais = Convert.ToInt16(cbo_Pais.SelectedValue);
            cbo_ciudad.Enabled = true;
            CargaCombos(false, true, pais);
            chk_nuevaCiudad.Checked = false;
        }

        private void chk_nuevaCiudad_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_nuevaCiudad.Checked)
            {
                txt_ciudadNew.Enabled = true;
                txt_precioCiudad.Enabled = true;
                //cbo_ciudad.Text = "";
                cbo_ciudad.Enabled = false;

            }
            else
            {
                cbo_ciudad.Enabled = true;

                txt_ciudadNew.Enabled = false;
                txt_precioCiudad.Enabled = false;

            }
        }





        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Funciones Propias:

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

    }
}
