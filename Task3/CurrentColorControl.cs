﻿using System;
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
    public partial class CurrentColorControl : Control
    {
        private Color color;
        public CurrentColorControl()
        {
            InitializeComponent();
        }

        public CurrentColorControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public Color Color
        {
            get => color; set
            {
                color = value;
                Invalidate();
            }
        }

        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.FillRectangle(new SolidBrush(Color), ClientRectangle);
        }
    }
}
