using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProjectStore.Core.Feature.Authentications.Query.Model
{
    public class UserModel
    {
        public Guid User_Id  { get; set; }
        public string User_Address { set; get; }
        public string User_UserName { get; set; }
        public string User_Password { get; set; }
        public string User_Email { get; set; }   
        public bool User_emailConfirmed { set; get; }
        public string User_PhoneNumber { get; set; }
        public bool User_phoneNumberConfirmed { set; get; }
        public string User_securityStamp { set; get; }
        public string User_accessFailedCount { set; get; }
    }
}
