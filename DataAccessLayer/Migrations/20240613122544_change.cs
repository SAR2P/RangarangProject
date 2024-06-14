using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_ProductNameId",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "ProductNameId",
                table: "OrderDetails",
                newName: "ProductEId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_ProductNameId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_ProductEId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_ProductEId",
                table: "OrderDetails",
                column: "ProductEId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_ProductEId",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "ProductEId",
                table: "OrderDetails",
                newName: "ProductNameId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_ProductEId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_ProductNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_ProductNameId",
                table: "OrderDetails",
                column: "ProductNameId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
