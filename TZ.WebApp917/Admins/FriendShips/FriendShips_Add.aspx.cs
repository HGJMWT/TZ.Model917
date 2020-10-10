using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TZ.BLL;

namespace TZ.WebApp917.Admins.FriendShips
{
    public partial class FriendShips_Add : System.Web.UI.Page
    {
        private FriendShipsService friendShipsService=new FriendShipsService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
                return;
        }

        protected void BtnSubmit_OnClick(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            Model917.FriendShips friendShips = new Model917.FriendShips()
            {
                FriendShips_Title = this.txtTitle.Text.Trim(),
                FriendShips_Link = this.txtLink.Text.Trim(),
            };
            var res = friendShipsService.AddFriendShips(friendShips);
            if (res > 0)
            {
                Response.Write("<script>alert('添加成功');location.href='FriendShips_List.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('添加失败');location.href='FriendShips_List.aspx'</script>");
            }
        }

        protected void BtnReset_OnClick(object sender, EventArgs e)
        {
        }
    }
}