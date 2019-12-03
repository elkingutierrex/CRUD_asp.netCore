using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp.netCoreMVCCRUD.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id_cliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre_cliente = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(11)", nullable: true),
                    tipo_cliente = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    pais = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    departamento = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ciudad = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id_cliente);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
