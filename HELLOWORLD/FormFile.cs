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
    public partial class FormFile : Form
    {
        public FormFile()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileRecord fr = new FileRecord();
            string strRead = textBoxRead.Text;
            char c;
            int a=0;
            if(strRead.Length<3&& strRead.Length>0)
            {
                for (int i = strRead.Length - 1; i >= 0; i--)
                {
                    c = strRead[i];
                    a += (int)(c - '0') * (int)Math.Pow(10, strRead.Length-i-1);
                }
                string str = "输入的数字（字符串转数字）=" + a;
                str+="\r\n文件内容："+fr.ReadTXT(Application.StartupPath+"\\file\\ReadText.txt",a);
                textBoxShow.Text = str;
            }
            else
            {
                MessageBox.Show("文件位置非法!\r\n请重新输入", "错误");
            }
        }
    }
}
