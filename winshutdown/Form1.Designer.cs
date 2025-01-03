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
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 33);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Hours";
            // 
            // txthour
            // 
            txthour.Location = new Point(23, 50);
            txthour.Margin = new Padding(3, 2, 3, 2);
            txthour.Name = "txthour";
            txthour.Size = new Size(110, 23);
            txthour.TabIndex = 1;
            txthour.Leave += txthour_Leave;
            // 
            // button1
            // 
            button1.Location = new Point(403, 33);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(116, 22);
            button1.TabIndex = 2;
            button1.Text = "Shutdown";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(403, 59);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(116, 22);
            button2.TabIndex = 2;
            button2.Text = "Restart";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 33);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 0;
            label2.Text = "Minutes";
            // 
            // txtmin
            // 
            txtmin.Location = new Point(137, 50);
            txtmin.Margin = new Padding(3, 2, 3, 2);
            txtmin.Name = "txtmin";
            txtmin.Size = new Size(110, 23);
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
            label3.Location = new Point(23, 92);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 5;
            label3.Text = "Seconds left to shutdown:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 92);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 6;
            label4.Text = "00000";
            // 
            // button4
            // 
            button4.Location = new Point(403, 85);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(116, 22);
            button4.TabIndex = 10;
            button4.Text = "Stop Count";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtmin);
            Controls.Add(txthour);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Timed Shutdown";
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
        private Button button4;
    }
}
