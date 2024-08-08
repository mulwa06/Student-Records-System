namespace Part2_Task2_
{
    partial class Welcome
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
            labelWelcome = new Label();
            labelMain = new Label();
            label1 = new Label();
            buttonOK = new Button();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWelcome.ForeColor = Color.FromArgb(0, 64, 64);
            labelWelcome.Location = new Point(264, 208);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(260, 54);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "WELCOME !";
            // 
            // labelMain
            // 
            labelMain.AutoSize = true;
            labelMain.Font = new Font("Showcard Gothic", 36F, FontStyle.Underline, GraphicsUnit.Point, 0);
            labelMain.ForeColor = Color.FromArgb(0, 64, 0);
            labelMain.Location = new Point(26, 83);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(774, 74);
            labelMain.TabIndex = 1;
            labelMain.Text = "STUDENT RECORD SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(167, 308);
            label1.Name = "label1";
            label1.Size = new Size(458, 23);
            label1.TabIndex = 2;
            label1.Text = "\"With great power, comes great responsibility!\"";
            // 
            // buttonOK
            // 
            buttonOK.BackColor = SystemColors.ActiveCaption;
            buttonOK.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOK.Location = new Point(349, 360);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(78, 58);
            buttonOK.TabIndex = 3;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOK);
            Controls.Add(label1);
            Controls.Add(labelMain);
            Controls.Add(labelWelcome);
            Name = "Welcome";
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Label labelMain;
        private Label label1;
        private Button buttonOK;
    }
}
