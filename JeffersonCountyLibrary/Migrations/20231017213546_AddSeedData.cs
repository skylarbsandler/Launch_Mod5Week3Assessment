using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JeffersonCountyLibrary.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "branches",
                columns: new[] { "id", "librarian_id", "name" },
                values: new object[,]
                {
                    { 1, null, "Arvada" },
                    { 2, null, "Belmar" },
                    { 3, null, "Columbine" }
                });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "id", "author", "branch_id", "checked_out_by_id", "due_date", "title" },
                values: new object[,]
                {
                    { 1, "Barbara Kingsolver", 1, null, null, "Demon Copperhead" },
                    { 2, "Hannah Grace", 2, null, null, "Icebreaker" },
                    { 3, "Colleen Hoover", 3, null, null, "Verity" },
                    { 4, "Colleen Hoover", 1, null, null, "It Starts With Us" },
                    { 5, "Abraham Verghese", 2, null, null, "The Covenant of Water" },
                    { 6, "Freida McFadden", 3, null, null, "The Housemaid" },
                    { 7, "Colleen Hoover", 1, null, null, "It Ends With Us" },
                    { 8, "Bonnie Garmus", 2, null, null, "Lessons In Chemistry" },
                    { 9, "Colleen Hoover", 3, null, null, "Too Late" },
                    { 10, "James McBride", 1, null, null, "The Heaven & Earth Grocery Store" },
                    { 11, "Lisa Jewell", 2, null, null, "None Of This Is True" },
                    { 12, "Danielle Steel", 3, null, null, "Happiness" },
                    { 13, "Ann Patchett", 1, null, null, "Tom Lake" },
                    { 14, "Rebecca Yarros", 2, null, null, "Fourth Wing" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "branches",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "branches",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "branches",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
