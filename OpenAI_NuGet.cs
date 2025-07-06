using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MillionaireGame
{
    public partial class OpenAI_NuGet : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public OpenAI_NuGet()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox3.Text = "Прашањето е пратено до AI, почекајте одговор!";
            string apiKey = textBox2.Text;
            string question = textBox1.Text;

            if (string.IsNullOrWhiteSpace(question))
            {
                this.textBox1.Focus();
                MessageBox.Show("Внесете прашање.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button1.Enabled = true;
                textBox3.Text = "";
                return;
            }
            if (string.IsNullOrWhiteSpace(apiKey))
            {
                this.textBox2.Focus();
                MessageBox.Show("Внесете API Key.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button1.Enabled = true;
                textBox3.Text = "";
                return;
            }

            string response = await GetOpenAIResponse(apiKey, question);
            button1.Enabled = true;
            textBox3.Text = response;
        }

        private async Task<string> GetOpenAIResponse(string apiKey, string prompt)
        {
            string url = "https://api.openai.com/v1/chat/completions";

            var requestBody = new
            {
                model = "gpt-4o-mini", 
                messages = new object[]
                {
                    new { role = "system", content = "Ти си експерт за квиз прашања." },
                    new { role = "user", content = prompt }
                }
            };

            string jsonContent = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

            try
            {
                var response = await client.PostAsync(url, content);
                string jsonResponse = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var parsedJson = JsonConvert.DeserializeObject<dynamic>(jsonResponse);
                    return parsedJson["choices"][0]["message"]["content"].ToString();
                }
                else
                {
                    return $"Грешка: {response.StatusCode}. Response: {jsonResponse}";
                }
            }
            catch (Exception ex)
            {
                return $"Настана грешка: {ex.Message}";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpenAI_NuGet_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "Генерирај во JSON формат 15 тешки квиз прашања на македонски за игра 'Кој сака да биде милионер?' " +
       "со 4 опции (A, B, C, D) и точно поместени одговори. " +
       "Формат: {\"Text\":\"Прашање?\",\"OptionA\":\"A) Опција A\", " +
       "\"OptionB\":\"B) Опција B\", \"OptionC\":\"C) Опција C\", " +
       "\"OptionD\":\"D) Опција D\", \"CorrectAnswer\":\"A\"} Одговорот да биде само JSON, не ставај префикс ```json и суфикс ```";

            // Читајте го API_KEY од корисничките променливи
            string apiKey = Environment.GetEnvironmentVariable("API_KEY", EnvironmentVariableTarget.User);

            // Проверете дали API_KEY постои
            if (!string.IsNullOrEmpty(apiKey))
            {
                this.textBox2.Text = apiKey;
                this.textBox2.Refresh();
                MessageBox.Show("Пронајден e API_KEY во USER ENV: " + apiKey, "API KEY за AI ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("API_KEY во USER ENV не е пронајден, Внеси АPI KEY за OPEN_AI ", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string jsonText = textBox3.Text;

            // Проверка дали текстот е во JSON формат
            if (IsValidJson(jsonText))
            {
                // Понуди опција за зачувување
                DialogResult result = MessageBox.Show("Текстот е во JSON формат. Дали сакате да го зачувате?",
                    "Зачувај", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    SaveJsonToFile(jsonText);
                }
            }
            else
            {
                MessageBox.Show("Текстот не е во валиден JSON формат.", "Грешка", MessageBoxButtons.OK);
            }
        }
 
        private bool IsValidJson(string jsonString)
        {
            try
            {
                JsonDocument.Parse(jsonString);
                return true;
            }
            catch (System.Text.Json.JsonException)
            {
                return false;
            }
        }

        private void SaveJsonToFile(string jsonText)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.Title = "Зачувај JSON";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, jsonText);
                    MessageBox.Show("Фајлот е успешно зачуван!", "Успех", MessageBoxButtons.OK);


                    //prasaj dali saka vednas da go starta kvizot
                    DialogResult result = MessageBox.Show("Дали сакате веднаш да го започнете квизот?",
    "Потврда", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        var json = File.ReadAllText(saveFileDialog.FileName);
                        var questions = JsonConvert.DeserializeObject<List<Question>>(json);
                        if (questions != null && questions.Count > 0)
                        {
                            this.label1.Text = "Прашања:" + Path.GetFileName(saveFileDialog.FileName);
                            // Start the quiz with the loaded questions
                            Form1 quizForm = new Form1(questions);
                            quizForm.ShowDialog(); // Show the quiz form
                        }
                        else
                        {
                            MessageBox.Show("Не се вчитани прашања.");
                        }
                    }
                    //

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Дали навистина сакате да излезете од AI генерирање на прашањата ?",
                "Потврда",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
