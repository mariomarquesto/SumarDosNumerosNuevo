namespace SumarDosNumerosNuevo
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
            lblnum1 = new Label();
            label2 = new Label();
            txtn1 = new TextBox();
            txtn2 = new TextBox();
            lblresult = new Label();
            btnsumar = new Button();
            SuspendLayout();
            // 
            // lblnum1
            // 
            lblnum1.AutoSize = true;
            lblnum1.BackColor = Color.Red;
            lblnum1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnum1.ForeColor = SystemColors.ButtonFace;
            lblnum1.Location = new Point(164, 36);
            lblnum1.Name = "lblnum1";
            lblnum1.Size = new Size(94, 21);
            lblnum1.TabIndex = 0;
            lblnum1.Text = "NÚMERO 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(428, 36);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(94, 21);
            label2.TabIndex = 1;
            label2.Text = "NÚMERO 2";
            // 
            // txtn1
            // 
            txtn1.Location = new Point(164, 70);
            txtn1.Name = "txtn1";
            txtn1.Size = new Size(100, 23);
            txtn1.TabIndex = 2;
            // 
            // txtn2
            // 
            txtn2.Location = new Point(422, 70);
            txtn2.Name = "txtn2";
            txtn2.Size = new Size(100, 23);
            txtn2.TabIndex = 3;
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.BackColor = Color.Red;
            lblresult.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblresult.ForeColor = Color.White;
            lblresult.Location = new Point(301, 197);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(0, 30);
            lblresult.TabIndex = 4;
            // 
            // btnsumar
            // 
            btnsumar.BackColor = Color.Red;
            btnsumar.BackgroundImageLayout = ImageLayout.Center;
            btnsumar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsumar.ForeColor = SystemColors.ButtonFace;
            btnsumar.Location = new Point(257, 125);
            btnsumar.Name = "btnsumar";
            btnsumar.Size = new Size(168, 42);
            btnsumar.TabIndex = 5;
            btnsumar.Text = "SUMAR";
            btnsumar.UseVisualStyleBackColor = false;
            btnsumar.Click += btnsumar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsumar);
            Controls.Add(lblresult);
            Controls.Add(txtn2);
            Controls.Add(txtn1);
            Controls.Add(label2);
            Controls.Add(lblnum1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnum1;
        private Label label2;
        private TextBox txtn1;
        private TextBox txtn2;
        private Label lblresult;
        private Button btnsumar;
    }
}
