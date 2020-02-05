using Service_Rrequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Requests.Database
{
    class Actions_Data
    {

        public Actions_Data()
        {

        }

        public void addAction(action a)
        {
            DateTime date = DateTime.Now;
            a.action_description = date.ToString() + ": " + SessionInfo.userName + " "  + a.action_description;
            using (var dbContext = new Service_Requests_Data_GOVEntities())
            {
                dbContext.actions.Add(a);
                dbContext.SaveChanges();
            }
        }

        public List<action> getAllActionsForIssue(int issueId)
        {
            List<action> actions = new List<action>();
            using (var dbContext = new Service_Requests_Data_GOVEntities())
            {
                actions = dbContext.actions.Where(a => a.issue_id.Equals(issueId)).ToList();
            }

            return actions;
        }
    }
}
