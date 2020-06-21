using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Entity;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        teamBus bus;
        public Form2()
        {
            InitializeComponent();
            bus = new teamBus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemDoiBong_Click(object sender, EventArgs e)
        {
            if(bus.CreateTeam(new eTeam() { maDoiBong = txtMaDoiBong.Text, tenDoiBong = txtTenDoiBong.Text }))
            {
                MessageBox.Show( "them doi bong thanh cong", "thong bao");
            }
        }
    }
}
