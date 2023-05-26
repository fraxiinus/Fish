namespace Fish
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
            this.fishPictureBox = new System.Windows.Forms.PictureBox();
            this.quizPrimaryText = new System.Windows.Forms.Label();
            this.quizSecondaryText = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.quizResponsePanel = new System.Windows.Forms.Panel();
            this.QuizPossiblyButton = new System.Windows.Forms.Button();
            this.QuizNoButton = new System.Windows.Forms.Button();
            this.QuizYesButton = new System.Windows.Forms.Button();
            this.FishyOMeterBar = new System.Windows.Forms.ProgressBar();
            this.FishyOMeterPanel = new System.Windows.Forms.Panel();
            this.FishyOMeterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fishPictureBox)).BeginInit();
            this.quizResponsePanel.SuspendLayout();
            this.FishyOMeterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fishPictureBox
            // 
            this.fishPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fishPictureBox.Image = global::Fish.Properties.Resources.fish;
            this.fishPictureBox.Location = new System.Drawing.Point(140, 50);
            this.fishPictureBox.Name = "fishPictureBox";
            this.fishPictureBox.Size = new System.Drawing.Size(125, 52);
            this.fishPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fishPictureBox.TabIndex = 0;
            this.fishPictureBox.TabStop = false;
            // 
            // quizPrimaryText
            // 
            this.quizPrimaryText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quizPrimaryText.AutoSize = true;
            this.quizPrimaryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.quizPrimaryText.Location = new System.Drawing.Point(100, 125);
            this.quizPrimaryText.MinimumSize = new System.Drawing.Size(200, 0);
            this.quizPrimaryText.Name = "quizPrimaryText";
            this.quizPrimaryText.Size = new System.Drawing.Size(200, 13);
            this.quizPrimaryText.TabIndex = 1;
            this.quizPrimaryText.Text = "Fish";
            this.quizPrimaryText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quizSecondaryText
            // 
            this.quizSecondaryText.AutoSize = true;
            this.quizSecondaryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.quizSecondaryText.Location = new System.Drawing.Point(30, 155);
            this.quizSecondaryText.MinimumSize = new System.Drawing.Size(350, 0);
            this.quizSecondaryText.MaximumSize = new System.Drawing.Size(350, 0);
            this.quizSecondaryText.Name = "quizSecondaryText";
            this.quizSecondaryText.Size = new System.Drawing.Size(350, 13);
            this.quizSecondaryText.TabIndex = 2;
            this.quizSecondaryText.Text = "Take the quiz and find your true self.";
            this.quizSecondaryText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(155, 189);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start Quiz";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // quizResponsePanel
            // 
            this.quizResponsePanel.Controls.Add(this.QuizPossiblyButton);
            this.quizResponsePanel.Controls.Add(this.QuizNoButton);
            this.quizResponsePanel.Controls.Add(this.QuizYesButton);
            this.quizResponsePanel.Location = new System.Drawing.Point(80, 218);
            this.quizResponsePanel.Name = "quizResponsePanel";
            this.quizResponsePanel.Size = new System.Drawing.Size(240, 30);
            this.quizResponsePanel.TabIndex = 4;
            this.quizResponsePanel.Visible = false;
            // 
            // QuizPossiblyButton
            // 
            this.QuizPossiblyButton.Location = new System.Drawing.Point(162, 3);
            this.QuizPossiblyButton.Name = "QuizPossiblyButton";
            this.QuizPossiblyButton.Size = new System.Drawing.Size(75, 23);
            this.QuizPossiblyButton.TabIndex = 2;
            this.QuizPossiblyButton.Text = "Possibly";
            this.QuizPossiblyButton.UseVisualStyleBackColor = true;
            this.QuizPossiblyButton.Click += new System.EventHandler(this.QuizPossiblyButton_Click);
            // 
            // QuizNoButton
            // 
            this.QuizNoButton.Location = new System.Drawing.Point(81, 3);
            this.QuizNoButton.Name = "QuizNoButton";
            this.QuizNoButton.Size = new System.Drawing.Size(75, 23);
            this.QuizNoButton.TabIndex = 1;
            this.QuizNoButton.Text = "No";
            this.QuizNoButton.UseVisualStyleBackColor = true;
            this.QuizNoButton.Click += new System.EventHandler(this.QuizNoButton_Click);
            // 
            // QuizYesButton
            // 
            this.QuizYesButton.Location = new System.Drawing.Point(3, 3);
            this.QuizYesButton.Name = "QuizYesButton";
            this.QuizYesButton.Size = new System.Drawing.Size(75, 23);
            this.QuizYesButton.TabIndex = 0;
            this.QuizYesButton.Text = "Yes";
            this.QuizYesButton.UseVisualStyleBackColor = true;
            this.QuizYesButton.Click += new System.EventHandler(this.QuizYesButton_Click);
            // 
            // FishyOMeterBar
            // 
            this.FishyOMeterBar.Location = new System.Drawing.Point(4, 15);
            this.FishyOMeterBar.Name = "FishyOMeterBar";
            this.FishyOMeterBar.Size = new System.Drawing.Size(250, 12);
            this.FishyOMeterBar.Step = 5;
            this.FishyOMeterBar.TabIndex = 5;
            // 
            // FishyOMeterPanel
            // 
            this.FishyOMeterPanel.Controls.Add(this.FishyOMeterLabel);
            this.FishyOMeterPanel.Controls.Add(this.FishyOMeterBar);
            this.FishyOMeterPanel.Location = new System.Drawing.Point(79, 276);
            this.FishyOMeterPanel.Name = "FishyOMeterPanel";
            this.FishyOMeterPanel.Size = new System.Drawing.Size(257, 84);
            this.FishyOMeterPanel.TabIndex = 6;
            this.FishyOMeterPanel.Visible = false;
            // 
            // FishyOMeterLabel
            // 
            this.FishyOMeterLabel.AutoSize = true;
            this.FishyOMeterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FishyOMeterLabel.Location = new System.Drawing.Point(4, 41);
            this.FishyOMeterLabel.MinimumSize = new System.Drawing.Size(250, 0);
            this.FishyOMeterLabel.Name = "FishyOMeterLabel";
            this.FishyOMeterLabel.Size = new System.Drawing.Size(250, 13);
            this.FishyOMeterLabel.TabIndex = 6;
            this.FishyOMeterLabel.Text = "Fishy-o-meter";
            this.FishyOMeterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 389);
            this.Controls.Add(this.FishyOMeterPanel);
            this.Controls.Add(this.quizResponsePanel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.quizSecondaryText);
            this.Controls.Add(this.quizPrimaryText);
            this.Controls.Add(this.fishPictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Fish: Find your true self";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fishPictureBox)).EndInit();
            this.quizResponsePanel.ResumeLayout(false);
            this.FishyOMeterPanel.ResumeLayout(false);
            this.FishyOMeterPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fishPictureBox;
        private System.Windows.Forms.Label quizPrimaryText;
        public System.Windows.Forms.Label quizSecondaryText;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel quizResponsePanel;
        private System.Windows.Forms.Button QuizPossiblyButton;
        private System.Windows.Forms.Button QuizNoButton;
        private System.Windows.Forms.Button QuizYesButton;
        private System.Windows.Forms.ProgressBar FishyOMeterBar;
        private System.Windows.Forms.Panel FishyOMeterPanel;
        private System.Windows.Forms.Label FishyOMeterLabel;
    }
}

