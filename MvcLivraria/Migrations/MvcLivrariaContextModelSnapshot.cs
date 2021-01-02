﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcLivraria.Data;

namespace MvcLivraria.Migrations
{
    [DbContext(typeof(MvcLivrariaContext))]
    partial class MvcLivrariaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("MvcLivraria.Models.Autor", b =>
                {
                    b.Property<int>("autorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Lingua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nomeautor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("autorId");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("MvcLivraria.Models.Autoria", b =>
                {
                    b.Property<int>("AutoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AutorId")
                        .HasColumnType("int");

                    b.Property<int>("LivroId")
                        .HasColumnType("int");

                    b.HasKey("AutoriaId");

                    b.HasIndex("AutorId");

                    b.HasIndex("LivroId");

                    b.ToTable("Autoria");
                });

            modelBuilder.Entity("MvcLivraria.Models.Editora", b =>
                {
                    b.Property<int>("EditoraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CodigoPostal")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fracao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Morada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeEditora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroPorta")
                        .HasColumnType("int");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.Property<string>("WebSite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EditoraId");

                    b.ToTable("Editora");
                });

            modelBuilder.Entity("MvcLivraria.Models.Livro", b =>
                {
                    b.Property<int>("LivroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("Ano")
                        .HasColumnType("int");

                    b.Property<int?>("EditoraId")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Quantidade")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("LivroId");

                    b.HasIndex("EditoraId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Livro");
                });

            modelBuilder.Entity("MvcLivraria.Models.Localidade", b =>
                {
                    b.Property<int>("LocalidadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Local")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocalidadeId");

                    b.ToTable("Localidade");
                });

            modelBuilder.Entity("MvcLivraria.Models.Requisicao", b =>
                {
                    b.Property<int>("RequisicaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DataRequisicao")
                        .HasColumnType("datetime2");

                    b.Property<int>("LivroId")
                        .HasColumnType("int");

                    b.Property<int>("LocalidadeId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dataDevolucao")
                        .HasColumnType("datetime2");

                    b.HasKey("RequisicaoId");

                    b.HasIndex("LivroId");

                    b.HasIndex("LocalidadeId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Requisicao");
                });

            modelBuilder.Entity("MvcLivraria.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BilheteIdentidade")
                        .HasColumnType("int");

                    b.Property<int>("CodigoPostal")
                        .HasColumnType("int");

                    b.Property<int>("Contribuinte")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fracao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Morada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroPorta")
                        .HasColumnType("int");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("MvcLivraria.Models.Autoria", b =>
                {
                    b.HasOne("MvcLivraria.Models.Autor", "Autor")
                        .WithMany("Autorias")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvcLivraria.Models.Livro", "Livro")
                        .WithMany("Autorias")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("MvcLivraria.Models.Livro", b =>
                {
                    b.HasOne("MvcLivraria.Models.Editora", "Editora")
                        .WithMany("Livros")
                        .HasForeignKey("EditoraId");

                    b.HasOne("MvcLivraria.Models.Usuario", null)
                        .WithMany("Livros")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Editora");
                });

            modelBuilder.Entity("MvcLivraria.Models.Requisicao", b =>
                {
                    b.HasOne("MvcLivraria.Models.Livro", "Livro")
                        .WithMany()
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvcLivraria.Models.Localidade", "Localidade")
                        .WithMany()
                        .HasForeignKey("LocalidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvcLivraria.Models.Usuario", null)
                        .WithMany("Requisicoes")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Livro");

                    b.Navigation("Localidade");
                });

            modelBuilder.Entity("MvcLivraria.Models.Autor", b =>
                {
                    b.Navigation("Autorias");
                });

            modelBuilder.Entity("MvcLivraria.Models.Editora", b =>
                {
                    b.Navigation("Livros");
                });

            modelBuilder.Entity("MvcLivraria.Models.Livro", b =>
                {
                    b.Navigation("Autorias");
                });

            modelBuilder.Entity("MvcLivraria.Models.Usuario", b =>
                {
                    b.Navigation("Livros");

                    b.Navigation("Requisicoes");
                });
#pragma warning restore 612, 618
        }
    }
}
