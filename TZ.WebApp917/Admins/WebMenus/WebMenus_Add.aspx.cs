using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TZ.BLL;

namespace TZ.WebApp917.Admins.WebMenus
{
    public partial class WebMenus_Add : System.Web.UI.Page
    {
        private WebMenusService webMenusService=new WebMenusService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void BtnSubmit_OnClick(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            var file = UploadImage(FileUpload1, "../../upload/webmenus/");
            Model917.WebMenus webMenus = new Model917.WebMenus()
            {
                WebMenus_Title = this.txtTitle.Text.Trim(),
                WebMenus_Link = this.txtLink.Text.Trim(),
                WebMenus_Icon = (file == null ? "def.png" : file)
            };
            Response.Write("<script>alert('" + file + "')</script>");
            var res = webMenusService.AddWebMenus(webMenus);
            if (res > 0)
            {
                Response.Write("<script>alert('添加成功');location.href='WebMenus_List.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('添加失败');location.href='WebMenus_List.aspx'</script>");
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