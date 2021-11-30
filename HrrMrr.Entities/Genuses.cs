using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrrMrr.Entities
{
    public class Genuses
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GenusId { get; set; }

        [Required(ErrorMessage = "Evcil hayvanın cinsi alanı boş geçilemez.")]
        public string Name { get; set; }

        [Required]
        public int PetTypeId { get; set; }

        [Required]
        [ForeignKey("PetTypeId")]
        public virtual PetTypes PetType { get; set; }
    }
}
