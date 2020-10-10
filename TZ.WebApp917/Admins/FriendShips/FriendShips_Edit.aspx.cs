using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TZ.BLL;

namespace TZ.WebApp917.Admins.FriendShips
{
    public partial class FriendShips_Edit : System.Web.UI.Page
    {
        private FriendShipsService friendShipsService=new FriendShipsService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
                return;
            Bind();
        }
        private void Bind()
        {
            var id = Request.Params["action"] != null ? Guid.Parse(Request.Params["action"]) : Guid.Empty;
            if (id == Guid.Empty)
                Response.Write("<script>alert('数据丢失')；location.href='FriendShips_List.aspx'<.script>");
            var data = friendShipsService.GetFriendShipsById(id);
            this.txtId.Text = data.Id.ToString();
            this.txtTitle.Text = data.FriendShips_Title;
            this.txtLink.Text = data.FriendShips_Link;
        }
        protected void BtnSubmit_OnClick(object sender, EventArgs e)
        {
            var Title = this.txtTitle.Text.Trim();
            var Link = this.txtLink.Text.Trim();
            Model917.FriendShips friendShips = new Model917.FriendShips()
            {
                Id = Guid.Parse(this.txtId.Text),
                FriendShips_Title = Title,
                FriendShips_Link = Link
            };
            var res = friendShipsService.EditFriendShips(friendShips);
            if (res > 0)
            {
                Response.Write("<script>alert('修改成功');location.href='FriendShips_List.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('修改失败');location.href='FriendShips_List.aspx'</script>");
            }
        }

        protected void BtnReset_OnClick(object sender, EventArgs e)
        {
            Bind();
        }
    }
}