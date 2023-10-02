﻿using Halloween.Models;
using Microsoft.EntityFrameworkCore;

namespace Halloween.Data
{
    public static class ModelBuilderGenerator
    {
        public static void GenerateData(this ModelBuilder builder)
        {
          #region Données pour SORCIERE
            builder.Entity<Sorciere>().HasData(new Sorciere() { Id = 1, Nom = "Maléfique", Origine = "Belle au bois dormant" });
            builder.Entity<Sorciere>().HasData(new Sorciere() { Id = 2, Nom = "Belagile", Origine = "Basque" });
            builder.Entity<Sorciere>().HasData(new Sorciere() { Id = 3, Nom = "Morgane", Origine = "Roi Arthur" });
            builder.Entity<Sorciere>().HasData(new Sorciere() { Id = 4, Nom = "Médée", Origine = "Grèce" });
            builder.Entity<Sorciere>().HasData(new Sorciere() { Id = 5, Nom = "Taoueille", Origine = "Acadie" });
            builder.Entity<Sorciere>().HasData(new Sorciere() { Id = 6, Nom = "Andor", Origine = "Acadie" });
            builder.Entity<Sorciere>().HasData(new Sorciere() { Id = 7, Nom = "Merlin", Origine = "Roi Arthur" });
            builder.Entity<Sorciere>().HasData(new Sorciere() { Id = 8, Nom = "Mariecomo", Origine = "Acadie" });
            #endregion

            #region Données pour POTION
            builder.Entity<Potion>().HasData(new Potion() { Id = 1, Nom = "Elixir cérébral de Barrufio", DateCreation = new DateTime(1811, 05, 04, 00, 00, 00), Sorciere_Id = 1 });
            builder.Entity<Potion>().HasData(new Potion() { Id = 2, Nom = "Philtre d'apathie", DateCreation = new DateTime(1815, 05, 04, 00, 00, 00), Sorciere_Id = 1 });
            builder.Entity<Potion>().HasData(new Potion() { Id = 3, Nom = "Potion de perception", DateCreation = new DateTime(1817, 05, 04, 00, 00, 00), Sorciere_Id = 3 });
            builder.Entity<Potion>().HasData(new Potion() { Id = 4, Nom = "Potion Exstimulo", DateCreation = new DateTime(1634, 05, 04, 00, 00, 00), Sorciere_Id = 4 });
            builder.Entity<Potion>().HasData(new Potion() { Id = 5, Nom = "Potion Exstimulo renforcée", DateCreation = new DateTime(1642, 05, 04, 00, 00, 00), Sorciere_Id = 4 });
            builder.Entity<Potion>().HasData(new Potion() { Id = 6, Nom = "Potion Exstimulo puissante", DateCreation = new DateTime(1732, 05, 04, 00, 00, 00), Sorciere_Id = 5 });
            builder.Entity<Potion>().HasData(new Potion() { Id = 7, Nom = "Potion de Soin", DateCreation = new DateTime(1721, 05, 04, 00, 00, 00), Sorciere_Id = 6 });
            builder.Entity<Potion>().HasData(new Potion() { Id = 8, Nom = "Potion scintillante", DateCreation = new DateTime(1787, 05, 04, 00, 00, 00), Sorciere_Id = 2 });
            builder.Entity<Potion>().HasData(new Potion() { Id = 9, Nom = "Potion d'Aiguise-Méninges", DateCreation = new DateTime(1634, 05, 04, 00, 00, 00), Sorciere_Id = 7 });
            builder.Entity<Potion>().HasData(new Potion() { Id = 10, Nom = "Breuvage abondant", DateCreation = new DateTime(1819, 05, 04, 00, 00, 00), Sorciere_Id = 3 });
            builder.Entity<Potion>().HasData(new Potion() { Id = 11, Nom = "Potion de Mémoire", DateCreation = new DateTime(1651, 05, 04, 00, 00, 00), Sorciere_Id = 8 });
            builder.Entity<Potion>().HasData(new Potion() { Id = 12, Nom = "Potion revigorante forte", DateCreation = new DateTime(1842, 05, 04, 00, 00, 00), Sorciere_Id = 2 });
            builder.Entity<Potion>().HasData(new Potion() { Id = 13, Nom = "Potion de l'Œil Vif", DateCreation = new DateTime(1652, 05, 04, 00, 00, 00), Sorciere_Id = 8 });
            builder.Entity<Potion>().HasData(new Potion() { Id = 14, Nom = "Potion d'invisibilité", DateCreation = new DateTime(1789, 05, 04, 00, 00, 00), Sorciere_Id = 2 });
            #endregion

            #region Données pour DETAILS POTION
            builder.Entity<DetailsPotion>().HasData(new DetailsPotion() { Id = 1, Couleur = "Rouge", VolumeEnLitre = 1.0f, Potion_Id = 1 });
            builder.Entity<DetailsPotion>().HasData(new DetailsPotion() { Id = 2, Couleur = "Verte", VolumeEnLitre = 0.5f, Potion_Id = 2 });
            builder.Entity<DetailsPotion>().HasData(new DetailsPotion() { Id = 3, Couleur = "Bleue", VolumeEnLitre = 0.666f, Potion_Id = 3 });
            builder.Entity<DetailsPotion>().HasData(new DetailsPotion() { Id = 4, Couleur = "Mauve", VolumeEnLitre = 2.8f, Potion_Id = 4 });
            builder.Entity<DetailsPotion>().HasData(new DetailsPotion() { Id = 5, Couleur = "Jaune", VolumeEnLitre = 0.45f, Potion_Id = 5 });
            builder.Entity<DetailsPotion>().HasData(new DetailsPotion() { Id = 6, Couleur = "Orange", VolumeEnLitre = 0.8f, Potion_Id = 6 });
            builder.Entity<DetailsPotion>().HasData(new DetailsPotion() { Id = 7, Couleur = "Rose", VolumeEnLitre = 0.95f, Potion_Id = 7 });
            builder.Entity<DetailsPotion>().HasData(new DetailsPotion() { Id = 8, Couleur = "Écarlate", VolumeEnLitre = 0.22f, Potion_Id = 8 });
            builder.Entity<DetailsPotion>().HasData(new DetailsPotion() { Id = 9, Couleur = "Cyan", VolumeEnLitre = 0.42f, Potion_Id = 9 });
            builder.Entity<DetailsPotion>().HasData(new DetailsPotion() { Id = 10, Couleur = "Brune", VolumeEnLitre = 8.0f, Potion_Id = 10 });
            builder.Entity<DetailsPotion>().HasData(new DetailsPotion() { Id = 11, Couleur = "Blanche", VolumeEnLitre = 1.4f, Potion_Id = 11 });
            builder.Entity<DetailsPotion>().HasData(new DetailsPotion() { Id = 12, Couleur = "Noire", VolumeEnLitre = 1.6f, Potion_Id = 12 });
            builder.Entity<DetailsPotion>().HasData(new DetailsPotion() { Id = 13, Couleur = "Pourpre", VolumeEnLitre = 0.431f, Potion_Id = 13 });
            builder.Entity<DetailsPotion>().HasData(new DetailsPotion() { Id = 14, Couleur = "Grise", VolumeEnLitre = 0.454f, Potion_Id = 14 });
            #endregion
        }
    }
}
