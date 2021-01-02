using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLivraria.Models
{
    public class Autor
    {
        public int autorId { get; set; }
        public string Nomeautor { get; set; }
        public string Pais { get; set; }
        public string Lingua { get; set; }

        public ICollection<Autoria> Autorias { get; set; }
    }
}
