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
        }
    }
}
