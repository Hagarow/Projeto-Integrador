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

namespace Projeto_Integrador
{
    public partial class addveiculo : Form
    {
        public addveiculo()
        {
            InitializeComponent();
        }

        
        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuarios openform = new usuarios();
            openform.ShowDialog();
        }
    }
}
