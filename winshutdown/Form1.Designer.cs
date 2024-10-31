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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txthour = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            txtmin = new TextBox();
            countdowntimer = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            label4 = new Label();
            button6 = new Button();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 44);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 0;
            label2.Text = "Minutes";
            // 
            // txtmin
            // 
            txtmin.Location = new Point(157, 67);
            txtmin.Name = "txtmin";
            txtmin.Size = new Size(125, 27);
            txtmin.TabIndex = 1;
            txtmin.Leave += txtmin_Leave;
            // 
            // countdowntimer
            // 
            countdowntimer.Interval = 1000;
            countdowntimer.Tick += countdowntimer_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(439, 234);
            label3.Name = "label3";
            label3.Size = new Size(205, 20);
            label3.TabIndex = 5;
            label3.Text = "Time Remaining to Shutdown";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(452, 274);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // button6
            // 
            button6.Location = new Point(154, 274);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 8;
            button6.Text = "Start Count";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Location = new Point(254, 274);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 10;
            button4.Text = "Stop Count";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(label4);
            Controls.Add(label3);
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
        private Label label2;
        private TextBox txtmin;
        private System.Windows.Forms.Timer countdowntimer;
        private Label label3;
        private Label label4;
        private Button button6;
        private Button button4;
    }
}
