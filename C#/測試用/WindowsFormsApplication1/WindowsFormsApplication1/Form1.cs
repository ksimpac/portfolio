using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Train_Schedule Search = new Train_Schedule("竹南","沙鹿");

            foreach (Train Train_Data in Train_Schedule.Train_data_list)
            {
                dataGridView1.Rows.Add(new Object[] {Train_Data.TrainType, Train_Data.TrainNum , Train_Data.Line, Train_Data.Departure,
                Train_Data.Destination, Train_Data.DepTime, Train_Data.ArrTime, Train_Data.Note});
            }

            dataGridView1.AutoResizeColumns();
            dataGridView1.Sort(開車時間, System.ComponentModel.ListSortDirection.Ascending);
        }

        
    }
}
