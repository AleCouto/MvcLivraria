using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLivraria.Models
{
    public class Livro
    {
        public int LivroId { get; set; }

        [Display(Name = "Título do Livro")]
        public string Titulo { get; set; }
        public int? Ano { get; set; }

        [Display(Name = "Gênero")]
        public string Genero { get; set; }

        [Display(Name = "Preço")]
        public decimal? Preco { get; set; }
        public int? Quantidade { get; set; }

        [ForeignKey("Editora")]
        public int? EditoraId { get; set; }
        public Editora Editora { get; set; }

        public ICollection<Autoria> Autorias { get; set; }
    }
}

