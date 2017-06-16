using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TheMachineACafe.Models
{
    public class Selection
    {
        public int Id { get; set; }

        [Display(Name = "Selectionner un boisson")]
        [Required]
        public int BoissonId { get; set; }

        public ApplicationUser UserId { get; set; }

        [Display(Name = "Sucre")]
        [Required]
        public int Sucre { get; set; }

        [Display(Name = "Muge")]
        [Required]
        public bool HasMuge { get; set; }

        public virtual Boisson boisson { get; set; }
    }
}