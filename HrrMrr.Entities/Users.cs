using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrrMrr.Entities
{
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Ad alanı boş geçilemez.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad alanı boş geçilemez.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Telefon numarası alanı boş geçilemez.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Mail adresi alanı boş geçilemez.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Password alanı boş geçilemez.")]
        public string Password { get; set; }

        public string Website { get; set; }

        [Required(ErrorMessage = "Açıklama alanı boş geçilemez.")]
        public string Description { get; set; }


        [Required]
        public int RoleId { get; set; }

        [Required]
        [ForeignKey("RoleId")]
        public virtual Roles Role { get; set; }


        [Required]
        public string Location { get; set; }

        public virtual List<PetAdverts> PetAdverts { get; set; }

    }
}
