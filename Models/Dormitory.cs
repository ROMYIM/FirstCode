using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstCode.Models
{
    public class Dormitory
    {
        public string Id { get; set; }
        public int Floor { get; set; }
        public int Building { get; set; }
        public int Room { get; set; }
        public string DormitoryManagerId { get; set; }
        [ForeignKey("DormitoryManagerId")]
        public DormitoryManager DormitoryManager { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}