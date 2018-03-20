using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcZoo.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Cage MyCage { get; set; }
        
    }
}
