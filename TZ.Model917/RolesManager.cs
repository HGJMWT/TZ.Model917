using System.Data;
using System.Data.SqlClient;

namespace TZ.Model917
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
    }
}