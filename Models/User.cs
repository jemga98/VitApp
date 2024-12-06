using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitApp_0._1._0.Clases
{
    internal class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BornDate { get; set; }
        public int Phone { get; set; }
        public string Password { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int PStatusUser { get; set; }
    }

}
