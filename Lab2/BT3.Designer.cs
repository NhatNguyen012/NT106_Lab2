﻿namespace Lab2
{
    partial class BT3
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
            tb_Input = new TextBox();
            btn_Read = new Button();
            btn_Write = new Button();
            btn_Calculator = new Button();
            tb_Output = new TextBox();
            lbl_Title = new Label();
            lbl_Input = new Label();
            lbl_Output = new Label();
            SuspendLayout();
            // 
            // tb_Input
            // 
            tb_Input.Location = new Point(32, 114);
            tb_Input.Multiline = true;
            tb_Input.Name = "tb_Input";
            tb_Input.ScrollBars = ScrollBars.Both;
            tb_Input.Size = new Size(281, 327);
            tb_Input.TabIndex = 0;
            // 
            // btn_Read
            // 
            btn_Read.Cursor = Cursors.Hand;
            btn_Read.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Read.Location = new Point(337, 154);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(131, 43);
            btn_Read.TabIndex = 2;
            btn_Read.Text = "ĐỌC";
            btn_Read.UseVisualStyleBackColor = true;
            btn_Read.Click += btn_Read_Click;
            // 
            // btn_Write
            // 
            btn_Write.Cursor = Cursors.Hand;
            btn_Write.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Write.Location = new Point(337, 257);
            btn_Write.Name = "btn_Write";
            btn_Write.Size = new Size(131, 43);
            btn_Write.TabIndex = 3;
            btn_Write.Text = "GHI";
            btn_Write.UseVisualStyleBackColor = true;
            btn_Write.Click += btn_Write_Click;
            // 
            // btn_Calculator
            // 
            btn_Calculator.Cursor = Cursors.Hand;
            btn_Calculator.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Calculator.Location = new Point(337, 361);
            btn_Calculator.Name = "btn_Calculator";
            btn_Calculator.Size = new Size(131, 43);
            btn_Calculator.TabIndex = 4;
            btn_Calculator.Text = "TÍNH TOÁN";
            btn_Calculator.UseVisualStyleBackColor = true;
            btn_Calculator.Click += btn_Calculator_Click;
            // 
            // tb_Output
            // 
            tb_Output.Location = new Point(483, 114);
            tb_Output.Multiline = true;
            tb_Output.Name = "tb_Output";
            tb_Output.ReadOnly = true;
            tb_Output.ScrollBars = ScrollBars.Both;
            tb_Output.Size = new Size(281, 327);
            tb_Output.TabIndex = 5;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbl_Title.Location = new Point(317, 23);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(160, 33);
            lbl_Title.TabIndex = 6;
            lbl_Title.Text = "TÍNH TOÁN";
            // 
            // lbl_Input
            // 
            lbl_Input.AutoSize = true;
            lbl_Input.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbl_Input.ForeColor = SystemColors.ActiveCaptionText;
            lbl_Input.Location = new Point(32, 84);
            lbl_Input.Name = "lbl_Input";
            lbl_Input.Size = new Size(70, 27);
            lbl_Input.TabIndex = 7;
            lbl_Input.Text = "Input";
            // 
            // lbl_Output
            // 
            lbl_Output.AutoSize = true;
            lbl_Output.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbl_Output.Location = new Point(483, 84);
            lbl_Output.Name = "lbl_Output";
            lbl_Output.Size = new Size(86, 27);
            lbl_Output.TabIndex = 8;
            lbl_Output.Text = "Output";
            // 
            // BT3
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 471);
            Controls.Add(lbl_Output);
            Controls.Add(lbl_Input);
            Controls.Add(lbl_Title);
            Controls.Add(tb_Output);
            Controls.Add(btn_Calculator);
            Controls.Add(btn_Write);
            Controls.Add(btn_Read);
            Controls.Add(tb_Input);
            Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Name = "BT3";
            Text = "BT3_Đọc và ghi file (mở rộng)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_Input;
        private Button btn_Read;
        private Button btn_Write;
        private Button btn_Calculator;
        private TextBox tb_Output;
        private Label lbl_Title;
        private Label lbl_Input;
        private Label lbl_Output;
    }
}