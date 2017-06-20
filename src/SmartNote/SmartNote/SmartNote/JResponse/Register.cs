using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNote.JResponse
{
    public class Register
    {
        public int error { set; get; }
        public int success { set; get; }
        public string email { set; get; }
        public Enums.Register result { set; get; }
    }
}
