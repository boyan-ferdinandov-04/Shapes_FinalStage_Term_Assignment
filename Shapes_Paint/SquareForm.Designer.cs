namespace Shapes_Paint
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            height_box = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(92, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(262, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(92, 209);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(262, 23);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 24);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Square";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 122);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 4;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 154);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 5;
            label3.Text = "Y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 212);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "Area";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 183);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 8;
            label5.Text = "Height";
            // 
            // height_box
            // 
            height_box.Location = new Point(92, 180);
            height_box.Name = "height_box";
            height_box.Size = new Size(262, 23);
            height_box.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 481);
            Controls.Add(label5);
            Controls.Add(height_box);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Square Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox height_box;
    }
}