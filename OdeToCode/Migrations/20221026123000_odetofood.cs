using Microsoft.EntityFrameworkCore.Migrations;

namespace OdeToCode.Migrations
{
    public partial class odetofood : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantReview_Restaurants_RestaurantId",
                table: "RestaurantReview");

            migrationBuilder.RenameColumn(
                name: "Names",
                table: "Restaurants",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Raiting",
                table: "RestaurantReview",
                newName: "Rating");

            migrationBuilder.RenameColumn(
                name: "Body",
                table: "RestaurantReview",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "RestaurantId",
                table: "RestaurantReview",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "RestaurantReview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "RestaurantReview",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantReview_Restaurants_RestaurantId",
                table: "RestaurantReview",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantReview_Restaurants_RestaurantId",
                table: "RestaurantReview");

            migrationBuilder.DropColumn(
                name: "City",
                table: "RestaurantReview");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "RestaurantReview");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Restaurants",
                newName: "Names");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "RestaurantReview",
                newName: "Raiting");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "RestaurantReview",
                newName: "Body");

            migrationBuilder.AlterColumn<int>(
                name: "RestaurantId",
                table: "RestaurantReview",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantReview_Restaurants_RestaurantId",
                table: "RestaurantReview",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
