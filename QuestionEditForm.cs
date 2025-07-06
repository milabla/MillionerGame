using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MillionaireGame
{
    public partial class QuestionEditForm : Form
    {
        public string QuestionText { get; private set; }
        public string OptionA { get; private set; }
        public string OptionB { get; private set; }
        public string OptionC { get; private set; }
        public string OptionD { get; private set; }
        public string CorrectAnswer { get; private set; } // Property for the correct answer

        public QuestionEditForm(string questionText, string optionA, string optionB, string optionC, string optionD, string correctAnswer)
        {
            InitializeComponent();
            txtQuestion.Text = questionText;
            txtOptionA.Text = optionA;
            txtOptionB.Text = optionB;
            txtOptionC.Text = optionC;
            txtOptionD.Text = optionD;

            // Initialize the ComboBox with options A, B, C, D
            cmbCorrectAnswer.Items.AddRange(new[] { "A", "B", "C", "D" });
            cmbCorrectAnswer.SelectedItem = correctAnswer; // Set the current correct answer
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            QuestionText = txtQuestion.Text;
            OptionA = txtOptionA.Text;
            OptionB = txtOptionB.Text;
            OptionC = txtOptionC.Text;
            OptionD = txtOptionD.Text;
            CorrectAnswer = cmbCorrectAnswer.SelectedItem.ToString(); // Get the selected correct answer
            DialogResult = DialogResult.OK; // Set dialog result to OK
            Close();
        }


        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Set dialog result to Cancel
            Close();
        }
    }
}
