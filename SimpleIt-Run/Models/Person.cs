using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIt_Run.Models
{
    public abstract class Person : EntityBase
    {
        public string  Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
       

    }
}
