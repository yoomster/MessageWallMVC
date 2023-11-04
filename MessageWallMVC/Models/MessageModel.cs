using System.ComponentModel.DataAnnotations;

namespace MessageWallMVC.Models
{
    public class MessageModel
    {
        [Required]
        [StringLength(20, MinimumLength = 2)]
        [Display(Name = "Message you'd like to leave:")]
        public string Message { get; set; }
    }
}
