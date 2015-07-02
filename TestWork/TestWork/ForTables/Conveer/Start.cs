using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTables.Conveer
{
   public class Start:CBase<string>
   {
       public  Start()
       {
          
           Req(new EmtyT());
           Req(new Inwork());
           Req(new Crime());
           Req(new AddTo());
          
       }
    }
}
