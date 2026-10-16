using System;
using System.Collections.Generic;
using System.Text;

namespace KooliProjekt.Application.Data
{
    public class Attachment
    {
        public int Id { get; set; }
        public string File_Name { get; set; }
        public string File_Path { get; set; }
        public string File_Type { get; set; }
        public DateTime Uploaded_Date { get; set; }
    }
}