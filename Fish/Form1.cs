using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Fish
{
    public partial class Form1 : Form
    {
        private readonly string[] _fishyQuestions;
        private readonly int _totalQuestions = 0;
        private int _currentQuestion = 0;

        public Form1()
        {
            _fishyQuestions = LoadFishyQuestions();
            _totalQuestions = _fishyQuestions.Length;
            _currentQuestion = 1; // 1 indexing is cool

            InitializeComponent();

            // I'm not very good at WinForms, so I'm manually centering these horizontally :)
            fishPictureBox.Left = (this.ClientSize.Width - fishPictureBox.Width) / 2;
            quizPrimaryText.Left = (this.ClientSize.Width - quizPrimaryText.Width) / 2;
            quizSecondaryText.Left = (this.ClientSize.Width - quizSecondaryText.Width) / 2;
            StartButton.Left = (this.ClientSize.Width - StartButton.Width) / 2;
            quizResponsePanel.Left = (this.ClientSize.Width - quizResponsePanel.Width) / 2;
            FishyOMeterPanel.Left = (this.ClientSize.Width - FishyOMeterPanel.Width) / 2;

            CenterToScreen();

            // Initialize Fishy-o-meter
            FishyOMeterBar.Step = 1;
            FishyOMeterBar.Maximum = _totalQuestions * 2;

            // Hide window until balloon is clicked
            ShowInTaskbar = false;
            Opacity = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ShowInTaskbar = true;
            //Opacity = 1;

            Thread.Sleep(1000);

            ShowBalloonNotification();
        }

        private void StartQuiz()
        {
            StartButton.Visible = false;
            quizResponsePanel.Visible = true;
            FishyOMeterPanel.Visible = true;

            NextQuestion();
        }

        private void NextQuestion()
        {
            if (_currentQuestion == _totalQuestions + 1)
            {
                ShowResultsMessageBox();
                return;
            }

            quizPrimaryText.Text = $"Question {_currentQuestion}/{_totalQuestions}";
            quizSecondaryText.Text = _fishyQuestions[_currentQuestion - 1]; // 1 indexing is not fun

            _currentQuestion++;
        }

        private void ShowResultsMessageBox()
        {
            MessageBoxIcon resultIcon = MessageBoxIcon.Information;
            string resultTitle;
            string resultCaption;
            float fishPercentage = 100 * ((float)FishyOMeterBar.Value / FishyOMeterBar.Maximum);
            if (fishPercentage < 30)
            {
                resultTitle = "Unlikely";
                resultCaption = "You are unlikely to be a fish. This is not confirmation that you are a human.";
            }
            else if (fishPercentage < 60)
            {
                resultTitle = "Uncertain";
                resultCaption = "Quiz was unable to discern, please seek help from an ichthyologist for more detailed analysis.";
                resultIcon = MessageBoxIcon.Question;
            }
            else if (fishPercentage < 90)
            {
                resultTitle = "Highly Likely";
                resultCaption = "There is a high likelihood that you are a fish. If symptoms continue, contact your local Fish and Wildlife department.";
                resultIcon = MessageBoxIcon.Warning;
            }
            else
            {
                resultTitle = "Absolutely Certain";
                resultCaption = "You are undeniably a fish. Stay where you are, authorities have been notified and are on their way.";
                resultIcon = MessageBoxIcon.Error;
            }

            DialogResult results = MessageBox.Show(resultCaption, resultTitle, MessageBoxButtons.OK, resultIcon);

            if (results == DialogResult.OK)
            {
                Close();
            }
        }

        private void ShowBalloonNotification()
        {
            NotifyIcon notif = new NotifyIcon
            {
                Visible = true,
                Icon = SystemIcons.Error
            };
            notif.ShowBalloonTip(3000, "You might be at risk", "Fish detection quiz has not been taken\n\nClick this balloon to fix this problem.", ToolTipIcon.Error);
            notif.BalloonTipClicked += Notif_BalloonTipClicked;
        }

        private void Notif_BalloonTipClicked(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            Opacity = 1;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartQuiz();
        }

        private void QuizYesButton_Click(object sender, EventArgs e)
        {
            FishyOMeterBar.PerformStep();
            FishyOMeterBar.PerformStep();
            NextQuestion();
        }

        private void QuizNoButton_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }

        private void QuizPossiblyButton_Click(object sender, EventArgs e)
        {
            FishyOMeterBar.PerformStep();
            NextQuestion();
        }

        private string[] LoadFishyQuestions()
        {
            // From https://stackoverflow.com/a/35780405/15625585
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Fish.Resources.fishyQuestions.txt"))
            {
                TextReader tr = new StreamReader(stream);
                string fileContents = tr.ReadToEnd();

                return fileContents.Split('\n');
            }
        }
    }
}
