using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class PracticalExam :Exam
    {
        int Grade;
        Exam practicalExam = new Exam();
        //Question questionforshow = new MCQ();
                Question question2 = new MCQ();
        public void CreatePracticalExam()
        {
            Exam practical = new PracticalExam();

            Console.Write($"Please Enter Time OF Exam In Minutes: ");

            if (DateTime.TryParse(Console.ReadLine(), out DateTime dateTime))
            {
                practical.Time = dateTime;
                int minute = practical.Time.Minute;
            }

            Console.Write($"Please Enter Number Of Questions You Wanted To Create: ");

            if (int.TryParse(Console.ReadLine(), out int num))
            {
                practical.NumOfQuestions = num;
            }

            Console.Clear();

                question2.Body = new string[practical.NumOfQuestions];
                question2.Mark = new int[practical.NumOfQuestions];
                question2.AnswerId = new int[practical.NumOfQuestions];
            for (int i = 0; i < practical.NumOfQuestions; i++)
            {



                Console.Write($"Please Enter The Body Of The Question Number {i + 1} : ");
                question2.Body[i] = Console.ReadLine() ?? string.Empty;

                Console.Write($"Please Enter The Marks Of The Question {i + 1} : ");
                int.TryParse(Console.ReadLine(), out int mark);
                question2.Mark[i] = mark;



                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Please Enter The Choice Number {j + 1} : ");

                    question2.AnswerText[j] = Console.ReadLine() ?? string.Empty;

                }
                int right;

                do
                {
                    Console.WriteLine($"Please Enter The Right Choice Of The Question {i + 1} (from 1 to 4) :  ");
                } while (!int.TryParse(Console.ReadLine(), out right) || !(right >= 1 && right <= 4));
                question2.AnswerId[i] = right;


                 practicalExam = practical;
              
                //questionforshow = question2;

                Console.Clear();
            }
        }

        public void ShowExam()
        {
            for (int i = 0; i < practicalExam.NumOfQuestions; i++)
            {
                Console.WriteLine($"Choose One Answer     Mark({question2.Mark[i]})");
                Console.WriteLine($" {question2.Body[i] }");
                Console.WriteLine($"1){question2.AnswerText[0]}  2){question2.AnswerText[1]}  3){question2.AnswerText[2]}  4){question2.AnswerText[3]}");
                Console.WriteLine("---------------------------------");

                int.TryParse(Console.ReadLine(), out int answered);

                if (answered == question2.AnswerId[i])
                {
                    Grade += question2.Mark[i];
                }


            }
            Console.WriteLine($"Your Grade is {Grade}");

        }







    }
}
