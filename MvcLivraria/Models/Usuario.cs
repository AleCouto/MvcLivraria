using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLivraria.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        [Display(Name = "Nome")]
        public string NomeUsuario { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Morada { get; set; }
        [Display(Name = "Número")]
        public int NumeroPorta { get; set; }
        [Display(Name = "Fração")]
        public string Fracao { get; set; }
        [Display(Name = "Código Postal")]
        public int CodigoPostal { get; set; }
        [Display(Name = "Data de Nascimento")]
        public DateTime? DataNascimento { get; set; }
        [Display(Name = "BI")]
        public int BilheteIdentidade { get; set; }
        [Display(Name = "NIF")]
        public int Contribuinte { get; set; }
        public ICollection<Requisicao> Requisicoes { get; set; }
        public ICollection<Livro> Livros { get; set; }
    }
}
