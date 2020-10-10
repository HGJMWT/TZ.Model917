using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TZ.BLL;

namespace TZ.WebApp917.Admins.SystemMenus
{
    public partial class SystemMenus_Add : System.Web.UI.Page
    {
        private SystemMenusService systemMenusService=new SystemMenusService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void BtnSubmit_OnClick(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            var file = UploadImage(FileUpload1, "../../upload/systemmenus/");
            Model917.SystemMenus systemMenus = new Model917.SystemMenus()
            {
                SystemMenus_Title = this.txtTitle.Text.Trim(),
                SystemMenus_Link = this.txtLink.Text.Trim(),
                SystemMenus_Icon = (file == null ? "def.png" : file)
            };
            Response.Write("<script>alert('" + file + "')</script>");
            var res = systemMenusService.AddSystemMenus(systemMenus);
            if (res > 0)
            {
                Response.Write("<script>alert('添加成功');location.href='SystemMenus_List.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('添加失败');location.href='SystemMenus_List.aspx'</script>");
            }
        }

        protected void BtnReset_OnClick(object sender, EventArgs e)
        {

        }
        public string UploadImage(FileUpload file, string url)
        {
            var kzm = file.FileName.Substring(file.FileName.IndexOf('.'));
            if (kzm.Equals(".jpg") || kzm.Equals(".png") || kzm.Equals(".gif"))
            {
                var date = DateTime.Now.ToString("yyyyMMddHHmmss");
                Random r = new Random();
                var num = r.Next(1, 10000);
                var newFileName = date + num.ToString() + kzm;
                //var path = "../..upload/users"+newFileName;
                var realPath = Server.MapPath(url + newFileName);
                file.SaveAs(realPath);
                return newFileName;
            }
            else
            {
                return null;
            }
        }
    }
}