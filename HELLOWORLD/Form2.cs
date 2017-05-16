using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HELLOWORLD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private int makeRandomNumber(int n)//【可复用】每次生成不同随机数，范围0-n。(测试有效，每次调用该函数，结果不同)
        {
            int res;//随机数结果
            Random ran = new Random();
            res = ran.Next(0, n + 1);
            return res;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            labelRandom.Text=labelRandom.Text+" "+makeRandomNumber(10);
        }
    }
}
