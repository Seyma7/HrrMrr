using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrrMrr.Entities
{
    public class Locations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocationId { get; set; }

        [Required(ErrorMessage = "Ülke alanı boş geçilemez.")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Şehir alanı boş geçilemez.")]
        public string City { get; set; }

        [Required(ErrorMessage = "İlçe alanı boş geçilemez.")]
        public string District { get; set; }

        [Required(ErrorMessage = "Mahalle alanı boş geçilemez.")]
        public string Neighbourhood { get; set; }

        [Required(ErrorMessage = "Sokak alanı boş geçilemez.")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Bina numarası alanı boş geçilemez.")]
        public string BuildingNumber { get; set; }

        [Required(ErrorMessage = "Bina numarası alanı boş geçilemez.")]
        public string ApartmentNumber { get; set; }

        [Required(ErrorMessage = "Adres açıklama alanı boş geçilemez.")]
        public string Description { get; set; }
    }
}
