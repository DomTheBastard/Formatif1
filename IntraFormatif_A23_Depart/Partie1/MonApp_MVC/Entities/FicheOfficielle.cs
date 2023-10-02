using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MonApp_MVC.Entities
{
    public class FicheOfficielle
    {
        public int Id { get; set; }

        [DisplayName("Biographie")]
        public string Biographie { get; set; }

        [DisplayName("Photo")]
        [StringLength(30)]
        public string Photo { get; set; }

        [ValidateNever]
        public Joueur Joueur { get; set; }
    }
}
