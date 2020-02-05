using Service_Requests;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Rrequests.Database
{
    class IssuesData
    {
        public IssuesData()
        {

        }

        public List<issue> getAllIssues()
        {
            List<issue> issues = new List<issue>();
            using (var dbContext = new Service_Requests_Data_GOVEntities())
            {
                foreach(issue i in dbContext.issues)
                {
                    issues.Add(i);
                }
            }
            return issues;
        }

        public int getIssueIDbyTitle(string title)
        {
            using (var dbContext = new Service_Requests_Data_GOVEntities())
            {
                var issueType = dbContext.issue_types.Where(i => i.issue_title.Equals(title)).FirstOrDefault<issue_types>();
                return issueType.issue_type_id;
            }
        }

        public int saveIssue(issue i)
        {
            try
            {
                using (var dbContext = new Service_Requests_Data_GOVEntities())
                {
                    dbContext.issues.Add(i);
                    dbContext.SaveChanges();
                    return 1;
                }
            }
            catch
            {
                return 0;
            }
        }

        public void toggleIssueStatusTo(bool status, int issueId)
        {
            using (var dbContext = new Service_Requests_Data_GOVEntities())
            {
                var result = dbContext.issues.SingleOrDefault(i => i.issue_id == issueId);
                if (result != null)
                {
                    result.issue_ongoing = status;
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
