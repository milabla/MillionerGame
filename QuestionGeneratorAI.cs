using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MilionaireGame
{
    public partial class QuestionGeneratorAI : Form
    {
        private static readonly HttpClient client = new HttpClient()
        {
            // Зголемен timeout (во милисекунди)
            Timeout = TimeSpan.FromSeconds(180) // 3 минути
        };

        private CancellationTokenSource cts;

        public QuestionGeneratorAI()
        {
            InitializeComponent();
        }

        private async void btnGenerateQuestions_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();

            try
            {
                btnGenerateQuestions.Enabled = false;
                btnGenerateQuestions.Text = "Генерира...";

                var questions = await GenerateQuestionsFromAI(cts.Token);
                if (questions.Count > 0)
                {
                    string filePath = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                        "milioner_prasanja.json");

                    File.WriteAllText(filePath, JsonConvert.SerializeObject(questions, Formatting.Indented));

                    MessageBox.Show($"Успешно генерирани {questions.Count} прашања!\n" +
                                  $"Фајлот е зачуван на:\n{filePath}",
                                  "Успешно",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не се генерираа прашања.",
                                  "Информација",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                }
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show("Операцијата е прекината поради истечен рок. Обидете се повторно.",
                              "Истечен рок",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка: {ex.Message}",
                              "Грешка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
            finally
            {
                btnGenerateQuestions.Enabled = true;
                btnGenerateQuestions.Text = "Генерирај прашања";
                cts?.Dispose();
            }
        }

        private async Task<List<Question>> GenerateQuestionsFromAI(CancellationToken cancellationToken)
        {
            var requestBody = new
            {
                input = "Генерирај во JSON формат 15 тешки квиз прашања на македонски за игра 'Кој сака да биде милионер?' " +
                       "со 4 опции (A, B, C, D) и точно поместени одговори. " +
                       "Формат: {\"Text\":\"Прашање?\",\"OptionA\":\"A) Опција A\", " +
                       "\"OptionB\":\"B) Опција B\", \"OptionC\":\"C) Опција C\", " +
                       "\"OptionD\":\"D) Опција D\", \"CorrectAnswer\":\"A\"}",
                stream = false
            };
            txtProgressLog.Text = requestBody.ToString() ;
            using (var request = new HttpRequestMessage())
            {
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri("https://api.deepinfra.com/v1/inference/meta-llama/Meta-Llama-3-70B-Instruct");
                request.Content = new StringContent(
                    JsonConvert.SerializeObject(requestBody),
                    Encoding.UTF8,
                    "application/json");

                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(
                    "Bearer",
                    "YBT1TCy3hwnq1t2CT8ZhDlpTYJZSjpdY"); // Замени го со вистинскиот API клуч
                txtProgressLog.Text = txtProgressLog.Text + Environment.NewLine + "Authorization: " + request.Headers.Authorization.ToString(); 
                // 15.06.2025 "3GsRlYcGeChXye2C9RtDazirHe55xFEm"
                // 16.06.2025 "YBT1TCy3hwnq1t2CT8ZhDlpTYJZSjpdY"

                using (var response = await client.SendAsync(request, cancellationToken))
                {
                    response.EnsureSuccessStatusCode();
                    var responseBody = await response.Content.ReadAsStringAsync();
                    return ParseResponse(responseBody);
                }
            }
        }

        private List<Question> ParseResponse(string jsonResponse)
        {
            var result = new List<Question>();
            try
            {
                var json = JObject.Parse(jsonResponse);
                var generatedText = json["results"]?[0]?["generated_text"]?.ToString();

                if (string.IsNullOrWhiteSpace(generatedText))
                    return result;

                var jsonObjects = ExtractJsonObjects(generatedText);
                foreach (var jsonObj in jsonObjects)
                {
                    try
                    {
                        var question = JsonConvert.DeserializeObject<Question>(jsonObj);
                        if (question != null &&
                            !string.IsNullOrEmpty(question.Text) &&
                            !string.IsNullOrEmpty(question.CorrectAnswer))
                        {
                            result.Add(question);
                        }
                    }
                    catch { /* Игнорирај невалидни прашања */ }
                }
            }
            catch { /* Деталите за грешка се веќе обработени */ }

            return result;
        }

        private IEnumerable<string> ExtractJsonObjects(string text)
        {
            int startIndex = 0;
            while ((startIndex = text.IndexOf('{', startIndex)) != -1)
            {
                int endIndex = text.IndexOf('}', startIndex) + 1;
                if (endIndex <= startIndex) break;

                yield return text.Substring(startIndex, endIndex - startIndex);
                startIndex = endIndex;
            }
        }



        private void QuestionGeneratorAI_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cts?.Cancel();
        }
    }

    public class Question
    {
        public string Text { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectAnswer { get; set; }
    }
}