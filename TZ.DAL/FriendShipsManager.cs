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
    public class FriendShipsManager
    {
        public int AddFriendShips(FriendShips friendShips)
        {
            string sql =
                "insert into FriendShips(FriendShips_Id,FriendShips_Title,FriendShips_Link,FriendShips_DeleteId,FriendShips_CreateTime,FriendShips_UpdateTime)values(@FriendShips_Id,@FriendShips_Title,@FriendShips_Link,@FriendShips_DeleteId,@FriendShips_CreateTime,@FriendShips_UpdateTime)";
            SqlParameter[] param =
            {
                new SqlParameter("@FriendShips_Id", friendShips.Id),
                new SqlParameter("@FriendShips_Title",friendShips.FriendShips_Title),
                new SqlParameter("@FriendShips_Link",friendShips.FriendShips_Link),
                new SqlParameter("@FriendShips_DeleteId", friendShips.DeleteId),
                new SqlParameter("@FriendShips_CreateTime",friendShips.CreateTime),
                new SqlParameter("@FriendShips_UpdateTime", friendShips.UpdateTime),
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public int EditFriendShips(FriendShips friendShips)
        {
            string sql =
                "update FriendShips set FriendShips_Title = @FriendShips_Title,FriendShips_Link = @FriendShips_Link,FriendShips_UpdateTime = @FriendShips_UpdateTime where FriendShips_Id = @FriendShips_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@FriendShips_Title", friendShips.FriendShips_Title),
                new SqlParameter("@FriendShips_Link", friendShips.FriendShips_Link),
                new SqlParameter("@FriendShips_UpdateTime", friendShips.UpdateTime),
                new SqlParameter("@FriendShips_Id", friendShips.Id)
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public int PutTrash(Guid id)
        {
            string sql = "update FriendShips set FriendShips_DeleteId = 0 where FriendShips_Id = @FriendShips_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@FriendShips_Id",id)
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public int RemoveSystemMenus(Guid id)
        {
            string sql = "delete from FriendShips where FriendShips_DeleteId = 0 and FriendShips_Id = @FriendShips_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@FriendShips_Id",id)
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public List<FriendShips> GetAll()
        {
            string sql = "select * from FriendShips where FriendShips_DeleteId = 1 order by FriendShips_UpdateTime desc";
            var dt = SqlHelper.Query(sql, null);
            return FillData(dt);
        }

        public FriendShips GetFriendShipsById(Guid id)
        {
            string sql = "select * from FriendShips where  FriendShips_Id = @FriendShips_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@FriendShips_Id",id)
            };
            var list = FillData(SqlHelper.Query(sql, param));
            return list.FirstOrDefault();
        }

        public List<FriendShips> GetFriendShipsByTitle(string title)
        {
            string sql = "select * from FriendShips_Id where FriendShips_DeleteId = 1 and FriendShips_Title like '%" + title + "%'";
            var dt = SqlHelper.Query(sql, null);
            return FillData(dt);
        }

        public List<FriendShips> FillData(DataTable dt)
        {
            var list = new List<FriendShips>();
            foreach (DataRow dr in dt.Rows)
            {
                var item = new FriendShips()
                {
                    Id = Guid.Parse(dr["FriendShips_Id"].ToString()),
                    FriendShips_Title = dr["FriendShips_Title"].ToString(),
                    FriendShips_Link = dr["FriendShips_Link"].ToString(),
                    DeleteId = int.Parse(dr["FriendShips_DeleteId"].ToString()),
                    UpdateTime = DateTime.Parse(dr["FriendShips_UpdateTime"].ToString())
                };
                list.Add(item);
            }
            return list;
        }
    }
}
