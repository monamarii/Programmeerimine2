using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Data
{
    public class Project
    {
        public int Id { get; set; }
        public string Project_Name { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime Due_Date { get; set; }
        public decimal Budget { get; set; }
        public decimal Hourly_Rate { get; set; }
    }
}