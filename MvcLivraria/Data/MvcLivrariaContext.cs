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




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>().HasData(
                new Autor() { autorId = 1, Nomeautor = "Jose Saramago", Pais = "Portugal", Lingua = "português" },
                new Autor() { autorId = 2, Nomeautor = "Fernando Pessoa", Pais = "Portugal", Lingua = "português" },
                new Autor() { autorId = 3, Nomeautor = "Eça de Queirós", Pais = "Portugal", Lingua = "português" },
                new Autor() { autorId = 4, Nomeautor = "Miguel Torga", Pais = "Portugal", Lingua = "português" }
             );
            modelBuilder.Entity<Editora>().HasData(
                new Editora() { EditoraId = 1, NomeEditora = "Porto", Telefone = 226088322, Email = "porto@porto.com.pt", Morada = "Rua da Restauração", NumeroPorta = 365, Fracao = "na", CodigoPostal = 4099023, WebSite = "www.portoeditora.pt" },
                new Editora() { EditoraId = 2, NomeEditora = "Bertrand Editora", Telefone = 217626000, Email = "bertrand@editoa.com.pt", Morada = "Rua Professor Jorge Silva Horta", NumeroPorta = 1, Fracao = "na", CodigoPostal = 1500499, WebSite = "www.bertrandeditora.pt" },
                new Editora() { EditoraId = 3, NomeEditora = "Leya", Telefone = 214272200, Email = "leya@editora.com.pt", Morada = "Rua Cidade de Córdova", NumeroPorta = 2, Fracao = "na", CodigoPostal = 42610038, WebSite = "www.leya.com" }
             );
            modelBuilder.Entity<Livro>().HasData(
                new Livro() { LivroId = 1, Titulo = "Ensaio sobre a Cegueira", Ano = 1995, Genero = "Romance", Preco = 17, Quantidade = 100, EditoraId = 1 },
                new Livro() { LivroId = 2, Titulo = "Poemas Completos de Alberto Caeiro", Ano = 1946, Genero = "Poesia", Preco = 18, Quantidade = 150, EditoraId = 2 },
                new Livro() { LivroId = 3, Titulo = "O Primo Basílio", Ano = 1878, Genero = "Romance", Preco = 8, Quantidade = 150, EditoraId = 3 },
                new Livro() { LivroId = 4, Titulo = "Bichos", Ano = 1940, Genero = "Poesia", Preco = 10, Quantidade = 150, EditoraId = 1 }
             );
            modelBuilder.Entity<Autoria>().HasData(
                new Autoria() { AutoriaId = 1, AutorId = 1, LivroId = 1 },
                new Autoria() { AutoriaId = 2, AutorId = 2, LivroId = 2 },
                new Autoria() { AutoriaId = 3, AutorId = 3, LivroId = 3 },
                new Autoria() { AutoriaId = 4, AutorId = 4, LivroId = 4 }
             );
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario() { UsuarioId = 1, NomeUsuario = "Alexandre Couto", Telefone = 222222222, Email = "aecmar@hotmail.com", Morada = "Rua Vitimas da Guerra", NumeroPorta = 30, Fracao = "anexo a", CodigoPostal = 2825420, DataNascimento = null, BilheteIdentidade = 6666666, Contribuinte = 294260250 },
                new Usuario() { UsuarioId = 2, NomeUsuario = "João Golçalves", Telefone = 333333333, Email = "jg@hotmail.com", Morada = "Rua Lisboa", NumeroPorta = 40, Fracao = "na", CodigoPostal = 1234567, DataNascimento = null, BilheteIdentidade = 7777777, Contribuinte = 289076145 },
                new Usuario() { UsuarioId = 3, NomeUsuario = "Pedro Jose", Telefone = 444444444, Email = "apjose@hotmail.com", Morada = "Rua Almirante reis", NumeroPorta = 3, Fracao = "2E", CodigoPostal = 7654321, DataNascimento = null, BilheteIdentidade = 8888888, Contribuinte = 876956456 }
             );
            modelBuilder.Entity<Localidade>().HasData(
                new Localidade() { LocalidadeId = 1, Local = "Lisboa" },
                new Localidade() { LocalidadeId = 2, Local = "Porto" }
             );
            modelBuilder.Entity<Requisicao>().HasData(
                new Requisicao() { RequisicaoId = 1, LocalidadeId = 1, LivroId = 2 },
                new Requisicao() { RequisicaoId = 2, LocalidadeId = 2, LivroId = 1 },
                new Requisicao() { RequisicaoId = 3, LocalidadeId = 1, LivroId = 4 },
                new Requisicao() { RequisicaoId = 4, LocalidadeId = 2, LivroId = 3 }
             );
        }
    }
}
