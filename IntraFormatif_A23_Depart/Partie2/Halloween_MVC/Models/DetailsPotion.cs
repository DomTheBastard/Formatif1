
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace Halloween.Models
{
    public class DetailsPotion
    {
        public int Id { get; set; }
        public float VolumeEnLitre { get; set; }
        public string Couleur { get; set; }

        [ForeignKey("Potion")]
        public int Potion_Id { get; set; }
        [ValidateNever]
        public Potion Potion { get; set; }
    }
}
