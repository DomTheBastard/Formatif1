using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MonApp_MVC.Entities
{
    public class Equipe
    {
        public int Id { get; set; }

        [DisplayName("Nom")]
        [StringLength(15, MinimumLength = 5)]
        public string Nom { get; set; }

        [DisplayName("Date de création")]
        [DataType(DataType.DateTime)]
        public DateTime DateCreation { get; set; }

        [DisplayName("Propriétaire")]
        [StringLength(25, MinimumLength = 5)]
        public string Proprietaire { get; set; }

        [ValidateNever]
        public List<Tournoi>? Tournois { get; set; }

        [ValidateNever]
        public List<Joueur>? Joueurs { get; set; }
    }
}
