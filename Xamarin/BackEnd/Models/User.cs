namespace BackEnd.Models
{
    using System.ComponentModel.DataAnnotations;
    public class User
    {
        [Required]
        [Display(Name ="Name")]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}