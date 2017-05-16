using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HELLOWORLD
{
    public class FileRecord
    {
        //文件操作类，用以读取或写入文件
        /// <summary>
        /// 传入文件路径和文本内容，写入文件
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="text"></param>
        public void WriteTXT(string FileName, string text)
        {
            //创建一个文件流，用以写入或创建一个StreamWriter
            FileStream fsW = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fsW);
            sw.Flush();//清理当前缓冲区
            sw.BaseStream.Seek(0, SeekOrigin.Begin);//从文件开头写入
            sw.Write(text);//把text写入文件
            sw.Flush();
            sw.Close();
        }

        /// <summary>
        /// 从文件路径的文件中第m个位置开始读取该行字符串
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public string ReadTXT(string FileName, int m)
        {
            try
            {
                string result;
                FileStream fsR = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fsR);
                sr.BaseStream.Seek(m, SeekOrigin.Begin);//从文件m处开始读入
                result = sr.ReadLine();//读行
                sr.Close();
                return result;
            }
            catch(Exception ex)
            {
                string error;
                error = ex.ToString();
                return error;
            }
        }

    }
}
