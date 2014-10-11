using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AbstractFactoryDemo.Models;

namespace AbstractFactoryDemo.Interface
{
    public interface ISendMessage
    {
        string SendMessage(Message message);
    }
}