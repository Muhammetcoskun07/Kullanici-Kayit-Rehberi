namespace Kullanıcı_Kayıt_Rehberi
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(88, 73);
            button1.Name = "button1";
            button1.Size = new Size(152, 69);
            button1.TabIndex = 0;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(406, 90);
            label1.Name = "label1";
            label1.Size = new Size(114, 35);
            label1.TabIndex = 1;
            label1.Text = "Merhaba";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Yellow;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(406, 176);
            label2.Name = "label2";
            label2.Size = new Size(81, 35);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.Font = new Font("Segoe UI", 15F);
            button2.ForeColor = Color.Yellow;
            button2.Location = new Point(88, 160);
            button2.Name = "button2";
            button2.Size = new Size(152, 67);
            button2.TabIndex = 3;
            button2.Text = "Kayıt";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.Font = new Font("Segoe UI", 15F);
            button3.ForeColor = Color.Yellow;
            button3.Location = new Point(88, 246);
            button3.Name = "button3";
            button3.Size = new Size(193, 62);
            button3.TabIndex = 4;
            button3.Text = "Textbox Kayıt";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(406, 255);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 41);
            textBox1.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = Color.Blue;
            button4.Font = new Font("Segoe UI", 15F);
            button4.ForeColor = Color.Yellow;
            button4.Location = new Point(88, 331);
            button4.Name = "button4";
            button4.Size = new Size(163, 71);
            button4.TabIndex = 6;
            button4.Text = "Veri Kaydet";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(406, 349);
            label3.Name = "label3";
            label3.Size = new Size(81, 35);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
        private Label label3;
    }
}
