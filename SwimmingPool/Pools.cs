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
    public partial class Pools : Form
    {
        private Form FormToBack;
        public Pools(Form Parent)
        {
            InitializeComponent();
            FormToBack = Parent;
        }

        private void Pools_Load(object sender, EventArgs e)
        {
            string Query = "select * from GetPoolsData";
            PoolsData.DataSource = DB.Select(Query);
        }

        private void Pools_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            FormToBack.Show();
        }

        private void MaxPollIncome_Click(object sender, EventArgs e)
        {
            string Query = "select * from MaxPoolIncome";
            PoolsData.DataSource = DB.Select(Query);
        }
    }
}
