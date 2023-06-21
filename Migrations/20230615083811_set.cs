using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDOprationAPI.Migrations
{
    public partial class set : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryMaster",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryMaster", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ProuductClasse",
                columns: table => new
                {
                    P_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductQuntity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductPrice = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProuductClasse", x => x.P_Id);
                });

            migrationBuilder.CreateTable(
                name: "ProudctMaster",
                columns: table => new
                {
                    P_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductQuntity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductPrice = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryMasterCategoryId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProudctMaster", x => x.P_Id);
                    table.ForeignKey(
                        name: "FK_ProudctMaster_CategoryMaster_CategoryMasterCategoryId",
                        column: x => x.CategoryMasterCategoryId,
                        principalTable: "CategoryMaster",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProudctMaster_CategoryMasterCategoryId",
                table: "ProudctMaster",
                column: "CategoryMasterCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProudctMaster");

            migrationBuilder.DropTable(
                name: "ProuductClasse");

            migrationBuilder.DropTable(
                name: "CategoryMaster");
        }
    }
}
