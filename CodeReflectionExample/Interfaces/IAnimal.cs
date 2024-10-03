using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReflectionExample.Interfaces
{
    internal interface IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void SayHello();
    }
}
