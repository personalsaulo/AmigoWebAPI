using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Amigo
    {
        public Amigo()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
    }
}
