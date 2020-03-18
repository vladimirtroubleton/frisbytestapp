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
    public partial class AddStaffForm : Form
    {
        private readonly IStaffRepository staffRepository;
        public AddStaffForm(IStaffRepository staffRepository)
        {
            this.staffRepository = staffRepository;
            InitializeComponent();
        }

        private void AddStaffForm_Load(object sender, EventArgs e)
        {

        }



        private void StaffAddButton_Click_1(object sender, EventArgs e)
        {
            StaffModel staffRecord;

            try { 
                
                    if (dateTimePickerEnd.Value > dateTimePickerStartDate.Value)
                    {
                        staffRecord = new StaffModel
                        {
                            Name = textBoxName.Text,
                            Surname = textBoxSurname.Text,
                            MiddleName = textBoxMiddleName.Text,
                            Position = textBoxPosition.Text,
                            Salary = Convert.ToInt64(textBoxSalary.Text),
                            StartDate = dateTimePickerStartDate.Value,
                            DateofDismissal = dateTimePickerEnd.Value

                        };
                    }
                    else
                    {
                        staffRecord = new StaffModel
                        {
                            Name = textBoxName.Text,
                            Surname = textBoxSurname.Text,
                            MiddleName = textBoxMiddleName.Text,
                            Position = textBoxPosition.Text,
                            Salary = Convert.ToInt64(textBoxSalary.Text),
                            StartDate = dateTimePickerStartDate.Value,
                            DateofDismissal = null


                        };
                    }
                    var operationResult = staffRepository.AddStaffRecord(staffRecord);
                    if (operationResult == true)
                    {
                        if (MessageBox.Show("Сохранено!", "Успех") == DialogResult.OK)
                        {
                            Close();
                        };

                    }
                    else
                    {
                        MessageBox.Show("Сохранение не удалось");
                    }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }
        }
    }
}
