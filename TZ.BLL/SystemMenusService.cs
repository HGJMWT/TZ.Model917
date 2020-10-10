using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TZ.DAL;
using TZ.Model917;

namespace TZ.BLL
{
    public class SystemMenusService
    {
        private SystemMenusManager sm= new SystemMenusManager();
        public int AddSystemMenus(SystemMenus systemMenus)
        {
            return sm.AddSystemMenus(systemMenus);
        }

        public int EditSystemMenus(SystemMenus systemMenus)
        {
            return sm.EditSystemMenus(systemMenus);
        }

        public int PutTrash(Guid id)
        {
            return sm.PutTrash(id);
        }

        public int RemoveSystemMenus(Guid id)
        {
            return sm.RemoveSystemMenus(id);
        }

        public List<SystemMenus> GetAll()
        {
            return sm.GetAll();
        }

        public SystemMenus GetSystemMenusById(Guid id)
        {
            return sm.GetSystemMenusById(id);
        }

        public List<SystemMenus> GetSystemMenusByTitle(string title)
        {
            return sm.GetSystemMenusByTitle(title);
        }

    }
}
