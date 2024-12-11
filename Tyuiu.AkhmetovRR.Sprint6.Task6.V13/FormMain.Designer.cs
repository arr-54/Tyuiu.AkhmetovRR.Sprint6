namespace Tyuiu.AkhmetovRR.Sprint6.Task6.V13
{
    partial class FormMain
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
            openFileDialog1 = new OpenFileDialog();
            ButtonOpenFile = new Button();
            TextBoxIn = new TextBox();
            TextBoxOut = new TextBox();
            ButtonProcessText = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ButtonOpenFile
            // 
            ButtonOpenFile.Location = new Point(267, 245);
            ButtonOpenFile.Name = "ButtonOpenFile";
            ButtonOpenFile.Size = new Size(197, 23);
            ButtonOpenFile.TabIndex = 0;
            ButtonOpenFile.Text = "Выбрать файл";
            ButtonOpenFile.UseVisualStyleBackColor = true;
            ButtonOpenFile.Click += ButtonOpenFile_Click;
            // 
            // TextBoxIn
            // 
            TextBoxIn.Location = new Point(12, 133);
            TextBoxIn.Name = "TextBoxIn";
            TextBoxIn.Size = new Size(837, 23);
            TextBoxIn.TabIndex = 1;
            // 
            // TextBoxOut
            // 
            TextBoxOut.Location = new Point(12, 189);
            TextBoxOut.Name = "TextBoxOut";
            TextBoxOut.Size = new Size(837, 23);
            TextBoxOut.TabIndex = 2;
            TextBoxOut.TextChanged += TextBoxOut_TextChanged;
            // 
            // ButtonProcessText
            // 
            ButtonProcessText.Location = new Point(308, 295);
            ButtonProcessText.Name = "ButtonProcessText";
            ButtonProcessText.Size = new Size(121, 23);
            ButtonProcessText.TabIndex = 3;
            ButtonProcessText.Text = "Обработать";
            ButtonProcessText.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 494);
            Controls.Add(ButtonProcessText);
            Controls.Add(TextBoxOut);
            Controls.Add(TextBoxIn);
            Controls.Add(ButtonOpenFile);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button ButtonOpenFile;
        private TextBox TextBoxIn;
        private TextBox TextBoxOut;
        private Button ButtonProcessText;
    }
}
