using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class CircleControl : Control
    {
        private Color color;

        public CircleControl()
        {
            InitializeComponent();
        }

        public Color Color { get => color;  set { color = value;
                Invalidate();
            } }

        public CircleControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.FillEllipse(new SolidBrush(Color), ClientRectangle);
        }
    }
}
