using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace 字串處理
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();

            for (int i = 1; i <= 2; i++ )
            {
                StreamReader sr = new StreamReader("in" + i + ".txt");
                string line = sr.ReadToEnd();
                sr.Close();
                y(line);
                if (i == 1)
                {
                    System.IO.StreamWriter file = new System.IO.StreamWriter(Application.StartupPath + "\\out.txt", true);
                    file.WriteLine("\r\n");
                    file.Close();
                }
            }

            this.Close();
        }
        private void y(string filereader)
        {
           
            filereader = filereader.Replace("\r\n", "\\");
            string[] data = filereader.Split('\\');

            for (int i = 1; i <= Convert.ToInt64(data[0]);i++)
            {
                string ans = "";

                for (int j = 0; j <= data[i].Length-1; j++)
                {
                    string str = data[i].Substring(j,1);
                    
                    switch (str)
                    {
                        case "0":
                        case "1":
                        case "2":
                        case "3":
                        case "4":
                        case "5":
                        case "6":
                        case "7":
                        case "8":
                        case "9":
                            ans = ans + str;
                            break;
                    }

                    
                }

                System.IO.StreamWriter file = new System.IO.StreamWriter(Application.StartupPath + "\\out.txt", true);

                if (ans == "")
                {
                    file.WriteLine("N");
                }
                else
                {
                    file.WriteLine(ans);
                }
                
                file.Close();
           
            }
        }
    }
}
