using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TZ.BLL;

namespace TZ.WebApp917.Admins.Seos
{
    public partial class Seos_Edit : System.Web.UI.Page
    {
        private SeosService seosService=new SeosService();
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
                Response.Write("<script>alert('数据丢失')；location.href='Seos_List.aspx'<.script>");
            var data = seosService.GetSeosById(id);
            this.txtId.Text = data.Id.ToString();
            this.txtTitle.Text = data.Seos_Title;
            this.txtKeyword.Text = data.Seos_Keyword;
            this.txtDescription.Text = data.Seos_Description;
        }
        protected void BtnSubmit_OnClick(object sender, EventArgs e)
        {
            var Title = this.txtTitle.Text.Trim();
            var Keyword = this.txtKeyword.Text.Trim();
            var Description = this.txtKeyword.Text.Trim();
            Model917.Seos seos = new Model917.Seos()
            {
                Id = Guid.Parse(this.txtId.Text),
                Seos_Title = Title,
                Seos_Keyword = Keyword,
                Seos_Description=Description
            };
            var res = seosService.EditSeos(seos);
            if (res > 0)
            {
                Response.Write("<script>alert('修改成功');location.href='Seos_List.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('修改失败');location.href='Seos_List.aspx'</script>");
            }
        }

        protected void BtnReset_OnClick(object sender, EventArgs e)
        {
            Bind();
        }
    }
}