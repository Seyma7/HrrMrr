using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrrMrr.Entities
{
    public class PetTypes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PetTypeId { get; set; }

        [Required(ErrorMessage = "Evcil hayvanın türü alanı boş geçilemez.")]
        public string TypeName { get; set; }
    }
}
