using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TZ.BLL;

namespace TZ.WebApp917.Admins.Users
{
    public partial class Users_Add : System.Web.UI.Page
    {
        private UsersService usersSvc =new UsersService();
        private RolesService rolesSvc =new RolesService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            var list = rolesSvc.GetAll();
            this.ddlRolesList.DataSource = list;
            this.ddlRolesList.DataTextField = "Roles_Title";
            this.ddlRolesList.DataValueField = "Id";
            this.ddlRolesList.DataBind();
        }

        

        protected void BtnSubmit_OnClick(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            var file = UploadImage(FileUpload1,"../../upload/users/");
            Model917.Users users = new Model917.Users()
            {
                Users_Account = this.txtAccount.Text.Trim(),
                Users_Password = this.txtPassword.Text.Trim(),
                Users_NickName = this.txtNickName.Text.Trim(),
                Users_RolesId = Guid.Parse(this.ddlRolesList.SelectedValue),
                Users_Photo = (file == null ? "def.png" : file)
            };
            Response.Write("<script>alert('"+file+"')</script>");
            var res = usersSvc.AddUsers(users);
            if (res > 0)
            {
                Response.Write("<script>alert('添加成功');location.href='Users_List.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('添加失败');location.href='Users_List.aspx'</script>");
            }
        }

        public string UploadImage(FileUpload file,string url)
        {
            var kzm = file.FileName.Substring(file.FileName.IndexOf('.'));
            if (kzm.Equals(".jpg") || kzm.Equals(".png") || kzm.Equals(".gif"))
            {
                var date = DateTime.Now.ToString("yyyyMMddHHmmss");
                Random r=new Random();
                var num = r.Next(1, 10000);
                var newFileName = date + num.ToString() + kzm;
                //var path = "../..upload/users"+newFileName;
                var realPath= Server.MapPath(url+newFileName);
                file.SaveAs(realPath);
                return newFileName;
            }
            else
            {
                return null;
            }
        }


        protected void BtnReset_OnClick(object sender, EventArgs e)
        {
            //this.txtAccount.Text = "";
            //this.txtPassword.Text = "";
            //this.txtNickName.Text = "";
            //this.txtPhoto.Text = "";
            //this.txtRolesId.Text = "";
        }
    }
}