using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userControl11.Visible = false;
            fileControl1.Visible = false;
            numberTextBox1.Visible = true;
            button1.Visible = false;

        }

        private void задание1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.Visible = false;
            fileControl1.Visible = false;
            numberTextBox1.Visible = true;
            button1.Visible = false;

        }

        private void задание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.Visible = false;
            fileControl1.Visible = true;
            numberTextBox1.Visible = false;
            button1.Visible = false;
        }

        private void задание3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl11.Visible = true;
            fileControl1.Visible = false;
            numberTextBox1.Visible = false;
            button1.Visible = true;
        }

        private void userControl11_CurrentColorChanged(object sender, EventArgs e)
        {
            button1.BackColor = userControl11.Color;
        }
    }
}
