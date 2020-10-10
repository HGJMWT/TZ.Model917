using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TZ.DAL;
using TZ.Model917;

namespace TZ.BLL
{
    public class FriendShipsService
    { 
        private FriendShipsManager fm=new FriendShipsManager();
        public int AddFriendShips(FriendShips friendShips)
        {
            return fm.AddFriendShips(friendShips);
        }

        public int EditFriendShips(FriendShips friendShips)
        {
            return fm.EditFriendShips(friendShips);
        }

        public int PutTrash(Guid id)
        {
            return fm.PutTrash(id);
        }

        public int RemoveSystemMenus(Guid id)
        {
            return fm.RemoveSystemMenus(id);
        }

        public List<FriendShips> GetAll()
        {
            return fm.GetAll();
        }

        public FriendShips GetFriendShipsById(Guid id)
        {
            return fm.GetFriendShipsById(id);
        }

        public List<FriendShips> GetFriendShipsByTitle(string title)
        {
            return fm.GetFriendShipsByTitle(title);
        }
    }
}
