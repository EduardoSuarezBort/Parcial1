using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Carlos.Models
{
    public enum TypeTricks
    {
        Casa,
        Cama,
        Camisa
    }
    public class Clown
    {
        [Key]
        public int ClownID { get; set; }
        [Required]
        [Display(Name = "Nombre Completo")]
        [StringLength(24,MinimumLength =2)]
        public string NickName { get; set; }
        [Required]
        public TypeTricks Tricks { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }

    }
}