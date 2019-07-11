using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GardenMarket.Data.Migrations
{
    public partial class Characteristics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characteristics_SubCategories_SubCategoryId",
                table: "Characteristics");

            migrationBuilder.AlterColumn<int>(
                name: "SubCategoryId",
                table: "Characteristics",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "CharacteristicCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CharacteristicId = table.Column<int>(nullable: false),
                    SubCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacteristicCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharacteristicCategories_Characteristics_CharacteristicId",
                        column: x => x.CharacteristicId,
                        principalTable: "Characteristics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CharacteristicCategories_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacteristicCategories_CharacteristicId",
                table: "CharacteristicCategories",
                column: "CharacteristicId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacteristicCategories_SubCategoryId",
                table: "CharacteristicCategories",
                column: "SubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characteristics_SubCategories_SubCategoryId",
                table: "Characteristics",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characteristics_SubCategories_SubCategoryId",
                table: "Characteristics");

            migrationBuilder.DropTable(
                name: "CharacteristicCategories");

            migrationBuilder.AlterColumn<int>(
                name: "SubCategoryId",
                table: "Characteristics",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Characteristics_SubCategories_SubCategoryId",
                table: "Characteristics",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
