using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TZ.BLL;

namespace TZ.WebApp917.Admins.WebMenus
{
    public partial class WebMenus_Edit : System.Web.UI.Page
    {
        private WebMenusService webMenusService=new WebMenusService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            Bind();
        }
        private void Bind()
        {
            var id = Request.Params["action"] != null ? Guid.Parse(Request.Params["action"]) : Guid.Empty;
            if (id == Guid.Empty)
                Response.Write("<script>alert('数据丢失')；location.href='WebMenus_List.aspx'<.script>");
            var data = webMenusService.GetWebMenusById(id);
            this.txtId.Text = data.Id.ToString();
            this.txtTitle.Text = data.WebMenus_Title;
            this.txtLink.Text = data.WebMenus_Link;
        }
        protected void BtnSubmit_OnClick(object sender, EventArgs e)
        {
            var Title = this.txtTitle.Text.Trim();
            var Link = this.txtLink.Text.Trim();
            Model917.WebMenus webMenus = new Model917.WebMenus()
            {
                Id = Guid.Parse(this.txtId.Text),
                WebMenus_Title = Title,
                WebMenus_Link = Link
            };
            var res = webMenusService.EditWebMenus(webMenus);
            if (res > 0)
            {
                Response.Write("<script>alert('修改成功');location.href='WebMenus_List.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('修改失败');location.href='WebMenus_List.aspx'</script>");
            }
        }

        protected void BtnReset_OnClick(object sender, EventArgs e)
        {
            Bind();
        }
    }
}