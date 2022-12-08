using SimpleIt_Run.Abstractions.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIt_Run.Models
{
    public class Teacher : Person, ITeacher
    {
        public void Teach()
        {
            throw new NotImplementedException();
        }
    }
}
