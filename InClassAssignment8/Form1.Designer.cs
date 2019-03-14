namespace InClassAssignment8
{
    partial class Form1
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
            this.button1_clear = new System.Windows.Forms.Button();
            this.textBox1_caloriesFromFat = new System.Windows.Forms.TextBox();
            this.textBox2_caloriesFromCarbs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2_calculate = new System.Windows.Forms.Button();
            this.button3_exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5_displayCaloriesFromFat = new System.Windows.Forms.Label();
            this.label6_displayCaloriesFromCarbs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_clear
            // 
            this.button1_clear.Location = new System.Drawing.Point(188, 238);
            this.button1_clear.Name = "button1_clear";
            this.button1_clear.Size = new System.Drawing.Size(85, 36);
            this.button1_clear.TabIndex = 0;
            this.button1_clear.Text = "Clear";
            this.button1_clear.UseVisualStyleBackColor = true;
            this.button1_clear.Click += new System.EventHandler(this.button1_clear_Click);
            // 
            // textBox1_caloriesFromFat
            // 
            this.textBox1_caloriesFromFat.Location = new System.Drawing.Point(327, 97);
            this.textBox1_caloriesFromFat.Name = "textBox1_caloriesFromFat";
            this.textBox1_caloriesFromFat.Size = new System.Drawing.Size(100, 22);
            this.textBox1_caloriesFromFat.TabIndex = 1;
            // 
            // textBox2_caloriesFromCarbs
            // 
            this.textBox2_caloriesFromCarbs.Location = new System.Drawing.Point(327, 170);
            this.textBox2_caloriesFromCarbs.Name = "textBox2_caloriesFromCarbs";
            this.textBox2_caloriesFromCarbs.Size = new System.Drawing.Size(100, 22);
            this.textBox2_caloriesFromCarbs.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calories from fat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Calories from carbs:";
            // 
            // button2_calculate
            // 
            this.button2_calculate.Location = new System.Drawing.Point(279, 238);
            this.button2_calculate.Name = "button2_calculate";
            this.button2_calculate.Size = new System.Drawing.Size(85, 36);
            this.button2_calculate.TabIndex = 5;
            this.button2_calculate.Text = "Calculate";
            this.button2_calculate.UseVisualStyleBackColor = true;
            this.button2_calculate.Click += new System.EventHandler(this.button2_calculate_Click);
            // 
            // button3_exit
            // 
            this.button3_exit.Location = new System.Drawing.Point(370, 238);
            this.button3_exit.Name = "button3_exit";
            this.button3_exit.Size = new System.Drawing.Size(85, 36);
            this.button3_exit.TabIndex = 6;
            this.button3_exit.Text = "Exit";
            this.button3_exit.UseVisualStyleBackColor = true;
            this.button3_exit.Click += new System.EventHandler(this.button3_exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fat Grams:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Carbs Grams:";
            // 
            // label5_displayCaloriesFromFat
            // 
            this.label5_displayCaloriesFromFat.AutoSize = true;
            this.label5_displayCaloriesFromFat.Location = new System.Drawing.Point(324, 140);
            this.label5_displayCaloriesFromFat.Name = "label5_displayCaloriesFromFat";
            this.label5_displayCaloriesFromFat.Size = new System.Drawing.Size(0, 17);
            this.label5_displayCaloriesFromFat.TabIndex = 9;
            // 
            // label6_displayCaloriesFromCarbs
            // 
            this.label6_displayCaloriesFromCarbs.AutoSize = true;
            this.label6_displayCaloriesFromCarbs.Location = new System.Drawing.Point(324, 208);
            this.label6_displayCaloriesFromCarbs.Name = "label6_displayCaloriesFromCarbs";
            this.label6_displayCaloriesFromCarbs.Size = new System.Drawing.Size(0, 17);
            this.label6_displayCaloriesFromCarbs.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 543);
            this.Controls.Add(this.label6_displayCaloriesFromCarbs);
            this.Controls.Add(this.label5_displayCaloriesFromFat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3_exit);
            this.Controls.Add(this.button2_calculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2_caloriesFromCarbs);
            this.Controls.Add(this.textBox1_caloriesFromFat);
            this.Controls.Add(this.button1_clear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_clear;
        private System.Windows.Forms.TextBox textBox1_caloriesFromFat;
        private System.Windows.Forms.TextBox textBox2_caloriesFromCarbs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2_calculate;
        private System.Windows.Forms.Button button3_exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5_displayCaloriesFromFat;
        private System.Windows.Forms.Label label6_displayCaloriesFromCarbs;
    }
}

