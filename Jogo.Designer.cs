namespace Calculadora
{
    partial class Jogo
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Cooper Black", 18F);
            button1.Location = new Point(29, 430);
            button1.Name = "button1";
            button1.Size = new Size(172, 95);
            button1.TabIndex = 0;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Cooper Black", 18F);
            button2.Location = new Point(227, 430);
            button2.Name = "button2";
            button2.Size = new Size(172, 95);
            button2.TabIndex = 0;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.Font = new Font("Cooper Black", 18F);
            button3.Location = new Point(423, 430);
            button3.Name = "button3";
            button3.Size = new Size(172, 95);
            button3.TabIndex = 0;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click_1;
            // 
            // button4
            // 
            button4.Font = new Font("Cooper Black", 18F);
            button4.Location = new Point(29, 329);
            button4.Name = "button4";
            button4.Size = new Size(172, 95);
            button4.TabIndex = 0;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click_1;
            // 
            // button5
            // 
            button5.Font = new Font("Cooper Black", 18F);
            button5.Location = new Point(423, 329);
            button5.Name = "button5";
            button5.Size = new Size(172, 95);
            button5.TabIndex = 0;
            button5.Text = "6";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click_1;
            // 
            // button6
            // 
            button6.Font = new Font("Cooper Black", 18F);
            button6.Location = new Point(227, 329);
            button6.Name = "button6";
            button6.Size = new Size(172, 95);
            button6.TabIndex = 0;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click_1;
            // 
            // button7
            // 
            button7.Font = new Font("Cooper Black", 18F);
            button7.Location = new Point(29, 228);
            button7.Name = "button7";
            button7.Size = new Size(172, 95);
            button7.TabIndex = 0;
            button7.Text = "1";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click_1;
            // 
            // button8
            // 
            button8.Font = new Font("Cooper Black", 18F);
            button8.Location = new Point(423, 228);
            button8.Name = "button8";
            button8.Size = new Size(172, 95);
            button8.TabIndex = 0;
            button8.Text = "3";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button1_Click_1;
            // 
            // button9
            // 
            button9.Font = new Font("Cooper Black", 18F);
            button9.Location = new Point(227, 228);
            button9.Name = "button9";
            button9.Size = new Size(172, 95);
            button9.TabIndex = 0;
            button9.Text = "2";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button1_Click_1;
            // 
            // Jogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 537);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button8);
            Controls.Add(button2);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "Jogo";
            Text = "Jogo";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}