namespace DND_Max_Hit_Points_Calculator
{
    partial class calculateMaxHPForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.resultsTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dieComboBox = new System.Windows.Forms.ComboBox();
            this.rollButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.maxHPTextBox = new System.Windows.Forms.TextBox();
            this.constModTextBox = new System.Windows.Forms.TextBox();
            this.rollTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Max HP: ";
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(12, 12);
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.resultsTextBox.Size = new System.Drawing.Size(252, 299);
            this.resultsTextBox.TabIndex = 1;
            this.resultsTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Const Modifier: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hit Die Roll: ";
            // 
            // dieComboBox
            // 
            this.dieComboBox.FormattingEnabled = true;
            this.dieComboBox.Items.AddRange(new object[] {
            "d2",
            "d3",
            "d4",
            "d6",
            "d8",
            "d10",
            "d12",
            "d20"});
            this.dieComboBox.Location = new System.Drawing.Point(56, 418);
            this.dieComboBox.Name = "dieComboBox";
            this.dieComboBox.Size = new System.Drawing.Size(121, 21);
            this.dieComboBox.TabIndex = 4;
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(183, 417);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(34, 23);
            this.rollButton.TabIndex = 5;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(62, 450);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(141, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Max Hit Points";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // maxHPTextBox
            // 
            this.maxHPTextBox.Location = new System.Drawing.Point(134, 320);
            this.maxHPTextBox.Name = "maxHPTextBox";
            this.maxHPTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxHPTextBox.TabIndex = 7;
            // 
            // constModTextBox
            // 
            this.constModTextBox.Location = new System.Drawing.Point(134, 361);
            this.constModTextBox.Name = "constModTextBox";
            this.constModTextBox.Size = new System.Drawing.Size(100, 20);
            this.constModTextBox.TabIndex = 8;
            // 
            // rollTextBox
            // 
            this.rollTextBox.Location = new System.Drawing.Point(134, 387);
            this.rollTextBox.Name = "rollTextBox";
            this.rollTextBox.Size = new System.Drawing.Size(100, 20);
            this.rollTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(122, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "(Enter 0 if rolling 1st level)";
            // 
            // calculateMaxHPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 482);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rollTextBox);
            this.Controls.Add(this.constModTextBox);
            this.Controls.Add(this.maxHPTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.dieComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.label1);
            this.Name = "calculateMaxHPForm";
            this.Text = "Max HP Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox resultsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dieComboBox;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox maxHPTextBox;
        private System.Windows.Forms.TextBox constModTextBox;
        private System.Windows.Forms.TextBox rollTextBox;
        private System.Windows.Forms.Label label4;
    }
}

