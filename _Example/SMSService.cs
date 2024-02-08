﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Example
{
    public class SMSService1:ISMSService
    {
        private string _sender = "TestSMS";
        public void SendSMS(string phoneNumber,string messageText)
        {
            Console.WriteLine($"I'm sending SMS with Provider1 to {phoneNumber} and text is->{messageText}");
        }
    }
    public class SMSService2:ISMSService
    {
        private string _sender = "TestSMS";
        public void SendSMS(string phoneNumber, string messageText)
        {
            Console.WriteLine($"SMS is sent with Provider2 to {phoneNumber} and text is {messageText}");
        }
    }
    public interface ISMSService 
    { 
    void SendSMS(string phoneNumber, string messageText);
    }

}
