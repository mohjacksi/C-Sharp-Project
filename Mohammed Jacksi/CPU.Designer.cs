namespace Mohammed_Jacksi
{
    partial class CPU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPU));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.priorityRadioButton = new System.Windows.Forms.RadioButton();
            this.sjfRadioButton = new System.Windows.Forms.RadioButton();
            this.fcfsRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.q = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.burst = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.priority_label = new System.Windows.Forms.Label();
            this.priority = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(101, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Processes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.priorityRadioButton);
            this.groupBox1.Controls.Add(this.sjfRadioButton);
            this.groupBox1.Controls.Add(this.fcfsRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(177, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 174);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithm";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(18, 136);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(123, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Round Robin";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // priorityRadioButton
            // 
            this.priorityRadioButton.AutoSize = true;
            this.priorityRadioButton.Location = new System.Drawing.Point(18, 101);
            this.priorityRadioButton.Name = "priorityRadioButton";
            this.priorityRadioButton.Size = new System.Drawing.Size(80, 24);
            this.priorityRadioButton.TabIndex = 2;
            this.priorityRadioButton.TabStop = true;
            this.priorityRadioButton.Text = "Priority";
            this.priorityRadioButton.UseVisualStyleBackColor = true;
            this.priorityRadioButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // sjfRadioButton
            // 
            this.sjfRadioButton.AutoSize = true;
            this.sjfRadioButton.Location = new System.Drawing.Point(18, 66);
            this.sjfRadioButton.Name = "sjfRadioButton";
            this.sjfRadioButton.Size = new System.Drawing.Size(57, 24);
            this.sjfRadioButton.TabIndex = 1;
            this.sjfRadioButton.TabStop = true;
            this.sjfRadioButton.Text = "SJF";
            this.sjfRadioButton.UseVisualStyleBackColor = true;
            this.sjfRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // fcfsRadioButton
            // 
            this.fcfsRadioButton.AutoSize = true;
            this.fcfsRadioButton.Location = new System.Drawing.Point(18, 31);
            this.fcfsRadioButton.Name = "fcfsRadioButton";
            this.fcfsRadioButton.Size = new System.Drawing.Size(70, 24);
            this.fcfsRadioButton.TabIndex = 0;
            this.fcfsRadioButton.TabStop = true;
            this.fcfsRadioButton.Text = "FCFS";
            this.fcfsRadioButton.UseVisualStyleBackColor = true;
            this.fcfsRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(177, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 58);
            this.button1.TabIndex = 15;
            this.button1.Text = "Calc AWT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // q
            // 
            this.q.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.q.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q.Location = new System.Drawing.Point(272, 236);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(60, 29);
            this.q.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(173, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quantum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Butst time:";
            // 
            // burst
            // 
            this.burst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.burst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burst.Location = new System.Drawing.Point(99, 236);
            this.burst.Name = "burst";
            this.burst.Size = new System.Drawing.Size(60, 29);
            this.burst.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(4, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 58);
            this.button2.TabIndex = 18;
            this.button2.Text = "Add proc.";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // priority_label
            // 
            this.priority_label.AutoSize = true;
            this.priority_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priority_label.ForeColor = System.Drawing.Color.White;
            this.priority_label.Location = new System.Drawing.Point(0, 203);
            this.priority_label.Name = "priority_label";
            this.priority_label.Size = new System.Drawing.Size(71, 24);
            this.priority_label.TabIndex = 22;
            this.priority_label.Text = "Priority:";
            // 
            // priority
            // 
            this.priority.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priority.Location = new System.Drawing.Point(99, 201);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(60, 29);
            this.priority.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(5, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(88, 139);
            this.textBox1.TabIndex = 23;
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.priorityTextBox.Location = new System.Drawing.Point(99, 56);
            this.priorityTextBox.Multiline = true;
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.ReadOnly = true;
            this.priorityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.priorityTextBox.Size = new System.Drawing.Size(60, 139);
            this.priorityTextBox.TabIndex = 24;
            // 
            // CPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(336, 333);
            this.Controls.Add(this.priorityTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.priority_label);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.burst);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.q);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CPU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton priorityRadioButton;
        private System.Windows.Forms.RadioButton sjfRadioButton;
        private System.Windows.Forms.RadioButton fcfsRadioButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox q;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox burst;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label priority_label;
        private System.Windows.Forms.TextBox priority;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox priorityTextBox;
    }
}