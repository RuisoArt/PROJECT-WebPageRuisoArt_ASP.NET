using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ruisoArtPage.Migrations
{
    /// <inheritdoc />
    public partial class MyAppMigrationFour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_MyType_TypeId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_TypeId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Item");

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "MyType",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyType_ItemId",
                table: "MyType",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyType_Item_ItemId",
                table: "MyType",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyType_Item_ItemId",
                table: "MyType");

            migrationBuilder.DropIndex(
                name: "IX_MyType_ItemId",
                table: "MyType");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "MyType");

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Item_TypeId",
                table: "Item",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_MyType_TypeId",
                table: "Item",
                column: "TypeId",
                principalTable: "MyType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
