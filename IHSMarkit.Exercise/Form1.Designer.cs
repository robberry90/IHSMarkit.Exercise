namespace IHSMarkit.Exercise
{
    partial class Form1
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
            this.sharesSold_TextBox = new System.Windows.Forms.TextBox();
            this.pricePerShare_TextBox = new System.Windows.Forms.TextBox();
            this.sellDate_TextBox = new System.Windows.Forms.TextBox();
            this.costMethod_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.costPrice_Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gainLoss_Label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sharesRemaining_Label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.remainingCostPrice_Label = new System.Windows.Forms.Label();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sharesSold_TextBox
            // 
            this.sharesSold_TextBox.Location = new System.Drawing.Point(207, 32);
            this.sharesSold_TextBox.Name = "sharesSold_TextBox";
            this.sharesSold_TextBox.Size = new System.Drawing.Size(142, 20);
            this.sharesSold_TextBox.TabIndex = 0;
            // 
            // pricePerShare_TextBox
            // 
            this.pricePerShare_TextBox.Location = new System.Drawing.Point(207, 58);
            this.pricePerShare_TextBox.Name = "pricePerShare_TextBox";
            this.pricePerShare_TextBox.Size = new System.Drawing.Size(142, 20);
            this.pricePerShare_TextBox.TabIndex = 1;
            // 
            // sellDate_TextBox
            // 
            this.sellDate_TextBox.Location = new System.Drawing.Point(207, 85);
            this.sellDate_TextBox.Name = "sellDate_TextBox";
            this.sellDate_TextBox.Size = new System.Drawing.Size(142, 20);
            this.sellDate_TextBox.TabIndex = 2;
            // 
            // costMethod_ComboBox
            // 
            this.costMethod_ComboBox.FormattingEnabled = true;
            this.costMethod_ComboBox.Items.AddRange(new object[] {
            "First In First Out",
            "Last In First Out",
            "Highest Cost",
            "Lowest Cost",
            "Weighted Average"});
            this.costMethod_ComboBox.Location = new System.Drawing.Point(207, 112);
            this.costMethod_ComboBox.Name = "costMethod_ComboBox";
            this.costMethod_ComboBox.Size = new System.Drawing.Size(142, 21);
            this.costMethod_ComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Shares Sold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price Per Share";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sell Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cost Method";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cost Price of Sold Shares";
            // 
            // costPrice_Label
            // 
            this.costPrice_Label.AutoSize = true;
            this.costPrice_Label.Location = new System.Drawing.Point(207, 157);
            this.costPrice_Label.Name = "costPrice_Label";
            this.costPrice_Label.Size = new System.Drawing.Size(0, 13);
            this.costPrice_Label.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Gain Loss on Sale";
            // 
            // gainLoss_Label
            // 
            this.gainLoss_Label.AutoSize = true;
            this.gainLoss_Label.Location = new System.Drawing.Point(207, 174);
            this.gainLoss_Label.Name = "gainLoss_Label";
            this.gainLoss_Label.Size = new System.Drawing.Size(0, 13);
            this.gainLoss_Label.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Number of Shares Remaining";
            // 
            // sharesRemaining_Label
            // 
            this.sharesRemaining_Label.AutoSize = true;
            this.sharesRemaining_Label.Location = new System.Drawing.Point(207, 191);
            this.sharesRemaining_Label.Name = "sharesRemaining_Label";
            this.sharesRemaining_Label.Size = new System.Drawing.Size(0, 13);
            this.sharesRemaining_Label.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Cost Price of Remaining Shares";
            // 
            // remainingCostPrice_Label
            // 
            this.remainingCostPrice_Label.AutoSize = true;
            this.remainingCostPrice_Label.Location = new System.Drawing.Point(207, 208);
            this.remainingCostPrice_Label.Name = "remainingCostPrice_Label";
            this.remainingCostPrice_Label.Size = new System.Drawing.Size(0, 13);
            this.remainingCostPrice_Label.TabIndex = 15;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Location = new System.Drawing.Point(44, 235);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(305, 30);
            this.calculate_Button.TabIndex = 16;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 299);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.remainingCostPrice_Label);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sharesRemaining_Label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gainLoss_Label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.costPrice_Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costMethod_ComboBox);
            this.Controls.Add(this.sellDate_TextBox);
            this.Controls.Add(this.pricePerShare_TextBox);
            this.Controls.Add(this.sharesSold_TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sharesSold_TextBox;
        private System.Windows.Forms.TextBox pricePerShare_TextBox;
        private System.Windows.Forms.TextBox sellDate_TextBox;
        private System.Windows.Forms.ComboBox costMethod_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label costPrice_Label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label gainLoss_Label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label sharesRemaining_Label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label remainingCostPrice_Label;
        private System.Windows.Forms.Button calculate_Button;
    }
}

