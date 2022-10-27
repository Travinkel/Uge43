using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge43
{
    public interface IRepository
    {
        Measurement GetByDate(DateTime date);
        void Create(Measurement measurement);
        void Update(Measurement measurement);
        void Delete(Measurement measurement);
    }
}
