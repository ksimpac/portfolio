using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 收銀機
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            thousand.ReadOnly = five_hundred.ReadOnly = one_hundred.ReadOnly = fifty.ReadOnly = ten.ReadOnly = one.ReadOnly = true;
        }

        public enum Cash : int
        {
            thousand = 1000,
            five_hundred = 500,
            one_hundred = 100,
            fifty = 50,
            ten = 10,
            one = 1,
        }

        private void give_change_Click(object sender, EventArgs e)
        {
            ulong price = 0;
            ulong money = 0;
            ulong total = 0;

            if (Money.Text.IndexOf("-", 0) != -1 || Total.Text.IndexOf("-", 0) != -1) /* 如果裡面有負號的話 */
            {
                MessageBox.Show("兩個金額都請輸入正數");

                if (Money.Text.IndexOf("-", 0) != -1)
                {
                    Money.Text = "";
                }
                else
                {
                    Total.Text = "";
                }
            }
            else
            {

                money = Convert.ToUInt64(Money.Text);
                total = Convert.ToUInt64(Total.Text);

                if (money < total)
                {
                    ulong left = 0;
                    left = total - money;
                    MessageBox.Show("付款金額不夠喲! " + "還少 " + left + " 元");
                }
                else
                {
                    price = money - total;

                    thousand.Text = (price / ((int)Cash.thousand)).ToString();
                    price -= 1000 * (price / (int)Cash.thousand);

                    five_hundred.Text = (price / ((int)Cash.five_hundred)).ToString();
                    price -= 500 * (price / (int)Cash.five_hundred);

                    one_hundred.Text = (price / ((int)Cash.one_hundred)).ToString();
                    price -= 100 * (price / (int)Cash.one_hundred);

                    fifty.Text = (price / ((int)Cash.fifty)).ToString();
                    price -= 50 * (price / (int)Cash.fifty);

                    ten.Text = (price / ((int)Cash.ten)).ToString();
                    price -= 10 * (price / (int)Cash.ten);

                    one.Text = price.ToString();
                }

            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Money.Text = Total.Text = thousand.Text = five_hundred.Text = one_hundred.Text = fifty.Text = ten.Text = one.Text = "";
        }
    }
}
