using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suplidores3.Data.View
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuplidor frmSuplidor = new frmSuplidor();
            frmSuplidor.ShowDialog();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarRnc frmrnc = new frmBuscarRnc();
            frmrnc.ShowDialog();
        }
    }
}
