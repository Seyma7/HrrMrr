using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [DisplayName("Adı")]
        public string Name { get; set; }

        [DisplayName("Kaç Aylık ?")]
        public int Month { get; set; }

        [DisplayName("Kaç Kilo ?")]
        public int Weight { get; set; }

        [Required(ErrorMessage ="Açıklama alanı boş geçilemez.")]
        [DisplayName("Açıklama")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Hikaye alanı boş geçilemez.Lütfen ilanınızı detaylandırınız.")]
        [DisplayName("Hikayesi")]
        public string Story { get; set; }

        public DateTime Date { get; set; }



        [Required]
        public string Gender { get; set; }


        [Required]
        public int PetTypeId { get; set; }


        [Required]
        [ForeignKey("PetTypeId")]
        public virtual PetTypes PetType { get; set; }




        [Required]
        [DisplayName("Adresi")]
        public string Location { get; set; }


        [Required]
        public int UserId { get; set; }

        [Required]
        [ForeignKey("UserId")]
        public virtual Users User { get; set; }



        [Required]
        public int ImageId { get; set; }

        [Required]
        [ForeignKey("ImageId")]
        public virtual Images Image { get; set; }

        public virtual List<Comments> Comments { get; set; }

    }
}
