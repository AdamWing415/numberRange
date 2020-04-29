using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace numberRange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            outputLabel.ResetText();
            try
            {
                int num1 = Convert.ToInt16(startInput.Text);
                int num2 = Convert.ToInt16(endInput.Text);


                if (num1 < num2)
                {
                    for (int i = num1 + 1; i < num2; i++)
                    {
                        outputLabel.Text = $"{outputLabel.Text} {i},";
                        Refresh();
                    }
                }
                else if (num2 < num1)
                {
                    for (int i = num2 + 1; i < num1; i++)
                    {
                        outputLabel.Text = $"{outputLabel.Text} {i},";
                        Refresh();
                    }
                }
            }
            catch
            {
                outputLabel.Text = "please input valid numerical values";
                Refresh();
            }
        }
    }
}
