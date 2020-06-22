using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        teamBus team;
        playerBus player;
        public Form1()
        {
            InitializeComponent();
            team = new teamBus();
            player = new playerBus();
            var ss = player.getALlPlayer();
           
            var s = team.getALlTeam();
            comboBox1.DataSource = team.getALlTeam();
        }
    }
}
