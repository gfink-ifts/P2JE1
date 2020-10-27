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
    public partial class CONSULTAS : Form
    {
        public string cadenaConex;
        SqlConnection cn;

        public CONSULTAS()
        {
            InitializeComponent();
        }

        private void CONSULTAS_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConex);
        }
    }
}
