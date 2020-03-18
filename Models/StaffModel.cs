using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FrisbiTestApp.Models
{
    public class StaffModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string Position { get; set; }
        public long Salary { get; set; }
        public DateTime StartDate{ get; set; }
        public DateTime? DateofDismissal { get; set; }
    }
}
