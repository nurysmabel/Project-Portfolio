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
    public partial class frmBorrar : Form
    {
        public frmBorrar()
        {
            InitializeComponent();
        }
        ISuplidorRepository _suplidorRep = new SuplidorRepository();

        private void btnBorrarS_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string find = txtBuscar.Text.ToString();
            dgvBorrar.DataSource = new List<Suplidore>() { _suplidorRep.FindById(find) };
        }
    }
}
