namespace Part2_Task2_
{
    partial class Records
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
            labelTITLE = new Label();
            listViewMODULES = new ListView();
            columnMARKS = new ColumnHeader();
            columnMODULE = new ColumnHeader();
            maskedTextBoxMODULE = new MaskedTextBox();
            textBoxMARKS = new TextBox();
            labelMODULE = new Label();
            labelMARKS = new Label();
            label1 = new Label();
            label3 = new Label();
            buttonAVERAGE = new Button();
            label4 = new Label();
            labelAVERAGE = new Label();
            label6 = new Label();
            buttonCLEAR = new Button();
            buttonSUBMIT = new Button();
            SuspendLayout();
            // 
            // labelTITLE
            // 
            labelTITLE.AutoSize = true;
            labelTITLE.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            labelTITLE.ForeColor = Color.FromArgb(0, 64, 0);
            labelTITLE.Location = new Point(397, 81);
            labelTITLE.Name = "labelTITLE";
            labelTITLE.Size = new Size(608, 59);
            labelTITLE.TabIndex = 2;
            labelTITLE.Text = "STUDENT RECORD SYSTEM";
            // 
            // listViewMODULES
            // 
            listViewMODULES.Columns.AddRange(new ColumnHeader[] { columnMARKS, columnMODULE });
            listViewMODULES.FullRowSelect = true;
            listViewMODULES.GridLines = true;
            listViewMODULES.Location = new Point(194, 208);
            listViewMODULES.Name = "listViewMODULES";
            listViewMODULES.Size = new Size(533, 464);
            listViewMODULES.TabIndex = 3;
            listViewMODULES.UseCompatibleStateImageBehavior = false;
            listViewMODULES.View = View.Details;
            // 
            // columnMARKS
            // 
            columnMARKS.Text = "MARKS";
            columnMARKS.Width = 260;
            // 
            // columnMODULE
            // 
            columnMODULE.Text = "MODULE";
            columnMODULE.Width = 260;
            // 
            // maskedTextBoxMODULE
            // 
            maskedTextBoxMODULE.AsciiOnly = true;
            maskedTextBoxMODULE.Location = new Point(875, 285);
            maskedTextBoxMODULE.Mask = "AAAAAAAAAAAAAAAA";
            maskedTextBoxMODULE.Name = "maskedTextBoxMODULE";
            maskedTextBoxMODULE.Size = new Size(125, 27);
            maskedTextBoxMODULE.TabIndex = 4;
            // 
            // textBoxMARKS
            // 
            textBoxMARKS.Location = new Point(1121, 285);
            textBoxMARKS.Name = "textBoxMARKS";
            textBoxMARKS.Size = new Size(125, 27);
            textBoxMARKS.TabIndex = 5;
            // 
            // labelMODULE
            // 
            labelMODULE.AutoSize = true;
            labelMODULE.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMODULE.Location = new Point(767, 285);
            labelMODULE.Name = "labelMODULE";
            labelMODULE.Size = new Size(101, 28);
            labelMODULE.TabIndex = 6;
            labelMODULE.Text = "MODULE:";
            // 
            // labelMARKS
            // 
            labelMARKS.AutoSize = true;
            labelMARKS.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMARKS.Location = new Point(1014, 284);
            labelMARKS.Name = "labelMARKS";
            labelMARKS.Size = new Size(87, 28);
            labelMARKS.TabIndex = 7;
            labelMARKS.Text = "MARKS:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10.2F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(828, 239);
            label1.Name = "label1";
            label1.Size = new Size(347, 21);
            label1.TabIndex = 8;
            label1.Text = "ENTER THE MODULE NAME AND MARKS BELOW:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10.2F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(840, 395);
            label3.Name = "label3";
            label3.Size = new Size(279, 21);
            label3.TabIndex = 10;
            label3.Text = "CLICK BELOW TO CALCULATE AVERAGE:";
            // 
            // buttonAVERAGE
            // 
            buttonAVERAGE.BackColor = SystemColors.ActiveCaption;
            buttonAVERAGE.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAVERAGE.Location = new Point(840, 449);
            buttonAVERAGE.Name = "buttonAVERAGE";
            buttonAVERAGE.Size = new Size(160, 37);
            buttonAVERAGE.TabIndex = 11;
            buttonAVERAGE.Text = "Average";
            buttonAVERAGE.UseVisualStyleBackColor = false;
            buttonAVERAGE.Click += buttonAVERAGE_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1017, 453);
            label4.Name = "label4";
            label4.Size = new Size(26, 28);
            label4.TabIndex = 12;
            label4.Text = "=";
            // 
            // labelAVERAGE
            // 
            labelAVERAGE.AutoSize = true;
            labelAVERAGE.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAVERAGE.Location = new Point(1059, 444);
            labelAVERAGE.Name = "labelAVERAGE";
            labelAVERAGE.Size = new Size(0, 46);
            labelAVERAGE.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 10.2F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.Location = new Point(864, 520);
            label6.Name = "label6";
            label6.Size = new Size(231, 21);
            label6.TabIndex = 14;
            label6.Text = "CLICK BELOW TO CLEAR MARKS:";
            // 
            // buttonCLEAR
            // 
            buttonCLEAR.BackColor = SystemColors.ActiveCaption;
            buttonCLEAR.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCLEAR.Location = new Point(901, 571);
            buttonCLEAR.Name = "buttonCLEAR";
            buttonCLEAR.Size = new Size(160, 37);
            buttonCLEAR.TabIndex = 15;
            buttonCLEAR.Text = "Clear Marks";
            buttonCLEAR.UseVisualStyleBackColor = false;
            buttonCLEAR.Click += buttonCLEAR_Click;
            // 
            // buttonSUBMIT
            // 
            buttonSUBMIT.BackColor = SystemColors.ActiveCaption;
            buttonSUBMIT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSUBMIT.Location = new Point(918, 334);
            buttonSUBMIT.Name = "buttonSUBMIT";
            buttonSUBMIT.Size = new Size(160, 37);
            buttonSUBMIT.TabIndex = 16;
            buttonSUBMIT.Text = "SUBMIT";
            buttonSUBMIT.UseVisualStyleBackColor = false;
            buttonSUBMIT.Click += buttonSUBMIT_Click;
            // 
            // Records
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 739);
            Controls.Add(buttonSUBMIT);
            Controls.Add(buttonCLEAR);
            Controls.Add(label6);
            Controls.Add(labelAVERAGE);
            Controls.Add(label4);
            Controls.Add(buttonAVERAGE);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(labelMARKS);
            Controls.Add(labelMODULE);
            Controls.Add(textBoxMARKS);
            Controls.Add(maskedTextBoxMODULE);
            Controls.Add(listViewMODULES);
            Controls.Add(labelTITLE);
            Name = "Records";
            Text = "Records";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTITLE;
        private ListView listViewMODULES;
        private MaskedTextBox maskedTextBoxMODULE;
        private TextBox textBoxMARKS;
        private Label labelMODULE;
        private Label labelMARKS;
        private Label label1;
        private Label label3;
        private Button buttonAVERAGE;
        private Label label4;
        private Label labelAVERAGE;
        private Label label6;
        private Button buttonCLEAR;
        private Button buttonSUBMIT;
        private ColumnHeader columnMODULE;
        private ColumnHeader columnMARKS;
    }
}