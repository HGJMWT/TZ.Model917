using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ApplicationServices;
using System.Web.UI;
using System.Web.UI.WebControls;
using TZ.BLL;

namespace TZ.WebApp917.Admins.Roles
{
    public partial class Roles_Remove : System.Web.UI.Page
    {
        private RolesService roleSvc = new RolesService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
                return;
            var id = Request.Params["action"];
            if (id != null)
            {
                Guid rid =Guid.Parse(id);
                var res = roleSvc.PutTrash(rid);
                if (res > 0)
                {
                    Response.Write("<script>alert('删除成功');location.href='Roles_List.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>alert('删除失败');location.href='Roles_List.aspx'</script>");
                }
            }

        }
    }
}