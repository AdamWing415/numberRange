namespace numberRange
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.startInput = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.endInput = new System.Windows.Forms.TextBox();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calculateButton.Location = new System.Drawing.Point(339, 260);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 30);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // startInput
            // 
            this.startInput.Location = new System.Drawing.Point(339, 158);
            this.startInput.Name = "startInput";
            this.startInput.Size = new System.Drawing.Size(100, 22);
            this.startInput.TabIndex = 1;
            // 
            // headerLabel
            // 
            this.headerLabel.Font = new System.Drawing.Font("Stylus BT", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.headerLabel.Location = new System.Drawing.Point(-5, -2);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(523, 79);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "NUMBERS YEAH!!";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endInput
            // 
            this.endInput.Location = new System.Drawing.Point(339, 209);
            this.endInput.Name = "endInput";
            this.endInput.Size = new System.Drawing.Size(100, 22);
            this.endInput.TabIndex = 3;
            // 
            // startLabel
            // 
            this.startLabel.Font = new System.Drawing.Font("Stylus BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startLabel.Location = new System.Drawing.Point(12, 147);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(305, 41);
            this.startLabel.TabIndex = 4;
            this.startLabel.Text = "enter first number";
            this.startLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endLabel
            // 
            this.endLabel.Font = new System.Drawing.Font("Stylus BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.endLabel.Location = new System.Drawing.Point(12, 198);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(305, 41);
            this.endLabel.TabIndex = 5;
            this.endLabel.Text = "enter second number";
            this.endLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Stylus BT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.outputLabel.Location = new System.Drawing.Point(4, 314);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(497, 93);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(513, 426);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.endInput);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.startInput);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox startInput;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox endInput;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label outputLabel;
    }
}

