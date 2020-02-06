using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Requests.Database
{
    class Reminders_Data
    {
        public Reminders_Data() { }

        public void saveReminder(int issueId, int userId, DateTime date, bool status)
        { 
            using (var dbContext = new Service_Requests_Data_GOVEntities())
            {
                reminder re = dbContext.reminders.SingleOrDefault(r => r.reminder_issue_id == issueId && r.reminder_user_id == userId);
                
                if(re == null)
                {
                    reminder remind = new reminder();
                    remind.reminder_issue_id = issueId;
                    remind.reminder_user_id = userId;
                    remind.remider_date = date;
                    remind.reminder_enabled = status;
                    dbContext.reminders.Add(remind);
                    dbContext.SaveChanges();
                }
                else
                {
                    updateReminder(issueId, userId, date, status);
                }
                
            }  
        }

        public void updateReminder(int issueId, int userId, DateTime date, Boolean status)
        {
            using (var dbContext = new Service_Requests_Data_GOVEntities())
            {
                reminder rem = dbContext.reminders.SingleOrDefault(r => r.reminder_issue_id == issueId && r.reminder_user_id == userId);
                if (rem != null)
                {
                    rem.remider_date = date;
                    rem.reminder_enabled = status;
                    dbContext.SaveChanges();
                }
            }
        }

        public reminder getReminder(int issueId, int userId)
        {
            using (var dbContext = new Service_Requests_Data_GOVEntities())
            {
                reminder rem = dbContext.reminders.SingleOrDefault(r => r.reminder_issue_id == issueId && r.reminder_user_id == userId);
                return rem;
            }  
        }
    

        public Boolean reminderEnabled(int issueId, int userId)
        {
            using (var dbContext = new Service_Requests_Data_GOVEntities())
            {
                reminder rem = dbContext.reminders.SingleOrDefault(r => r.reminder_issue_id == issueId && r.reminder_user_id == userId);
                if (rem != null && rem.reminder_enabled == true)
                {
                    return true;
                }
                else { return false; }
            }
        }
    }
}
