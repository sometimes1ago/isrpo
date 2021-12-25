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
    public partial class Tickets : Form
    {
        private Form FormToBack;
        public Tickets(Form Parent)
        {
            InitializeComponent();
            FormToBack = Parent; 
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            TIcketsData.DataSource = DB.Select("select * from GetTicketsData");
            FillTrainersCombobox();
            Trainers.SelectedIndex = 0;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            FormToBack.Show();
            Hide();
        }

        private void GetSelectedTicket_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            string[] spl = service.SplitComboboxItem(Trainers, ' ');
            TIcketsData.DataSource = DB.Select("execute GetTickedByTrainer '" + spl[0] + "'");
        }

        private void FillTrainersCombobox()
        {
            DB.Select("select Фамилия, Имя, Отчество from Тренер");
            for (int i = 0; i < DB.ds.Tables[0].Rows.Count; i++)
            {
                Trainers.Items.Add(
                    DB.ds.Tables[0].Rows[i][0].ToString() + " " +
                    DB.ds.Tables[0].Rows[i][1].ToString() + " " +
                    DB.ds.Tables[0].Rows[i][2].ToString()
                    );
            }
        }

        private void Tickets_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
