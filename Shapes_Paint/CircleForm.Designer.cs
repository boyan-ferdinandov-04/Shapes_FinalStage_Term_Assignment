namespace Shapes_Paint
{
    partial class CircleForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CircleForm));
            label1 = new Label();
            label2 = new Label();
            textBoxX = new TextBox();
            textBoxY = new TextBox();
            label3 = new Label();
            textBoxHeight = new TextBox();
            label4 = new Label();
            textBoxWidth = new TextBox();
            label5 = new Label();
            textBoxArea = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 54);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Circle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 110);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 1;
            label2.Text = "X";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(162, 107);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(100, 23);
            textBoxX.TabIndex = 2;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(162, 140);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(100, 23);
            textBoxY.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 143);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 3;
            label3.Text = "Y";
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(162, 174);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(100, 23);
            textBoxHeight.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 177);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 5;
            label4.Text = "Height";
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(162, 203);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(100, 23);
            textBoxWidth.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(106, 206);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 7;
            label5.Text = "Width";
            // 
            // textBoxArea
            // 
            textBoxArea.Location = new Point(162, 232);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(100, 23);
            textBoxArea.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(106, 235);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 9;
            label6.Text = "Area";
            // 
            // CircleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 481);
            Controls.Add(textBoxArea);
            Controls.Add(label6);
            Controls.Add(textBoxWidth);
            Controls.Add(label5);
            Controls.Add(textBoxHeight);
            Controls.Add(label4);
            Controls.Add(textBoxY);
            Controls.Add(label3);
            Controls.Add(textBoxX);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CircleForm";
            Text = "Circle Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxX;
        private TextBox textBoxY;
        private Label label3;
        private TextBox textBoxHeight;
        private Label label4;
        private TextBox textBoxWidth;
        private Label label5;
        private TextBox textBoxArea;
        private Label label6;
    }
}