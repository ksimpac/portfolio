using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();

            s.Name = "水母";
            s.StudentID = 213131;
            s.Grade = "高三" ;

            Student s2 = new Student();

            s2.Name = "派大星";
            s2.StudentID = 312115;
            s2.Grade = "高二";
       

            MessageBox.Show(s.talk(s2));
           
        }
    }
}
