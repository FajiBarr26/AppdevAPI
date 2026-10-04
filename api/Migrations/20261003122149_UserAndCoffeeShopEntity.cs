using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class UserAndCoffeeShopEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "UserReviews",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "FoodItems",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CoffeeShopId",
                table: "FoodItems",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CoffeeShop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    CeilingPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    FloorPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    OpeningHour = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    OverallRating = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoffeeShop", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserReviews_UserId",
                table: "UserReviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItems_CategoryId",
                table: "FoodItems",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItems_CoffeeShopId",
                table: "FoodItems",
                column: "CoffeeShopId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "CoffeeShop");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_UserReviews_UserId",
                table: "UserReviews");

            migrationBuilder.DropIndex(
                name: "IX_FoodItems_CategoryId",
                table: "FoodItems");

            migrationBuilder.DropIndex(
                name: "IX_FoodItems_CoffeeShopId",
                table: "FoodItems");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserReviews");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "FoodItems");

            migrationBuilder.DropColumn(
                name: "CoffeeShopId",
                table: "FoodItems");
        }
    }
}
