using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AbstractFactoryDemo.Interface;

namespace AbstractFactoryDemo.Models
{
    public class SMTPMessage : ISendMessage
    {
        public string SendMessage(Message message)
        {
            return string.Format("Message send to userID: {0}, send time {1}", message.sendTo, message.sendTime);
        }
    }
}