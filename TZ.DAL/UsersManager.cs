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
    public class UsersManager
    {
        public int AddUsers(Users users)
        {
            string sql =
                "insert into Users(Users_Id,Users_Account,Users_Password,Users_NickName,Users_Photo,Users_RolesId,Users_DeleteId,Users_CreateTime,Users_UpdateTime)values(@Users_Id,@Users_Account,@Users_Password,@Users_NickName,@Users_Photo,@Users_RolesId,@Users_DeleteId,@Users_CreateTime,@Users_UpdateTime)";
            SqlParameter[] param =
            {
                new SqlParameter("@Users_Id", users.Id),
                new SqlParameter("@Users_Account", users.Users_Account),
                new SqlParameter("@Users_Password", users.Users_Password),
                new SqlParameter("@Users_NickName", users.Users_NickName),
                new SqlParameter("@Users_Photo", users.Users_Photo),
                new SqlParameter("@Users_RolesId", users.Users_RolesId),
                new SqlParameter("@Users_DeleteId", users.DeleteId),
                new SqlParameter("@Users_CreateTime", users.CreateTime),
                new SqlParameter("@Users_UpdateTime", users.UpdateTime)
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public int EditUsers(Users users)
        {
            string sql =
                "update Users set Users_Password = @Users_Password,Users_NickName = @Users_NickName,Users_RolesId = @Users_RolesId,Users_UpdateTime = @Users_UpdateTime where Users_Id = @Users_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@Users_Password", users.Users_Password),
                new SqlParameter("@Users_NickName", users.Users_NickName),
                new SqlParameter("@Users_RolesId", users.Users_RolesId),
                new SqlParameter("@Users_UpdateTime", users.UpdateTime),
                new SqlParameter("@Users_Id", users.Id)
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public int PutTrash(Guid id)
        {
            string sql = "update Users set Users_DeleteId = 0 where Users_Id = @Users_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@Users_Id",id)
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public int RemoveUsers(Guid id)
        {
            string sql = "delete from Users where Users_DeleteId = 0 and Users_Id = @Users_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@Users_Id",id)
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public List<Users> GetAll()
        {
            string sql = "select * from Users where Users_DeleteId = 1 order by Users_UpdateTime desc";
            var dt = SqlHelper.Query(sql, null);
            return FillData(dt);
        }

        public Users GetUsersById(Guid id)
        {
            string sql = "select * from Users where  Users_Id = @Users_Id";
            SqlParameter[] param =
            {
                new SqlParameter("@Users_Id",id)
            };
            var list = FillData(SqlHelper.Query(sql, param));
            return list.FirstOrDefault();
        }

        public List<Users> GetUsersByNickName(string nickName)
        {
            string sql = "select * from Users where Users_DeleteId = 1 and Users_NickName like '%" + nickName + "%'";
            var dt = SqlHelper.Query(sql, null);
            return FillData(dt);
        }

        public int ChangePwd(Users users)
        {
            string sql = "update Users set Users_Password= @Users_PassWord where Users_Account=@Users_Account";
            SqlParameter[] param =
            {
                new SqlParameter("@Users_PassWord",users.Users_Password),
                new SqlParameter("@Users_Account",users.Users_Account)
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public Users SignIn(string account, string password)
        {
            string sql =
                "select * from Users where Users_DeleteId =1 and Users_Account=@Users_Account and Users_PassWord=@Users_PassWord";
            SqlParameter[] param =
            {
                new SqlParameter("@Users_Account",account),
                new SqlParameter("@Users_PassWord",password)
            };
            var dt = SqlHelper.Query(sql, param);
            return FillData(dt).FirstOrDefault();
        }

        public List<Users> GetUsersInTrash()
        {
            string sql = "select * from Users where Users_DeleteId=0";
            var dt = SqlHelper.Query(sql, null);
            return FillData(dt);
        }

        public int RestoreUsers(Guid id)
        {
            string sql = "update Users set Users_DeleteId = 1 where Users_Id = @Users_id";
            SqlParameter[] param =
            {
                new SqlParameter("@Users_Id",id), 
            };
            return SqlHelper.ExecuteNonQuery(sql, param);
        }

        public List<Users> GetUsersInTrashByNickName(string nickName)
        {
            string sql = "select * from Users where Users_DeleteId = 0 and Users_NickName like '%" + nickName + "%'";
            var dt = SqlHelper.Query(sql, null);
            return FillData(dt);
        }

        public bool IsExists(string account)
        {
            string sql = "select* from Users where Users_DeleteId = 1 and Users_Account=@Users_Account";
            SqlParameter[] param =
            {
                new SqlParameter("@Users_Account", account),
            };
            var dt = SqlHelper.Query(sql, param);
            return dt.Rows.Count > 0;
        }

        public List<Users> FillData(DataTable dt)
        {
            var list = new List<Users>();
            foreach (DataRow dr in dt.Rows)
            {
                var item = new Users()
                {
                    Id = Guid.Parse(dr["Users_Id"].ToString()),
                    Users_Account = dr["Users_Account"].ToString(),
                    Users_Password = dr["Users_Password"].ToString(),
                    Users_NickName = dr["Users_NickName"].ToString(),
                    Users_Photo = dr["Users_Photo"].ToString(),
                    Users_RolesId = Guid.Parse(dr["Users_RolesId"].ToString()),
                    DeleteId = int.Parse(dr["Users_DeleteId"].ToString()),
                    UpdateTime = DateTime.Parse(dr["Users_UpdateTime"].ToString())
                };
                list.Add(item);
            }
            return list;
        }
    }
}
