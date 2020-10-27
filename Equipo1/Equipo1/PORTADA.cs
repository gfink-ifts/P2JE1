using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipo1
{
    public partial class PORTADA : Form
    {
        // Ruta de acceso a la Base de Datos. Se declara como variable global para pasarla
        // a todos los formularios cuando arrancan.
        string dBase = @"data source=.\SQLEXPRESS; initial catalog = Turismo_Squeo-Selis; integrated security=SSPI";

        public PORTADA(  )
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_git_Click(object sender, EventArgs e)
        {
            CLIENTE formcliente = new CLIENTE();
            // Pasa la cadena de conexión de la Base de datos al Formulario
            formcliente.cadenaConex = dBase;
            formcliente.Show();
        }

        private void btn_Agr_o_Mod_Produ_Click(object sender, EventArgs e)
        {
            PRODUCTOS formproductos = new PRODUCTOS();
            formproductos.cadenaConex = dBase;
            formproductos.Show();
        }

        private void btn_Agre_o_Modi_Ventas_Click(object sender, EventArgs e)
        {
            VENTAS formventas = new VENTAS();
            formventas.cadenaConex = dBase;
            formventas.Show();
        }

        private void btn_Consultas_Click(object sender, EventArgs e)
        {
            CONSULTAS formconsultas = new CONSULTAS();
            formconsultas.cadenaConex = dBase;
            formconsultas.Show();
        }
    }
}
 