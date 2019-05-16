using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstract
{
   public interface IAuditable
    {

        int ID { get; set; }
        string Code { get; set; }
        string Name { get; set; }
    }
}
