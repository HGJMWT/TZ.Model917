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
        private UsersManager um = new UsersManager();

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

        public int RemoveUsers(Guid id)
        {
            return um.RemoveUsers(id);
        }

        public List<Users> GetAll()
        {
            return um.GetAll();
        }

        public Users GetUsersById(Guid id)
        {
            return um.GetUsersById(id);
        }

        public List<Users> GetUsersByNickName(string nickName)
        {
            return um.GetUsersByNickName(nickName);
        }

        public int ChangePwd(Users users)
        {
            return um.ChangePwd(users);
        }

        public Users SignIn(string account, string password)
        {
            return um.SignIn(account, password);
        }

        public List<Users> GetUsersInTrash()
        {
            return um.GetUsersInTrash();
        }

        public int RestoreUsers(Guid id)
        {
            return um.RestoreUsers(id);
        }

        public List<Users> GetUsersInTrashByNickName(string nickName)
        {
            return um.GetUsersInTrashByNickName(nickName);
        }

        public bool IsExists(string account)
        {
            return um.IsExists(account);
        }
    }
}
