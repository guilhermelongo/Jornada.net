using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevJobs.API.Entities
{
    public class JobApplication
    {
        public JobApplication(string applicationName, string applicationEmail, int idjobVacancy)
        {
            ApplicationName = applicationName;
            ApplicationEmail = applicationEmail;
            IdjobVacancy = idjobVacancy;
        }

        public int Id {get; private set;}
        
        public string ApplicationName { get; private set; }

        public string ApplicationEmail { get; private set; }

        public int IdjobVacancy { get; private set; }
        
        
        
               
        
    }
}