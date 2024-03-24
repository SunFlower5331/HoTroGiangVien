using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DAL_TeachingSchedule : DatabaseAccess
    {

        public class SqlConnectionData
        {
            public static SqlConnection connect()
            {
                string conStr = "Data Source=ONG;Initial Catalog=HoTroGiangVien;Integrated Security=True;integrated security=True";//SỬA LẠI DATASOURCE
                SqlConnection con = new SqlConnection(conStr);
                return con;
            }
        }

        public static TeachingSchedule GetTeachingScheduleByUserID(int userID)
        {
           TeachingSchedule teachingSchedule = null;

            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TeachingSchedule WHERE user_id = @UserID", conn);
                cmd.Parameters.AddWithValue("@UserID", userID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Khởi tạo đối tượng DTO từ dữ liệu đọc được từ cơ sở dữ liệu
                        teachingSchedule = new TeachingSchedule
                        {
                            ScheduleId = (int)reader["schedule_id"],
                            UserId = (int)reader["user_id"],
                            Date = (DateTime)reader["date"],
                            ca = reader["ca"].ToString()
                        };
                    }
                }
            }

            return teachingSchedule;
        }
        public static void AddTeachingSchedule(string id, string date, string ca)
        {
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();
                string sql = "INSERT INTO TeachingSchedule VALUES (@id, @date, @ca)";
                SqlCommand cmd = new SqlCommand(sql, conn);
               
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@ca", ca);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
