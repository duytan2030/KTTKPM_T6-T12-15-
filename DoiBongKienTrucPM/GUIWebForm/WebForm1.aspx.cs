using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using Entity;

namespace GUIWebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        teamBus busteam = new teamBus();
        playerBus busplayer = new playerBus();
        public int vitri = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            loadData();
        }

        protected void btnThemDoiBong_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm2.aspx");
        }
        public void loadData()
        {
            txtEmail.Enabled = false;
            txtIDCauThu.Enabled = false;
            txtSDT.Enabled = false;
            txtTenCauThu.Enabled = false;

            var lst = busteam.getALlTeam();

            DropDownList1.DataValueField = "maDoiBong";
            DropDownList1.DataTextField = "tenDoiBong";
            DropDownList1.DataSource = lst;
            DropDownList1.DataBind();

            DropDownList2.DataValueField = "maDoiBong";
            DropDownList2.DataTextField = "tenDoiBong";
            DropDownList2.DataSource = lst;
            DropDownList2.DataBind();
        }

        protected void btnCauThu_Click(object sender, EventArgs e)
        {
            var lst = busplayer.getALlPlayerTheoTeam(DropDownList1.SelectedItem.Value);
            GridView1.DataSource = lst;
            GridView1.DataBind();
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text.Equals("Them"))
            {

                txtEmail.Enabled = true;
                txtIDCauThu.Enabled = true;
                txtSDT.Enabled = true;
                txtTenCauThu.Enabled = true;
                btnThem.Text = "Huy Them";
                btnLuu.Text = "Luu Moi";
            }
            else
            {
                txtEmail.Enabled = false;
                txtIDCauThu.Enabled = false;
                txtSDT.Enabled = false;
                txtTenCauThu.Enabled = false;
                btnThem.Text = "Them";
                btnLuu.Text = "Luu";
            }

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnThem.Text.Equals("Update"))
            {

                txtEmail.Enabled = true;
                txtIDCauThu.Enabled = true;
                txtSDT.Enabled = true;
                txtTenCauThu.Enabled = true;
                btnUpdate.Text = "Huy Update";
                btnLuu.Text = "Luu Update";
            }
            else
            {
                txtEmail.Enabled = false;
                txtIDCauThu.Enabled = false;
                txtSDT.Enabled = false;
                txtTenCauThu.Enabled = false;
                btnThem.Text = "Update";
                btnLuu.Text = "Luu";
            }
        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnLuu.Text.Equals("Luu Moi"))
            {
                if (busplayer.CreatPlayer(new ePlayer()
                {
                    maCauThu = txtIDCauThu.Text,
                    tenCauThu = txtTenCauThu.Text,
                    email = txtEmail.Text,
                    soDT = txtSDT.Text,
                    maDoiBong = DropDownList2.SelectedItem.Value
                }))
                {
                    MsgBox("! Sucess !", this.Page, this);
                }


            }
            else
            {
                if (busplayer.updatePlayer(new ePlayer()
                {
                    maCauThu = txtIDCauThu.Text,
                    tenCauThu = txtTenCauThu.Text,
                    email = txtEmail.Text,
                    soDT = txtSDT.Text,
                    maDoiBong = DropDownList2.SelectedItem.Value
                }))
                {
                    MsgBox("! Sucess !", this.Page, this);
                }
            }
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            if (busplayer.deletePlayer(txtIDCauThu.Text)) { MsgBox("! Sucess !", this.Page, this); } else
            {
                MsgBox("! Faild !", this.Page, this);
            }
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