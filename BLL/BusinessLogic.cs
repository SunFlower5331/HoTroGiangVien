using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BusinessLogic
    {
        public static TeachingSchedule GetTeachingScheduleByUserID(int userID)
        {
            return DAL_TeachingSchedule.GetTeachingScheduleByUserID(userID);
        }
        public static void AddTeachingSchedule(string id, string date, string ca)
        {
            DAL_TeachingSchedule.AddTeachingSchedule(id, date, ca);
        }
    }
}
