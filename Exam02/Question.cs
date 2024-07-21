using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    internal class Question :Answer
    {
        public string[]? Header { get; set; }
        public string[]? Body  { get; set; }
        public int[] Mark { get; set; }



       
        //public int[] Answers { get; set; }
        //public int RightAnswer { get; set; }



    }
}
