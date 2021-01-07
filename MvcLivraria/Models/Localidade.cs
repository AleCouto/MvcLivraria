using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLivraria.Models
{
    public class Localidade
    {
        public int LocalidadeId { get; set; }

        [Display(Name = "Localidade")]
        public string Local { get; set; }
    }
}
