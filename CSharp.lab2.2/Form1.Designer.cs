namespace CSharp.lab2._2
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
            buttonStart = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            initialPayment = new TextBox();
            limitOfExceedingValue = new TextBox();
            limitOfExceedingDepositAmount = new TextBox();
            label4 = new Label();
            numberOfMonths = new TextBox();
            buttonTask = new Button();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(12, 297);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 29);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Запуск";
            buttonStart.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 109);
            label1.Name = "label1";
            label1.Size = new Size(179, 20);
            label1.TabIndex = 1;
            label1.Text = "Первоначальный взнос:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 174);
            label2.Name = "label2";
            label2.Size = new Size(483, 20);
            label2.TabIndex = 2;
            label2.Text = "Граница превышения величины ежемесячного увеличения вклада:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 241);
            label3.Name = "label3";
            label3.Size = new Size(377, 20);
            label3.TabIndex = 3;
            label3.Text = "Граница превышения размера вклада за n-месяцев:";
            // 
            // initialPayment
            // 
            initialPayment.Location = new Point(12, 132);
            initialPayment.Name = "initialPayment";
            initialPayment.Size = new Size(201, 27);
            initialPayment.TabIndex = 4;
            // 
            // limitOfExceedingValue
            // 
            limitOfExceedingValue.Location = new Point(12, 197);
            limitOfExceedingValue.Name = "limitOfExceedingValue";
            limitOfExceedingValue.Size = new Size(201, 27);
            limitOfExceedingValue.TabIndex = 5;
            // 
            // limitOfExceedingDepositAmount
            // 
            limitOfExceedingDepositAmount.Location = new Point(12, 264);
            limitOfExceedingDepositAmount.Name = "limitOfExceedingDepositAmount";
            limitOfExceedingDepositAmount.Size = new Size(201, 27);
            limitOfExceedingDepositAmount.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 56);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 7;
            label4.Text = "Число месяцев:";
            // 
            // numberOfMonths
            // 
            numberOfMonths.Location = new Point(12, 79);
            numberOfMonths.Name = "numberOfMonths";
            numberOfMonths.Size = new Size(60, 27);
            numberOfMonths.TabIndex = 8;
            // 
            // buttonTask
            // 
            buttonTask.Location = new Point(12, 12);
            buttonTask.Name = "buttonTask";
            buttonTask.Size = new Size(94, 29);
            buttonTask.TabIndex = 9;
            buttonTask.Text = "Задание";
            buttonTask.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 450);
            Controls.Add(buttonTask);
            Controls.Add(numberOfMonths);
            Controls.Add(label4);
            Controls.Add(limitOfExceedingDepositAmount);
            Controls.Add(limitOfExceedingValue);
            Controls.Add(initialPayment);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox initialPayment;
        private TextBox limitOfExceedingValue;
        private TextBox limitOfExceedingDepositAmount;
        private Label label4;
        private TextBox numberOfMonths;
        private Button buttonTask;
    }
}
