using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace PryConexionBDLopezBearzi
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }
        ClsConexion conexion = new ClsConexion();
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
          conexion.Conectar(GrlM);
        }

        private void GrlM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
