using FrisbiTestApp.Exceptions;
using FrisbiTestApp.Forms;
using FrisbiTestApp.Models;
using FrisbiTestApp.Repositories;
using FrisbiTestApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace FrisbiTestApp
{
    public partial class Form1 : Form
    {
        private readonly IStaffRepository staffRepository;
        public Form1(IStaffRepository staffRepository)
        {
            this.staffRepository = staffRepository;
            InitializeComponent();
        }

        private List<StaffModel> staffRecords;

        string filename = "";

        private void AddStaffButon_Click(object sender, EventArgs e)
        {
            AddStaffForm addStaffForm = new AddStaffForm(staffRepository);
            addStaffForm.Show();
        }

        private void GetStaffsListButton_Click(object sender, EventArgs e)
        {
            StaffRecordsForm staffRecordsForm = new StaffRecordsForm(staffRepository);
            staffRecordsForm.Show();
        }

        private void FindStaffButton_Click(object sender, EventArgs e)
        {
            FindedStaffRecords.Items.Clear();

            List<StaffModel> staffRecordsFinded = new List<StaffModel>(); ;

            var staffInform = StaffFindTextBox.Text;
            if(radioButtonName.Checked == true)
            {
                staffRecordsFinded = staffRepository.GetStaffRecordByName(staffInform);
              
               
                
            }
            else if(radioButtonSurname.Checked == true)
            {
                staffRecordsFinded = staffRepository.GetStaffRecordBySurname(staffInform);
                
            }
            else
            {
                MessageBox.Show("Вы не выбрали тип поисковых данных","Ошибка");
            }

            if(staffRecordsFinded.Count != 0)
            {
                foreach (var staffRecord in staffRecordsFinded)
                {
                    FindedStaffRecords.Items.Add("_______________________________________");
                    FindedStaffRecords.Items.Add("ID сотрудника: " + staffRecord.Id);
                    FindedStaffRecords.Items.Add("Имя: " + staffRecord.Name);
                    FindedStaffRecords.Items.Add("Фамилия: " + staffRecord.Surname);
                    FindedStaffRecords.Items.Add("Отчество: " + staffRecord.MiddleName);
                    FindedStaffRecords.Items.Add("Должность: " + staffRecord.Position);
                    FindedStaffRecords.Items.Add("Оклад: " + staffRecord.Salary);
                    FindedStaffRecords.Items.Add("Начало работы: " + staffRecord.StartDate);
                    FindedStaffRecords.Items.Add("Дата увольнения: " + staffRecord.DateofDismissal);
                    FindedStaffRecords.Items.Add("_______________________________________");
                }
            }
            else if(staffRecordsFinded.Count == 0 &&(radioButtonName.Checked == true || radioButtonSurname.Checked == true))
            {
                FindedStaffRecords.Items.Add("_______________________________________");
                FindedStaffRecords.Items.Add("Данных по вашему запросу не обнаружено");
                FindedStaffRecords.Items.Add("_______________________________________");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                staffRepository.RingingDb();
                labelConnectData.Text = "База данных готова к работе";
                staffRecords = staffRepository.GetAllStaffRecords();
            }
            catch(ExceptDbAcess except)
            {
                MessageBox.Show(except.Message);
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }
        }

        private void DismissStaffButton_Click(object sender, EventArgs e)
        {
            DismissStaffForm dismissStaffForm = new DismissStaffForm(staffRepository);
            dismissStaffForm.Show();
        }

        private void buttonStatisticsShow_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm(staffRepository);
            statisticsForm.Show();
        }

        private void buttonExportToXML_Click(object sender, EventArgs e)
        {


            if(staffRecords.Count == 0)
            {
                if(MessageBox.Show("Нечего экспортировать") == DialogResult.OK)
                {
                    return;
                }
            }
            if (filename == "")
            {
                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.Title = "Экспорт";
                fileDialog.Filter = "XML files|*.xml";
                if (fileDialog.ShowDialog() != DialogResult.OK)
                    return;

                filename = fileDialog.FileName;
                Export();
                MessageBox.Show("Можете посмотреть экспортированные файлы в выбранном каталоге");
                filename = "";
            }

        }

        public void Export()
        {
            var arrExportStaff = staffRecords.ToArray();
        
            FileStream fs = new FileStream(filename, FileMode.Create);
            XmlTextWriter xmlOut = new XmlTextWriter(fs, Encoding.Unicode);

            xmlOut.Formatting = Formatting.Indented;

            xmlOut.WriteStartDocument();
            xmlOut.WriteComment("Тестовое задание");

            xmlOut.WriteStartElement("StaffList");
            xmlOut.WriteAttributeString("Version", "1.0.0");

            int count = arrExportStaff.Count();

            for (int i = 0; i < count; i++)
            {
                
                XmlWorkingUtil stroka = new XmlWorkingUtil(arrExportStaff[i].Id.ToString(),
                                                            arrExportStaff[i].Name, 
                                                            arrExportStaff[i].Surname,
                                                            arrExportStaff[i].MiddleName, 
                                                            arrExportStaff[i].Position, 
                                                            arrExportStaff[i].Salary.ToString(),
                                                            arrExportStaff[i].StartDate.ToString(), 
                                                            arrExportStaff[i].DateofDismissal.ToString());
                stroka.SaveToFile(xmlOut);
            }

            //закрытие основного тега и документа
            xmlOut.WriteEndElement();
            xmlOut.WriteEndDocument();

            //закрытие объекта записи
            xmlOut.Close();
            fs.Close();
        }



    }
}
