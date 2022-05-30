using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleFinanceiro.DAL.Migrations
{
    public partial class criacaoBancoDados1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Funcoes",
                keyColumn: "Id",
                keyValue: "359b7853-e5b3-44c0-af1b-35fbd60acacc");

            migrationBuilder.DeleteData(
                table: "Funcoes",
                keyColumn: "Id",
                keyValue: "8a3949c7-0cf2-49c3-8c0c-9ea0b89f3b69");

            migrationBuilder.InsertData(
                table: "Funcoes",
                columns: new[] { "Id", "ConcurrencyStamp", "Descricao", "Name", "NormalizedName" },
                values: new object[] { "229c9686-72af-4efb-8361-5233846c1655", "518ed6b9-4a2d-4e13-804c-8cfb1faeec42", "Administrador do sistema", "Administrador", "ADMINSISTRADOR" });

            migrationBuilder.InsertData(
                table: "Funcoes",
                columns: new[] { "Id", "ConcurrencyStamp", "Descricao", "Name", "NormalizedName" },
                values: new object[] { "c914f4f0-726f-43ff-8757-b70e1d20ba7e", "a8d4b5b9-a1af-4a69-9232-84c9347ad785", "Usuario do sistema", "Usuario", "USUARIO" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Funcoes",
                keyColumn: "Id",
                keyValue: "229c9686-72af-4efb-8361-5233846c1655");

            migrationBuilder.DeleteData(
                table: "Funcoes",
                keyColumn: "Id",
                keyValue: "c914f4f0-726f-43ff-8757-b70e1d20ba7e");

            migrationBuilder.InsertData(
                table: "Funcoes",
                columns: new[] { "Id", "ConcurrencyStamp", "Descricao", "Name", "NormalizedName" },
                values: new object[] { "8a3949c7-0cf2-49c3-8c0c-9ea0b89f3b69", "748cb2da-e63f-417d-aa69-1afc6aaab526", "Administrador do sistema", "Administrador", "ADMINSISTRADOR" });

            migrationBuilder.InsertData(
                table: "Funcoes",
                columns: new[] { "Id", "ConcurrencyStamp", "Descricao", "Name", "NormalizedName" },
                values: new object[] { "359b7853-e5b3-44c0-af1b-35fbd60acacc", "8dfd3111-3a31-4aa2-a531-d212fb9fabe9", "Usuario do sistema", "Usuario", "USUARIO" });
        }
    }
}
