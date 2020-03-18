using FrisbiTestApp.Models;
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
    public partial class DismissStaffForm : Form
    {
        private readonly IStaffRepository staffRepository;
        private StaffModel dismissStaffRecord;
        public DismissStaffForm(IStaffRepository staffRepository)
        {
            this.staffRepository = staffRepository;
            InitializeComponent();
        }

        private void DismissStaffForm_Load(object sender, EventArgs e)
        {

        }

        private void DismissStartButton_Click(object sender, EventArgs e)
        {
           
            try 
            { 
                dismissStaffRecord = staffRepository.GetStaffRecordById(Convert.ToInt32(numericDismissId.Value));
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }


            if (dismissStaffRecord != null && dismissStaffRecord.DateofDismissal == null)
            {
                numericDismissId.Visible = false;
                DismissStartButton.Visible = false;
                label1.Visible = false;

                DismissStaffInfo.Visible = true;

                label2.Visible = true;

                DismissTimePicker.Visible = true;
                DismissEndButton.Visible = true;
                label3.Visible = true;
        
                DismissStaffInfo.Items.Add("_______________________________________");
                DismissStaffInfo.Items.Add("ID сотрудника: " + dismissStaffRecord.Id);
                DismissStaffInfo.Items.Add("Имя: " + dismissStaffRecord.Name);
                DismissStaffInfo.Items.Add("Фамилия: " + dismissStaffRecord.Surname);
                DismissStaffInfo.Items.Add("Отчество: " + dismissStaffRecord.MiddleName);
                DismissStaffInfo.Items.Add("Должность: " + dismissStaffRecord.Position);
                DismissStaffInfo.Items.Add("Оклад: " + dismissStaffRecord.Salary);
                DismissStaffInfo.Items.Add("Начало работы: " + dismissStaffRecord.StartDate);
                DismissStaffInfo.Items.Add("Дата увольнения: " + dismissStaffRecord.DateofDismissal);
                DismissStaffInfo.Items.Add("_______________________________________");


                


            }
            else
            {
                MessageBox.Show("Сотрудник уже уволен или не найден");
            }
        }

        private void DismissEndButton_Click(object sender, EventArgs e)
        {
            if (dismissStaffRecord != null && DismissTimePicker.Value > dismissStaffRecord.StartDate) 
            { 
                dismissStaffRecord.DateofDismissal = DismissTimePicker.Value;

                staffRepository.DismissingStaffRecord(dismissStaffRecord);

                string dismissstring = String.Format("Сотрудник  - {0} {1} был уволен", dismissStaffRecord.Surname , dismissStaffRecord.Name);
                
                MessageBox.Show(dismissstring);

                Close();
            }
            else
            {
                MessageBox.Show("Повторите попытку ввода даты увольнения");
            }

          
        }
    }
}
