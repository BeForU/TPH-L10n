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
        string[] koreanData;

        int column;
        string title;
        string description;
        string english;
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

                else if (textData[i].Contains("1 string Term"))
                {
                    tempStringArray = textData[i].Split('"');

                    if (tempStringArray.Length > 1)
                    {
                        title = tempStringArray[1];
                    }
                }

                else if (textData[i].Contains("1 string Description"))
                {
                    tempStringArray = textData[i].Split('"');

                    if (tempStringArray.Length > 1)
                    {
                        description = tempStringArray[1];
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
                            english = textData[i + 1].Substring(textData[i + 1].IndexOf('"') + 1, textData[i + 1].LastIndexOf('"') - textData[i + 1].IndexOf('"') - 1);
                        }
                    }
                }

                else if (textData[i].StartsWith("        [2]"))
                {
                    if (textData[i + 1].Contains("1 string data"))
                    {
                        tempStringArray = textData[i + 1].Split('"');

                        if (tempStringArray.Length > 1)
                        {
                            chinese = textData[i + 1].Substring(textData[i + 1].IndexOf('"') + 1, textData[i + 1].LastIndexOf('"') - textData[i + 1].IndexOf('"') - 1);
                        }

                        dataGridView1.Rows.Add(column, title, description, english, chinese, i);
                    }
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            int line;
            string[] output = new string[dataGridView1.Rows.Count + 1];

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                line = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);

                if (output[line] == null)
                    output[line] = (string)dataGridView1.Rows[i].Cells[3].Value;
            }

            System.IO.File.WriteAllLines("English.txt", output);
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
