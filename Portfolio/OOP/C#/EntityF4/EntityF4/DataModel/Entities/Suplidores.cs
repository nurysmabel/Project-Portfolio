using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace EntityF4.DataModel.Entities
{
    //[Table("Hola")]

    public class Suplidores
    {
        [Key]
        public int EmpresaId { get; set; }
        public string NombreEmpresa { get; set; }
        public string PersonaRepresentante { get; set; }
        public string RNC { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool ProveedorEstado { get; set; }
        public string RegistroProveedor { get; set; }
        public bool Estado { get; set; }

    }
}
