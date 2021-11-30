﻿using System;
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

        public int Age { get; set; }

        public string Website { get; set; }

        [Required(ErrorMessage = "Açıklama alanı boş geçilemez.")]
        public string Description { get; set; }

        [Required]
        public int ImageId { get; set; }

        [Required]
        public int GenderId { get; set; }

        [Required]
        public int RoleId { get; set; }

        [Required]
        public int LocationId { get; set; }

        [Required]
        [ForeignKey("ImageId")]
        public virtual Images Image { get; set; }

        [Required]
        [ForeignKey("GenderId")]
        public virtual Genders Gender { get; set; }

        [Required]
        [ForeignKey("RoleId")]
        public virtual Roles Role { get; set; }

        [Required]
        [ForeignKey("LocationId")]
        public virtual Locations Location { get; set; }

    }
}