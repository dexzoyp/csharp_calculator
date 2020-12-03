
namespace csharp_calculator
{
    partial class Window
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
            this.active_box = new System.Windows.Forms.TextBox();
            this.passive_box = new System.Windows.Forms.Label();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.button_changeSign = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_brackets = new System.Windows.Forms.Button();
            this.button_backspace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // active_box
            // 
            this.active_box.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.active_box.Location = new System.Drawing.Point(12, 51);
            this.active_box.Name = "active_box";
            this.active_box.Size = new System.Drawing.Size(231, 32);
            this.active_box.TabIndex = 0;
            this.active_box.Text = "0";
            // 
            // passive_box
            // 
            this.passive_box.AutoSize = true;
            this.passive_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.passive_box.Location = new System.Drawing.Point(12, 24);
            this.passive_box.Name = "passive_box";
            this.passive_box.Size = new System.Drawing.Size(0, 21);
            this.passive_box.TabIndex = 1;
            // 
            // button_0
            // 
            this.button_0.Location = new System.Drawing.Point(66, 366);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(50, 50);
            this.button_0.TabIndex = 2;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.input_number);
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(11, 310);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(50, 50);
            this.button_1.TabIndex = 3;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.input_number);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(66, 310);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(50, 50);
            this.button_2.TabIndex = 4;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.input_number);
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(122, 310);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(50, 50);
            this.button_3.TabIndex = 5;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.input_number);
            // 
            // button_4
            // 
            this.button_4.Location = new System.Drawing.Point(11, 254);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(50, 50);
            this.button_4.TabIndex = 6;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.input_number);
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(66, 254);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(50, 50);
            this.button_5.TabIndex = 7;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.input_number);
            // 
            // button_6
            // 
            this.button_6.Location = new System.Drawing.Point(122, 254);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(50, 50);
            this.button_6.TabIndex = 8;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.input_number);
            // 
            // button_9
            // 
            this.button_9.Location = new System.Drawing.Point(122, 198);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(50, 50);
            this.button_9.TabIndex = 11;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.input_number);
            // 
            // button_8
            // 
            this.button_8.Location = new System.Drawing.Point(66, 198);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(50, 50);
            this.button_8.TabIndex = 10;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.input_number);
            // 
            // button_7
            // 
            this.button_7.Location = new System.Drawing.Point(11, 198);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(50, 50);
            this.button_7.TabIndex = 9;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.input_number);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.input_dot_operator);
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(178, 310);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(65, 50);
            this.button_plus.TabIndex = 13;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.input_operator);
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(178, 254);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(65, 50);
            this.button_minus.TabIndex = 14;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.input_operator);
            // 
            // button_multiplication
            // 
            this.button_multiplication.Location = new System.Drawing.Point(178, 198);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(65, 50);
            this.button_multiplication.TabIndex = 15;
            this.button_multiplication.Text = "*";
            this.button_multiplication.UseVisualStyleBackColor = true;
            this.button_multiplication.Click += new System.EventHandler(this.input_operator);
            // 
            // button_division
            // 
            this.button_division.Location = new System.Drawing.Point(178, 142);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(65, 50);
            this.button_division.TabIndex = 16;
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.input_operator);
            // 
            // button_equal
            // 
            this.button_equal.Location = new System.Drawing.Point(178, 366);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(65, 50);
            this.button_equal.TabIndex = 17;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = true;
            this.button_equal.Click += new System.EventHandler(this.input_equal);
            // 
            // button_changeSign
            // 
            this.button_changeSign.Location = new System.Drawing.Point(11, 366);
            this.button_changeSign.Name = "button_changeSign";
            this.button_changeSign.Size = new System.Drawing.Size(50, 50);
            this.button_changeSign.TabIndex = 18;
            this.button_changeSign.Text = "+/-";
            this.button_changeSign.UseVisualStyleBackColor = true;
            this.button_changeSign.Click += new System.EventHandler(this.input_changeSign);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(66, 142);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(50, 50);
            this.button_clear.TabIndex = 19;
            this.button_clear.Text = "C";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.input_clear);
            // 
            // button_brackets
            // 
            this.button_brackets.Location = new System.Drawing.Point(122, 142);
            this.button_brackets.Name = "button_brackets";
            this.button_brackets.Size = new System.Drawing.Size(50, 50);
            this.button_brackets.TabIndex = 20;
            this.button_brackets.Text = "(  )";
            this.button_brackets.UseVisualStyleBackColor = true;
            this.button_brackets.Click += new System.EventHandler(this.input_brackets);
            // 
            // button_backspace
            // 
            this.button_backspace.Location = new System.Drawing.Point(12, 142);
            this.button_backspace.Name = "button_backspace";
            this.button_backspace.Size = new System.Drawing.Size(50, 50);
            this.button_backspace.TabIndex = 21;
            this.button_backspace.Text = "<-";
            this.button_backspace.UseVisualStyleBackColor = true;
            this.button_backspace.Click += new System.EventHandler(this.input_backspace);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 425);
            this.Controls.Add(this.button_backspace);
            this.Controls.Add(this.button_brackets);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_changeSign);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button_multiplication);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.passive_box);
            this.Controls.Add(this.active_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox active_box;
        private System.Windows.Forms.Label passive_box;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_multiplication;
        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_changeSign;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_brackets;
        private System.Windows.Forms.Button button_backspace;
    }
}

