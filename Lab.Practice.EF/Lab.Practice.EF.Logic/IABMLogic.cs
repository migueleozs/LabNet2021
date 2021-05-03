using Lab.Practice.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practice.EF.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T newEntity);

        void Delete(int id);

        void Update(T employees);

        void Print();
    }
}
