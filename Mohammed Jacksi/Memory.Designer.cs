namespace Mohammed_Jacksi
{
    partial class Memory
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
            this.blocksTextBox = new System.Windows.Forms.TextBox();
            this.addBlockButton = new System.Windows.Forms.Button();
            this.processesTextBox = new System.Windows.Forms.TextBox();
            this.addProcessButton = new System.Windows.Forms.Button();
            this.blockText = new System.Windows.Forms.TextBox();
            this.processText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.worstFitRadioButton = new System.Windows.Forms.RadioButton();
            this.bestFitRadioButton = new System.Windows.Forms.RadioButton();
            this.firstFitRadioButton = new System.Windows.Forms.RadioButton();
            this.goButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // blocksTextBox
            // 
            this.blocksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blocksTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.blocksTextBox.Location = new System.Drawing.Point(3, 77);
            this.blocksTextBox.Multiline = true;
            this.blocksTextBox.Name = "blocksTextBox";
            this.blocksTextBox.ReadOnly = true;
            this.blocksTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.blocksTextBox.Size = new System.Drawing.Size(178, 139);
            this.blocksTextBox.TabIndex = 25;
            this.blocksTextBox.Text = "100\r\n500\r\n200\r\n300\r\n600\r\n";
            // 
            // addBlockButton
            // 
            this.addBlockButton.BackColor = System.Drawing.Color.DimGray;
            this.addBlockButton.FlatAppearance.BorderSize = 0;
            this.addBlockButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.addBlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBlockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBlockButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBlockButton.Location = new System.Drawing.Point(3, 257);
            this.addBlockButton.Name = "addBlockButton";
            this.addBlockButton.Size = new System.Drawing.Size(178, 58);
            this.addBlockButton.TabIndex = 24;
            this.addBlockButton.Text = "Add block size";
            this.addBlockButton.UseVisualStyleBackColor = false;
            this.addBlockButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // processesTextBox
            // 
            this.processesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processesTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.processesTextBox.Location = new System.Drawing.Point(187, 77);
            this.processesTextBox.Multiline = true;
            this.processesTextBox.Name = "processesTextBox";
            this.processesTextBox.ReadOnly = true;
            this.processesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.processesTextBox.Size = new System.Drawing.Size(178, 139);
            this.processesTextBox.TabIndex = 27;
            this.processesTextBox.Text = "212\r\n417\r\n112\r\n426\r\n";
            // 
            // addProcessButton
            // 
            this.addProcessButton.BackColor = System.Drawing.Color.DimGray;
            this.addProcessButton.FlatAppearance.BorderSize = 0;
            this.addProcessButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.addProcessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProcessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProcessButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addProcessButton.Location = new System.Drawing.Point(187, 257);
            this.addProcessButton.Name = "addProcessButton";
            this.addProcessButton.Size = new System.Drawing.Size(178, 58);
            this.addProcessButton.TabIndex = 26;
            this.addProcessButton.Text = "Add process size";
            this.addProcessButton.UseVisualStyleBackColor = false;
            this.addProcessButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // blockText
            // 
            this.blockText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blockText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockText.Location = new System.Drawing.Point(3, 222);
            this.blockText.Name = "blockText";
            this.blockText.Size = new System.Drawing.Size(178, 29);
            this.blockText.TabIndex = 28;
            // 
            // processText
            // 
            this.processText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processText.Location = new System.Drawing.Point(187, 222);
            this.processText.Name = "processText";
            this.processText.Size = new System.Drawing.Size(178, 29);
            this.processText.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(181, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 31);
            this.label3.TabIndex = 30;
            this.label3.Text = "Memory";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.worstFitRadioButton);
            this.groupBox1.Controls.Add(this.bestFitRadioButton);
            this.groupBox1.Controls.Add(this.firstFitRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(371, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 139);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithm";
            // 
            // worstFitRadioButton
            // 
            this.worstFitRadioButton.AutoSize = true;
            this.worstFitRadioButton.Location = new System.Drawing.Point(6, 99);
            this.worstFitRadioButton.Name = "worstFitRadioButton";
            this.worstFitRadioButton.Size = new System.Drawing.Size(96, 24);
            this.worstFitRadioButton.TabIndex = 2;
            this.worstFitRadioButton.Text = "Worst Fit";
            this.worstFitRadioButton.UseVisualStyleBackColor = true;
            this.worstFitRadioButton.CheckedChanged += new System.EventHandler(this.worstFitRadioButton_CheckedChanged);
            // 
            // bestFitRadioButton
            // 
            this.bestFitRadioButton.AutoSize = true;
            this.bestFitRadioButton.Location = new System.Drawing.Point(6, 64);
            this.bestFitRadioButton.Name = "bestFitRadioButton";
            this.bestFitRadioButton.Size = new System.Drawing.Size(86, 24);
            this.bestFitRadioButton.TabIndex = 1;
            this.bestFitRadioButton.Text = "Best Fit";
            this.bestFitRadioButton.UseVisualStyleBackColor = true;
            this.bestFitRadioButton.CheckedChanged += new System.EventHandler(this.bistFitRadioButton_CheckedChanged);
            // 
            // firstFitRadioButton
            // 
            this.firstFitRadioButton.AutoSize = true;
            this.firstFitRadioButton.Checked = true;
            this.firstFitRadioButton.Location = new System.Drawing.Point(6, 29);
            this.firstFitRadioButton.Name = "firstFitRadioButton";
            this.firstFitRadioButton.Size = new System.Drawing.Size(85, 24);
            this.firstFitRadioButton.TabIndex = 0;
            this.firstFitRadioButton.TabStop = true;
            this.firstFitRadioButton.Text = "First Fit";
            this.firstFitRadioButton.UseVisualStyleBackColor = true;
            this.firstFitRadioButton.CheckedChanged += new System.EventHandler(this.firstFitRadioButton_CheckedChanged);
            // 
            // goButton
            // 
            this.goButton.BackColor = System.Drawing.Color.DimGray;
            this.goButton.FlatAppearance.BorderSize = 0;
            this.goButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.goButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.goButton.Location = new System.Drawing.Point(371, 257);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(116, 58);
            this.goButton.TabIndex = 32;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.BackColor = System.Drawing.Color.DimGray;
            this.clearAllButton.FlatAppearance.BorderSize = 0;
            this.clearAllButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.clearAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearAllButton.Location = new System.Drawing.Point(371, 222);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(116, 29);
            this.clearAllButton.TabIndex = 33;
            this.clearAllButton.Text = "Clear all";
            this.clearAllButton.UseVisualStyleBackColor = false;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // Memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(492, 319);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.processText);
            this.Controls.Add(this.blockText);
            this.Controls.Add(this.processesTextBox);
            this.Controls.Add(this.addProcessButton);
            this.Controls.Add(this.blocksTextBox);
            this.Controls.Add(this.addBlockButton);
            this.Name = "Memory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox blocksTextBox;
        private System.Windows.Forms.Button addBlockButton;
        private System.Windows.Forms.TextBox processesTextBox;
        private System.Windows.Forms.Button addProcessButton;
        private System.Windows.Forms.TextBox blockText;
        private System.Windows.Forms.TextBox processText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton worstFitRadioButton;
        private System.Windows.Forms.RadioButton bestFitRadioButton;
        private System.Windows.Forms.RadioButton firstFitRadioButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button clearAllButton;
    }
}