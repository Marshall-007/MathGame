namespace MathsQuiz
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblTimer = new Label();
            plusLeftLabel = new Label();
            minusLeftLabel = new Label();
            timesLeftLabel = new Label();
            plusRightLabel = new Label();
            minusRightLable = new Label();
            timesRightLabel = new Label();
            lblAdd = new Label();
            lblEqual = new Label();
            sum = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            diffarence = new NumericUpDown();
            product = new NumericUpDown();
            devideLeftLable = new Label();
            devideRightLable = new Label();
            label8 = new Label();
            label9 = new Label();
            quotient = new NumericUpDown();
            atartButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diffarence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(399, 17);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 0;
            label1.Text = "Time Remaining";
            label1.Click += label1_Click;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 15F);
            lblTimer.Location = new Point(543, 17);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(0, 28);
            lblTimer.TabIndex = 1;
            lblTimer.Click += lblTimer_Click;
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Segoe UI", 30F);
            plusLeftLabel.Location = new Point(78, 74);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(52, 55);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font = new Font("Segoe UI", 30F);
            minusLeftLabel.Location = new Point(78, 140);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(52, 55);
            minusLeftLabel.TabIndex = 2;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("Segoe UI", 30F);
            timesLeftLabel.Location = new Point(78, 212);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(52, 55);
            timesLeftLabel.TabIndex = 2;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Segoe UI", 30F);
            plusRightLabel.Location = new Point(306, 74);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(52, 55);
            plusRightLabel.TabIndex = 2;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusRightLable
            // 
            minusRightLable.Font = new Font("Segoe UI", 30F);
            minusRightLable.Location = new Point(306, 140);
            minusRightLable.Name = "minusRightLable";
            minusRightLable.Size = new Size(52, 55);
            minusRightLable.TabIndex = 2;
            minusRightLable.Text = "?";
            minusRightLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font = new Font("Segoe UI", 30F);
            timesRightLabel.Location = new Point(306, 212);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(52, 55);
            timesRightLabel.TabIndex = 2;
            timesRightLabel.Text = "?";
            timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAdd
            // 
            lblAdd.Font = new Font("Segoe UI", 30F);
            lblAdd.Location = new Point(191, 74);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(52, 55);
            lblAdd.TabIndex = 2;
            lblAdd.Text = "+";
            lblAdd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEqual
            // 
            lblEqual.Font = new Font("Segoe UI", 30F);
            lblEqual.Location = new Point(384, 74);
            lblEqual.Name = "lblEqual";
            lblEqual.Size = new Size(52, 55);
            lblEqual.TabIndex = 2;
            lblEqual.Text = "=";
            lblEqual.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI", 11F);
            sum.Location = new Point(465, 94);
            sum.MinimumSize = new Size(100, 0);
            sum.Name = "sum";
            sum.Size = new Size(100, 27);
            sum.TabIndex = 1;
            sum.ValueChanged += sum_ValueChanged;
            sum.Enter += answer_Enter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 30F);
            label2.Location = new Point(191, 140);
            label2.Name = "label2";
            label2.Size = new Size(52, 55);
            label2.TabIndex = 2;
            label2.Text = "-";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 30F);
            label3.Location = new Point(191, 212);
            label3.Name = "label3";
            label3.Size = new Size(52, 55);
            label3.TabIndex = 2;
            label3.Text = "X";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 30F);
            label6.Location = new Point(384, 140);
            label6.Name = "label6";
            label6.Size = new Size(52, 55);
            label6.TabIndex = 2;
            label6.Text = "=";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 30F);
            label7.Location = new Point(384, 212);
            label7.Name = "label7";
            label7.Size = new Size(52, 55);
            label7.TabIndex = 2;
            label7.Text = "=";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // diffarence
            // 
            diffarence.Font = new Font("Segoe UI", 11F);
            diffarence.Location = new Point(465, 159);
            diffarence.MinimumSize = new Size(100, 0);
            diffarence.Name = "diffarence";
            diffarence.Size = new Size(100, 27);
            diffarence.TabIndex = 2;
            // 
            // product
            // 
            product.Font = new Font("Segoe UI", 11F);
            product.Location = new Point(465, 230);
            product.MinimumSize = new Size(100, 0);
            product.Name = "product";
            product.Size = new Size(100, 27);
            product.TabIndex = 3;
            // 
            // devideLeftLable
            // 
            devideLeftLable.Font = new Font("Segoe UI", 30F);
            devideLeftLable.Location = new Point(78, 281);
            devideLeftLable.Name = "devideLeftLable";
            devideLeftLable.Size = new Size(52, 55);
            devideLeftLable.TabIndex = 2;
            devideLeftLable.Text = "?";
            devideLeftLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // devideRightLable
            // 
            devideRightLable.Font = new Font("Segoe UI", 30F);
            devideRightLable.Location = new Point(306, 281);
            devideRightLable.Name = "devideRightLable";
            devideRightLable.Size = new Size(52, 55);
            devideRightLable.TabIndex = 2;
            devideRightLable.Text = "?";
            devideRightLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 30F);
            label8.Location = new Point(191, 281);
            label8.Name = "label8";
            label8.Size = new Size(52, 55);
            label8.TabIndex = 2;
            label8.Text = "÷";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 30F);
            label9.Location = new Point(384, 281);
            label9.Name = "label9";
            label9.Size = new Size(52, 55);
            label9.TabIndex = 2;
            label9.Text = "=";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += label9_Click;
            // 
            // quotient
            // 
            quotient.Font = new Font("Segoe UI", 11F);
            quotient.Location = new Point(465, 296);
            quotient.MinimumSize = new Size(100, 0);
            quotient.Name = "quotient";
            quotient.Size = new Size(100, 27);
            quotient.TabIndex = 4;
            // 
            // atartButton
            // 
            atartButton.BackColor = Color.FromArgb(192, 192, 255);
            atartButton.FlatStyle = FlatStyle.Popup;
            atartButton.Location = new Point(243, 366);
            atartButton.Name = "atartButton";
            atartButton.Size = new Size(106, 31);
            atartButton.TabIndex = 5;
            atartButton.Text = "START";
            atartButton.UseVisualStyleBackColor = false;
            atartButton.Click += atartButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 435);
            Controls.Add(atartButton);
            Controls.Add(quotient);
            Controls.Add(product);
            Controls.Add(diffarence);
            Controls.Add(sum);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(lblEqual);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(devideRightLable);
            Controls.Add(lblAdd);
            Controls.Add(timesRightLabel);
            Controls.Add(minusRightLable);
            Controls.Add(devideLeftLable);
            Controls.Add(plusRightLabel);
            Controls.Add(timesLeftLabel);
            Controls.Add(minusLeftLabel);
            Controls.Add(plusLeftLabel);
            Controls.Add(lblTimer);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Math Quiz";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)diffarence).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTimer;
        private Label plusLeftLabel;
        private Label minusLeftLabel;
        private Label timesLeftLabel;
        private Label plusRightLabel;
        private Label minusRightLable;
        private Label timesRightLabel;
        private Label lblAdd;
        private Label lblEqual;
        private NumericUpDown sum;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label7;
        private NumericUpDown diffarence;
        private NumericUpDown product;
        private Label devideLeftLable;
        private Label devideRightLable;
        private Label label8;
        private Label label9;
        private NumericUpDown quotient;
        private Button atartButton;
        private System.Windows.Forms.Timer timer1;
    }
}
