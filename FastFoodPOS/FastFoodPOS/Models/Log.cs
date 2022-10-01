using FastFoodPOS.DatabaseUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodPOS.Models
{
    class Log
    {
        User user;
        public int user_id { get; set; }
        public DateTime date_created{ get; set; }
        public string activity { get; set; }

        public Log(User user)
        {
            this.user = user;
        }

        public User GetUser()
        {
            if (user == null)
                user = User.Find(user_id);
            return user;
        }

        public static void AddLog(string activity)
        {
            if (User.CurrentUser.Role == "Administrator") return;
            using (var cmd = DatabaseModel.CreateCommand("INSERT INTO  Logs ( user_id ,  activity ,  date_created ) VALUES ('" + User.CurrentUser.Id + "','" + activity + "',Convert(datetime,GetDate()))"))
            {
                DatabaseModel.BindParameters(cmd, User.CurrentUser.Id, activity, DatabaseModel.GetProvider().FormatDateTime(DateTime.Now));
                DatabaseModel.GetConnection().Open();
                cmd.ExecuteNonQuery();
                DatabaseModel.GetConnection().Close();
            }
        }

        public static List<Log> GetLogs(User user,DateTime date)
        {
            var result = new List<Log>();
            using (var cmd = DatabaseModel.CreateCommand("SELECT  activity ,  date_created  FROM  logs  WHERE  user_id ='"+user.Id+ "' and date_created Between Convert(date,'" + DatabaseModel.GetProvider().FormatShortDate(date) + "') AND Convert(date,'" + DatabaseModel.GetProvider().FormatShortDate(date.AddDays(1)) + "')  ORDER BY  date_created  DESC"))
            {
                DatabaseModel.BindParameters(cmd, user.Id);
                DatabaseModel.GetConnection().Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new Log(user) { 
                            activity = reader.GetString(0), 
                            date_created = reader.GetDateTime(1) 
                        });
                    }
                }
                DatabaseModel.GetConnection().Close();
            }
            return result;
        }
    }
}
