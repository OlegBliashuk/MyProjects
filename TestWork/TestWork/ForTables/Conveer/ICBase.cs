using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ForTables.Conveer
{
    public interface ICBase<task>
    {
        IEnumerable<task> StartOf(IEnumerable<task> input);

    }
}