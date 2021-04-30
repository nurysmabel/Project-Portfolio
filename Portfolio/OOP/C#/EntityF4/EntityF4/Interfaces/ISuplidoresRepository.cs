using EntityF4.DataModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityF4.Interfaces
{
    public interface ISuplidoresRepository
    {
        Suplidores Create(Suplidores suplidores);
        List<Suplidores> GetAll();
        Suplidores FindByRNC(string Rnc);
        OperationResult Update(Suplidores suplidores, string Rnc);
        OperationResult Delete(string Rnc);

    }
}
