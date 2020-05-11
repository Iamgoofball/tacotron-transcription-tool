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
            this.IBMButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IBM_APIkey = new System.Windows.Forms.TextBox();
            this.IBM_URL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AutoSPT = new System.Windows.Forms.CheckBox();
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
            this.PlayAudioButton.Size = new System.Drawing.Size(213, 120);
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
            // IBMButton
            // 
            this.IBMButton.Enabled = false;
            this.IBMButton.Location = new System.Drawing.Point(575, 237);
            this.IBMButton.Name = "IBMButton";
            this.IBMButton.Size = new System.Drawing.Size(213, 120);
            this.IBMButton.TabIndex = 13;
            this.IBMButton.Text = "Guess Transcription W/ IBM (HOME)";
            this.IBMButton.UseVisualStyleBackColor = true;
            this.IBMButton.Click += new System.EventHandler(this.IBMButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "IBM Cloud API Key";
            // 
            // IBM_APIkey
            // 
            this.IBM_APIkey.Location = new System.Drawing.Point(12, 448);
            this.IBM_APIkey.Name = "IBM_APIkey";
            this.IBM_APIkey.Size = new System.Drawing.Size(553, 20);
            this.IBM_APIkey.TabIndex = 15;
            this.IBM_APIkey.UseSystemPasswordChar = true;
            // 
            // IBM_URL
            // 
            this.IBM_URL.Location = new System.Drawing.Point(12, 487);
            this.IBM_URL.Name = "IBM_URL";
            this.IBM_URL.Size = new System.Drawing.Size(553, 20);
            this.IBM_URL.TabIndex = 17;
            this.IBM_URL.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "IBM Cloud Service URL";
            // 
            // AutoSPT
            // 
            this.AutoSPT.AutoSize = true;
            this.AutoSPT.Location = new System.Drawing.Point(575, 448);
            this.AutoSPT.Name = "AutoSPT";
            this.AutoSPT.Size = new System.Drawing.Size(153, 17);
            this.AutoSPT.TabIndex = 18;
            this.AutoSPT.Text = "Automatic Speech-To-Text";
            this.AutoSPT.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.AutoSPT);
            this.Controls.Add(this.IBM_URL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IBM_APIkey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IBMButton);
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
        private System.Windows.Forms.Button IBMButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IBM_APIkey;
        private System.Windows.Forms.TextBox IBM_URL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AutoSPT;
    }
}

