using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class DummyData01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodItems_Category_CategoryId",
                table: "FoodItems");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodItems_CoffeeShop_CoffeeShopId",
                table: "FoodItems");

            migrationBuilder.DropForeignKey(
                name: "FK_UserReviews_User_UserId",
                table: "UserReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoffeeShop",
                table: "CoffeeShop");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "CoffeeShop",
                newName: "CoffeeShops");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoffeeShops",
                table: "CoffeeShops",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodItems_Categories_CategoryId",
                table: "FoodItems",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodItems_CoffeeShops_CoffeeShopId",
                table: "FoodItems",
                column: "CoffeeShopId",
                principalTable: "CoffeeShops",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserReviews_Users_UserId",
                table: "UserReviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodItems_Categories_CategoryId",
                table: "FoodItems");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodItems_CoffeeShops_CoffeeShopId",
                table: "FoodItems");

            migrationBuilder.DropForeignKey(
                name: "FK_UserReviews_Users_UserId",
                table: "UserReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoffeeShops",
                table: "CoffeeShops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "CoffeeShops",
                newName: "CoffeeShop");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoffeeShop",
                table: "CoffeeShop",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodItems_Category_CategoryId",
                table: "FoodItems",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodItems_CoffeeShop_CoffeeShopId",
                table: "FoodItems",
                column: "CoffeeShopId",
                principalTable: "CoffeeShop",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserReviews_User_UserId",
                table: "UserReviews",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
