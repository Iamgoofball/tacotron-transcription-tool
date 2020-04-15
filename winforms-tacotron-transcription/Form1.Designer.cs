namespace winforms_tacotron_transcription
{
    partial class Form1
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
            this.ProgressBarTranscripts = new System.Windows.Forms.ProgressBar();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.TranscriptionBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WavName = new System.Windows.Forms.Label();
            this.SaveTranscriptionButton = new System.Windows.Forms.Button();
            this.NextLineButton = new System.Windows.Forms.Button();
            this.PreviousLineButton = new System.Windows.Forms.Button();
            this.PlayAudioButton = new System.Windows.Forms.Button();
            this.NewTranscriptionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProgressBarTranscripts
            // 
            this.ProgressBarTranscripts.Location = new System.Drawing.Point(12, 406);
            this.ProgressBarTranscripts.Maximum = 420;
            this.ProgressBarTranscripts.Name = "ProgressBarTranscripts";
            this.ProgressBarTranscripts.Size = new System.Drawing.Size(556, 23);
            this.ProgressBarTranscripts.TabIndex = 0;
            this.ProgressBarTranscripts.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Location = new System.Drawing.Point(9, 390);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(162, 13);
            this.ProgressLabel.TabIndex = 1;
            this.ProgressLabel.Text = "Transcription Progress: 0 of 0 left";
            this.ProgressLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TranscriptionBox
            // 
            this.TranscriptionBox.Enabled = false;
            this.TranscriptionBox.Location = new System.Drawing.Point(12, 44);
            this.TranscriptionBox.Name = "TranscriptionBox";
            this.TranscriptionBox.Size = new System.Drawing.Size(556, 343);
            this.TranscriptionBox.TabIndex = 2;
            this.TranscriptionBox.Text = "He turned himself into a pickle. He called himself \"Pickle Rick\". It was the funn" +
    "iest shit I\'ve ever seen.";
            this.TranscriptionBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current File:";
            // 
            // WavName
            // 
            this.WavName.AutoSize = true;
            this.WavName.Enabled = false;
            this.WavName.Location = new System.Drawing.Point(9, 28);
            this.WavName.Name = "WavName";
            this.WavName.Size = new System.Drawing.Size(74, 13);
            this.WavName.TabIndex = 6;
            this.WavName.Text = "ass_blast_usa";
            this.WavName.Click += new System.EventHandler(this.label4_Click);
            // 
            // SaveTranscriptionButton
            // 
            this.SaveTranscriptionButton.Enabled = false;
            this.SaveTranscriptionButton.Location = new System.Drawing.Point(575, 73);
            this.SaveTranscriptionButton.Name = "SaveTranscriptionButton";
            this.SaveTranscriptionButton.Size = new System.Drawing.Size(213, 23);
            this.SaveTranscriptionButton.TabIndex = 8;
            this.SaveTranscriptionButton.Text = "Save Transcription File";
            this.SaveTranscriptionButton.UseVisualStyleBackColor = true;
            this.SaveTranscriptionButton.Click += new System.EventHandler(this.SaveTranscriptionButton_Click);
            // 
            // NextLineButton
            // 
            this.NextLineButton.Enabled = false;
            this.NextLineButton.Location = new System.Drawing.Point(574, 406);
            this.NextLineButton.Name = "NextLineButton";
            this.NextLineButton.Size = new System.Drawing.Size(213, 23);
            this.NextLineButton.TabIndex = 9;
            this.NextLineButton.Text = "Next line (Pg Down)";
            this.NextLineButton.UseVisualStyleBackColor = true;
            this.NextLineButton.Click += new System.EventHandler(this.NextLineButton_Click);
            // 
            // PreviousLineButton
            // 
            this.PreviousLineButton.Enabled = false;
            this.PreviousLineButton.Location = new System.Drawing.Point(574, 377);
            this.PreviousLineButton.Name = "PreviousLineButton";
            this.PreviousLineButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PreviousLineButton.Size = new System.Drawing.Size(213, 23);
            this.PreviousLineButton.TabIndex = 10;
            this.PreviousLineButton.Text = "Previous line (Pg Up)";
            this.PreviousLineButton.UseVisualStyleBackColor = true;
            this.PreviousLineButton.Click += new System.EventHandler(this.PreviousLineButton_Click);
            // 
            // PlayAudioButton
            // 
            this.PlayAudioButton.Enabled = false;
            this.PlayAudioButton.Location = new System.Drawing.Point(575, 102);
            this.PlayAudioButton.Name = "PlayAudioButton";
            this.PlayAudioButton.Size = new System.Drawing.Size(213, 266);
            this.PlayAudioButton.TabIndex = 11;
            this.PlayAudioButton.Text = "Play Audio (END)";
            this.PlayAudioButton.UseVisualStyleBackColor = true;
            this.PlayAudioButton.Click += new System.EventHandler(this.PlayAudioButton_Click);
            // 
            // NewTranscriptionButton
            // 
            this.NewTranscriptionButton.Location = new System.Drawing.Point(575, 44);
            this.NewTranscriptionButton.Name = "NewTranscriptionButton";
            this.NewTranscriptionButton.Size = new System.Drawing.Size(213, 23);
            this.NewTranscriptionButton.TabIndex = 12;
            this.NewTranscriptionButton.Text = "New Transcription Project";
            this.NewTranscriptionButton.UseVisualStyleBackColor = true;
            this.NewTranscriptionButton.Click += new System.EventHandler(this.NewTranscriptionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewTranscriptionButton);
            this.Controls.Add(this.PlayAudioButton);
            this.Controls.Add(this.PreviousLineButton);
            this.Controls.Add(this.NextLineButton);
            this.Controls.Add(this.SaveTranscriptionButton);
            this.Controls.Add(this.WavName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TranscriptionBox);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.ProgressBarTranscripts);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Tacotron Transcription File Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBarTranscripts;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.RichTextBox TranscriptionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WavName;
        private System.Windows.Forms.Button SaveTranscriptionButton;
        private System.Windows.Forms.Button NextLineButton;
        private System.Windows.Forms.Button PreviousLineButton;
        private System.Windows.Forms.Button PlayAudioButton;
        private System.Windows.Forms.Button NewTranscriptionButton;
    }
}

