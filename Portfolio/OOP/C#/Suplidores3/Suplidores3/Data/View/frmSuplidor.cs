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
    public partial class frmSuplidor : Form
    {
        ISuplidorRepository _suplidorRepository = new SuplidorRepository();
        public frmSuplidor()
        {
            InitializeComponent();
        }

        private void frmSuplidor_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void FillData()
        {
            dgvSuplidores.DataSource = _suplidorRepository.GetAll().Select(x => new
            {
                x.EmpresaId,
                x.RNC,
                x.NombreEmpresa,
                x.PersonaRepresentante,
                x.Direccion,
                x.Telefono
            }).ToList();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmCrear frmcrear = new frmCrear();
            frmcrear.ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string rnc = txtRNC.Text.ToString();

            if (String.IsNullOrWhiteSpace(rnc))
            {
                MessageBox.Show("Debe completar el campo ID");
            }
            else
            {
                if (MessageBox.Show("¿Seguro que desea actualizar este empleado?", "Actualizar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var BorrarSuplidor = supply_.Delete(rnc);
                    if (BorrarSuplidor.Result)
                    {
                        MessageBox.Show(BorrarSuplidor.Message);
                    }
                    else
                    {
                        MessageBox.Show("Empleado Eliminado satisfactoriamente");
                        FilldgvPantallaPrincipal();
                    }
                }
            }
        }

        private void dgvSuplidores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FillData();
        }
    }
}
