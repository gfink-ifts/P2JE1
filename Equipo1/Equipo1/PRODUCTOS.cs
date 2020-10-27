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
        }
    }
}
