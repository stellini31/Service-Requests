using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Requests.Database
{
    class IssueType_Data
    {

        public IssueType_Data()
        {

        }

        public int getIssueTypeIDbyTitle(string title)
        {
            using (var dbContext = new Service_Requests_Data_GOVEntities())
            {
                var issueType = dbContext.issue_types.Where(i => i.issue_title.Equals(title)).FirstOrDefault<issue_types>();
                return issueType.issue_type_id;
            }
        }

        public issue_types getIssueTypeById(int ID)
        {
            using (var dbContext = new Service_Requests_Data_GOVEntities())
            {
                var issueType = dbContext.issue_types.Where(i => i.issue_type_id.Equals(ID)).FirstOrDefault<issue_types>();
                return issueType;
            }
        }

        public issue_types getIssueTypeByTitle(string title)
        {
            using (var dbContext = new Service_Requests_Data_GOVEntities())
            {
                var issueType = dbContext.issue_types.Where(i => i.issue_title.Equals(title)).FirstOrDefault<issue_types>();
                return issueType;
            }
        }

        public List<issue_types> getAllIssues()
        {
            List<issue_types> issueTypes = new List<issue_types>();
            using (var dbContext = new Service_Requests_Data_GOVEntities())
            {
                foreach (issue_types it in dbContext.issue_types)
                {
                    issueTypes.Add(it);
                }
            }
            return issueTypes;
        }
    }
}
