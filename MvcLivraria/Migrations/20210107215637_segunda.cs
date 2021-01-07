using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcLivraria.Migrations
{
    public partial class segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "dataDevolucao",
                table: "Requisicao",
                newName: "DataDevolucao");

            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "autorId", "Lingua", "Nomeautor", "Pais" },
                values: new object[,]
                {
                    { 1, "português", "Jose Saramago", "Portugal" },
                    { 2, "português", "Fernando Pessoa", "Portugal" },
                    { 3, "português", "Eça de Queirós", "Portugal" },
                    { 4, "português", "Miguel Torga", "Portugal" }
                });

            migrationBuilder.InsertData(
                table: "Editora",
                columns: new[] { "EditoraId", "CodigoPostal", "Email", "Fracao", "Morada", "NomeEditora", "NumeroPorta", "Telefone", "WebSite" },
                values: new object[,]
                {
                    { 1, 4099023, "porto@porto.com.pt", "na", "Rua da Restauração", "Porto", 365, 226088322, "www.portoeditora.pt" },
                    { 2, 1500499, "bertrand@editoa.com.pt", "na", "Rua Professor Jorge Silva Horta", "Bertrand Editora", 1, 217626000, "www.bertrandeditora.pt" },
                    { 3, 42610038, "leya@editora.com.pt", "na", "Rua Cidade de Córdova", "Leya", 2, 214272200, "www.leya.com" }
                });

            migrationBuilder.InsertData(
                table: "Localidade",
                columns: new[] { "LocalidadeId", "Local" },
                values: new object[,]
                {
                    { 1, "Lisboa" },
                    { 2, "Porto" }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UsuarioId", "BilheteIdentidade", "CodigoPostal", "Contribuinte", "DataNascimento", "Email", "Fracao", "Morada", "NomeUsuario", "NumeroPorta", "Telefone" },
                values: new object[,]
                {
                    { 1, 6666666, 2825420, 294260250, null, "aecmar@hotmail.com", "anexo a", "Rua Vitimas da Guerra", "Alexandre Couto", 30, 222222222 },
                    { 2, 7777777, 1234567, 289076145, null, "jg@hotmail.com", "na", "Rua Lisboa", "João Golçalves", 40, 333333333 },
                    { 3, 8888888, 7654321, 876956456, null, "apjose@hotmail.com", "2E", "Rua Almirante reis", "Pedro Jose", 3, 444444444 }
                });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "LivroId", "Ano", "EditoraId", "Genero", "Preco", "Quantidade", "Titulo", "UsuarioId" },
                values: new object[,]
                {
                    { 1, 1995, 1, "Romance", 17m, 100, "Ensaio sobre a Cegueira", null },
                    { 4, 1940, 1, "Poesia", 10m, 150, "Bichos", null },
                    { 2, 1946, 2, "Poesia", 18m, 150, "Poemas Completos de Alberto Caeiro", null },
                    { 3, 1878, 3, "Romance", 8m, 150, "O Primo Basílio", null }
                });

            migrationBuilder.InsertData(
                table: "Autoria",
                columns: new[] { "AutoriaId", "AutorId", "LivroId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 4, 4, 4 },
                    { 2, 2, 2 },
                    { 3, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Requisicao",
                columns: new[] { "RequisicaoId", "DataDevolucao", "DataRequisicao", "LivroId", "LocalidadeId", "UsuarioId" },
                values: new object[,]
                {
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, null },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Autoria",
                keyColumn: "AutoriaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Autoria",
                keyColumn: "AutoriaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Autoria",
                keyColumn: "AutoriaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Autoria",
                keyColumn: "AutoriaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Requisicao",
                keyColumn: "RequisicaoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Requisicao",
                keyColumn: "RequisicaoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Requisicao",
                keyColumn: "RequisicaoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Requisicao",
                keyColumn: "RequisicaoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "UsuarioId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "autorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "autorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "autorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "autorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "LivroId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "LivroId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "LivroId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "LivroId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Localidade",
                keyColumn: "LocalidadeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Localidade",
                keyColumn: "LocalidadeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Editora",
                keyColumn: "EditoraId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Editora",
                keyColumn: "EditoraId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Editora",
                keyColumn: "EditoraId",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "DataDevolucao",
                table: "Requisicao",
                newName: "dataDevolucao");
        }
    }
}
