using ILP_002_Anglar_VI393317_VijayaprabakaranS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ILP_002_Anglar_VI393317_VijayaprabakaranS.Data
{
    public class Data
    {
        public static List<Supervisor> GetSupervisors()
        {
            List<Supervisor> supervisors = new List<Supervisor>
            {
                new Supervisor{ Name = "Vijayaprabakaran S", EmailID = "vijay@wipro.com", Position = "L1", Location = "Bengaluru" },
                new Supervisor{ Name = "Sathish Kumar S", EmailID = "sathish@wipro.com", Position = "L1", Location = "Bengaluru" }
            };
            return supervisors;
        }
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{ Name = "E1", EmailID = "e1@wipro.com", Position = "R1", Location = "Bengaluru", Id = 1 },
                new Employee{ Name = "E2", EmailID = "e2@wipro.com", Position = "R2", Location = "Bengaluru", Id = 1 },
                new Employee{ Name = "E3", EmailID = "e3@wipro.com", Position = "R3", Location = "Bengaluru", Id = 1 },
                new Employee{ Name = "E4", EmailID = "e4@wipro.com", Position = "R1", Location = "Bengaluru", Id = 1 },
                new Employee{ Name = "E5", EmailID = "e5@wipro.com", Position = "R2", Location = "Bengaluru", Id = 1 },
                new Employee{ Name = "E6", EmailID = "e6@wipro.com", Position = "R1", Location = "Bengaluru", Id = 2 },
                new Employee{ Name = "E7", EmailID = "e7@wipro.com", Position = "R2", Location = "Bengaluru", Id = 2 },
                new Employee{ Name = "E8", EmailID = "e8@wipro.com", Position = "R3", Location = "Bengaluru", Id = 2 }
            };
            return employees;
        }
        
    }
}