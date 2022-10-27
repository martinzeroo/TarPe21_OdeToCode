using Microsoft.EntityFrameworkCore.Migrations;

namespace OdeToCode.Migrations
{
    public partial class Create_RestaurantAndReviewscs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantReview_Restaurants_RestaurantId",
                table: "RestaurantReview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RestaurantReview",
                table: "RestaurantReview");

            migrationBuilder.RenameTable(
                name: "RestaurantReview",
                newName: "RestaurantReviews");

            migrationBuilder.RenameIndex(
                name: "IX_RestaurantReview_RestaurantId",
                table: "RestaurantReviews",
                newName: "IX_RestaurantReviews_RestaurantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RestaurantReviews",
                table: "RestaurantReviews",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantReviews_Restaurants_RestaurantId",
                table: "RestaurantReviews",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantReviews_Restaurants_RestaurantId",
                table: "RestaurantReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RestaurantReviews",
                table: "RestaurantReviews");

            migrationBuilder.RenameTable(
                name: "RestaurantReviews",
                newName: "RestaurantReview");

            migrationBuilder.RenameIndex(
                name: "IX_RestaurantReviews_RestaurantId",
                table: "RestaurantReview",
                newName: "IX_RestaurantReview_RestaurantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RestaurantReview",
                table: "RestaurantReview",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantReview_Restaurants_RestaurantId",
                table: "RestaurantReview",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
