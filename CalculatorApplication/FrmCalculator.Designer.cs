namespace CalculatorApplication
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
            txtBoxInput1 = new TextBox();
            label1 = new Label();
            cbOperator = new ComboBox();
            label2 = new Label();
            txtBoxInput2 = new TextBox();
            lblDisplayTotal = new Label();
            btnEqual = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Segoe UI", 12F);
            txtBoxInput1.Location = new Point(216, 20);
            txtBoxInput1.Margin = new Padding(3, 4, 3, 4);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(266, 34);
            txtBoxInput1.TabIndex = 0;
            txtBoxInput1.KeyPress += txtBoxInput1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(30, 26);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 1;
            label1.Text = "Enter First Number:";
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 12F);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(301, 69);
            cbOperator.Margin = new Padding(3, 4, 3, 4);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(97, 31);
            cbOperator.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(2, 117);
            label2.Name = "label2";
            label2.Size = new Size(208, 28);
            label2.TabIndex = 3;
            label2.Text = "Enter Second Number:";
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Segoe UI", 12F);
            txtBoxInput2.Location = new Point(216, 117);
            txtBoxInput2.Margin = new Padding(3, 4, 3, 4);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(266, 34);
            txtBoxInput2.TabIndex = 4;
            txtBoxInput2.KeyPress += txtBoxInput2_KeyPress;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Segoe UI", 12F);
            lblDisplayTotal.Location = new Point(131, 183);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(79, 28);
            lblDisplayTotal.TabIndex = 5;
            lblDisplayTotal.Text = "Answer:";
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Consolas", 12F);
            btnEqual.Location = new Point(362, 277);
            btnEqual.Margin = new Padding(3, 4, 3, 4);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(120, 49);
            btnEqual.TabIndex = 6;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 195);
            label3.Name = "label3";
            label3.Size = new Size(255, 20);
            label3.TabIndex = 7;
            label3.Text = "_________________________________________";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 344);
            Controls.Add(lblDisplayTotal);
            Controls.Add(label3);
            Controls.Add(btnEqual);
            Controls.Add(txtBoxInput2);
            Controls.Add(label2);
            Controls.Add(cbOperator);
            Controls.Add(label1);
            Controls.Add(txtBoxInput1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxInput1;
        private Label label1;
        private ComboBox cbOperator;
        private Label label2;
        private TextBox txtBoxInput2;
        private Label lblDisplayTotal;
        private Button btnEqual;
        private Label label3;
    }
}
