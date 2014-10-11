using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AbstractFactoryDemo.Models;
using AbstractFactoryDemo.Interface;

namespace AbstractFactoryDemo.Factories
{
    public class MessageFactory
    {
        private string _messageType;

        public MessageFactory(string MessageType) {
            _messageType = MessageType;
        }

        public ISendMessage setupMessage() {

            switch(_messageType) {
                case "Twitter" : 
                    return new TwitterMessage();
                    break;
                case "Facebook" :
                    return new FacebookMessage();
                    break;
                default : 
                    return new SMTPMessage();
                    break;  
            }
        }
    }
}