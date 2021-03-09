using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class RGBTextControl : TextBox
    {

        public string ColorNumber = "0";

        public RGBTextControl()
        {
            InitializeComponent();
            Text = "0";
        }

        public RGBTextControl(IContainer container)
        {
            container.Add(this);
            Text = "0";
            InitializeComponent();
        }

        //параметры при изменении текста
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            int colorNumber = 0;
            if (_notation == NotationType.Dec)
            {         
                    int.TryParse(Text, out colorNumber);

                    if (colorNumber > 255)
                    {
                        Text = "255";
                        ColorNumber = "255";
                    }                           
            }
            if (colorNumber == 0 && Text.Length == 0)
            {
                Text = "0";
                ColorNumber = "0";
            }
            ColorNumber = Text;
        }
       

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (_notation)
            {
                case NotationType.Dec:
                    if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                        e.Handled = true;

                    return;

                case NotationType.Hex:
                    if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                        if (!((e.KeyChar >= 'a') && (e.KeyChar <= 'f')))
                        {
                            e.Handled = true;
                        }
                        if (Char.IsLower(e.KeyChar))
                                e.KeyChar = char.ToUpper(e.KeyChar);  
                    return;
            }
            

            base.OnKeyPress(e);
        }
       


        public enum NotationType
        {
            Dec, Hex
        }
        private NotationType _notation = NotationType.Hex;
        public NotationType Notation
        {
            get { return _notation; }
            set
            {
                _notation = value;
                if (_notation == NotationType.Dec)
                {
                    MaxLength = 3;
                }
                else
                {
                    MaxLength = 2;
                }
            }
        }
        
    }
}
