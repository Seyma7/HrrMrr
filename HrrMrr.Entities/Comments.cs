using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HrrMrr.Entities
{
    public class Comments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentId { get; set; }

        [Required(ErrorMessage ="Yorum alanı boş geçilemez.")]
        public string Text { get; set; }

        public DateTime Date { get; set; }



        [Required]
        public int UserId { get; set; }

        [Required]
        [ForeignKey("UserId")]
        public virtual Users User { get; set; }




        [Required]
        public int PetAdvertId { get; set; }

        [Required]
        [ForeignKey("PetAdvertId")]
        public virtual PetAdverts PetAdvert { get; set; }
    }
}
