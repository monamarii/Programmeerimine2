using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Data
{
    public class ProjectTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime Start_Date { get; set; }
        public decimal Estimated_Hours { get; set; }
        public bool Is_Done { get; set; }
        public decimal? Fixed_Price { get; set; }
    }
}