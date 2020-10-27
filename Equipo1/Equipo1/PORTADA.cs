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
            formcliente.Show();
        }

        private void btn_Agr_o_Mod_Produ_Click(object sender, EventArgs e)
        {
            PRODUCTOS formproductos = new PRODUCTOS();
            formproductos.Show();
        }

        private void btn_Agre_o_Modi_Ventas_Click(object sender, EventArgs e)
        {
            VENTAS formventas = new VENTAS();
            formventas.Show();
        }

        private void btn_Consultas_Click(object sender, EventArgs e)
        {
            CONSULTAS formconsultas = new CONSULTAS();
            formconsultas.Show();
        }
    }
}
 