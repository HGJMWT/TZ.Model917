using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TZ.Model917;

namespace TZ.DAL
{
    public class SystemMenusManager
    {
        public int AddSystemMenus(SystemMenus systemMenus)
        {
            string sql =
                "insert into SystemMenus(SystemMenus_Id,SystemMenus_Title,SystemMenus_Link,SystemMenus_ParentId,SystemMenus_Icon,SystemMenus_DeleteId,SystemMenus_CreateTime,SystemMenus_UpdateTime)values(@SystemMenus_Id,@SystemMenus_Title,@SystemMenus_Link,@SystemMenus_ParentId,@SystemMenus_Icon,@SystemMenus_DeleteId,@SystemMenus_CreateTime,@SystemMenus_UpdateTime)";
            SqlParameter[] param =
            {
                new SqlParameter("@SystemMenus_Id", systemMenus.Id),
                new SqlParameter("@SystemMenus_Title",systemMenus.SystemMenus_Title),
                new SqlParameter("@SystemMenus_Link",systemMenus.SystemMenus_Link),
                new SqlParameter("@SystemMenus_ParentId", systemMenus.SystemMenus_ParentId),
                new SqlParameter("@SystemMenus_Icon", systemMenus.SystemMenus_Icon),
                new SqlParameter("@SystemMenus_DeleteId", systemMenus.DeleteId),
                new SqlParameter("@SystemMenus_CreateTime",systemMenus.CreateTime),
                new SqlParameter("@SystemMenus_UpdateTime", systemMenus.UpdateTime),
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public int EditSystemMenus(SystemMenus systemMenus)
        {
            string sql =
                "update SystemMenus set SystemMenus_Title = @SystemMenus_Title,SystemMenus_Link = @SystemMenus_Link,SystemMenus_UpdateTime = @SystemMenus_UpdateTime where SystemMenus_Id = @SystemMenus_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@SystemMenus_Title", systemMenus.SystemMenus_Title),
                new SqlParameter("@SystemMenus_Link", systemMenus.SystemMenus_Link),
                new SqlParameter("@SystemMenus_UpdateTime", systemMenus.UpdateTime),
                new SqlParameter("@SystemMenus_Id", systemMenus.Id)
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public int PutTrash(Guid id)
        {
            string sql = "update SystemMenus set SystemMenus_DeleteId = 0 where SystemMenus_Id = @SystemMenus_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@SystemMenus_Id",id)
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public int RemoveSystemMenus(Guid id)
        {
            string sql = "delete from SystemMenus where SystemMenus_DeleteId = 0 and SystemMenus_Id = @SystemMenus_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@SystemMenus_Id",id)
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public List<SystemMenus> GetAll()
        {
            string sql = "select * from SystemMenus where SystemMenus_DeleteId = 1 order by SystemMenus_UpdateTime desc";
            var dt = SqlHelper.Query(sql, null);
            return FillData(dt);
        }

        public SystemMenus GetSystemMenusById(Guid id)
        {
            string sql = "select * from SystemMenus where  SystemMenus_Id = @SystemMenus_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@SystemMenus_Id",id)
            };
            var list = FillData(SqlHelper.Query(sql, param));
            return list.FirstOrDefault();
        }

        public List<SystemMenus> GetSystemMenusByTitle(string title)
        {
            string sql = "select * from SystemMenus where SystemMenus_DeleteId = 1 and SystemMenus_Title like '%" + title + "%'";
            var dt = SqlHelper.Query(sql, null);
            return FillData(dt);
        }

        public List<SystemMenus> FillData(DataTable dt)
        {
            var list = new List<SystemMenus>();
            foreach (DataRow dr in dt.Rows)
            {
                var item = new SystemMenus()
                {
                    Id = Guid.Parse(dr["SystemMenus_Id"].ToString()),
                    SystemMenus_Title = dr["SystemMenus_Title"].ToString(),
                    SystemMenus_Link = dr["SystemMenus_Link"].ToString(),
                    SystemMenus_ParentId = Guid.Parse(dr["SystemMenus_ParentId"].ToString()),
                    SystemMenus_Icon = dr["SystemMenus_Icon"].ToString(),
                    DeleteId = int.Parse(dr["SystemMenus_DeleteId"].ToString()),
                    UpdateTime = DateTime.Parse(dr["SystemMenus_UpdateTime"].ToString())
                };
                list.Add(item);
            }
            return list;
        }
    }
}
