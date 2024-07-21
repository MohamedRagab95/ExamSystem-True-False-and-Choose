using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class Exam
    {
        public DateTime Time { get; set; }
        public int NumOfQuestions { get; set; }

        //Show Exam();
        // if exam is final\

       int TypeOfQuestion;

        public void CreateExam()
        {
            do
            {
                Console.Write($"Please Enter The Type Of Exam You Want To Create ( 1 for Practical and 2 for Final): ");
            } while (!int.TryParse(Console.ReadLine(), out TypeOfQuestion) || (TypeOfQuestion != 1 && TypeOfQuestion != 2));



            if (TypeOfQuestion == 1)
            {
                PracticalExam practical = new PracticalExam();
                practical.CreatePracticalExam();
                practical.ShowExam();


            }


            else if (TypeOfQuestion == 2) 
            {
                FinalExam finalExam = new FinalExam();
                finalExam.CreateFinalExam();
                finalExam.ShowExam();
            }

        }


       



    }
}
