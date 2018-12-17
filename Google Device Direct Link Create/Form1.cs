using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Google_Device_Direct_Link_Create
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text.Contains("d/"))
            {
                textBox2.Text = "uc?export=download&";
            }
           
            string str = textBox1.Text;
            using(StringReader sReader = new StringReader(str))
            {
                string line;
                string endline;
                while (sReader.Peek() != -1)
                {
                    line = sReader.ReadLine();
                    endline = sReader.ReadLine();
                    if(line !=" ")
                    {
                        string dd = line;
                        string enddd = endline;
                        dd = dd.Substring(dd.IndexOf("d/")+2);
                        textfirstlink = "https://drive.google.com/uc?export=download&id=" + dd;
                        string test = textfirstlink;
                        test = test.Remove(test.Length -17);
                        textBox2.Text = test;
                       
                    }
                }
            }
          
        }
        string textfirstlink;
     
    }
}
