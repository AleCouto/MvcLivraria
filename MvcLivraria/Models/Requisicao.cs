using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLivraria.Models
{
    public class Requisicao
    {
        public int RequisicaoId { get; set; }
        public DateTime DataRequisicao { get; set; }
        public DateTime DataDevolucao { get; set; }

        [ForeignKey("Livro")]
        public int LivroId { get; set; }
        public Livro Livro { get; set; }

        [ForeignKey("Localidade")]
        public int LocalidadeId { get; set; }
        public Localidade Localidade { get; set; }
    }
}
