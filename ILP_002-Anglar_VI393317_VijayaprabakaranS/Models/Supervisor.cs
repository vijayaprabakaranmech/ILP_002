﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ILP_002_Anglar_VI393317_VijayaprabakaranS.Models
{
    public class Supervisor
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String EmailID { get; set; }
        public String Position { get; set; }
        public String Location { get; set; }

        List<Employee> employees;
    }
}