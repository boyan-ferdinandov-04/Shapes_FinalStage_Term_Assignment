namespace Shapes_Paint
{
    partial class RectangleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectangleForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            width_box = new TextBox();
            height_box = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 27);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Rectangle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 104);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 1;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 138);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 2;
            label3.Text = "Y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 216);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "Area";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(131, 213);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(207, 23);
            textBox3.TabIndex = 6;
            // 
            // width_box
            // 
            width_box.Location = new Point(131, 188);
            width_box.Name = "width_box";
            width_box.Size = new Size(207, 23);
            width_box.TabIndex = 10;
            // 
            // height_box
            // 
            height_box.Location = new Point(131, 159);
            height_box.Name = "height_box";
            height_box.Size = new Size(207, 23);
            height_box.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 191);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 8;
            label5.Text = "Width";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 162);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 7;
            label6.Text = "Height";
            // 
            // RectangleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 481);
            Controls.Add(width_box);
            Controls.Add(height_box);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RectangleForm";
            Text = "Rectangle Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox width_box;
        private TextBox height_box;
        private Label label5;
        private Label label6;
    }
}