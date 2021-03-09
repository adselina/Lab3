using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class FileControl : UserControl
    {
        public event EventHandler FileNameChanged;

        public FileControl()
        {
            InitializeComponent();
        }

        public string FileName
        {
            get { return textBox1.Text; }
            set 
            { 
                textBox1.Text = value;
                OnFileNameChanged();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                FileName = d.FileName;
            }
        }

        protected void OnFileNameChanged()
        {
            if (FileNameChanged != null)
                FileNameChanged(this, new EventArgs());
        }
    }
}
