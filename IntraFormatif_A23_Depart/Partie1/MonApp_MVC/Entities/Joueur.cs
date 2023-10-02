using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MonApp_MVC.Entities
{
    public class Joueur
    {
        public int Id { get; set; }

        [DisplayName("Prénom")]
        [StringLength(15, MinimumLength = 5)]
        public string Prenom { get; set; }

        [DisplayName("Nom")]
        [StringLength(15, MinimumLength = 5)]
        public string Nom { get; set; }

        [DisplayName("Position")]
        [StringLength(10, MinimumLength = 5)]
        public string Position { get; set; }

        public int FicheOfficielleId { get; set; }
        [ValidateNever]
        public FicheOfficielle? FicheOfficielle { get; set; }

        public int EquipeId { get; set; }
        [ValidateNever]
        public Equipe Equipe { get; set; }
    }
}
