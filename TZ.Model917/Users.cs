using System;

namespace TZ.Model917
{
    public class Users:BaseEntity
    {
        public string Users_Account { get; set; }
        public string Users_Password { get; set; }
        public string Users_NickName { get; set; }
        public string Users_Photo { get; set; }
        public Guid Users_RolesId { get; set; }
    }


}