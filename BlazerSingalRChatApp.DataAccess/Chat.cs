﻿using System.ComponentModel.DataAnnotations;

namespace BlazerSingalRChatApp.DataAccess
{
    public class Chat
    {
        [Required]
        public string Message { get; set; }
        [Required]
        public string UserName { get; set; }
        public DateTime DateTime { get; set; }
    }
}
