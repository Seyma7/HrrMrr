using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrrMrr.Entities
{
    public class Images
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageId { get; set; }

        [NotMapped]
        [DisplayName("Görsel Yükle")]
        public IFormFile ImageFile { get; set; }

        [Required]
        public int PetAdvertId{ get; set; }

        [Required]
        [ForeignKey("PetAdvertId")]
        public virtual PetAdverts PetAdvert { get; set; }
    }
}
