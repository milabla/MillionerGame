using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace MillionaireGame
{
    public partial class QuestionEditorForm : Form
    {
        private List<Question> questions; // = new List<Question>(); // Декларација на questions

        public QuestionEditorForm(List<Question> questions)
        {
            InitializeComponent();
            //this.questions = questions;
            this.questions = questions; // Пренесување на прашањата
            InitializeListView();
            DisplayQuestions();
        }
        private void InitializeListView()
        {
            listViewQuestions.Columns.Add("Прашање", 300);
            listViewQuestions.Columns.Add("Опција A", 100);
            listViewQuestions.Columns.Add("Опција B", 100);
            listViewQuestions.Columns.Add("Опција C", 100);
            listViewQuestions.Columns.Add("Опција D", 100);
            listViewQuestions.Columns.Add("Точен Одговор", 100);
            listViewQuestions.View = View.Details;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.Title = "Зачувај прашања";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveQuestions(saveFileDialog.FileName);
                }
            }
        }

        private void SaveQuestions(string filePath)
        {
            var json = JsonConvert.SerializeObject(questions, Formatting.Indented);
            File.WriteAllText(filePath, json);
            MessageBox.Show("Прашањата се зачувани.");
        }

        /*  private void btnLoad_Click(object sender, EventArgs e)
          {
              using (OpenFileDialog openFileDialog = new OpenFileDialog())
              {
                  openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                  openFileDialog.Title = "Вчитај прашања";

                  if (openFileDialog.ShowDialog() == DialogResult.OK)
                  {
                      LoadQuestions(openFileDialog.FileName);
                  }
              }
          }
        */
        private void LoadQuestions(string filePath)
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                questions = JsonConvert.DeserializeObject<List<Question>>(json);
                MessageBox.Show("Прашањата се вчитани.");
                DisplayQuestions();
            }
            else
            {
                MessageBox.Show("Датотеката не постои.");
            }
        }
        private void DisplayQuestions()
        {
            listViewQuestions.Items.Clear();

            foreach (var question in questions)
            {
                var item = new ListViewItem(question.Text);
                item.SubItems.Add(question.OptionA);
                item.SubItems.Add(question.OptionB);
                item.SubItems.Add(question.OptionC);
                item.SubItems.Add(question.OptionD);
                item.SubItems.Add(question.CorrectAnswer);
                listViewQuestions.Items.Add(item);
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.Title = "Зачувај прашања";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SaveQuestions(saveFileDialog.FileName);
                    Form2.tekoven_set_prasanja = Path.GetFileName(saveFileDialog.FileName);
                    this.label1.Text = " **** Сет на прашања: " + Form2.tekoven_set_prasanja + " ****";
                    MessageBox.Show("Прашањата се снимени како " + Path.GetFileName(saveFileDialog.FileName));

                }
            }
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Вчитај прашања";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadQuestions(openFileDialog.FileName);
                    Form2.tekoven_set_prasanja = Path.GetFileName(openFileDialog.FileName);
                    this.label1.Text = " **** Сет на прашања: " + Form2.tekoven_set_prasanja + " ****";
                    MessageBox.Show("Вчитани се за едитирање прашањата " + Path.GetFileName(openFileDialog.FileName));
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listViewQuestions.SelectedItems.Count > 0)
            {
                var selectedItem = listViewQuestions.SelectedItems[0];
                var questionText = selectedItem.Text;
                var optionA = selectedItem.SubItems[1].Text;
                var optionB = selectedItem.SubItems[2].Text;
                var optionC = selectedItem.SubItems[3].Text;
                var optionD = selectedItem.SubItems[4].Text;
                var correctAnswer = selectedItem.SubItems[5].Text;

                // Get the correct answer from the questions list
                int selectedIndex = listViewQuestions.SelectedIndices[0];
               // var correctAnswer = questions[selectedIndex].CorrectAnswer;

                // Open the edit form with all necessary parameters
                QuestionEditForm editForm = new QuestionEditForm(questionText, optionA, optionB, optionC, optionD, correctAnswer);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Update the ListView with the new values
                    selectedItem.Text = editForm.QuestionText;
                    selectedItem.SubItems[1].Text = editForm.OptionA;
                    selectedItem.SubItems[2].Text = editForm.OptionB;
                    selectedItem.SubItems[3].Text = editForm.OptionC;
                    selectedItem.SubItems[4].Text = editForm.OptionD;
                    selectedItem.SubItems[5].Text = editForm.CorrectAnswer;

                    // Update the actual questions list as well
                    questions[selectedIndex] = new Question(
                        editForm.QuestionText,
                        editForm.OptionA,
                        editForm.OptionB,
                        editForm.OptionC,
                        editForm.OptionD,
                        editForm.CorrectAnswer // Update the correct answer as well
                    );
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Прикажување на потврдно дијалошко поле
            DialogResult result = MessageBox.Show(
                "Дали навистина сакате да излезете од едитирање на прашањата ?",
                "Потврда",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Проверка на одговорот
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void QuestionEditorForm_Load(object sender, EventArgs e)
        {
            this.label1.Text = " **** Сет на прашања: " + Form2.tekoven_set_prasanja+ " ****";
        }
        /*
public class Question
{
public string Text { get; set; }
public string OptionA { get; set; }
public string OptionB { get; set; }
public string OptionC { get; set; }
public string OptionD { get; set; }
public string CorrectAnswer { get; set; }

public Question(string text, string optionA, string optionB, string optionC, string optionD, string correctAnswer)
{
 Text = text;
 OptionA = optionA;
 OptionB = optionB;
 OptionC = optionC;
 OptionD = optionD;
 CorrectAnswer = correctAnswer;
}
}
*/
    }
}
