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
    public class WebMenusManager
    {
        public int AddWebMenus(WebMenus webMenus)
        {
            string sql =
                "insert into WebMenus(WebMenus_Id,WebMenus_Title,WebMenus_Link,WebMenus_ParentId,WebMenus_Icon,WebMenus_DeleteId,WebMenus_CreateTime,WebMenus_UpdateTime)values(@WebMenus_Id,@WebMenus_Title,@WebMenus_Link,@WebMenus_ParentId,@WebMenus_Icon,@WebMenus_DeleteId,@WebMenus_CreateTime,@WebMenus_UpdateTime)";
            SqlParameter[] param =
            {
                new SqlParameter("@WebMenus_Id", webMenus.Id),
                new SqlParameter("@WebMenus_Title",webMenus.WebMenus_Title),
                new SqlParameter("@WebMenus_Link",webMenus.WebMenus_Link),
                new SqlParameter("@WebMenus_ParentId", webMenus.WebMenus_ParentId),
                new SqlParameter("@WebMenus_Icon", webMenus.WebMenus_Icon),
                new SqlParameter("@WebMenus_DeleteId", webMenus.DeleteId),
                new SqlParameter("@WebMenus_CreateTime",webMenus.CreateTime),
                new SqlParameter("@WebMenus_UpdateTime", webMenus.UpdateTime),
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public int EditWebMenus(WebMenus webMenus)
        {
            string sql =
                "update WebMenus set WebMenus_Title = @WebMenus_Title,WebMenus_Link = @WebMenus_Link,WebMenus_UpdateTime = @WebMenus_UpdateTime where WebMenus_Id = @WebMenus_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@WebMenus_Title", webMenus.WebMenus_Title),
                new SqlParameter("@WebMenus_Link", webMenus.WebMenus_Link),
                new SqlParameter("@WebMenus_UpdateTime", webMenus.UpdateTime),
                new SqlParameter("@WebMenus_Id", webMenus.Id)
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public int PutTrash(Guid id)
        {
            string sql = "update WebMenus set WebMenus_DeleteId = 0 where WebMenus_Id = @WebMenus_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@WebMenus_Id",id)
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public int RemoveWebMenus(Guid id)
        {
            string sql = "delete from WebMenus where WebMenus_DeleteId = 0 and WebMenus_Id = @WebMenus_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@WebMenus_Id",id)
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public List<WebMenus> GetAll()
        {
            string sql = "select * from WebMenus where WebMenus_DeleteId = 1 order by WebMenus_UpdateTime desc";
            var dt = SqlHelper.Query(sql, null);
            return FillData(dt);
        }

        public WebMenus GetWebMenusById(Guid id)
        {
            string sql = "select * from WebMenus where  WebMenus_Id = @WebMenus_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@WebMenus_Id",id)
            };
            var list = FillData(SqlHelper.Query(sql, param));
            return list.FirstOrDefault();
        }

        public List<WebMenus> GetWebMenusByTitle(string title)
        {
            string sql = "select * from WebMenus where WebMenus_DeleteId = 1 and WebMenus_Title like '%" + title + "%'";
            var dt = SqlHelper.Query(sql, null);
            return FillData(dt);
        }

        public List<WebMenus> FillData(DataTable dt)
        {
            var list = new List<WebMenus>();
            foreach (DataRow dr in dt.Rows)
            {
                var item = new WebMenus()
                {
                    Id = Guid.Parse(dr["WebMenus_Id"].ToString()),
                    WebMenus_Title = dr["WebMenus_Titl"].ToString(),
                    WebMenus_Link = dr["WebMenus_Link"].ToString(),
                    WebMenus_ParentId = Guid.Parse(dr["WebMenus_ParentId"].ToString()),
                    WebMenus_Icon = dr["WebMenus_Icon"].ToString(),
                    DeleteId = int.Parse(dr["WebMenus_DeleteId"].ToString()),
                    UpdateTime = DateTime.Parse(dr["WebMenus_UpdateTime"].ToString())
                };
                list.Add(item);
            }
            return list;
        }
    }
}
