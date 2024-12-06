using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using VitApp_0._1._0.Clases;

namespace VitApp_0._1._0.Models
{
    internal class AssignPhysicStatus
    {
        public int Q1;
        public int Q2;
        public int Q3;
        public int Q4;
        public int Calories;
        public int PStatus;

        public void CalculateStatus()
        {
            User user = new User();

            PStatus = Q1 + Q2 + Q3 + Q4 + Calories;

            user.PStatusUser = PStatus;
        }

    }

}
