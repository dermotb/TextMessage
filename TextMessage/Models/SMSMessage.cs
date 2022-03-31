using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TextMessage.Models
{
    public class SMSMessage
    {
        [Required(ErrorMessage = "Need a number!")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Phone Number must be 10 digits")]
        [DisplayName("To")]
        public string ToMobileNumber { get; set; }

        [Required(ErrorMessage = "Message must not be blank!")]
        [StringLength(140, ErrorMessage = "Maximum message is 140 characters!")]
        [DisplayName("Message")]
        public string Content { get; set; }
    }
}
