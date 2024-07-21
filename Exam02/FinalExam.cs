using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class FinalExam : Exam
    {
                int QType;
         Question question1 = new TrueOrFalse();
          Question question2 = new MCQ();
        int Grade;
        Exam finalExam = new Exam();

        public void CreateFinalExam()
        {


            Exam final = new FinalExam();
            Console.Write($"Please Enter Time OF Exam In Minutes: ");

            if (DateTime.TryParse(Console.ReadLine(), out DateTime dateTime))
            {
                final.Time = dateTime;
                int minute = final.Time.Minute;
            }

            Console.Write($"Please Enter Number Of Questions You Wanted To Create: ");

            if (int.TryParse(Console.ReadLine(), out int num))
            {
                final.NumOfQuestions = num;
            }


            Console.Clear();

            for (int i = 0; i < final.NumOfQuestions; i++)
            {
                Console.Clear();
                do 
                { 
                Console.WriteLine($"Please Choose The Type Of Question Number{i + 1} (1:For True Or False, 2: For MCQ) ");
                }   while(!int.TryParse(Console.ReadLine(), out  QType) || (QType != 1 && QType != 2));

                Console.Clear();

                if (QType == 1)
                {

                    question1.Body  =new string[final.NumOfQuestions];
                    question1.Mark  =new int[final.NumOfQuestions];
                    question1.AnswerId  =new int[final.NumOfQuestions];


                    Console.Write("True | False Question ");

                    Console.Write($"Please Enter The Body Of The Question : ");
                    question1.Body[i] =  Console.ReadLine()??string.Empty;

                    Console.Write($"Please Enter The Marks Of The Question : ");
                    int.TryParse(Console.ReadLine(), out int mark);
                    question1.Mark[i] = mark;

                    Console.Write("Please Enter The Right Answer Of The Question (1 For True and 2 For False ) : " );
                    int.TryParse(Console.ReadLine(), out int right);
                    question1.AnswerId[i] = right;

                }

                else if (QType == 2)
                {
                    question2.Body = new string[final.NumOfQuestions];
                    question2.Mark = new int[final.NumOfQuestions];
                    question2.AnswerId = new int[final.NumOfQuestions];

                    Console.WriteLine("MCQ Question ");

                    Console.Write($"Please Enter The Body Of The Question: ");
                    question2.Body[i] = Console.ReadLine() ?? string.Empty;

                    Console.Write($"Please Enter The Marks Of The Question: ");
                    int.TryParse(Console.ReadLine(), out int mark);
                    question2.Mark[i] = mark;


                    Console.WriteLine("The Choices Of Question : ");
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

                }

                finalExam = final;
            }


        }

        // in case MCQ
        public void ShowExam()
        {   
            for (int i = 0; i < finalExam.NumOfQuestions; i++)
            {
                if (QType == 1)
                {
                    Console.WriteLine($"Choose One Answer     Mark({question1.Mark[i]})");
                    Console.WriteLine($" {question1.Body[i]}");
                    Console.WriteLine($"1){question1.AnswerText[0]}  2){question1.AnswerText[1]}  3){question1.AnswerText[2]}  4){question1.AnswerText[3]}");
                    Console.WriteLine("---------------------------------");

                    int.TryParse(Console.ReadLine(), out int answered);

                    if (answered == question1.AnswerId[i])
                    {
                        Grade += question1.Mark[i];
                    }

                }

                else if (QType == 2)
                { 
                  Console.WriteLine($"Choose One Answer     Mark({question2.Mark[i]})");
                  Console.WriteLine($" {question2.Body[i]}");
                  Console.WriteLine($"1){question2.AnswerText[0]}  2){question2.AnswerText[1]}  3){question2.AnswerText[2]}  4){question2.AnswerText[3]}");
                  Console.WriteLine("---------------------------------");
                  
                  int.TryParse(Console.ReadLine(), out int answered);
                  
                  if (answered == question2.AnswerId[i])
                  {
                      Grade += question2.Mark[i];
                  }

                }



            }
            Console.WriteLine($"Your Grade is {Grade}");

        }

    }
}
