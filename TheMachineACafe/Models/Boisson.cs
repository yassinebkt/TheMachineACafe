using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TheMachineACafe.Models
{
    public class Boisson
    {
        public int Id { get; set; }


        [Required]
        public string Nom { get; set; }
    }
}