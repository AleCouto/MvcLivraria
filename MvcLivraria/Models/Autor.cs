using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLivraria.Models
{
    public class Autor
    {
        
        public int autorId { get; set; }

        [Display(Name = "Nome do Autor")]
        public string Nomeautor { get; set; }

        [Display(Name = "País")]
        public string Pais { get; set; }

        [Display(Name = "língua")]
        public string Lingua { get; set; }

        public ICollection<Autoria> Autorias { get; set; }
    }
}
