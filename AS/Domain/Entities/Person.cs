using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS.Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime Idade { get; set; }
    }
}