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
    public partial class Trainers : Form
    {
        private Form FormToBack;
        public Trainers(Form Parent)
        {
            InitializeComponent();
            FormToBack = Parent;
        }

        private void AmountTrainersIncome_Click(object sender, EventArgs e)
        {
            string Query = "select * from GetTrainersIncome";
            TrainersData.DataSource = DB.Select(Query);
        }

        private void GetTrainersIntoPoolBtn_Click(object sender, EventArgs e)
        {
            string Query = "execute GetTrainersIntoPool '" + PoolsNames.SelectedItem.ToString() + "'";
            TrainersData.DataSource = DB.Select(Query);
        }

        private void FillPoolsCombobox()
        {
            string Query = "select Название from Бассейн";
            DB.Select(Query);

            for (int i = 0; i < DB.ds.Tables[0].Rows.Count; i++)
            {
                PoolsNames.Items.Add(DB.ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void GetTrainersData()
        {
            string Query = "select * from GetTrainersData";
            TrainersData.DataSource = DB.Select(Query);
        }

        private void Trainers_Load(object sender, EventArgs e)
        {
            FillPoolsCombobox();
            PoolsNames.SelectedIndex = 0;
            GetTrainersData();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Hide();
            FormToBack.Show();
        }

        private void Trainers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BeginnersTrainers_Click(object sender, EventArgs e)
        {
            string Query = "select * from GetBeginnersTrainer";
            TrainersData.DataSource = DB.Select(Query);
        }
    }
}
