﻿namespace Lab2
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
            btn_BT1 = new Button();
            btn_BT5 = new Button();
            btn_BT4 = new Button();
            btn_BT3 = new Button();
            btn_BT2 = new Button();
            btn_Exit = new Button();
            btn_clean = new Button();
            SuspendLayout();
            // 
            // btn_BT1
            // 
            btn_BT1.Font = new Font("Cambria", 10.8F, FontStyle.Bold);
            btn_BT1.Location = new Point(102, 52);
            btn_BT1.Name = "btn_BT1";
            btn_BT1.Size = new Size(94, 29);
            btn_BT1.TabIndex = 0;
            btn_BT1.Text = "Bài 1";
            btn_BT1.UseVisualStyleBackColor = true;
            btn_BT1.Click += btn_BT1_Click;
            // 
            // btn_BT5
            // 
            btn_BT5.Font = new Font("Cambria", 10.8F, FontStyle.Bold);
            btn_BT5.Location = new Point(102, 357);
            btn_BT5.Name = "btn_BT5";
            btn_BT5.Size = new Size(94, 29);
            btn_BT5.TabIndex = 1;
            btn_BT5.Text = "Bài 5";
            btn_BT5.UseVisualStyleBackColor = true;
            // 
            // btn_BT4
            // 
            btn_BT4.Font = new Font("Cambria", 10.8F, FontStyle.Bold);
            btn_BT4.Location = new Point(102, 280);
            btn_BT4.Name = "btn_BT4";
            btn_BT4.Size = new Size(94, 29);
            btn_BT4.TabIndex = 2;
            btn_BT4.Text = "Bài 4";
            btn_BT4.UseVisualStyleBackColor = true;
            btn_BT4.Click += btn_BT4_Click;
            // 
            // btn_BT3
            // 
            btn_BT3.Font = new Font("Cambria", 10.8F, FontStyle.Bold);
            btn_BT3.Location = new Point(102, 205);
            btn_BT3.Name = "btn_BT3";
            btn_BT3.Size = new Size(94, 29);
            btn_BT3.TabIndex = 3;
            btn_BT3.Text = "Bài 3";
            btn_BT3.UseVisualStyleBackColor = true;
            // 
            // btn_BT2
            // 
            btn_BT2.Font = new Font("Cambria", 10.8F, FontStyle.Bold);
            btn_BT2.Location = new Point(102, 132);
            btn_BT2.Name = "btn_BT2";
            btn_BT2.Size = new Size(94, 29);
            btn_BT2.TabIndex = 4;
            btn_BT2.Text = "Bài 2";
            btn_BT2.UseVisualStyleBackColor = true;
            btn_BT2.Click += btn_BT2_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(279, 53);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(94, 29);
            btn_Exit.TabIndex = 5;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            // 
            // btn_clean
            // 
            btn_clean.Location = new Point(279, 132);
            btn_clean.Name = "btn_clean";
            btn_clean.Size = new Size(94, 29);
            btn_clean.TabIndex = 6;
            btn_clean.Text = "Clean";
            btn_clean.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_clean);
            Controls.Add(btn_Exit);
            Controls.Add(btn_BT2);
            Controls.Add(btn_BT3);
            Controls.Add(btn_BT4);
            Controls.Add(btn_BT5);
            Controls.Add(btn_BT1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_BT1;
        private Button btn_BT5;
        private Button btn_BT4;
        private Button btn_BT3;
        private Button btn_BT2;
        private Button btn_Exit;
        private Button btn_clean;
    }
}
