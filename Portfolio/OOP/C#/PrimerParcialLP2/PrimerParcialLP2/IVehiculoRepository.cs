using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialLP2
{
    public interface IVehiculoRepository
    {
        OperationResult Create(Vehiculo vehiculo);
        OperationResult GetAll(Vehiculo vehiculo);
        OperationResult Get(Vehiculo vehiculo);
        OperationResult Update(Vehiculo vehiculo);
        OperationResult Delete(Vehiculo vehiculo);

        
    }
}
