using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Data
{
    public class Timelog
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Duration_H { get; set; }
        public string Activity_Desc { get; set; }
    }
}