namespace SyncFileExchange
{
    partial class MainFrame
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
            button1 = new Button();
            addFile_btn = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Force Synchronization";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addFile_btn
            // 
            addFile_btn.Location = new Point(93, 415);
            addFile_btn.Name = "addFile_btn";
            addFile_btn.Size = new Size(75, 23);
            addFile_btn.TabIndex = 1;
            addFile_btn.Text = "Add file";
            addFile_btn.UseVisualStyleBackColor = true;
            addFile_btn.Click += addFile_btn_Click;
            // 
            // MainFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addFile_btn);
            Controls.Add(button1);
            Name = "MainFrame";
            Text = "File Exchanger";
            Load += MainFrame_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button addFile_btn;
    }
}
