using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.CLASS
{
    public class Record
    {
        public int Rid { get; set; }
        public DateTime Rdate { get; set; }
        public string Rtitle { get; set; }
        public string Rcontent { get; set; }
        public byte[] Pic { get; set; }
        public int AccountId { get; set; }

    }
}
