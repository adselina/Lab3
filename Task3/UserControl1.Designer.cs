namespace Task3
{
    partial class UserControl1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dec_button = new System.Windows.Forms.RadioButton();
            this.Hex_button = new System.Windows.Forms.RadioButton();
            this.currentColorControl1 = new Task3.CurrentColorControl(this.components);
            this.Blue_TextBox = new Task3.RGBTextControl(this.components);
            this.Green_TextBox = new Task3.RGBTextControl(this.components);
            this.Red_TextBox = new Task3.RGBTextControl(this.components);
            this.currentColorControl2 = new Task3.CurrentColorControl(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Красный";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Зеленый";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Синий";
            // 
            // Dec_button
            // 
            this.Dec_button.AutoSize = true;
            this.Dec_button.Checked = true;
            this.Dec_button.Location = new System.Drawing.Point(54, 159);
            this.Dec_button.Name = "Dec_button";
            this.Dec_button.Size = new System.Drawing.Size(63, 24);
            this.Dec_button.TabIndex = 4;
            this.Dec_button.TabStop = true;
            this.Dec_button.Text = "Dec";
            this.Dec_button.UseVisualStyleBackColor = true;
            this.Dec_button.CheckedChanged += new System.EventHandler(this.Dec_CheckedChanged);
            // 
            // Hex_button
            // 
            this.Hex_button.AutoSize = true;
            this.Hex_button.Location = new System.Drawing.Point(144, 159);
            this.Hex_button.Name = "Hex_button";
            this.Hex_button.Size = new System.Drawing.Size(62, 24);
            this.Hex_button.TabIndex = 4;
            this.Hex_button.TabStop = true;
            this.Hex_button.Text = "Hex";
            this.Hex_button.UseVisualStyleBackColor = true;
            this.Hex_button.CheckedChanged += new System.EventHandler(this.Hex_button_CheckedChanged);
            // 
            // currentColorControl1
            // 
            this.currentColorControl1.BackColor = System.Drawing.Color.Black;
            this.currentColorControl1.Color = System.Drawing.Color.Empty;
            this.currentColorControl1.Location = new System.Drawing.Point(291, 17);
            this.currentColorControl1.Name = "currentColorControl1";
            this.currentColorControl1.Size = new System.Drawing.Size(175, 175);
            this.currentColorControl1.TabIndex = 5;
            this.currentColorControl1.Text = "currentColorControl1";
            // 
            // Blue_TextBox
            // 
            this.Blue_TextBox.Location = new System.Drawing.Point(128, 113);
            this.Blue_TextBox.MaxLength = 2;
            this.Blue_TextBox.Name = "Blue_TextBox";
            this.Blue_TextBox.Notation = Task3.RGBTextControl.NotationType.Hex;
            this.Blue_TextBox.Size = new System.Drawing.Size(100, 26);
            this.Blue_TextBox.TabIndex = 1;
            this.Blue_TextBox.Text = "0";
            this.Blue_TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
            // 
            // Green_TextBox
            // 
            this.Green_TextBox.Location = new System.Drawing.Point(128, 70);
            this.Green_TextBox.MaxLength = 2;
            this.Green_TextBox.Name = "Green_TextBox";
            this.Green_TextBox.Notation = Task3.RGBTextControl.NotationType.Hex;
            this.Green_TextBox.Size = new System.Drawing.Size(100, 26);
            this.Green_TextBox.TabIndex = 1;
            this.Green_TextBox.Text = "0";
            this.Green_TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
            // 
            // Red_TextBox
            // 
            this.Red_TextBox.Location = new System.Drawing.Point(128, 29);
            this.Red_TextBox.MaxLength = 2;
            this.Red_TextBox.Name = "Red_TextBox";
            this.Red_TextBox.Notation = Task3.RGBTextControl.NotationType.Hex;
            this.Red_TextBox.Size = new System.Drawing.Size(100, 26);
            this.Red_TextBox.TabIndex = 0;
            this.Red_TextBox.Text = "0";
            this.Red_TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
            // 
            // currentColorControl2
            // 
            this.currentColorControl2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currentColorControl2.Color = System.Drawing.Color.Empty;
            this.currentColorControl2.Location = new System.Drawing.Point(290, 15);
            this.currentColorControl2.Name = "currentColorControl2";
            this.currentColorControl2.Size = new System.Drawing.Size(179, 179);
            this.currentColorControl2.TabIndex = 5;
            this.currentColorControl2.Text = "currentColorControl1";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.currentColorControl1);
            this.Controls.Add(this.Hex_button);
            this.Controls.Add(this.Dec_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Blue_TextBox);
            this.Controls.Add(this.Green_TextBox);
            this.Controls.Add(this.Red_TextBox);
            this.Controls.Add(this.currentColorControl2);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(515, 219);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RGBTextControl Red_TextBox;
        private RGBTextControl Green_TextBox;
        private RGBTextControl Blue_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Dec_button;
        private System.Windows.Forms.RadioButton Hex_button;
        private CurrentColorControl currentColorControl1;
        private CurrentColorControl currentColorControl2;
    }
}
