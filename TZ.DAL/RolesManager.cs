using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using TZ.Model917;

namespace TZ.DAL
{
    public class RolesManager
    {
        public int AddRoles(Roles roles)
        {
            string sql = "insert into Roles(Roles_Id,Roles_Title,Roles_DeleteId,Roles_CreateTime,Roles_UpdateTime) values(@Roles_Id,@Roles_Title,@Roles_DeleteId,@Roles_CreateTime,@Roles_UpdateTime)";

            SqlParameter[] param =
            {
                new SqlParameter("@Roles_Id", roles.Id),
                new SqlParameter("@Roles_Title", roles.Roles_Title),
                new SqlParameter("@Roles_DeleteId", roles.DeleteId),
                new SqlParameter("@Roles_CreateTime", roles.CreateTime),
                new SqlParameter("@Roles_UpdateTime", roles.UpdateTime)
            };
         return SqlHelper.ExecuteNonQuery(sql, param);
        }
        public int EditRoles(Roles roles)
        {
            string sql = "update Roles set Roles_Title = @Roles_Title , Roles_UpdateTime = @Roles_UpdateTime where Roles_Id = @Roles_Id";

            SqlParameter[] param =
            {
                new SqlParameter("@Roles_Title", roles.Roles_Title),
                new SqlParameter("@Roles_UpdateTime", roles.UpdateTime),
                new SqlParameter("@Roles_Id", roles.Id)
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }
        public int PutTrash(Guid id)
        {
            string sql = "update Roles set Roles_DeleteId = 0 where Roles_Id = @Roles_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@Roles_Id",id)
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }
        public int RemoveRoles(Guid id)
        {
            string sql = "delete from Roles where Roles_DeleteId = 0 and Roles_Id = @Roles_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@Roles_Id",id)
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }
        public int PutTrashList(string idList)
        {
            string sql = "update Roles set Roles_DeleteId = 0 where Roles_Id in (" + idList + ")";
            return SqlHelper.ExecuteNonQuery(sql, null);
        }
        public int RemoveRolesList(string idList)
        {
            string sql = "delete from Roles where Roles_Id in (" + idList + ")";

            return SqlHelper.ExecuteNonQuery(sql, null);
        }
        public List<Roles> GetAll()
        {
            string sql = "select * from Roles where Roles_DeleteId = 1 order by Roles_UpdateTime desc";
            var data = SqlHelper.Query(sql, null);
            List<Roles> list = FillData(data);
            return list;
        }
        public List<Roles> FillData(DataTable dt)
        {
            var list = new List<Roles>();

            foreach (DataRow dr in dt.Rows)
            {
                var item = new Roles
                {
                    Id = Guid.Parse(dr["Roles_Id"].ToString()),
                    Roles_Title = dr["Roles_Title"].ToString(),
                    DeleteId = int.Parse(dr["Roles_DeleteId"].ToString()),
                    UpdateTime = DateTime.Parse(dr["Roles_UpdateTime"].ToString())
                };
                list.Add(item);
            }
            return list;
        }
        public Roles GetRolesById(Guid id)
        {
            string sql = "select * from Roles where Roles_DeleteId = 1 and Roles_Id = @Roles_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@Roles_Id",id)
            };
            var dt = SqlHelper.Query(sql, param);
            var data = FillData(dt).FirstOrDefault();
            return data;
        }
        public List<Roles> GetRolesByTitle(string title)
        {
            string sql = "select * from Roles where Roles_DeleteId = 1 and Roles_Title like '%" + title + "%'";
            var dt = SqlHelper.Query(sql, null);
            return FillData(dt);
        }
        public bool IsExists(string title)
        {
            string sql = "select * from Roles where Roles_Delete = 1 and Roles_Title = @Roles_Title";
            SqlParameter[] param =
            {
                new SqlParameter("@Roles_Title",title)
            };
            var dt = SqlHelper.Query(sql, param);
            return FillData(dt).Any();
        }
    }
}