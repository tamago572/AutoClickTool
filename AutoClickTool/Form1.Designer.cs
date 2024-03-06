namespace AutoClickTool
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
            label1 = new Label();
            barrangeStartBtn = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            label4 = new Label();
            checkBox2 = new CheckBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans JP", 24F);
            label1.Location = new Point(24, 54);
            label1.Name = "label1";
            label1.Size = new Size(308, 46);
            label1.TabIndex = 0;
            label1.Text = "一定間隔でクリック";
            // 
            // barrangeStartBtn
            // 
            barrangeStartBtn.Font = new Font("Noto Sans JP", 16F);
            barrangeStartBtn.Location = new Point(560, 52);
            barrangeStartBtn.Name = "barrangeStartBtn";
            barrangeStartBtn.Size = new Size(189, 46);
            barrangeStartBtn.TabIndex = 1;
            barrangeStartBtn.Text = "開始";
            barrangeStartBtn.UseVisualStyleBackColor = true;
            barrangeStartBtn.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(338, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 25);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Noto Sans JP", 16F);
            label2.Location = new Point(468, 60);
            label2.Name = "label2";
            label2.Size = new Size(36, 32);
            label2.TabIndex = 3;
            label2.Text = "秒";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Noto Sans JP", 24F);
            label3.Location = new Point(24, 272);
            label3.Name = "label3";
            label3.Size = new Size(308, 46);
            label3.TabIndex = 4;
            label3.Text = "押しっぱなしにする";
            label3.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Noto Sans JP", 12F);
            checkBox1.Location = new Point(338, 105);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(131, 28);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "ms指定にする";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Noto Sans JP", 16F);
            button2.Location = new Point(560, 272);
            button2.Name = "button2";
            button2.Size = new Size(189, 46);
            button2.TabIndex = 6;
            button2.Text = "開始";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(24, 204);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(725, 23);
            progressBar1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 178);
            label4.Name = "label4";
            label4.Size = new Size(104, 17);
            label4.TabIndex = 8;
            label4.Text = "次のクリックまで";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(143, 177);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(147, 21);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "プログレスバーを表示";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(338, 136);
            label5.Name = "label5";
            label5.Size = new Size(414, 17);
            label5.TabIndex = 10;
            label5.Text = "小数の入力はできないため、n.n秒待機したい場合、msを使用してください";
            // 
            // button1
            // 
            button1.Location = new Point(24, 398);
            button1.Name = "button1";
            button1.Size = new Size(204, 25);
            button1.TabIndex = 11;
            button1.Text = "バックグラウンドキー検知の設定";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(checkBox2);
            Controls.Add(label4);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(barrangeStartBtn);
            Controls.Add(label1);
            Name = "Form1";
            Text = "AutoClickTool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button barrangeStartBtn;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private Button button2;
        private ProgressBar progressBar1;
        private Label label4;
        private CheckBox checkBox2;
        private Label label5;
        private Button button1;
    }
}
