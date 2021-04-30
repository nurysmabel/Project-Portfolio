using Suplidores3.Data.Dbcontext;
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
    public partial class frmBuscarRnc : Form
    {
        public frmBuscarRnc()
        {
            InitializeComponent();
        }
        ISuplidorRepository _suplidorRep = new SuplidorRepository();
        private void btnRNC_Click(object sender, EventArgs e)
        {
            string find = txtBuscar.Text.ToString();
            dgvBuscarRnc.DataSource = new List<Suplidore>() { _suplidorRep.FindById(find) };

          
        }

        private void frmBuscarRnc_Load(object sender, EventArgs e)
        {

        }

        private void dgvBuscarRnc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
