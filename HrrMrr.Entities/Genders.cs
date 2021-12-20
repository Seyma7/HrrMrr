using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrrMrr.Entities
{
    public class Genders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GenderId { get; set; }

        [Required(ErrorMessage = "Cinsiyet alanı boş geçilemez.")]
        public string GenderName { get; set; }

        public virtual List<PetAdverts> PetAdverts { get; set; }

    }
}
