﻿namespace Tyuiu.AkhmetovRR.Sprint6.Task0.V10
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
            textOutPut = new TextBox();
            text2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textOutPut
            // 
            textOutPut.Location = new Point(359, 202);
            textOutPut.Name = "textOutPut";
            textOutPut.Size = new Size(100, 23);
            textOutPut.TabIndex = 0;
            textOutPut.TextChanged += textOutPut_TextChanged;
            // 
            // text2
            // 
            text2.Location = new Point(359, 143);
            text2.Name = "text2";
            text2.Size = new Size(100, 23);
            text2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(369, 260);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(text2);
            Controls.Add(textOutPut);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textOutPut;
        private TextBox text2;
        private Button button1;
    }
}