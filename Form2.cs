//using MilionaireGame;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MillionaireGame
{
      public partial class Form2: Form
    {
        private SoundPlayer player;
        public static string tekoven_set_prasanja;
        private List<Question> questions;
        public Form2(List<Question> questions)
        {
            InitializeComponent();
            this.questions = questions;
        }

        private void генерирајПрашањаToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
        }

        private void изToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Вчитај прашања за едитирање !";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var json = File.ReadAllText(openFileDialog.FileName);
                    var questions = JsonConvert.DeserializeObject<List<Question>>(json);
                    if (questions != null && questions.Count > 0)
                    {

                        this.label1.Text = "Прашања:" + Path.GetFileName(openFileDialog.FileName);
                        tekoven_set_prasanja = Path.GetFileName(openFileDialog.FileName); 
                        MessageBox.Show("Избрани се прашањата " + Path.GetFileName(openFileDialog.FileName));
                        

                        // Создајте нова форма со прашањата
                        QuestionEditorForm editorForm = new QuestionEditorForm(questions);
                        editorForm.ShowDialog(); // Отворете ја формата

                        /* Start the quiz with the loaded questions
                        Form1 quizForm = new Form1(questions);
                        quizForm.ShowDialog(); // Show the quiz form */

                    }
                    else
                    {
                        MessageBox.Show("Не беа вчитани прашања.");
                    }
                }
            }
        }

        private void музикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сакате музика да свири?", "Музика", MessageBoxButtons.YesNo);

            // Запомни ја преференцијата
            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.PlayMusic = true;
                // Релативна патека до WAV фајлот
                string soundFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Muzika", "round-1.wav");

                // Логирајте ја патеката за проверка
                //Console.WriteLine(soundFilePath);

                using (SoundPlayer player = new SoundPlayer(soundFilePath))
                {
                    player.PlayLooping(); // Репродуцирај звук
                }
            }
            else
            {
                Properties.Settings.Default.PlayMusic = false;
                // base.OnFormClosing(e);
                // if (player != null)
                // { 
                player?.Stop(); // Прекини ја музиката
                player?.Dispose(); // Освободи ресурси
                player = null; // Постави player на null
                               // }
            }

            // Зачувај ја преференцијата
            Properties.Settings.Default.Save();
        }

        private void почниГоКвизотToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Вчитај прашања за квизот";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var json = File.ReadAllText(openFileDialog.FileName);
                    var questions = JsonConvert.DeserializeObject<List<Question>>(json);
                    if (questions != null && questions.Count > 0)
                    {

                        this.label1.Text = "Прашања:" + Path.GetFileName(openFileDialog.FileName);
                       MessageBox.Show("Избрани се прашањата " + Path.GetFileName(openFileDialog.FileName));

                        /* Start the quiz with the loaded questions
                        Form1 quizForm = new Form1(questions);
                        quizForm.ShowDialog(); // Show the quiz form */

                    }
                    else
                    {
                        MessageBox.Show("Не беа вчитани прашања.");
                    }
                }
            }
        }

        private void излезToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Прикажување на потврдно дијалошко поле
            DialogResult result = MessageBox.Show(
                "Дали навистина сакате да излезете од програмата?",
                "Потврда",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Проверка на одговорот
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Излез од апликацијата
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void chatGTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenAI_NuGet genAIQ = new OpenAI_NuGet())
            {
                genAIQ.ShowDialog();
            }
        }

        private void почниСоКвизотToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void избериПрашањаЗаКвизотToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Вчитај прашања за квизот";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var json = File.ReadAllText(openFileDialog.FileName);
                    var questions = JsonConvert.DeserializeObject<List<Question>>(json);
                    if (questions != null && questions.Count > 0)
                    {
                        this.label1.Text = "Прашања:"+ Path.GetFileName(openFileDialog.FileName);
                        // Start the quiz with the loaded questions
                        Form1 quizForm = new Form1(questions);
                        quizForm.ShowDialog(); // Show the quiz form
                    }
                    else
                    {
                        MessageBox.Show("Не се вчитани прашања.");
                    }
                }
            }
        }

        private void почниГоКвизотToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (questions != null && questions.Count > 0)
            {

                // Start the quiz with the loaded questions
                Form1 quizForm = new Form1(questions);
                quizForm.ShowDialog(); // Show the quiz form
            }
            else
            {
                MessageBox.Show("Не се вчитани прашања.");
            }
            ;
        }
                private void Form2_Load(object sender, EventArgs e)
                {
                    this.label1.Text = "Почетни прашања";
            // Scroll text === TOP
            // Создавање на Timer
            Timer timer = new Timer();
            timer.Interval = 50; // Постави интервал

            // Создавање на TextBox
            TextBox textBox = new TextBox
            {
                Multiline = false, // Постави на еднореден
                ScrollBars = ScrollBars.None, // Исклучи автоматско скролување
                Size = new Size(this.ClientSize.Width, 30), // Постави големина за цела ширина
                Location = new Point(0, this.ClientSize.Height - 20), // Постави во последниот ред
                Text = "Кој сака да биде милионер       (C)2025 Мила Блажевска, ФИНКИ, Индекс бр. 231100", // Постави текст

                ReadOnly = true, // Направи го само за читање
                BorderStyle = BorderStyle.None, // Исклучи рамка
                BackColor = Color.White, // Додади бела позадина
                ForeColor = Color.DarkBlue, // Додади темно-плава боја на текстот
                Font = new Font("Arial", 10, FontStyle.Bold) // Постави font на bold
            };

            // Додај TextBox во формата
            this.Controls.Add(textBox);

            // Постави почетна позиција на TextBox
            textBox.Left = this.ClientSize.Width; // Почни од целосно десно

            // Додади настан за Tick на Timer
            timer.Tick += (s, args) =>
            {
                // Помести текстот лево
                if (textBox.Right < 0) // Проверка ако текстот излезе од видливото подрачје
                {
                    textBox.Left = this.ClientSize.Width; // Врати на почеток
                }
                else
                {
                    textBox.Left -= 2; // Помести лево
                }
            };

            timer.Start(); // Започни Timer

            // Отстрани фокусот од TextBox
            textBox.LostFocus += (s, args) =>
            {
                this.ActiveControl = null; // Дефинирај го фокусот на формата
            };

            textBox.Focus(); // Фокусирај на TextBox
            textBox.SelectionStart = 0; // Постави курсор на почеток
            textBox.SelectionLength = 0; // Отстрани селекција
                                         // Scroll test === END
        }

        private void заАвторотToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мила Блажевска, Финки, Индекс број 231100");
        }

        private void информацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Квиз: \"Кој сака да биде милионер\"\n\n" +
                         "Историја:\n" +
                         "Квизот \"Кој сака да биде милионер\" првпат е создадена во Велика Британија во 1998 година. Брзо стана популарна и се прошири во многу земји, вклучувајќи ја и Македонија.\n\n" +
                         "Начин на играње:\n" +
                         "Играчите одговараат на серии прашања со различни нивоа на тешкотија. Секое правилно одговорено прашање им носи пари, а целта е да стигнат до милион. Играчите можат да користат три помошни опции:\n" +
                         "1. Помош од публика: Публиката гласа за одговор.\n" +
                         "2. 50:50: Се елиминираат два неправилни одговора.\n" +
                         "3. Телефонски повик: Повикаат пријател за помош.\n\n" +
                         "Цел:\n" +
                         "Целта на играта е да се одговори на сите прашања и да се стигне до максималниот износ од милион, покажувајќи знаење и стратегија во изборот на одговори.";

            MessageBox.Show(message, "Информации за Квизот", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void заАвторотToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "### Објаснување за генерација и уредување на прашања\n\n" +
                 "Во апликацијата \"Кој сака да биде милионер\", можете да генерирате прашања од вештачка интелигенција (АИ) или да ги уредувате рачно. Овие прашања можете да ги снимите и вчитате во форма на JSON фајлови.\n\n" +
                 "#### 1. Генерација на прашања од АИ:\n" +
                 "- **Генерирање на прашања:** Користете опцијата „Генерирај прашања“ за да ја отворите форма за генерација на прашања од вештачка интелигенција.\n" +
                 "- **Процес:** По изборот, АИ ќе создаде нови прашања, кои потоа можете да ги прегледате и користите во квизот.\n\n" +
                 "#### 2. Рачно уредување на прашања:\n" +
                 "- **Уредување:** Опцијата „Из“ ви овозможува да уредувате постоечки прашања. Откако ќе ги внесете промените, можете да ги зачувате.\n" +
                 "- **Додавање нови прашања:** Имате можност да додадете нови прашања, како и да измените постоечките.\n\n" +
                 "#### 3. Снимање и вчитување на прашања:\n" +
                 "- **Снимање:** По завршувањето на уредувањето, можете да ги снимите прашањата во JSON формат. Ова ви овозможува да ги зачувате вашите прашања за идни игри.\n" +
                 "- **Вчитување:** Кога сакате да играте, можете да вчитате JSON фајл со прашања. Кога ќе изберете фајл, апликацијата ќе го прочита и прикаже во квизот. Тековниот сет на прашања е прикажан во горниот лев агол.\n\n" +
                 "### Заклучок:\n" +
                 "Оваа функционалност ви овозможува флексибилност во создавањето и управувањето со прашањата, што ја прави играта поинтересна и персонализирана. Уживајте во создавањето на вашиот уникатен квиз!";

            MessageBox.Show(message, "Информации за генерација и уредување на прашања", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void eAPIKEYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //-----
            // Open the Environment Variables dialog
           // Process.Start("SystemPropertiesAdvanced.exe");
            Process.Start("rundll32.exe", "sysdm.cpl,EditEnvironmentVariables");
            //----

        }
    }
}
