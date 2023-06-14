using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StazhirovkaZadanie2
{
    public class LoginsHistory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime DateTime { get; set; }
        public string IP { get; set; }
        public string DeviceSettings { get; set; }
    }
}
