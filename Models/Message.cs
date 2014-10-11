using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AbstractFactoryDemo.Models
{
    public class Message
    {
        [DisplayName("Send message to")]
        [Required(ErrorMessage = "Please enter recipient")]
        public string sendTo { get; set; }
        [DisplayName("Your message")]
        [Required(ErrorMessage = "Please, dont forget your message..")]
        public string content { get; set; }
        [DisplayName("Send your message using")]
        [Required(ErrorMessage="Please select how you would like to send your message")]
        public string MessageType { get; set; }

        public DateTime sendTime;

        public Message(){
            sendTime = DateTime.Now;
        }
    }
}