namespace winshutdown
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
            txthour = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            txtmin = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 44);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 0;
            label1.Text = "Hours";
            label1.Click += label1_Click;
            // 
            // txthour
            // 
            txthour.Location = new Point(26, 67);
            txthour.Name = "txthour";
            txthour.Size = new Size(125, 27);
            txthour.TabIndex = 1;
            txthour.Leave += txthour_Leave;
            // 
            // button1
            // 
            button1.Location = new Point(439, 32);
            button1.Name = "button1";
            button1.Size = new Size(132, 29);
            button1.TabIndex = 2;
            button1.Text = "Shutdown";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(439, 67);
            button2.Name = "button2";
            button2.Size = new Size(132, 29);
            button2.TabIndex = 2;
            button2.Text = "Restart";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(439, 102);
            button3.Name = "button3";
            button3.Size = new Size(132, 29);
            button3.TabIndex = 3;
            button3.Text = "Shutdown NOW";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 44);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 0;
            label2.Text = "Minutes";
            label2.Click += label2_Click;
            // 
            // txtmin
            // 
            txtmin.Location = new Point(157, 67);
            txtmin.Name = "txtmin";
            txtmin.Size = new Size(125, 27);
            txtmin.TabIndex = 1;
            txtmin.Leave += txtmin_Leave;
            // 
            // button4
            // 
            button4.Location = new Point(439, 137);
            button4.Name = "button4";
            button4.Size = new Size(132, 29);
            button4.TabIndex = 4;
            button4.Text = "Restart NOW";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtmin);
            Controls.Add(txthour);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txthour;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private TextBox txtmin;
        private Button button4;
    }
}
