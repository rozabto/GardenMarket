using Microsoft.EntityFrameworkCore.Migrations;

namespace GardenMarket.Data.Migrations
{
    public partial class SubSubCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubSubCategory_SubSubCategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_SubSubCategory_SubCategories_SubCategoryId",
                table: "SubSubCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubSubCategory",
                table: "SubSubCategory");

            migrationBuilder.RenameTable(
                name: "SubSubCategory",
                newName: "SubSubCategories");

            migrationBuilder.RenameIndex(
                name: "IX_SubSubCategory_SubCategoryId",
                table: "SubSubCategories",
                newName: "IX_SubSubCategories_SubCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubSubCategories",
                table: "SubSubCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubSubCategories_SubSubCategoryId",
                table: "Products",
                column: "SubSubCategoryId",
                principalTable: "SubSubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubSubCategories_SubCategories_SubCategoryId",
                table: "SubSubCategories",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubSubCategories_SubSubCategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_SubSubCategories_SubCategories_SubCategoryId",
                table: "SubSubCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubSubCategories",
                table: "SubSubCategories");

            migrationBuilder.RenameTable(
                name: "SubSubCategories",
                newName: "SubSubCategory");

            migrationBuilder.RenameIndex(
                name: "IX_SubSubCategories_SubCategoryId",
                table: "SubSubCategory",
                newName: "IX_SubSubCategory_SubCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubSubCategory",
                table: "SubSubCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubSubCategory_SubSubCategoryId",
                table: "Products",
                column: "SubSubCategoryId",
                principalTable: "SubSubCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubSubCategory_SubCategories_SubCategoryId",
                table: "SubSubCategory",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
