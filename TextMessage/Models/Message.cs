using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TextMessage.Models
{
    public class Message
    {
        [Required]
        [Phone]
        [Display(Name = "Destination Number:")]
        public string DestinationNumber { get; set; }
        [MinLength(1)]
        [MaxLength(140)]
        [Display(Name = "Message text:")]
        public string Content { get; set; }
    }
}