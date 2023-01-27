using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Area.SelectedIndexChanged += new System.EventHandler(Area_SelectedIndexChanged);
        }

        List<List<string>> Area_List = new List<List<string>>();
        List<string> Station_List = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            System.IO.StreamReader file = new System.IO.StreamReader("./ComboBox.txt", Encoding.UTF8);
            string line = "";

            while ((line = file.ReadLine()) != null && (line = file.ReadLine()) != "")
            {
                Char delimiter = '\n';
                string[] data = line.Split(delimiter);

                if (data[0] != "")
                {
                    Area.Items.Add(data[0]);

                    while (line != "" || line.Substring(0, 1) == "\t")
                    {
                        line = file.ReadLine();
                        if (line == null || line == "") break;
                        delimiter = '\t';
                        data = line.Split(delimiter);
                        Station_List.Add(data[1]);
                    }

                    Area_List.Add(Station_List);
                    Station_List = new List<string>();
                }
                
            }

            Area.SelectedIndex = 0;
        }
        private void Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            Station.Items.Clear();

            int i = return_area_num(Area.Text);

            for (int j = 0; j <= Area_List[i].Count - 1; j++)
            {
                Station.Items.Add(Area_List[i][j]);
            }
            Station.SelectedIndex = 0;
        }

        private int return_area_num(string search)
        {
            int result = 0;

            switch (Area.Text)
            {
                case "臺北/基隆地區":
                    result = 0;
                    break;
                case "桃園地區":
                    result = 1;
                    break;
                case "新竹地區":
                    result = 2;
                    break;
                case "苗栗地區":
                    result = 3;
                    break;
                case "臺中地區":
                    result = 4;
                    break;
                case "彰化地區":
                    result = 5;
                    break;
                case "雲林地區":
                    result = 6;
                    break;
                case "嘉義地區":
                    result = 7;
                    break;
                case "臺南地區":
                    result = 8;
                    break;
                case "高雄地區":
                    result = 9;
                    break;
                case "屏東地區":
                    result = 10;
                    break;
                case "臺東地區":
                    result = 11;
                    break;
                case "花蓮地區":
                    result = 12;
                    break;
                case "宜蘭地區":
                    result = 13;
                    break;
                case "平溪/深澳線":
                    result = 14;
                    break;
                case "內灣/六家線":
                    result = 15;
                    break;
                case "集集線":
                    result = 16;
                    break;
                case "沙崙線":
                    result = 17;
                    break;
            }

            return result;
        }
    }
}
