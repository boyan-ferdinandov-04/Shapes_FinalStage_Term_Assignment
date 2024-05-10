namespace Shapes_Paint
{
    partial class TriangleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriangleForm));
            label1 = new Label();
            textBoxC = new TextBox();
            label5 = new Label();
            textBoxArea = new TextBox();
            textBoxB = new TextBox();
            textBoxA = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            side_box = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 54);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Triangle";
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(121, 175);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(207, 23);
            textBoxC.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 178);
            label5.Name = "label5";
            label5.Size = new Size(15, 15);
            label5.TabIndex = 15;
            label5.Text = "C";
            // 
            // textBoxArea
            // 
            textBoxArea.Location = new Point(121, 231);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(207, 23);
            textBoxArea.TabIndex = 14;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(121, 148);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(207, 23);
            textBoxB.TabIndex = 13;
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(121, 113);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(207, 23);
            textBoxA.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 231);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 11;
            label4.Text = "Area";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 148);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 10;
            label3.Text = "B";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 116);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 9;
            label2.Text = "A";
            // 
            // side_box
            // 
            side_box.Location = new Point(121, 202);
            side_box.Name = "side_box";
            side_box.Size = new Size(207, 23);
            side_box.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 202);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 17;
            label6.Text = "Side";
            // 
            // TriangleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 481);
            Controls.Add(side_box);
            Controls.Add(label6);
            Controls.Add(textBoxC);
            Controls.Add(label5);
            Controls.Add(textBoxArea);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TriangleForm";
            Text = "Triangle Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxC;
        private Label label5;
        private TextBox textBoxArea;
        private TextBox textBoxB;
        private TextBox textBoxA;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox side_box;
        private Label label6;
    }
}