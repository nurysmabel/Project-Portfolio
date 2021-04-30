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
    public partial class frmCrear : Form
    {
        ISuplidorRepository _suplidorRep = new SuplidorRepository();
        public frmCrear()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string personaR = txtPersonaRP.Text;
            string rnc = txtRnc.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;
            bool proveedor = checkBox.Checked;
            string numeroProveedor = txtNProveedor.Text;

            if (proveedor == true)
            {
                numeroProveedor = txtNProveedor.Text;
            }
            else numeroProveedor = null;

            if(string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(personaR)
                || string.IsNullOrWhiteSpace(rnc))
            {
                MessageBox.Show("Debes Completar Todos los Datos.");
            }
            else
            {
                _suplidorRep.Create(new Suplidore() { NombreEmpresa = nombre, PersonaRepresentante = personaR,
                RNC = rnc, Direccion = direccion, Telefono = telefono, ProveedorEstado = proveedor, RegistroProveedor = numeroProveedor,
                Estado = false});

                MessageBox.Show("Suplidor Creado exitosamente.");
                
            }
        }
    }
}
