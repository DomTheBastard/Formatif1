using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MonApp_MVC.Entities
{
    public class Tournoi
    {
        public int Id { get; set; }

        [DisplayName("Titre")]
        [StringLength(15, MinimumLength = 5)]
        public string Titre { get; set; }

        [DisplayName("Date de début")]
        [DataType(DataType.DateTime)]
        public DateTime DateDebut { get; set; }

        [ValidateNever]
        public List<Equipe>? Equipes { get; set; }
    }
}
