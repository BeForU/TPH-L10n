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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string[] textData;
        string[] tempStringArray;
        string tempString;

        int column;
        string title;
        string korean;
        string chinese;

        public Form1()
        {
            InitializeComponent();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            textData = File.ReadAllLines("I2Languages.txt");

            for (int i = 0; i < textData.Length; i++)
            {
                if (textData[i].StartsWith("    ["))
                {
                    column = int.Parse(textData[i].Split('[', ']')[1]);
                }

                else if (textData[i].Contains("1 string Description"))
                {
                    tempStringArray = textData[i].Split('"');

                    if (tempStringArray.Length > 1)
                    {
                        title = tempStringArray[1];
                    }
                }

                else if (textData[i].StartsWith("        [0]"))
                {
                    if (textData[i + 1].Contains("1 string data"))
                    {
                        tempStringArray = textData[i + 1].Split('"');

                        if (tempStringArray.Length > 1)
                        {
                            for (int j = 0; j < tempStringArray.Length; j++)
                            {

                            }
                            korean = tempStringArray[1];
                        }
                    }
                }

                else if (textData[i].StartsWith("        [8]"))
                {
                    if (textData[i + 1].Contains("1 string data"))
                    {
                        tempStringArray = textData[i + 1].Split('"');

                        if (tempStringArray.Length > 1)
                        {
                            chinese = tempStringArray[1];
                        }

                        dataGridView1.Rows.Add(column, title, korean, chinese, i);
                    }
                }
            }
        }
    }
}
