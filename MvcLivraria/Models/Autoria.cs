using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLivraria.Models
{
    public class Autoria
    {
        public int AutoriaId { get; set; }


        [ForeignKey("Livro")]
        public int LivroId { get; set; }
        public Livro Livro { get; set; }

        [ForeignKey("Autor")]
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
    }
}
