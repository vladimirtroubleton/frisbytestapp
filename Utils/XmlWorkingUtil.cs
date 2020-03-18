using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace FrisbiTestApp.Utils
{
    public class XmlWorkingUtil
    {
        public XmlWorkingUtil(string id, string name, string surname, string middleName, string position, string salary, string startDate, string dateofDismissal)
        {
            Id = id;
            Name = name;
            Surname = surname;
            MiddleName = middleName;
            Position = position;
            Salary = salary;
            StartDate = startDate;
            DateofDismissal = dateofDismissal;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string Position { get; set; }
        public string Salary { get; set; }
        public string StartDate { get; set; }
        public string DateofDismissal { get; set; }

        public void SaveToFile(XmlTextWriter xmlOut)
        {
            xmlOut.WriteStartElement("Сотрудник");
            xmlOut.WriteAttributeString("ID_Сотрудника", Id.ToString());
            xmlOut.WriteAttributeString("Имя", Name.ToString());
            xmlOut.WriteAttributeString("Фамилия", Surname.ToString());
            xmlOut.WriteAttributeString("Отчество", MiddleName.ToString());
            xmlOut.WriteAttributeString("Должность", Position.ToString());
            xmlOut.WriteAttributeString("Оклад", Salary.ToString());
            xmlOut.WriteAttributeString("Дата приема на работу", StartDate.ToString());
            xmlOut.WriteAttributeString("Дата увольнения", DateofDismissal.ToString());
            xmlOut.WriteEndElement();
        }
        public void LoadFromFile(XmlTextReader xmlin)
        {
            try
            {
                Id = xmlin.GetAttribute("ID_Сотрудника");
                Name = xmlin.GetAttribute("Имя");
                Surname = xmlin.GetAttribute("Фамилия");
                MiddleName = xmlin.GetAttribute("Отчество");
                Position = xmlin.GetAttribute("Должность");
                Salary = xmlin.GetAttribute("Оклад");
                StartDate = xmlin.GetAttribute("Дата приема на работу");
                DateofDismissal = xmlin.GetAttribute("Дата увольнения");
            }
            catch (Exception expcet)
            {
                MessageBox.Show(expcet.Message);
            }
        }
    }
}
