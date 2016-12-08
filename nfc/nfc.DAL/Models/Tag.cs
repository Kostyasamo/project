using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nfc.DAL.Models
{
    public class Tag
    {
        public int Id_Tag { get; set; }
        public string Name { get; set; }
        public bool isActive { get; set; }
        public DateTime TimeToLive { get; set; }
        public int Author_id { get; set; }
    }
}
