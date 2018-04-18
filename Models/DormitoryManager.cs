using System;
using System.Collections.Generic;
namespace FirstCode.Models
{
    public class DormitoryManager : User   
    {
        public DateTime MangeDate { get; set; }
        public ICollection<Dormitory> Dormitorys { get; set; }

        public DormitoryManager() => Identity = Identity.DORMITORY_ADMINISTRATOR;
    }
}