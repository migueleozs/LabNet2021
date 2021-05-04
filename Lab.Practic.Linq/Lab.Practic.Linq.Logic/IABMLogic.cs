using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practic.Linq.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T newEntity);
        void Update(T employees);
        void Delete(int id);
    }
}
