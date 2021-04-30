using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Suplidores3.Data.Dbcontext;

namespace Suplidores3
{
    public interface ISuplidorRepository
    {
        Suplidore Create(Suplidore suplidores);
        List<Suplidore> GetAll();
        Suplidore FindById(string Rnc);
        OperationResult Update(Suplidore suplidores, string Rnc);
        OperationResult Delete(string Rnc);
            
            }
}
