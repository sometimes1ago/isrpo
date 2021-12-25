using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimmingPool
{
    public partial class Main : Form
    {
        private Form FormToBack;
        public Main(Form Parent)
        {
            InitializeComponent();
            FormToBack = Parent;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Hide();
            FormToBack.Show();
        }

        private void GetPoolsDataBtn_Click(object sender, EventArgs e)
        {
            Pools pools = new Pools(this);
            pools.Show();
            Hide();
        }

        private void GetTrainersDataBtn_Click(object sender, EventArgs e)
        {
            Trainers trainers = new Trainers(this);
            trainers.Show();
            Hide();
        }

        private void GetGroupsDataBtn_Click(object sender, EventArgs e)
        {
            Groups groups = new Groups(this);
            groups.Show();
            Hide();
        }

        private void GetTicketsDataBtn_Click(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets(this);
            tickets.Show();
            Hide();
        }
    }
}
