namespace WinFormsApp1
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
            NumberX = new TextBox();
            NumberY = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // NumberX
            // 
            NumberX.Location = new Point(38, 40);
            NumberX.Name = "NumberX";
            NumberX.Size = new Size(125, 27);
            NumberX.TabIndex = 0;
            // 
            // NumberY
            // 
            NumberY.Location = new Point(38, 88);
            NumberY.Name = "NumberY";
            NumberY.Size = new Size(125, 27);
            NumberY.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 47);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 2;
            label1.Text = "Число x";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 95);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 3;
            label2.Text = "Число y";
            // 
            // button1
            // 
            button1.Location = new Point(38, 135);
            button1.Name = "button1";
            button1.Size = new Size(212, 29);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 184);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NumberY);
            Controls.Add(NumberX);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NumberX;
        private TextBox NumberY;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
