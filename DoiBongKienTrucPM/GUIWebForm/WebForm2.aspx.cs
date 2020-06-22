using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using Entity;

namespace GUIWebForm
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        teamBus bus = new teamBus();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnThemDoi_Click(object sender, EventArgs e)
        {
            if (bus.CreateTeam(new eTeam() { maDoiBong = txtMaDoiBong.Text, tenDoiBong = txtTenDoiBong.Text })) {
                MsgBox("! Success !", this.Page, this);
            }
            else
            {
                MsgBox("! Faild !", this.Page, this);
            }
        }

        protected void btnThoat_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm1.aspx");
        }
        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }
    }
}