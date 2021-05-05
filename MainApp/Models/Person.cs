using System;
using System.Collections.Generic;
using System.Text;

namespace MainApp.Models
{
    class Person
    {
        public string FIO { get; set; }
        public int Age { get; set; }
        public List<SubjectAssessmentModel> SubjectAssessment { get; set; }
    }
}
