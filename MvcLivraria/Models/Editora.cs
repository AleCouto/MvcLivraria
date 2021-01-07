using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLivraria.Models
{
    public class Editora
    {
        public int EditoraId { get; set; }

        [Display(Name = "Nome da Editora")]
        public string NomeEditora { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Morada { get; set; }

        [Display(Name = "Número")]
        public int NumeroPorta { get; set; }

        [Display(Name = "Fração")]
        public string Fracao { get; set; }

        [Display(Name = "Código Postal")]
        public int CodigoPostal { get; set; }
        public string WebSite { get; set; }

        public ICollection<Livro> Livros { get; set; }
    }
}
