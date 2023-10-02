using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Halloween.Migrations
{
    public partial class AjoutDetailsPotion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetailsPotion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolumeEnLitre = table.Column<float>(type: "real", nullable: false),
                    Couleur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Potion_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailsPotion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailsPotion_Potions_Potion_Id",
                        column: x => x.Potion_Id,
                        principalTable: "Potions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DetailsPotion",
                columns: new[] { "Id", "Couleur", "Potion_Id", "VolumeEnLitre" },
                values: new object[,]
                {
                    { 1, "Rouge", 1, 1f },
                    { 2, "Verte", 2, 0.5f },
                    { 3, "Bleue", 3, 0.666f },
                    { 4, "Mauve", 4, 2.8f },
                    { 5, "Jaune", 5, 0.45f },
                    { 6, "Orange", 6, 0.8f },
                    { 7, "Rose", 7, 0.95f },
                    { 8, "Écarlate", 8, 0.22f },
                    { 9, "Cyan", 9, 0.42f },
                    { 10, "Brune", 10, 8f },
                    { 11, "Blanche", 11, 1.4f },
                    { 12, "Noire", 12, 1.6f },
                    { 13, "Pourpre", 13, 0.431f },
                    { 14, "Grise", 14, 0.454f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailsPotion_Potion_Id",
                table: "DetailsPotion",
                column: "Potion_Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailsPotion");
        }
    }
}
