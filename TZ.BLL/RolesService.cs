using System;
using System.Collections.Generic;
using TZ.DAL;
using TZ.Model917;

namespace TZ.BLL
{
    public class RolesService
    {
        RolesManager rm =new RolesManager();
        public int AddRoles(Roles roles)
        {
            return rm.AddRoles(roles);
        }
        public int EditRoles(Roles roles)
        {
            return rm.EditRoles(roles);
        }
        public int PutTrash(Guid id)
        {
            return rm.PutTrash(id);
        }
        public int RemoveRoles(Guid id)
        {
            return rm.RemoveRoles(id);
        }
        public int PutTrashList(string idList)
        {
            return rm.PutTrashList(idList);
        }
        public int RemoveRolesList(string idList)
        {
            return rm.RemoveRolesList(idList);
        }
        public List<Roles> GetAll()
        {
            return rm.GetAll();
        }
        public Roles GetRolesById(Guid id)
        {
            return rm.GetRolesById(id);
        }
        public List<Roles> GetRolesByTitle(string title)
        {
            return rm.GetRolesByTitle(title);
        }
        public bool IsExists(string title)
        {
            return rm.IsExists(title);
        }
    }
}