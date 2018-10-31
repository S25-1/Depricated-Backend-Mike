using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cgi.Controllers
{
    public class User
    {
        protected int UserID { get; set; }
        protected string UserType { get; set; }
        //public Branch Branch { get; set; }
        protected string Name { get; set; }
        protected string Email { get; set; }
        protected string Password { get; set; }
        //protected DateTime DateOfBirth { get; set; }
        //protected string PhoneNumber { get; set; }
        //protected float HourlyWage { get; set; }
        //protected Address Address { get; set; }
        protected string Job { get; set; }
        protected List<SkillType> ListCompetences { get; set; }
        //protected List<Availability> Availability { get; set; }

        public User(int userID, string userType, string name, string email, string password, string job, List<SkillType> listCompetences)
        {
            UserID = userID;
            UserType = userType;
            Name = name;
            Email = email;
            Password = password;
            Job = job;
            ListCompetences = listCompetences;
        }
    }
}
