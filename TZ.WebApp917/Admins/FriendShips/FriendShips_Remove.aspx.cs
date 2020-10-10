using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TZ.BLL;

namespace TZ.WebApp917.Admins.FriendShips
{
    public partial class FriendShips_Remove : System.Web.UI.Page
    {
        private FriendShipsService friendShipsService=new FriendShipsService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            var id = Request.Params["action"];
            if (id != null)
            {
                Guid uid = Guid.Parse(id);
                var res = friendShipsService.PutTrash(uid);
                if (res > 0)
                {
                    Response.Write("<script>alert('删除成功');location.href='FriendShips_List.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>alert('删除失败');location.href='FriendShips_List.aspx'</script>");
                }
            }
        }
    }
}