using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KouintaBooksApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KouintaBooks",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    publisherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bookYear = table.Column<int>(type: "int", nullable: false),
                    bookPriceWVatND = table.Column<float>(type: "real", nullable: false),
                    finalBookPriceNoVat = table.Column<float>(type: "real", nullable: false),
                    finalBookPrice = table.Column<float>(type: "real", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KouintaBooks", x => x.BookID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KouintaBooks");
        }
    }
}
