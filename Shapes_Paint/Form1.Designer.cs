namespace Shapes_Paint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            fill_color_button = new Button();
            xml_open = new Button();
            xml_save = new Button();
            open_serialize = new Button();
            save_serialize = new Button();
            circle_area = new Button();
            triangle_area = new Button();
            rectangle_info = new Button();
            redo_button = new Button();
            square_area = new Button();
            circle_button = new Button();
            background_color = new Button();
            color_picker = new PictureBox();
            open_button = new Button();
            undo_button = new Button();
            save_button = new Button();
            clear_button = new Button();
            triangle_button = new Button();
            rectangle_button = new Button();
            square_button = new Button();
            fill_button = new Button();
            colorPicker = new Button();
            currentColor = new PictureBox();
            background = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)color_picker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currentColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)background).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(fill_color_button);
            panel1.Controls.Add(xml_open);
            panel1.Controls.Add(xml_save);
            panel1.Controls.Add(open_serialize);
            panel1.Controls.Add(save_serialize);
            panel1.Controls.Add(circle_area);
            panel1.Controls.Add(triangle_area);
            panel1.Controls.Add(rectangle_info);
            panel1.Controls.Add(redo_button);
            panel1.Controls.Add(square_area);
            panel1.Controls.Add(circle_button);
            panel1.Controls.Add(background_color);
            panel1.Controls.Add(color_picker);
            panel1.Controls.Add(open_button);
            panel1.Controls.Add(undo_button);
            panel1.Controls.Add(save_button);
            panel1.Controls.Add(clear_button);
            panel1.Controls.Add(triangle_button);
            panel1.Controls.Add(rectangle_button);
            panel1.Controls.Add(square_button);
            panel1.Controls.Add(fill_button);
            panel1.Controls.Add(colorPicker);
            panel1.Controls.Add(currentColor);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1433, 144);
            panel1.TabIndex = 0;
            // 
            // fill_color_button
            // 
            fill_color_button.Cursor = Cursors.Hand;
            fill_color_button.FlatStyle = FlatStyle.System;
            fill_color_button.Location = new Point(573, 99);
            fill_color_button.Name = "fill_color_button";
            fill_color_button.Size = new Size(79, 45);
            fill_color_button.TabIndex = 25;
            fill_color_button.Text = "Fill Color Change";
            fill_color_button.TextAlign = ContentAlignment.BottomCenter;
            fill_color_button.UseVisualStyleBackColor = true;
            fill_color_button.Click += fill_color_button_Click;
            // 
            // xml_open
            // 
            xml_open.Location = new Point(1320, 99);
            xml_open.Name = "xml_open";
            xml_open.Size = new Size(75, 38);
            xml_open.TabIndex = 24;
            xml_open.Text = "XML Open";
            xml_open.UseVisualStyleBackColor = true;
            xml_open.Click += xml_open_Click;
            // 
            // xml_save
            // 
            xml_save.Location = new Point(1229, 97);
            xml_save.Name = "xml_save";
            xml_save.Size = new Size(75, 38);
            xml_save.TabIndex = 23;
            xml_save.Text = "XML Save";
            xml_save.UseVisualStyleBackColor = true;
            xml_save.Click += xml_save_Click;
            // 
            // open_serialize
            // 
            open_serialize.Location = new Point(1320, 48);
            open_serialize.Name = "open_serialize";
            open_serialize.Size = new Size(75, 38);
            open_serialize.TabIndex = 22;
            open_serialize.Text = "Open Serialize";
            open_serialize.UseVisualStyleBackColor = true;
            open_serialize.Click += open_serialize_Click;
            // 
            // save_serialize
            // 
            save_serialize.Location = new Point(1229, 49);
            save_serialize.Name = "save_serialize";
            save_serialize.Size = new Size(75, 38);
            save_serialize.TabIndex = 21;
            save_serialize.Text = "Save Serialize";
            save_serialize.UseVisualStyleBackColor = true;
            save_serialize.Click += save_serialize_Click;
            // 
            // circle_area
            // 
            circle_area.Location = new Point(920, 99);
            circle_area.Name = "circle_area";
            circle_area.Size = new Size(79, 40);
            circle_area.TabIndex = 20;
            circle_area.Text = "Circle Area";
            circle_area.UseVisualStyleBackColor = true;
            circle_area.Click += circle_area_Click;
            // 
            // triangle_area
            // 
            triangle_area.Location = new Point(835, 99);
            triangle_area.Name = "triangle_area";
            triangle_area.Size = new Size(79, 41);
            triangle_area.TabIndex = 19;
            triangle_area.Text = "Triangle Area";
            triangle_area.UseVisualStyleBackColor = true;
            triangle_area.Click += triangle_area_Click;
            // 
            // rectangle_info
            // 
            rectangle_info.Location = new Point(750, 99);
            rectangle_info.Name = "rectangle_info";
            rectangle_info.Size = new Size(79, 41);
            rectangle_info.TabIndex = 18;
            rectangle_info.Text = "Rectangle Area";
            rectangle_info.UseVisualStyleBackColor = true;
            rectangle_info.Click += rectangle_info_Click;
            // 
            // redo_button
            // 
            redo_button.Location = new Point(1118, 20);
            redo_button.Name = "redo_button";
            redo_button.Size = new Size(75, 23);
            redo_button.TabIndex = 17;
            redo_button.Text = "Redo";
            redo_button.UseVisualStyleBackColor = true;
            redo_button.Click += redo_button_Click;
            // 
            // square_area
            // 
            square_area.Location = new Point(665, 99);
            square_area.Name = "square_area";
            square_area.Size = new Size(79, 41);
            square_area.TabIndex = 16;
            square_area.Text = "Square Area";
            square_area.UseVisualStyleBackColor = true;
            square_area.Click += square_area_Click;
            // 
            // circle_button
            // 
            circle_button.Cursor = Cursors.Hand;
            circle_button.Image = Properties.Resources.circle_icon__1_;
            circle_button.ImageAlign = ContentAlignment.TopCenter;
            circle_button.Location = new Point(920, 32);
            circle_button.Name = "circle_button";
            circle_button.Size = new Size(79, 63);
            circle_button.TabIndex = 15;
            circle_button.Text = "Circle";
            circle_button.TextAlign = ContentAlignment.BottomCenter;
            circle_button.UseVisualStyleBackColor = true;
            circle_button.Click += circle_button_Click;
            // 
            // background_color
            // 
            background_color.Location = new Point(392, 97);
            background_color.Name = "background_color";
            background_color.Size = new Size(90, 44);
            background_color.TabIndex = 14;
            background_color.Text = "Background Color";
            background_color.UseVisualStyleBackColor = true;
            background_color.Click += background_color_Click;
            // 
            // color_picker
            // 
            color_picker.Cursor = Cursors.Hand;
            color_picker.Image = (Image)resources.GetObject("color_picker.Image");
            color_picker.Location = new Point(0, 0);
            color_picker.Name = "color_picker";
            color_picker.Size = new Size(386, 144);
            color_picker.SizeMode = PictureBoxSizeMode.StretchImage;
            color_picker.TabIndex = 13;
            color_picker.TabStop = false;
            color_picker.MouseClick += color_picker_MouseClick;
            // 
            // open_button
            // 
            open_button.Location = new Point(1320, 20);
            open_button.Name = "open_button";
            open_button.Size = new Size(75, 23);
            open_button.TabIndex = 12;
            open_button.Text = "Open";
            open_button.UseVisualStyleBackColor = true;
            open_button.Click += open_button_Click;
            // 
            // undo_button
            // 
            undo_button.Location = new Point(1037, 20);
            undo_button.Name = "undo_button";
            undo_button.Size = new Size(75, 23);
            undo_button.TabIndex = 11;
            undo_button.Text = "Undo";
            undo_button.UseVisualStyleBackColor = true;
            undo_button.Click += undo_button_click;
            // 
            // save_button
            // 
            save_button.Location = new Point(1229, 20);
            save_button.Name = "save_button";
            save_button.Size = new Size(75, 23);
            save_button.TabIndex = 10;
            save_button.Text = "Save";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // clear_button
            // 
            clear_button.Location = new Point(1076, 63);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(75, 23);
            clear_button.TabIndex = 9;
            clear_button.Text = "Clear";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click;
            // 
            // triangle_button
            // 
            triangle_button.Cursor = Cursors.Hand;
            triangle_button.Image = Properties.Resources.triangle_small_up_icon__1_;
            triangle_button.Location = new Point(835, 31);
            triangle_button.Name = "triangle_button";
            triangle_button.Size = new Size(79, 64);
            triangle_button.TabIndex = 7;
            triangle_button.Text = "Triangle";
            triangle_button.TextAlign = ContentAlignment.BottomCenter;
            triangle_button.UseVisualStyleBackColor = true;
            triangle_button.Click += triangle_button_Click;
            // 
            // rectangle_button
            // 
            rectangle_button.Cursor = Cursors.Hand;
            rectangle_button.Image = Properties.Resources.rectangle_icon;
            rectangle_button.ImageAlign = ContentAlignment.BottomCenter;
            rectangle_button.Location = new Point(750, 31);
            rectangle_button.Name = "rectangle_button";
            rectangle_button.Size = new Size(79, 64);
            rectangle_button.TabIndex = 6;
            rectangle_button.Text = "Rectangle";
            rectangle_button.TextAlign = ContentAlignment.BottomCenter;
            rectangle_button.UseVisualStyleBackColor = true;
            rectangle_button.Click += rectangle_button_Click;
            // 
            // square_button
            // 
            square_button.Cursor = Cursors.Hand;
            square_button.Image = Properties.Resources.square_16_icon;
            square_button.ImageAlign = ContentAlignment.BottomCenter;
            square_button.Location = new Point(665, 30);
            square_button.Name = "square_button";
            square_button.Size = new Size(79, 64);
            square_button.TabIndex = 5;
            square_button.Text = "Square";
            square_button.TextAlign = ContentAlignment.BottomCenter;
            square_button.UseVisualStyleBackColor = true;
            square_button.Click += square_button_Click;
            // 
            // fill_button
            // 
            fill_button.Cursor = Cursors.Hand;
            fill_button.FlatStyle = FlatStyle.System;
            fill_button.Location = new Point(488, 99);
            fill_button.Name = "fill_button";
            fill_button.Size = new Size(79, 45);
            fill_button.TabIndex = 2;
            fill_button.Text = "Border Color Change";
            fill_button.TextAlign = ContentAlignment.BottomCenter;
            fill_button.UseVisualStyleBackColor = true;
            fill_button.Click += fill_button_Click;
            // 
            // colorPicker
            // 
            colorPicker.Cursor = Cursors.Hand;
            colorPicker.Image = (Image)resources.GetObject("colorPicker.Image");
            colorPicker.Location = new Point(491, 22);
            colorPicker.Name = "colorPicker";
            colorPicker.Size = new Size(76, 65);
            colorPicker.TabIndex = 1;
            colorPicker.Text = "Color";
            colorPicker.TextAlign = ContentAlignment.BottomCenter;
            colorPicker.UseVisualStyleBackColor = true;
            colorPicker.Click += colorPicker_Click;
            // 
            // currentColor
            // 
            currentColor.BackColor = Color.White;
            currentColor.Location = new Point(392, 30);
            currentColor.Name = "currentColor";
            currentColor.Size = new Size(56, 48);
            currentColor.TabIndex = 0;
            currentColor.TabStop = false;
            // 
            // background
            // 
            background.BackColor = Color.White;
            background.Dock = DockStyle.Fill;
            background.Location = new Point(0, 0);
            background.Name = "background";
            background.Size = new Size(1433, 657);
            background.TabIndex = 1;
            background.TabStop = false;
            background.Paint += background_OnPaint;
            background.MouseClick += background_MouseClick;
            background.MouseDown += background_MouseDown;
            background.MouseMove += background_MouseMove;
            background.MouseUp += background_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 657);
            Controls.Add(panel1);
            Controls.Add(background);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Shapes Paint";
            KeyDown += Form1_KeyDown_1;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)color_picker).EndInit();
            ((System.ComponentModel.ISupportInitialize)currentColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)background).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button colorPicker;
        private PictureBox currentColor;
        private Button triangle_button;
        private Button rectangle_button;
        private Button square_button;
        private Button fill_button;
        private PictureBox background;
        private Button clear_button;
        private Button save_button;
        private Button undo_button;
        private Button open_button;
        private PictureBox color_picker;
        private Button background_color;
        private Button circle_button;
        private Button square_area;
        private Button redo_button;
        private Button rectangle_info;
        private Button triangle_area;
        private Button circle_area;
        private Button save_serialize;
        private Button open_serialize;
        private Button xml_save;
        private Button xml_open;
        private Button fill_color_button;
    }
}
