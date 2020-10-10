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
    public class SeosManager
    {
        public int AddSeos(Seos seos)
        {
            string sql =
                "insert into Seos(Seos_Id,Seos_Title,Seos_Keyword,Seos_Description,Seos_DeleteId,Seos_CreateTime,Seos_UpdateTime)values(@Seos_Id,@Seos_Title,@Seos_Keyword,@Seos_Description,@Seos_DeleteId,@Seos_CreateTime,@Seos_UpdateTime)";
            SqlParameter[] param =
            {
                new SqlParameter("@Seos_Id", seos.Id),
                new SqlParameter("@Seos_Title",seos.Seos_Title),
                new SqlParameter("@Seos_Keyword",seos.Seos_Keyword),
                new SqlParameter("@Seos_Description", seos.Seos_Description),
                new SqlParameter("@Seos_DeleteId", seos.DeleteId),
                new SqlParameter("@Seos_CreateTime",seos.CreateTime),
                new SqlParameter("@Seos_UpdateTime", seos.UpdateTime),
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public int EditSeos(Seos seos)
        {
            string sql =
                "update Seos set Seos_Title = @Seos_Title,Seos_Keyword = @Seos_Keyword,Seos_Description=@Seos_Description,Seos_UpdateTime = @Seos_UpdateTime where Seos_Id = @Seos_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@Seos_Title", seos.Seos_Title),
                new SqlParameter("@Seos_Keyword", seos.Seos_Keyword),
                new SqlParameter("@Seos_Description", seos.Seos_Description),
                new SqlParameter("@Seos_UpdateTime", seos.UpdateTime),
                new SqlParameter("@Seos_Id", seos.Id)
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public int PutTrash(Guid id)
        {
            string sql = "update Seos set Seos_DeleteId = 0 where Seos_Id = @Seos_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@Seos_Id",id)
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public int RemoveSeos(Guid id)
        {
            string sql = "delete from Seos where Seos_DeleteId = 0 and Seos_Id = @Seos_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@Seos_Id",id)
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public List<Seos> GetAll()
        {
            string sql = "select * from Seos where Seos_DeleteId = 1 order by Seos_UpdateTime desc";
            var dt = SqlHelper.Query(sql, null);
            return FillData(dt);
        }

        public Seos GetSeosById(Guid id)
        {
            string sql = "select * from Seos where  Seos_Id = @Seos_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@Seos_Id",id)
            };
            var list = FillData(SqlHelper.Query(sql, param));
            return list.FirstOrDefault();
        }

        public List<Seos> GetSeosByTitle(string title)
        {
            string sql = "select * from Seos where Seos_DeleteId = 1 and Seos_Title like '%" + title + "%'";
            var dt = SqlHelper.Query(sql, null);
            return FillData(dt);
        }

        public List<Seos> FillData(DataTable dt)
        {
            var list = new List<Seos>();
            foreach (DataRow dr in dt.Rows)
            {
                var item = new Seos()
                {
                    Id = Guid.Parse(dr["Seos_Id"].ToString()),
                    Seos_Title = dr["Seos_Title"].ToString(),
                    Seos_Keyword = dr["Seos_Keyword"].ToString(),
                    Seos_Description = dr["Seos_Description"].ToString(),
                    DeleteId = int.Parse(dr["Seos_DeleteId"].ToString()),
                    UpdateTime = DateTime.Parse(dr["Seos_UpdateTime"].ToString())
                };
                list.Add(item);
            }
            return list;
        }
    }
}
