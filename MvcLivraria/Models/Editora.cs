using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLivraria.Models
{
    public class Editora
    {
        public int EditoraId { get; set; }
        public string NomeEditora { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Morada { get; set; }
        public int NumeroPorta { get; set; }
        public string Fracao { get; set; }
        public int CodigoPostal { get; set; }
        public string WebSite { get; set; }

        public ICollection<Livro> Livros { get; set; }
    }
}
