using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class UserControl1: UserControl
    {
        int Red = 0;
        int Green = 0;
        int Blue = 0;

        public event EventHandler CurrentColorChanged;
       
        protected void OnCurrentColorChanged()
        {
            if (CurrentColorChanged != null)
                CurrentColorChanged(this, new EventArgs());
        }

        private Color color;
        public Color Color
        {
            get => color; 
            set
            {
                color = value;
                OnCurrentColorChanged();
                
            }
        }

        public UserControl1()
        {
            InitializeComponent();
            Dec_Checked();
        }

        private void Dec_CheckedChanged(object sender, EventArgs e)
        {
            Dec_Checked();
        }
        private void Dec_Checked()
        {
            if (Dec_button.Checked == true)
                Hex_button.Checked = false;
            else
            {
                FromDecToHex();
            }
            Red_TextBox.Notation = RGBTextControl.NotationType.Dec;
            Green_TextBox.Notation = RGBTextControl.NotationType.Dec;
            Blue_TextBox.Notation = RGBTextControl.NotationType.Dec;
        }

        private void Hex_button_CheckedChanged(object sender, EventArgs e)
        {
            Hex_Checked();
        }
        private void Hex_Checked()
        {
            if (Hex_button.Checked == true)
                Dec_button.Checked = false;
            else
            {
                FromHexToDec();
            }
            Red_TextBox.Notation = RGBTextControl.NotationType.Hex;
            Green_TextBox.Notation = RGBTextControl.NotationType.Hex;
            Blue_TextBox.Notation = RGBTextControl.NotationType.Hex;
        }


        
        private void FromDecToHex()
        {
            Red_TextBox.Text = Red.ToString("X");
            Green_TextBox.Text = Green.ToString("X");
            Blue_TextBox.Text = Blue.ToString("X");
        }
        private void FromHexToDec()
        {
            Red_TextBox.Text = Convert.ToInt32(Red_TextBox.Text, 16).ToString();
            Green_TextBox.Text = Convert.ToInt32(Green_TextBox.Text, 16).ToString();
            Blue_TextBox.Text = Convert.ToInt32(Blue_TextBox.Text, 16).ToString();
        }

        
        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (Dec_button.Checked == true)
            {
                Red = Convert.ToInt32(Red_TextBox.ColorNumber);
                Green = Convert.ToInt32(Green_TextBox.ColorNumber);
                Blue = Convert.ToInt32(Blue_TextBox.ColorNumber);
                currentColorControl1.Color = Color.FromArgb(Red, Green, Blue);
                Color = currentColorControl1.Color;
            }
            else
            {
                Red = Convert.ToInt32(Red_TextBox.Text, 16);
                Green = Convert.ToInt32(Green_TextBox.Text, 16);
                Blue = Convert.ToInt32(Blue_TextBox.Text, 16);
                currentColorControl1.Color = Color.FromArgb(Red, Green, Blue);
                Color = currentColorControl1.Color;
            }
        }

        
    }
}
