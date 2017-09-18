using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whow_does_it_work_question_
{
    public class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value.Trim(); }
        }
        public string NormalizedName
        {
            get { return name.ToUpper(); }
        }

        //propFull + Tub + Tub = its some kind of magic;
    }
}
