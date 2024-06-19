namespace UYKiosk
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
            btnInput = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label12 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnInput
            // 
            btnInput.BackColor = System.Drawing.Color.YellowGreen;
            btnInput.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnInput.ForeColor = System.Drawing.Color.WhiteSmoke;
            btnInput.Location = new System.Drawing.Point(46, 156);
            btnInput.Margin = new System.Windows.Forms.Padding(20);
            btnInput.Name = "btnInput";
            btnInput.Size = new System.Drawing.Size(170, 90);
            btnInput.TabIndex = 0;
            btnInput.Text = "입금";
            btnInput.UseVisualStyleBackColor = false;
            btnInput.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.YellowGreen;
            button2.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            button2.Location = new System.Drawing.Point(53, 355);
            button2.Margin = new System.Windows.Forms.Padding(20);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(170, 90);
            button2.TabIndex = 0;
            button2.Text = "출금";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.YellowGreen;
            button3.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            button3.Location = new System.Drawing.Point(575, 156);
            button3.Margin = new System.Windows.Forms.Padding(20);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(170, 90);
            button3.TabIndex = 0;
            button3.Text = "계좌이체";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.YellowGreen;
            button4.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            button4.Location = new System.Drawing.Point(575, 355);
            button4.Margin = new System.Windows.Forms.Padding(20);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(170, 90);
            button4.TabIndex = 0;
            button4.Text = "조회";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.Color.YellowGreen;
            button5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            button5.Location = new System.Drawing.Point(643, 490);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(95, 40);
            button5.TabIndex = 1;
            button5.Text = "처음으로";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(12, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(760, 143);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(246, 156);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(299, 355);
            panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.사기주의1;
            pictureBox2.Location = new System.Drawing.Point(20, 87);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(260, 252);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = System.Drawing.Color.DarkSeaGreen;
            label12.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(-7, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(313, 45);
            label12.TabIndex = 0;
            label12.Text = "      거 래 선 택      ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(70, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(155, 20);
            label2.TabIndex = 1;
            label2.Text = "5만원권 출/입금 가능";
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            ClientSize = new System.Drawing.Size(784, 561);
            Controls.Add(panel1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(btnInput);
            Controls.Add(pictureBox1);
            Name = "Form2";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}