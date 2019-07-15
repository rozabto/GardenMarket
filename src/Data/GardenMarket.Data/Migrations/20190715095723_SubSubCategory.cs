using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GardenMarket.Data.Migrations
{
    public partial class SubSubCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characteristics_SubCategories_SubCategoryId",
                table: "Characteristics");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubCategories_SubCategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Characteristics_SubCategoryId",
                table: "Characteristics");

            migrationBuilder.DropColumn(
                name: "SubCategoryId",
                table: "Characteristics");

            migrationBuilder.RenameColumn(
                name: "SubCategoryId",
                table: "Products",
                newName: "SubSubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                newName: "IX_Products_SubSubCategoryId");

            migrationBuilder.AddColumn<bool>(
                name: "Display",
                table: "Characteristics",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "SubSubCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LowestPrice = table.Column<float>(nullable: false),
                    HighestPrice = table.Column<float>(nullable: false),
                    Name = table.Column<string>(nullable: false, maxLength: 200),
                    SubCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubSubCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubSubCategory_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubSubCategory_SubCategoryId",
                table: "SubSubCategory",
                column: "SubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubSubCategory_SubSubCategoryId",
                table: "Products",
                column: "SubSubCategoryId",
                principalTable: "SubSubCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubSubCategory_SubSubCategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "SubSubCategory");

            migrationBuilder.DropColumn(
                name: "Display",
                table: "Characteristics");

            migrationBuilder.RenameColumn(
                name: "SubSubCategoryId",
                table: "Products",
                newName: "SubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_SubSubCategoryId",
                table: "Products",
                newName: "IX_Products_SubCategoryId");

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId",
                table: "Characteristics",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characteristics_SubCategoryId",
                table: "Characteristics",
                column: "SubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characteristics_SubCategories_SubCategoryId",
                table: "Characteristics",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubCategories_SubCategoryId",
                table: "Products",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
