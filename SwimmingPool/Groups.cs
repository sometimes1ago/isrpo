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
    public partial class Groups : Form
    {
        private Form FormToBack;
        public Groups(Form Parent)
        {
            InitializeComponent();
            FormToBack = Parent;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            FormToBack.Show();
        }

        private void MaxPollIncome_Click(object sender, EventArgs e)
        {
            string Query = "select * from GetGroupsCount";
            GroupsData.DataSource = DB.Select(Query);
        }

        private void Groups_Load(object sender, EventArgs e)
        {
            GroupsData.DataSource = DB.Select("select * from GetGroupsData");
        }
    }
}
