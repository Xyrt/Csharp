using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whow_does_it_work_question_
{
    class PointClass
    {
        private int x;
        private int y;

        public PointClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        public override string ToString()
        {
            return String.Format("x = {0}, y = {1}", x, y);
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }
    }
}
