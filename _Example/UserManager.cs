using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Example
{
    internal class UserManager
    {
        private User[] Users=new User[10];
        private byte _currentposition = 0;
        private readonly ISMSService _smsService;

        public UserManager(ISMSService smsService)
        {
            _smsService = smsService;
        }

        public void RegisterNewUser(User user)
        {
            Users[_currentposition] = user;
            _currentposition++;
            
            _smsService.SendSMS("0507695539",$"You are completely registered with the Name:{user.Name}");

        }
        public void EditUser(User user)
        {
            User olduser = GetUserById(user.Id);
            string oldname= olduser.Name;
            olduser.Name = user.Name;
            
            _smsService.SendSMS("0507695539", $"{oldname} changed his/her name to:{user.Name}");
        }
        private User GetUserById(int id)
        {
            foreach(User user in Users)
            {
                if (user.Id == id)
                    return user;
            }
            return null;
        }
    }
}
