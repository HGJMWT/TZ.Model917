using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TZ.DAL;
using TZ.Model917;

namespace TZ.BLL
{
    public class UsersService
    {
        UsersManager um = new UsersManager();

        public int AddUsers(Users users)
        {
            return um.AddUsers(users);
        }

        public int EditUsers(Users users)
        {
            return um.EditUsers(users);
        }

        public int PutTrash(Guid id)
        {
            return um.PutTrash(id);
        }
        public List<Users> GetAll()
        {
            return um.GetAll();
        }
        public Users GetUsersById(Guid id)
        {
            return um.GetUsersById(id);
        }
    }
}
