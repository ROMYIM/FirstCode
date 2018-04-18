using System;

namespace FirstCode.Models
{
    public class Information
    {
        public int Id { get; set; }
        public DateTime SendDate { get; set; }
        public DateTime Deadline { get; set; }
        public string Content { get; set; }
    }
}