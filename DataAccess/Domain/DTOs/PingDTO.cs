using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class PingDTO
    {
        public string Status { get; set; }
        public int ID { get; set; }
        public DateTime time { get; set; }
    }
}
