using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS;
using System.Windows.Forms;
using Entity;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        teamBus teamBus;
        playerBus playerBus;
        public Form1()
        {
            InitializeComponent();
            teamBus = new teamBus();
            playerBus = new playerBus();
            loadData();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void loadData()
        {
            List<eTeam> listTeam = teamBus.getALlTeam();

            cboTeam.DisplayMember = "tenDoiBong";
            cboTeam.ValueMember = "maDoiBong";
            cboTeam.DataSource = listTeam;

            cboDoiBong1.DisplayMember = "tenDoiBong";
            cboDoiBong1.ValueMember = "maDoiBong";
            cboDoiBong1.DataSource = listTeam;

            txtCauThuID.Enabled = false;
            txtTenCauThu.Enabled = false;
            txtEmail.Enabled = false;
            txtSoDienThoai.Enabled = false;
            cboDoiBong1.Enabled = false;


        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            if (cboTeam.SelectedItem != null)
            {
                List<ePlayer> listPlayer = playerBus.getALlPlayerTheoTeam(cboTeam.SelectedValue.ToString());
                dataGridView1.DataSource = listPlayer;
                dataGridView1.Columns["eTeam"].Visible = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (btnThemCauThu.Text.Equals("Them"))
            {
                btnThemCauThu.Text = "Huy Them";
                txtCauThuID.Enabled = true;
                txtTenCauThu.Enabled = true;
                txtEmail.Enabled = true;
                txtSoDienThoai.Enabled = true;
                cboDoiBong1.Enabled = true;

                btnLuu.Text = "Luu Them";
            }
            else {
                btnThemCauThu.Text = "Them";
                txtCauThuID.Enabled = false;
                txtTenCauThu.Enabled = false;
                txtEmail.Enabled = false;
                txtSoDienThoai.Enabled = false;
                cboDoiBong1.Enabled = false;

                btnLuu.Text = "Luu";
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (btnCapNhat.Text.Equals("Cap Nhat"))
            {
                btnCapNhat.Text = "Huy Cap Nhat";
                txtCauThuID.Enabled = false;
                txtTenCauThu.Enabled = true;
                txtEmail.Enabled = true;
                txtSoDienThoai.Enabled = true;
                cboDoiBong1.Enabled = true;

                btnLuu.Text = "Luu Cap Nhat";
            }
            else
            {
                btnCapNhat.Text = "Cap Nhat";
                txtCauThuID.Enabled = false;
                txtTenCauThu.Enabled = false;
                txtEmail.Enabled = false;
                txtSoDienThoai.Enabled = false;
                cboDoiBong1.Enabled = false;

                btnLuu.Text = "Luu";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(btnLuu.Text.Equals("Luu Them"))
            {
               if( playerBus.CreatPlayer(new ePlayer()
                {
                    maCauThu = txtCauThuID.Text,
                    tenCauThu = txtTenCauThu.Text,
                    email = txtEmail.Text,
                    maDoiBong = cboDoiBong1.SelectedValue.ToString()                    
                }))
                {
                    MessageBox.Show("Thong bao", "Them cau thu thanh cong");
                    List<ePlayer> list = playerBus.getALlPlayerTheoTeam(cboTeam.SelectedValue.ToString());
                    dataGridView1.DataSource = list;
                }
            }
            else
            {
                if (playerBus.updatePlayer(new ePlayer()
                {
                    maCauThu = txtCauThuID.Text,
                    tenCauThu = txtTenCauThu.Text,
                    email = txtEmail.Text,
                    soDT =txtSoDienThoai.Text,
                    maDoiBong = cboDoiBong1.SelectedValue.ToString()
                })) {
                    MessageBox.Show( "Cap nhat cau thu thanh cong", "Thong bao");
                    List<ePlayer> list = playerBus.getALlPlayerTheoTeam(cboTeam.SelectedValue.ToString());
                    dataGridView1.DataSource = list;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (playerBus.deletePlayer(txtCauThuID.Text)) {
                MessageBox.Show("Xoa cau thu thanh cong","Thong bao");
            }
            List<ePlayer> list = playerBus.getALlPlayerTheoTeam(cboTeam.SelectedValue.ToString());
            dataGridView1.DataSource = list;
        }

        private void btnThemDoi_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();

            cboTeam.DataSource = null;
            cboTeam.DisplayMember = "tenDoiBong";
            cboTeam.ValueMember = "maDoiBong";
            cboTeam.DataSource= teamBus.getALlTeam();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtCauThuID.Text = dataGridView1.SelectedRows[0].Cells["maCauThu"].FormattedValue.ToString();
                txtTenCauThu.Text = dataGridView1.SelectedRows[0].Cells["tenCauThu"].FormattedValue.ToString();
                txtSoDienThoai.Text = dataGridView1.SelectedRows[0].Cells["soDT"].FormattedValue.ToString();
                txtEmail.Text = dataGridView1.SelectedRows[0].Cells["email"].FormattedValue.ToString();
                cboDoiBong1.SelectedItem = cboTeam.SelectedItem;
            }
        }
    }
}
