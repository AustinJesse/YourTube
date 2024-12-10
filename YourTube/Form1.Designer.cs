namespace YourTube
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
            YoutubeURLBox = new TextBox();
            ExtractAudiobtn = new Button();
            SuspendLayout();
            // 
            // YoutubeURLBox
            // 
            YoutubeURLBox.Location = new Point(237, 168);
            YoutubeURLBox.Name = "YoutubeURLBox";
            YoutubeURLBox.Size = new Size(212, 23);
            YoutubeURLBox.TabIndex = 0;
            YoutubeURLBox.TextChanged += YoutubeURLBox_TextChanged;
            // 
            // ExtractAudiobtn
            // 
            ExtractAudiobtn.Location = new Point(93, 149);
            ExtractAudiobtn.Name = "ExtractAudiobtn";
            ExtractAudiobtn.Size = new Size(138, 58);
            ExtractAudiobtn.TabIndex = 1;
            ExtractAudiobtn.Text = "Extract Audio";
            ExtractAudiobtn.UseVisualStyleBackColor = true;
            ExtractAudiobtn.Click += ExtractAudiobtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExtractAudiobtn);
            Controls.Add(YoutubeURLBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox YoutubeURLBox;
        private Button ExtractAudiobtn;
    }
}
