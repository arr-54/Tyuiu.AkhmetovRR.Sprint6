namespace Tyuiu.AkhmetovRR.Sprint6.Task7.V12
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
            dataGridViewIn = new DataGridView();
            dataGridViewOut = new DataGridView();
            openFileDialog = new OpenFileDialog();
            textBoxInPut = new TextBox();
            textBoxOutPut = new TextBox();
            buttonClick = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Location = new Point(12, 26);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.Size = new Size(218, 397);
            dataGridViewIn.TabIndex = 0;
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Location = new Point(247, 26);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.Size = new Size(211, 397);
            dataGridViewOut.TabIndex = 1;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.FileOk += openFileDialog1_FileOk;
            // 
            // textBoxInPut
            // 
            textBoxInPut.Location = new Point(524, 61);
            textBoxInPut.Name = "textBoxInPut";
            textBoxInPut.Size = new Size(203, 23);
            textBoxInPut.TabIndex = 2;
            // 
            // textBoxOutPut
            // 
            textBoxOutPut.Location = new Point(524, 111);
            textBoxOutPut.Name = "textBoxOutPut";
            textBoxOutPut.Size = new Size(203, 23);
            textBoxOutPut.TabIndex = 3;
            // 
            // buttonClick
            // 
            buttonClick.Location = new Point(524, 231);
            buttonClick.Name = "buttonClick";
            buttonClick.Size = new Size(203, 46);
            buttonClick.TabIndex = 4;
            buttonClick.Text = "Открыть файл";
            buttonClick.UseVisualStyleBackColor = true;
            buttonClick.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(524, 314);
            button1.Name = "button1";
            button1.Size = new Size(203, 46);
            button1.TabIndex = 5;
            button1.Text = "Обработать файл";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(buttonClick);
            Controls.Add(textBoxOutPut);
            Controls.Add(textBoxInPut);
            Controls.Add(dataGridViewOut);
            Controls.Add(dataGridViewIn);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewIn;
        private DataGridView dataGridViewOut;
        private OpenFileDialog openFileDialog;
        private TextBox textBoxInPut;
        private TextBox textBoxOutPut;
        private Button buttonClick;
        private Button button1;
    }
}
