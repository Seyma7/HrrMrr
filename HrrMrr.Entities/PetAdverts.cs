using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrrMrr.Entities
{
    public class PetAdverts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PetAdvertId { get; set; }

        public string Name { get; set; }

        public int Month { get; set; }

        public int Weight { get; set; }

        [Required(ErrorMessage ="Açıklama alanı boş geçilemez.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Hikaye alanı boş geçilemez.Lütfen ilanınızı detaylandırınız.")]
        public string Story { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public int ImageId { get; set; }

        [Required]
        public int GenderId { get; set; }

        [Required]
        public int PetTypeId { get; set; }

        [Required]
        public int LocationId { get; set; }

        [Required]
        public int UserId { get; set; }

        public virtual List<Images> Images { get; set; }

        [Required]
        [ForeignKey("GenderId")]
        public virtual Genders Gender { get; set; }

        [Required]
        [ForeignKey("PetTypeId")]
        public virtual PetTypes PetType { get; set; }

        [Required]
        [ForeignKey("LocationId")]
        public virtual Locations Location { get; set; }

        [Required]
        [ForeignKey("UserId")]
        public virtual Users User { get; set; }
    }
}
