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

        public issue getIssueById(int id)
        {
            using (var dbContext = new Service_Requests_Data_GOVEntities())
            {
                issue iss = dbContext.issues.Where(i => i.issue_id.Equals(id)).FirstOrDefault<issue>();
                return iss;
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

        public void updateIssueData(int issueId, string description, string name, string id, string tel, int issueTypeId)
        {
            using (var dbContext = new Service_Requests_Data_GOVEntities())
            {
                issue isue = dbContext.issues.SingleOrDefault(i => i.issue_id == issueId);
                if (isue != null)
                {
                    isue.issue_description = description;
                    isue.issuer_name = name;
                    isue.issuer_id = id;
                    isue.issuer_tel = tel;
                    isue.issue_type_id = issueTypeId;
                    dbContext.SaveChanges();
                }
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
