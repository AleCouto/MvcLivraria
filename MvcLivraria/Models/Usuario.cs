using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLivraria.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string NomeUsuario { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Morada { get; set; }
        public int NumeroPorta { get; set; }
        public string Fracao { get; set; }
        public int CodigoPostal { get; set; }
        public DateTime? DataNascimento { get; set; }
        public int BilheteIdentidade { get; set; }
        public int Contribuinte { get; set; }
        public ICollection<Requisicao> Requisicoes { get; set; }
        public ICollection<Livro> Livros { get; set; }
    }
}
