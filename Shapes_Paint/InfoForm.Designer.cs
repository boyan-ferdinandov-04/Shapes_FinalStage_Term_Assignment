namespace Shapes_Paint
{
    partial class InfoForm
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
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 74);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Selected Shape Info";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(565, 23);
            textBox1.TabIndex = 1;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 272);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "InfoForm";
            Text = "InfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
    }
}