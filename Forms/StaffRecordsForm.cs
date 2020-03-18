using FrisbiTestApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrisbiTestApp.Forms
{
    public partial class StaffRecordsForm : Form
    {
        private readonly IStaffRepository staffRepository;

        public StaffRecordsForm(IStaffRepository staffRepository)
        {
            this.staffRepository = staffRepository;
            InitializeComponent();
        }

        private void StaffRecordsForm_Load(object sender, EventArgs e)
        {
            try { 

                var staffRecords = staffRepository.GetAllStaffRecords();

                foreach(var staffRecord in staffRecords)
                {
                    ListViewItem record = new ListViewItem(new string[] {staffRecord.Id.ToString() , staffRecord.Name, staffRecord.Surname , staffRecord.MiddleName , staffRecord.Position , staffRecord.Salary.ToString() , staffRecord.StartDate.ToString() , staffRecord.DateofDismissal.ToString() });
                    StaffRecordsViewList.Items.Add(record);           
                }

            }
            catch(Exception except)
            {
                if(MessageBox.Show("Ошибка: "+except.Message , "Неудача") == DialogResult.OK)
                {
                    Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StaffRecordsViewList_DoubleClick(object sender, EventArgs es)
        {
            
        }
    }
}
