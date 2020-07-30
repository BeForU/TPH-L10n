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
        public Form1()
        {
            InitializeComponent();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            string[] textData;
            textData = File.ReadAllLines("I2Languages.txt");

            for (int i = 0; i < textData.Length; i++)
            {
                if(textData[i].StartsWith("    ["))
                {

                }
            }
        }
    }
}
