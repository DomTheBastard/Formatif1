using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonApp_MVC.Migrations
{
    public partial class AjoutModèles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Proprietaire = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FicheOfficielle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Biographie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FicheOfficielle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tournoi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DateDebut = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournoi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Joueur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prenom = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FicheOfficielleId = table.Column<int>(type: "int", nullable: false),
                    EquipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joueur", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Joueur_Equipe_EquipeId",
                        column: x => x.EquipeId,
                        principalTable: "Equipe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Joueur_FicheOfficielle_FicheOfficielleId",
                        column: x => x.FicheOfficielleId,
                        principalTable: "FicheOfficielle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipeTournoi",
                columns: table => new
                {
                    EquipesId = table.Column<int>(type: "int", nullable: false),
                    TournoisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipeTournoi", x => new { x.EquipesId, x.TournoisId });
                    table.ForeignKey(
                        name: "FK_EquipeTournoi_Equipe_EquipesId",
                        column: x => x.EquipesId,
                        principalTable: "Equipe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipeTournoi_Tournoi_TournoisId",
                        column: x => x.TournoisId,
                        principalTable: "Tournoi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipeTournoi_TournoisId",
                table: "EquipeTournoi",
                column: "TournoisId");

            migrationBuilder.CreateIndex(
                name: "IX_Joueur_EquipeId",
                table: "Joueur",
                column: "EquipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Joueur_FicheOfficielleId",
                table: "Joueur",
                column: "FicheOfficielleId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipeTournoi");

            migrationBuilder.DropTable(
                name: "Joueur");

            migrationBuilder.DropTable(
                name: "Tournoi");

            migrationBuilder.DropTable(
                name: "Equipe");

            migrationBuilder.DropTable(
                name: "FicheOfficielle");
        }
    }
}
