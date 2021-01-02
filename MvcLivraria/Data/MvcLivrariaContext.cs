using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcLivraria.Models;

namespace MvcLivraria.Data
{
    public class MvcLivrariaContext : DbContext
    {
        public MvcLivrariaContext (DbContextOptions<MvcLivrariaContext> options)
            : base(options)
        {
        }

        public DbSet<MvcLivraria.Models.Usuario> Usuario { get; set; }

        public DbSet<MvcLivraria.Models.Autor> Autor { get; set; }

        public DbSet<MvcLivraria.Models.Editora> Editora { get; set; }

        public DbSet<MvcLivraria.Models.Livro> Livro { get; set; }

        public DbSet<MvcLivraria.Models.Localidade> Localidade { get; set; }

        public DbSet<MvcLivraria.Models.Requisicao> Requisicao { get; set; }
    }
}
