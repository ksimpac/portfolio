using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Test
{
    class Student
    {
        // 屬性
        public int StudentID;
        public string Name;
        public string Grade;

        // 方法
        public string Say()
        {
            if (Grade == "我已經畢業了")
            {
                return "我叫" + Name + " " + Grade;
            }
            else
            {
                return "我的學號是" + StudentID + " 我叫" + Name + ",我目前是 " + Grade + " 的學生";
            }
        }

        public void upgrade()
        {
            switch (Grade)
            {
                case "高三":
                    Grade = "我已經畢業了";
                    break;
                case "高二":
                    Grade = "高三";
                    break;
                case "高一":
                    Grade = "高二";
                    break;
            }

         }

        public string talk(Student s)
        {
            return Grade + "的" + Name + "對" + s.Grade + "的"+ s.Name + "說您~是~笨~蛋~";
        }

      }
}
