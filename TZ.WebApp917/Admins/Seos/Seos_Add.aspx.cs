using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TZ.BLL;

namespace TZ.WebApp917.Admins.Seos
{
    public partial class Seos_Add : System.Web.UI.Page
    {
        private SeosService seosService=new SeosService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void BtnSubmit_OnClick(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            Model917.Seos seos = new Model917.Seos()
            {
                Seos_Title = this.txtTitle.Text.Trim(),
                Seos_Keyword = this.txtKeyword.Text.Trim(),
                Seos_Description = this.txtDescription.Text.Trim()
            };
            var res = seosService.AddSeos(seos);
            if (res > 0)
            {
                Response.Write("<script>alert('添加成功');location.href='Seos_List.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('添加失败');location.href='Seos_List.aspx'</script>");
            }
        }

        protected void BtnReset_OnClick(object sender, EventArgs e)
        {

        }
    }
}