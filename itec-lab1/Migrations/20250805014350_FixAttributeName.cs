using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace itec_lab1.Migrations
{
    /// <inheritdoc />
    public partial class FixAttributeName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categories_officers_OfficersId",
                table: "categories");

            migrationBuilder.DropForeignKey(
                name: "FK_categories_officers_OfficersId1",
                table: "categories");

            migrationBuilder.DropForeignKey(
                name: "FK_products_officers_OfficersId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_officers_OfficersId1",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_OfficersId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_OfficersId1",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_categories_OfficersId",
                table: "categories");

            migrationBuilder.DropIndex(
                name: "IX_categories_OfficersId1",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "OfficersId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "OfficersId1",
                table: "products");

            migrationBuilder.DropColumn(
                name: "OfficersId",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "OfficersId1",
                table: "categories");

            migrationBuilder.AddColumn<int>(
                name: "ProductCreatedBy",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductUpdatedBy",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryCreatedBy",
                table: "categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryUpdatedBy",
                table: "categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_products_ProductCreatedBy",
                table: "products",
                column: "ProductCreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_products_ProductUpdatedBy",
                table: "products",
                column: "ProductUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_categories_CategoryCreatedBy",
                table: "categories",
                column: "CategoryCreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_categories_CategoryUpdatedBy",
                table: "categories",
                column: "CategoryUpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_categories_officers_CategoryCreatedBy",
                table: "categories",
                column: "CategoryCreatedBy",
                principalTable: "officers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_categories_officers_CategoryUpdatedBy",
                table: "categories",
                column: "CategoryUpdatedBy",
                principalTable: "officers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_products_officers_ProductCreatedBy",
                table: "products",
                column: "ProductCreatedBy",
                principalTable: "officers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_products_officers_ProductUpdatedBy",
                table: "products",
                column: "ProductUpdatedBy",
                principalTable: "officers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categories_officers_CategoryCreatedBy",
                table: "categories");

            migrationBuilder.DropForeignKey(
                name: "FK_categories_officers_CategoryUpdatedBy",
                table: "categories");

            migrationBuilder.DropForeignKey(
                name: "FK_products_officers_ProductCreatedBy",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_officers_ProductUpdatedBy",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_ProductCreatedBy",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_ProductUpdatedBy",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_categories_CategoryCreatedBy",
                table: "categories");

            migrationBuilder.DropIndex(
                name: "IX_categories_CategoryUpdatedBy",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "ProductCreatedBy",
                table: "products");

            migrationBuilder.DropColumn(
                name: "ProductUpdatedBy",
                table: "products");

            migrationBuilder.DropColumn(
                name: "CategoryCreatedBy",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "CategoryUpdatedBy",
                table: "categories");

            migrationBuilder.AddColumn<int>(
                name: "OfficersId",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OfficersId1",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OfficersId",
                table: "categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OfficersId1",
                table: "categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_OfficersId",
                table: "products",
                column: "OfficersId");

            migrationBuilder.CreateIndex(
                name: "IX_products_OfficersId1",
                table: "products",
                column: "OfficersId1");

            migrationBuilder.CreateIndex(
                name: "IX_categories_OfficersId",
                table: "categories",
                column: "OfficersId");

            migrationBuilder.CreateIndex(
                name: "IX_categories_OfficersId1",
                table: "categories",
                column: "OfficersId1");

            migrationBuilder.AddForeignKey(
                name: "FK_categories_officers_OfficersId",
                table: "categories",
                column: "OfficersId",
                principalTable: "officers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_categories_officers_OfficersId1",
                table: "categories",
                column: "OfficersId1",
                principalTable: "officers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_officers_OfficersId",
                table: "products",
                column: "OfficersId",
                principalTable: "officers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_officers_OfficersId1",
                table: "products",
                column: "OfficersId1",
                principalTable: "officers",
                principalColumn: "Id");
        }
    }
}
