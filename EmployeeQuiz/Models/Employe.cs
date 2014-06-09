using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeQuiz.Models
{
    public class Employe
    {
        public string Id {get;set;}
        public string Name{ get; set; }
        public string FirstLastname { get; set; }
        public string SecondLastname { get; set; }
        public string Position { get; set; }
        public double Wage { get; set; }
        public char Sex { get; set; }
        public string PhothoPath { get; set; }
 
    }
}