using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationProjectStore.Service.Implementation.Security.Helper
{
    internal class SMTPOptions
    {
        public string Username { set; get; }
        public string Password { set; get; }
        public string Port { set; get; }
        public string Server { set; get; }
    }

    internal class  JWTOptions
    {
        public string Key { set; get; }
        public string Audience { set; get; }
        public string Expire { set; get; }
        public string Issuer { set; get; }
    }
}
