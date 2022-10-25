using ChessPieces.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessPieces.Domain.Abstract
{
    public interface IShapesRepository
    {
        IEnumerable<Shapes> Get();
        int Add(Shapes shapes);
        int Update(Shapes shapes);
        int Delete(long shapesId);
    }
}
