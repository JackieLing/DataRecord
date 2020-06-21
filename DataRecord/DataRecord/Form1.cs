using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataRecord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //首先创建流写入器对象
            StreamWriter sw = new StreamWriter(@"d:\Data\日志.txt", true);
            sw.WriteLine(DateTime.Now.ToString());
            sw.WriteLine(txtSource.Text);
            sw.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //创建流读取器对象
            StreamReader sr = new StreamReader(@"d:\Data\日志.txt");
            txtShow.Text = sr.ReadToEnd();//读取文件中的内容
            sr.Close();
        }
    }
}
