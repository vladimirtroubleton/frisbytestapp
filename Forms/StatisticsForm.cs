using FrisbiTestApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrisbiTestApp.Forms
{
    public partial class StatisticsForm : Form
    {
        private readonly IStaffRepository staffRepository;
        public StatisticsForm(IStaffRepository staffRepository)
        {
            this.staffRepository = staffRepository;
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            WrtiteStatisticAtListBox();
        }

        private void WrtiteStatisticAtListBox()
        {
            var staffRecords = staffRepository.GetAllStaffRecords();

            listBoxStatistics.Items.Add("_____________________________");
            listBoxStatistics.Items.Add("Число действующих работников: " + staffRecords.Where(x => x.DateofDismissal == null).Count());
            listBoxStatistics.Items.Add("Число работников за все время: " + staffRecords.Count());

            if(staffRecords.Where(x => x.DateofDismissal == null).Count()!= 0)
            listBoxStatistics.Items.Add("Средний оклад действующих работников: " + staffRecords.Where(x => x.DateofDismissal == null).Select(x => x.Salary).Sum()/ staffRecords.Where(x => x.DateofDismissal == null).Count());
            
            listBoxStatistics.Items.Add("Средний оклад за все время: " + staffRecords.Select(x => x.Salary).Sum()/ staffRecords.Count());
            listBoxStatistics.Items.Add("Последняя дата приема сотрудника: " + staffRecords.Select(x=>x.StartDate).Max());
            listBoxStatistics.Items.Add("Последняя дата увольнения сотрудника: " + staffRecords.Select(x=>x.DateofDismissal).Max());
            listBoxStatistics.Items.Add("_____________________________");
        }

        private void buttonRefreshStatic_Click(object sender, EventArgs e)
        {
            WrtiteStatisticAtListBox();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
