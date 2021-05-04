using Lab.Practic.Linq.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practic.Linq.Logic
{
    public class BasicLogic
    {
        protected readonly NorthwindContext context;

        public BasicLogic()
        {
            context = new NorthwindContext();

        }
    }
}
