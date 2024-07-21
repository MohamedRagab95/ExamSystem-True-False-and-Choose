using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class Subject
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Exam? ExamOfSubject { get; set; }


        //create exam 

       public void CreateExamOfSubject()
        {
            ExamOfSubject = new Exam();

            ExamOfSubject.CreateExam(); 
        }


    }
}
