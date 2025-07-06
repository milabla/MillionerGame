using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Numerics;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace MillionaireGame
{
    public partial class Form1 : Form
    {
        private SoundPlayer player; // Декларација на player на ниво на класата

        private List<Question> questions;
        private int currentQuestionIndex;
        private int prizeMoney; 
        private int[] prizeLevels = { 5000, 100000 };
       // private int lifelinesUsed;
        private int[] prizeAmounts = { 100,500, 1000,3000,5000, 10000,18000, 25000, 50000, 100000, 150000,  250000,  500000, 750000, 1000000 };
        private bool used5050 = false;
        private bool usedAskAudience = false;
        private bool usedCallFriend = false;
        private int lbl_y_pocetno = 0;
      
        // constructor to accept questions
        public Form1(List<Question> loadedQuestions = null)
        {
            InitializeComponent();

            lbl_y_pocetno = lblPointer.Top;
            Color bilo_boja = btnA.BackColor;
            btnA.BackColor = bilo_boja;
            btnB.BackColor = bilo_boja;
            btnC.BackColor = bilo_boja;
            btnD.BackColor = bilo_boja;
            // InitializeGame();
            // Use loaded questions if provided
            if (loadedQuestions != null && loadedQuestions.Count > 0)
            {
                questions = loadedQuestions;
            }
            else
            {
                questions = new List<Question>
        {
            new Question("Која е главната боја на небото?", "A) Црвена", "B) Сина", "C) Зелена", "D) Жута", "B"),
            new Question("Која е главниот град на Франција?", "A) Лондон", "B) Берлин", "C) Париз", "D) Рим", "C"),
            new Question("Кој е највисокиот врв на светот?", "A) МонБлан", "B) Еверест", "C) Килиманџаро", "D) Аконкагва", "B"),
            new Question("Кој е најдолгata рекa на светот?", "A) Амазон", "B) Нил", "C) Јангце", "D) Мисисипи", "B"),
            new Question("Колку секунди има во еден час?", "A) 360", "B) 3600", "C) 6000", "D) 60", "B"),
            new Question("Кој е најголемиот океан на Земјата?", "A) Атлантски", "B) Индиски", "C) Тихи", "D) Северен Леден", "C"),
            new Question("Како се вика највисоката зграда во светот?", "A) Бурџ Калифа", "B) Емпајр Стејт Билдинг", "C) Тајпеј 101", "D) Шангајска кула", "A"),
            new Question("Кој е симболот на хемискиот елемент злато?", "A) Ag", "B) Au", "C) Zn", "D) Hg", "B"),
            new Question("Во кој град се наоѓа музејот Лувр?", "A) Лондон", "B) Париз", "C) Берлин", "D) Рим", "B"),
            new Question("Кој грчки бог е бог на морето?", "A) Арес", "B) Хадес", "C) Посејдон", "D) Зевс", "C"),
            new Question("Кој филм освои Оскар за најдобар филм во 2023 година?", "A) Avatar: The Way of Water", "B) Everything Everywhere All at Once", "C) Top Gun: Maverick", "D) Elvis", "B"),
            new Question("Колку планети има во Сончевиот систем?", "A) 7", "B) 8", "C) 9", "D) 10", "B"),
            new Question("Кој спорт се игра со 11 играчи во тим на трева?", "A) Фудбал", "B) Кошарка", "C) Одбојка", "D) Бејзбол", "A"),
            new Question("Како се вика најголемиот остров на светот?", "A) Гренланд", "B) Австралија", "C) Нова Гвинеја", "D) Медитеранот", "A"),
            new Question("Колку години живеел Александар Македонски?", "A) 26", "B) 29", "C) 30", "D) 32", "D")
        };
                
            }
            InitializeGame(); // Load default questions if no questions are loaded
            PopulateRewardScale();
        }

        public void InitializeGame()
        {
            currentQuestionIndex = 0;
            prizeMoney = 0;
          //  lifelinesUsed = 0;

            btnA.Tag = "A";
            btnB.Tag = "B";
            btnC.Tag = "C";
            btnD.Tag = "D";

            btnA.Click += AnswerButton_Click;
            btnB.Click += AnswerButton_Click;
            btnC.Click += AnswerButton_Click;
            btnD.Click += AnswerButton_Click;

            btn5050.Click += btn50_50_Click;
            btnAskAudience.Click += btnAskAudience_Click;
            btnCallFriend.Click += btnCallFriend_Click;
            
            LoadQuestion();
        }
        public List<Question> GetQuestions()
        {
            return questions; // Returns the list of questions
        }

        private void LoadQuestion()
        {
                    
            lblPrize.Text = prizeMoney.ToString();
            if (currentQuestionIndex < questions.Count)
            {
                var question = questions[currentQuestionIndex];
                //lblQuestion.Text = question.Text;
                lblQuestion.Text = "Прашање број " +  (currentQuestionIndex+1).ToString()+ " за " + prizeAmounts[currentQuestionIndex].ToString()+" денари" + Environment.NewLine + " "+ question.Text;
                btnA.Text = question.OptionA;
                btnB.Text = question.OptionB;
                btnC.Text = question.OptionC;
                btnD.Text = question.OptionD;
                UpdatePointer();
                lblPrize.Text = $"Освоено : {prizeMoney} ден.";

                btnA.Visible = true;
                btnB.Visible = true;
                btnC.Visible = true;
                btnD.Visible = true;

                this.button1.Focus();
            }
            else
            {
                lblPrize.Text = $"Освоено : {prizeMoney} ден.";
                MessageBox.Show($"Крај на играта! Освоивте {prizeMoney} ден.", "Крај");
                this.Close();
            }
        }
        private void PopulateRewardScale()
        {
            listBoxRewards.Items.Clear();
            for (int i = prizeAmounts.Length - 1; i >= 0; i--)
            {
               
                 listBoxRewards.Items.Add($"{(i + 1).ToString("D2"),-3}. {prizeAmounts[i]:N0}".Replace(",", "."));
               
            }
            listBoxRewards.SetSelected(14, true);
            this.button1.Focus();
        }
        private void UpdatePointer()
        {
            lblPointer.Top= lbl_y_pocetno - currentQuestionIndex*21;
            lblPointer.Text = $"<== Прашање број: {currentQuestionIndex + 1}";
            if (listBoxRewards.Items.Count > 0)
            {
                listBoxRewards.SetSelected(14 - currentQuestionIndex, true);
            }
                
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                Color bilo_boja = button.BackColor;
                if (button.Tag.ToString() == questions[currentQuestionIndex].CorrectAnswer)
                {
                    
                    button.BackColor = System.Drawing.Color.GreenYellow;
                    
                    MessageBox.Show("Точен одговор !");

                    if (currentQuestionIndex == 14)
                    {
                        lblPrize.Text = $"Освоено : 1.000.000 ден.";
                        MessageBox.Show("Честитам, освоивте МИЛИОН 1.000.000 ден.");
                        button.BackColor = bilo_boja;
                    }
                    prizeMoney = prizeAmounts[currentQuestionIndex];

                    if (Array.Exists(prizeLevels, level => level == prizeMoney))
                    {
                        lblPrize.Text = $"Освоено : {prizeMoney} ден.";
                        MessageBox.Show($"Честитам, достигнавте сигурен праг! Гарантиран износ: {prizeMoney} ден.");
                    }

                   

                    button.BackColor = bilo_boja;
                    btnA.BackColor = bilo_boja;
                    btnB.BackColor = bilo_boja;
                    btnC.BackColor = bilo_boja;
                    btnD.BackColor = bilo_boja;
                    currentQuestionIndex++;
                    
                    LoadQuestion();
                }
                else
                {
                    button.BackColor = Color.Red;
                    int finalPrize = 0;
                    if (currentQuestionIndex >= 5)
                        finalPrize = 5000;
                    if (currentQuestionIndex >= 10)
                        finalPrize = 100000;
                    if (finalPrize == 0)
                    {
                        MessageBox.Show($"Погрешен одговор! Играта заврши !");
                        button.BackColor = bilo_boja;
                        this.Close();
                        // Application.Exit();
                    }
                    else
                    {
                        lblPrize.Text = $"Освоено : {finalPrize} ден.";
                        MessageBox.Show($"Погрешен одговор! Играта заврши, но го добивате сигурниот праг: {finalPrize} ден.");
                        button.BackColor = bilo_boja;
                        this.Close();
                       // Application.Exit();
                    }
                }
            }
        }

        private void btn50_50_Click(object sender, EventArgs e)
        {
            if (!used5050)
            {
                used5050 = true;
               btn5050.Enabled = false;
                RemoveTwoIncorrectAnswers();
            }
            else
            {
                MessageBox.Show("Веќе сте ја искористиле оваа помош.");
            }
        }

        private void RemoveTwoIncorrectAnswers()
        {
            List<Button> buttons = new List<Button> { btnA, btnB, btnC, btnD };
            var correctButton = buttons.Find(b => b.Tag.ToString() == questions[currentQuestionIndex].CorrectAnswer);

            buttons.Remove(correctButton);
            Random rand = new Random();
            while (buttons.Count > 1)
            {
                int index = rand.Next(buttons.Count);
                buttons[index].Visible = false;
                buttons.RemoveAt(index);
            }
        }

        private void btnAskAudience_Click(object sender, EventArgs e)
        {
            if (!usedAskAudience)
            {
                usedAskAudience = true;
                btnAskAudience.Enabled = false; 
                Random rand = new Random();
                int correctPercentage = rand.Next(60, 95);
                int incorrectPercentage = 100 - correctPercentage;
                MessageBox.Show($"Публиката мисли дека точниот одговор е: {questions[currentQuestionIndex].CorrectAnswer} ({correctPercentage}% гласови)");
            }
            else
            {
                MessageBox.Show("Веќе сте ја искористиле оваа помош.");
            }
        }

        private void btnCallFriend_Click(object sender, EventArgs e)
        {
            if (!usedCallFriend)
            {
                usedCallFriend = true;
                btnCallFriend.Enabled = false;  
                Random rand = new Random();
                int chance = rand.Next(1, 10);
                string friendAnswer = chance > 3 ? questions[currentQuestionIndex].CorrectAnswer : new List<string> { "A", "B", "C", "D" }[rand.Next(4)];
                MessageBox.Show($"Вашиот пријател мисли дека точниот одговор е: {friendAnswer}");
            }
            else
            {
                MessageBox.Show("Веќе сте ја искористиле оваа помош.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                DialogResult result = MessageBox.Show(
                       "Дали сакате да го прекинете квизот?",
                       "Потврда",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Освоени " + prizeMoney + " денари !");
                    this.Close();
                   // Application.Exit();
                }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            if (Properties.Settings.Default.PlayMusic)
            {

                // Релативна патека до WAV фајлот
                string soundFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Muzika", "round-1.wav");

                // Логирајте ја патеката за проверка
                //Console.WriteLine(soundFilePath);

                using (SoundPlayer player = new SoundPlayer(soundFilePath))
                {
                    player.PlayLooping(); // Репродуцирај звук
                }
            }*/
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
          /*  base.OnFormClosing(e);
            if (player != null)
            {
                player?.Stop(); // Прекини ја музиката
              //  player.Stop();
                player.Stream.Close();
            } */
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
    }

    public class Question
    {
        public string Text { get; }
        public string OptionA { get; }
        public string OptionB { get; }
        public string OptionC { get; }
        public string OptionD { get; }
        public string CorrectAnswer { get; }

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
}