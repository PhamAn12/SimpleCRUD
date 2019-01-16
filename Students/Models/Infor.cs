using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Students.Models
{
    public class Infor
    {
        [Key]
        [DisplayName("Mã Sinh Viên")]
        public int StudentId { get; set; }
        [DisplayName("Tên Sinh Viên")]
        public string StudentName { get; set; }
        [DisplayName("Tuổi")]
        public int Age { get; set; }
    }
}