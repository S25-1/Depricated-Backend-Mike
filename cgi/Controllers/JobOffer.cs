using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cgi.Controllers
{
    public class JobOffer
    {
        public int JobOfferID { get; set; }
        public Employer JobOfferOwner { get; set; }
        public string Name { get; set; }
        public string RequiredJob { get; set; }
        public List<SkillType> ReqCompetence { get; set; }
        public string Description { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        //public List<User> ListUserAccepted { get; set; }
        //public List<User> ListUserOffered { get; set; }

        public JobOffer(Employer employer, string name, string requiredJob, List<SkillType> reqCompetence, string description, DateTime dateBegin, DateTime dateEnd)
        {
            JobOfferID = -1;
            JobOfferOwner = employer;
            Name = name;
            RequiredJob = requiredJob;
            ReqCompetence = ReqCompetence;
            Description = description;
            DateBegin = dateBegin;
            DateEnd = dateEnd;
        }

        public void AddJobOffer()
        {
            
        }
    }
}
