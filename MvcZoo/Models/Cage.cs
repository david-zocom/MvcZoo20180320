using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcZoo.Models
{
    public class Cage
    {
        public int Id { get; set; }
        public IList<Animal> Animals { get; set; }

    }
}
