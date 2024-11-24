using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameApi.Migrations
{
    /// <inheritdoc />
    public partial class seedingdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "Developer", "Platform", "Publisher", "Title" },
                values: new object[,]
                {
                    { 1, "Nintendo", "Nintendo Switch", "Nintendo", "The Legend of Zelda: Breath of the Wild" },
                    { 2, "Santa Monica Studio", "PS5", "Sony Interactive Entertainment", "God of War: Ragnarok" },
                    { 3, "343 Industries", "Xbox Series X", "Xbox Game Studios", "Halo Infinite" },
                    { 4, "FromSoftware", "PC", "Bandai Namco Entertainment", "Elden Ring" },
                    { 5, "Mojang Studios", "PC", "Microsoft", "Minecraft" },
                    { 6, "CD Projekt Red", "PC", "CD Projekt", "Cyberpunk 2077" },
                    { 7, "Rockstar Games", "PS4", "Rockstar Games", "Red Dead Redemption 2" },
                    { 8, "Nintendo", "Nintendo Switch", "Nintendo", "Super Mario Odyssey" },
                    { 9, "Blizzard Entertainment", "PC", "Blizzard Entertainment", "Overwatch 2" },
                    { 10, "Ubisoft Montreal", "Xbox Series X", "Ubisoft", "Assassin's Creed Valhalla" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
