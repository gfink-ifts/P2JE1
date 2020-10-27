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
            lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
