using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FirstCode.Constants;

namespace FirstCode.Models
{
    public class Student : User
    {
        [Column(DataBase.ClassNumField)]
        public int ClassNum { get; set; }

        [Column(DataBase.GradeField)]
        public int Grade { get; set; }

        [Column(DataBase.MajorField)]
        public string Major { get; set; }

        [DataType(DataType.Date), Column(DataBase.InDateField)]
        public DateTime? InDate { get; set; }

        [DataType(DataType.Date), Column(DataBase.OutDateField)]
        public DateTime? OutDate { get; set; }

        [Column(DataBase.DormitoryForeignKey)]
        public string DormitoryId { get; set; }

        [ForeignKey("DormitoryId")]
        public Dormitory Dormitory { get; set; }

        public Student() => Identity = Identity.STUDENT;
    }
}