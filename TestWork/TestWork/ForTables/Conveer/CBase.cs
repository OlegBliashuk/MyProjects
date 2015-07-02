using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ForTables.Conveer
{
    public class CBase<task>
    {
        public List<ICBase<task>> MetodList = new List<ICBase<task>>();


        public CBase<task> Req(ICBase<task> operation)
        {
            MetodList.Add(operation);
            return this;
        }

        
        public void StartOf()
        {
            IEnumerable<task> current = new List<task>();
            foreach (ICBase<task> operation in MetodList)
            {
                current = operation.StartOf(current);
            }
            IEnumerator<task> enumerator = current.GetEnumerator();
            while (enumerator.MoveNext()) ;
        }


    }
}