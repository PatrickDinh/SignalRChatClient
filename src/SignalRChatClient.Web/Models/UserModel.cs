using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignalRChatClient.Web.Models
{
    public class UserModel
    {
        [Required]
        [Display(Name = "User name")]
        public string NickName { get; set; }
    }
}