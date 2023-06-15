using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ruisoArtPage.Migrations
{
    /// <inheritdoc />
    public partial class MyAppMigrationThree : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commission_MyType_MyTypeId",
                table: "Commission");

            migrationBuilder.DropIndex(
                name: "IX_Commission_MyTypeId",
                table: "Commission");

            migrationBuilder.DropColumn(
                name: "MyTypeId",
                table: "Commission");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "DocProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Commission",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DocProduct_ProductId",
                table: "DocProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Commission_TypeId",
                table: "Commission",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commission_MyType_TypeId",
                table: "Commission",
                column: "TypeId",
                principalTable: "MyType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DocProduct_Product_ProductId",
                table: "DocProduct",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commission_MyType_TypeId",
                table: "Commission");

            migrationBuilder.DropForeignKey(
                name: "FK_DocProduct_Product_ProductId",
                table: "DocProduct");

            migrationBuilder.DropIndex(
                name: "IX_DocProduct_ProductId",
                table: "DocProduct");

            migrationBuilder.DropIndex(
                name: "IX_Commission_TypeId",
                table: "Commission");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "DocProduct");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Commission");

            migrationBuilder.AddColumn<int>(
                name: "MyTypeId",
                table: "Commission",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Commission_MyTypeId",
                table: "Commission",
                column: "MyTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Commission_MyType_MyTypeId",
                table: "Commission",
                column: "MyTypeId",
                principalTable: "MyType",
                principalColumn: "Id");
        }
    }
}
